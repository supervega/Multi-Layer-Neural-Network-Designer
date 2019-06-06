using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Multi_Layer_Neural_Network
{
    public partial class Main_Interface : Form
    {
        public MainForm MF;
        ImageProcessing IP;

        public Main_Interface()
        {
            InitializeComponent();
        }

        private void neuralNetworkSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void imageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MF = new MainForm();
            MF.MdiParent = this;
            MF.Show();
        }

        public void CheckManager(string FilePath)
        {
            Load_and_Generate(FilePath);
            IP.Manager = MF.Manager;
            MF.Manager.ImageProcessing_ref = IP;
        }

        public void Load_and_Generate(string Path)
        {
            XPathDocument doc = new XPathDocument(Path);
            XPathNavigator nav = doc.CreateNavigator();

            // Compile a standard XPath expression
            XPathExpression expr;
            expr = nav.Compile("/network");
            XPathNodeIterator iterator = nav.Select(expr);
            if (MF == null)
            {
                MF = new MainForm();               
            }
            MF.Manager = new Layers_Manager();
            while (iterator.MoveNext())
            {
                XPathNavigator nav2 = iterator.Current.Clone();
                nav2.MoveToFirstChild();
                MF.Manager.InputSlotSize = Convert.ToInt32(nav2.Value);
                MF.NUDInputSlot.Value = (decimal)MF.Manager.InputSlotSize;
                nav2.MoveToNext();
                MF.Manager.MaxError = (float)Convert.ToDouble(nav2.Value);
                while (nav2.MoveToNext() && nav2.Name == "layer")
                {
                    nav2.MoveToFirstChild();
                    Layer L = new Layer(Convert.ToInt32(nav2.Value));
                    nav2.MoveToNext();
                    if (nav2.Value == "Hidden")
                        L.LayerType = Neuron.NeuronType.Hidden;
                    else
                        L.LayerType = Neuron.NeuronType.Output;
                    while (nav2.MoveToNext() && nav2.Name == "neuron")
                    {
                        nav2.MoveToFirstChild();
                        Neuron N = new Neuron();
                        N.ParentLayer_Ref = L;
                        N.Initialize(L.LayerType);
                        N.ID = Convert.ToInt32(nav2.Value);
                        nav2.MoveToNext();
                        N.InputCount = Convert.ToInt32(nav2.Value);
                        nav2.MoveToNext();
                        N.LearningRate = (float)Convert.ToDouble(nav2.Value);
                        nav2.MoveToNext();
                        N.Tag = nav2.Value;                        
                        nav2.MoveToNext();
                        N.Bias = (float)Convert.ToDouble(nav2.Value);
                        N.Weights.Add(N.Bias);
                        for (int i = 0; i < N.InputCount; i++)
                        {
                            N.Weights.Add(0);
                            N.OldWeights.Add(0);
                        }
                        L.Neurons.Add(N);
                        L.Count++;
                        nav2.MoveToParent();
                    }
                    L.InitializeLayer();
                    MF.Manager.Layers.Add(L);
                    nav2.MoveToParent();
                }
                foreach (Layer L in MF.Manager.Layers)
                {
                    L.MaxID = MF.Manager.Layers.Count;
                }
            }
            TSSStatusLbl.Text = "Network Loaded Successfully ...";
        }

        public void SaveNetwork(string PAth)
        {
            XmlTextWriter writer = new XmlTextWriter(PAth,Encoding.ASCII);
            XmlDocument doc = new XmlDocument(); 
            XmlElement root = doc.CreateElement("network");
            root.InnerXml = "<inputslot>"+MF.Manager.InputSlotSize+"</inputslot>"+"<maxerror>"+MF.Manager.MaxError+"</maxerror>";
            foreach (Layer L in MF.Manager.Layers)
            {
                XmlNode XmlLayer = doc.CreateNode(XmlNodeType.Element, "layer", "");
                XmlLayer.InnerXml = "<id>"+L.ID+"</id>"+"<type>"+L.LayerType+"</type>";
                foreach (Neuron N in L.Neurons)
                {
                    XmlNode XmlNeuron = doc.CreateNode(XmlNodeType.Element, "neuron", "");
                    XmlNeuron.InnerXml = "<id>" + N.ID + "</id>" + "<inputcount>" + (N.Weights.Count-1) + "</inputcount>" + "<learningrate>" + N.LearningRate + "</learningrate>"
                        +"<tag>" + N.Tag + "</tag>"+"<bias>"+N.Bias+"</bias>";
                    XmlLayer.AppendChild(XmlNeuron);
                }
                root.AppendChild(XmlLayer);
            }
            root.WriteTo(writer);
            writer.Close();
            TSSStatusLbl.Text = "Network Saved Successfully ...";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.InitialDirectory = Application.StartupPath;
            SFD.DefaultExt = ".net";
            SFD.Filter = "neural network files | *.net";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                SaveNetwork(SFD.FileName);
                SSStatus.Text = "Neural Network has been saved successfully ...";
            }
        }

        private void loadNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = Application.StartupPath;
            OFD.DefaultExt = ".net";
            OFD.Filter = "neural network files | *.net";
            MF = new MainForm();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Load_and_Generate(OFD.FileName);
            }          
            MF.Show();
            MF.DrawingThread.Start();
        }

        private void Main_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MF!=null)
                MF.MainForm_FormClosing(sender, e);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Interface_Load(object sender, EventArgs e)
        {

        }

        private void faceDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IP = new ImageProcessing();
            IP.MdiParent = this;
            IP.MainInterface_Ref = this;
            CheckManager("Yale_Faces_IP.net");
            IP.CBFD.Checked = true;
            IP.Show();
        }

        private void patternRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IP = new ImageProcessing();
            IP.MdiParent = this;
            IP.MainInterface_Ref = this;
            CheckManager("Image_Processing2.net");
            IP.CBFD.Checked = false;
            IP.Show();
        }
    }
}
