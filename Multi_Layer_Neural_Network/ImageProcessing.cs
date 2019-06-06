using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Multi_Layer_Neural_Network
{
    public partial class ImageProcessing : Form
    {
        public Layers_Manager Manager;
        public int ImageIndex = 0;
        private Graphics G;
        private Pen DrawingPen;
        string[] BMPFiles;
        Dictionary<string, Image> ImageInfo = new Dictionary<string, Image>();

        DateTime DTStart;
        private delegate void UpdateUI(object o);
        public Main_Interface MainInterface_Ref;

        //For Asynchronized Programming Instead of Handling Threads
        private delegate bool TrainingCallBack();
        private AsyncCallback asyCallBack = null;
        private IAsyncResult res = null;
        public ManualResetEvent ManualReset = null;

        public PCA _PCA;
        MCvTermCriteria termCrit;
        EigenObjectRecognizer imgRecognizer;
        private Image<Gray, Byte>[] emguImages { get; set; }
        private String[] emguImagesLabels { get; set; }

        public ImageProcessing()
        {
            InitializeComponent();
            _PCA = new PCA();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                TXTBrowse.Text = FBD.SelectedPath;                            
            }           
        }

        public void SetImages()
        {
            int Counter = 0;
            foreach (PictureBox PB in GBImages.Controls)
            {
                if (PB.Name != "PBBorder")
                {
                    if (ImageIndex + Counter < imageList1.Images.Count && ImageIndex + Counter >= 0)
                    {
                        PB.BackgroundImage = imageList1.Images[ImageIndex + Counter];
                        Counter++;
                    }
                    else
                    {
                        PB.BackgroundImage = null;
                        Counter++;
                    }
                }
            }
        }

        private void RBFileSource_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFileSource.Checked)
            {
                TXTBrowse.Enabled = true;
                BtnBrowse.Enabled = true;
                NUDHeight.Enabled = true;
                NUDWidth.Enabled = true;
                BtnLoad.Enabled = true;
                BtnCapture.Enabled = false;
            }
        }

        private void RBCameraSource_CheckedChanged(object sender, EventArgs e)
        {
               if(RBCameraSource.Checked)
                {
                    TXTBrowse.Enabled = false;
                    BtnBrowse.Enabled = false;
                    NUDHeight.Enabled = false;
                    NUDWidth.Enabled = false;
                    BtnLoad.Enabled = false;
                    BtnCapture.Enabled = true;
                }
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            TimeSpan TSElapsed = DateTime.Now.Subtract(DTStart);
            UpdateTimer(TSElapsed.Hours.ToString("D2") + ":" +
                TSElapsed.Minutes.ToString("D2") + ":" +
                TSElapsed.Seconds.ToString("D2"));
        }

        private void BtnTrain_Click(object sender, EventArgs e)
        {
            UpdateState("Began Training Process..\r\n");
            BtnTrain.Enabled = false;
            ManualReset.Reset();
            TrainingCallBack TR = new TrainingCallBack(Manager.DoTrainingCycle);
            res = TR.BeginInvoke(asyCallBack, TR);
            DTStart = DateTime.Now;
            TimerTime.Start();
        }

        private void UpdateTimer(object o)
        {
            if (LblTime.InvokeRequired)
            {
                LblTime.Invoke(new UpdateUI(UpdateTimer), o);
            }
            else
            {
                LblTime.Text = (string)o;
            }
        }
        public void UpdateError(object o)
        {
            if (LblError.InvokeRequired)
            {
                LblError.Invoke(new UpdateUI(UpdateError), o);
            }
            else
            {
                LblError.Text = ((float)o).ToString(".###");
            }
        }
        public void UpdateIteration(object o)
        {
            if (LblIteration.InvokeRequired)
            {
                LblIteration.Invoke(new UpdateUI(UpdateIteration), o);
            }
            else
            {
                LblIteration.Text = ((int)o).ToString();
            }
        }
        private void UpdateState(object o)
        {
            if (MainInterface_Ref.SSStatus.InvokeRequired)
            {
                MainInterface_Ref.SSStatus.Invoke(new UpdateUI(UpdateState), o);
            }
            else
            {
                MainInterface_Ref.TSSStatusLbl.Text = (string)o;
                BtnTrain.Enabled = true;
            }
        }


        private void TraningCompleted(IAsyncResult result)
        {
            if (result.AsyncState is TrainingCallBack)
            {
                TrainingCallBack TR = (TrainingCallBack)result.AsyncState;
                bool isSuccess = TR.EndInvoke(res);
                if (isSuccess)
                {
                    UpdateState("Completed Training Process Successfully.");
                    //
                }
                else
                {
                    UpdateState("Training Process is Aborted or Exceed Maximum Iteration.");
                    //BtnTrain.Enabled = true;
                }

                TimerTime.Stop();
            }
        }

        private void ImageProcessing_Load(object sender, EventArgs e)
        {
            asyCallBack = new AsyncCallback(TraningCompleted);
            ManualReset = new ManualResetEvent(false);
            NUDMaxError.Value = (decimal)Manager.MaxError;
            PBMain.PointSize = 25;
            NUDMaxError.Value = (decimal)Manager.MaxError;
        }


        private ArrayList Recognize()
        {
            ArrayList Info = new ArrayList();
            double[] Data = Image_Processing.ToMatrix(PBMain.ImageOnPanel, (int)NUDHeight.Value, (int)NUDWidth.Value);
            foreach (double Pixel in Data)
            {
                Info.Add(Pixel);
            }
            return Info;
        }

        private void LoadTrainingSet()
        {
             if (CBFD.Checked)
            {
                imageList1.Images.Clear();
                termCrit = new MCvTermCriteria(0.001);
                imgRecognizer = new EigenObjectRecognizer(emguImages, emguImagesLabels, 100, ref termCrit);         

                for (int i = 0; i < imgRecognizer.EigenImages.Length; i++)
                {
                    imageList1.Images.Add(Image.FromHbitmap(imgRecognizer.EigenImages[i].Bitmap.GetHbitmap()));
                }
                SetImages();
            }

            ArrayList Response = new ArrayList();
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                Response.Add(0);
            }
            int RIndex = 0;

            foreach (Image IM in imageList1.Images)
            {
                Response[RIndex] = 1;
                ArrayList Info = new ArrayList();
                Bitmap B = new Bitmap(IM);
                double[] Data= Image_Processing.ToMatrix(B, IM.Size.Height, IM.Size.Width);
                int Counter=0;
                foreach (double Pixel in Data)
                {
                    Info.Add(Pixel);
                    Counter++;
                }
                Manager.ExternalDataSource.Add(Response,Info);
                Response = new ArrayList();
                for (int i = 0; i < imageList1.Images.Count; i++)
                {
                    Response.Add(0);
                }
                RIndex++;
            }    
            MainInterface_Ref.TSSStatusLbl.Text = "Done Loading.";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NUDWidth_ValueChanged(object sender, EventArgs e)
        {
            imageList1.ImageSize = new Size((int)NUDWidth.Value, (int)NUDHeight.Value);
        }

        private void NUDHeight_ValueChanged(object sender, EventArgs e)
        {
            imageList1.ImageSize = new Size((int)NUDWidth.Value, (int)NUDHeight.Value);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                MainInterface_Ref.TSSStatusLbl.Text = "Start Loading...";
                BMPFiles = Directory.GetFiles(TXTBrowse.Text, "*.bmp", SearchOption.TopDirectoryOnly);
                if (CBFD.Checked)
                {
                    emguImages = new Image<Gray, byte>[BMPFiles.Length];
                    emguImagesLabels = new string[BMPFiles.Length];
                }
                int Counter = 0;
                foreach (string Path in BMPFiles)
                {
                    Image Temp = Image.FromFile(Path);
                    Bitmap B = new Bitmap(Temp);
                    Temp.Tag = Path;
                    if (CBFD.Checked)
                    {
                        Bitmap B2 = B.Clone(new RectangleF(new PointF(0, 0), new SizeF((int)NUDWidth.Value, (int)NUDHeight.Value)), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        emguImages[Counter] = new Image<Gray, byte>(B2);
                        emguImagesLabels[Counter] = Path;
                    }
                    Counter++;
                    imageList1.Images.Add(Temp);
                }
                SetImages();
                LoadTrainingSet();
            }
            catch (Exception ex)
            {
                MainInterface_Ref.TSSStatusLbl.Text = ex.Message;
            }
        }

        private void BtnNextImage_Click(object sender, EventArgs e)
        {
            if (ImageIndex + 1 < imageList1.Images.Count-2)
                ImageIndex++;
            SetImages();
        }

        private void BtnPreviousImage_Click(object sender, EventArgs e)
        {
            if (ImageIndex - 1 >= -2)
                ImageIndex--;
            SetImages();
        }

        private void PBImage1_Click(object sender, EventArgs e)
        {
            Bitmap B=new Bitmap(PBImage1.BackgroundImage);
            PBMain.ImageOnPanel = B;
        }

        private void PBImage2_Click(object sender, EventArgs e)
        {
            Bitmap B = new Bitmap(PBImage1.BackgroundImage);
            PBMain.ImageOnPanel = B;
        }

        private void PBImage5_Click(object sender, EventArgs e)
        {
            Bitmap B = new Bitmap(PBImage1.BackgroundImage);
            PBMain.ImageOnPanel = B;
        }

        private void PBImage4_Click(object sender, EventArgs e)
        {
            Bitmap B = new Bitmap(PBImage1.BackgroundImage);
            PBMain.ImageOnPanel = B;
        }

        private void PBImage3_Click(object sender, EventArgs e)
        {
            Bitmap B = new Bitmap(PBImage1.BackgroundImage);
            PBMain.ImageOnPanel = B;
        }

        private void BtnCreateNetwork_Click(object sender, EventArgs e)
        {
            if (NUDLayerNumber.Value == 1)
            {
                Manager = new Layers_Manager();
                Manager.InputSlotSize = (int)NUDImageWidth.Value * (int)NUDImageHeight.Value;
                Manager.MaxError = 1;
                Layer MainLayer = new Layer(0);
                MainLayer.LayerType = Neuron.NeuronType.Output;
                for (int i = 0; i < (int)NUDOutputNumber.Value; i++)
                {
                    Neuron N = new Neuron();
                    N.ParentLayer_Ref = MainLayer;
                    N.Initialize(Neuron.NeuronType.Output);
                    N.ID = i;
                    N.InputCount = Manager.InputSlotSize;
                    N.LearningRate = 0.2f;
                    N.ImageTag = imageList1.Images[i];
                    string[] Data = BMPFiles[i].Split('\\');
                    N.Tag = Data[Data.Length - 1].Split('.')[0];                    
                    N.Bias = 0.5f;
                    N.Weights.Add(N.Bias);
                    for (int j = 0; j < N.InputCount; j++)
                    {
                        N.Weights.Add(0);
                        N.OldWeights.Add(0);
                    }
                    MainLayer.Neurons.Add(N);
                    MainLayer.Count++;
                }
                MainLayer.InitializeLayer();
                Manager.Layers.Add(MainLayer);
                Layers_Manager Temp=MainInterface_Ref.MF.Manager;
                MainInterface_Ref.MF.Manager = Manager;
                MainInterface_Ref.SaveNetwork("Image_Processing.net");
                MainInterface_Ref.MF.Manager = Temp;
            }
        }

        private void NUDMaxError_ValueChanged(object sender, EventArgs e)
        {
            Manager.MaxError = (float)Convert.ToDouble(NUDMaxError.Value);
        }

       
        private void PBMain_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void PBMain_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void PBMain_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            PBMain.Clear();
        }

        private void BtnLastImage_Click(object sender, EventArgs e)
        {
            ImageIndex = imageList1.Images.Count - 3;
            SetImages();
        }

        private void BtnFirstImage_Click(object sender, EventArgs e)
        {
            ImageIndex = -2;
            SetImages();
        }

        private void BtnRecognize_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Manager.Layers.Count; i++)
            {
                Manager.Layers[i].ClearDynamicInfo();
            }
            Manager.Testing = true;
            MessageBox.Show(Manager.DoTrainingCycle(Recognize()).ToString());
        }
    }

    class Image_Processing
    {
        //Convert RGB To Matrix [Of Double]
        public static double[] ToMatrix(Bitmap BM, int MatrixRowNumber, int MatrixColumnNumber)
        {
            double HRate = ((Double)MatrixRowNumber / BM.Height);
            double WRate = ((Double)MatrixColumnNumber / BM.Width);
            double[] Result = new double[MatrixColumnNumber * MatrixRowNumber];

            for (int r = 0; r < MatrixRowNumber; r++)
            {
                for (int c = 0; c < MatrixColumnNumber; c++)
                {
                    Color color = BM.GetPixel((int)(c / WRate), (int)(r / HRate));
                    Result[r * MatrixColumnNumber + c] = 1 - (color.R * .3 + color.G * .59 + color.B * .11) / 255;
                }
            }
            return Result;
        }

        //Convert Double To Grey Level  
        public static Bitmap ToImage(double[] Matrix, int MatrixRowNumber, int MatrixColumnNumber,
                                                     int ImageHeight, int ImageWidth)
        {
            double HRate = ((double)ImageHeight / MatrixRowNumber);
            double WRate = ((double)ImageWidth / MatrixColumnNumber);
            Bitmap Result = new Bitmap(ImageWidth, ImageHeight);

            for (int i = 0; i < ImageHeight; i++)
            {
                for (int j = 0; j < ImageWidth; j++)
                {
                    int x = (int)((double)j / WRate);
                    int y = (int)((double)i / HRate);

                    double temp = Matrix[y * MatrixColumnNumber + x];
                    Result.SetPixel(j, i, Color.FromArgb((int)((1 - temp) * 255), (int)((1 - temp) * 255), (int)((1 - temp) * 255)));

                }
            }
            return Result;
        }     
    }
}
