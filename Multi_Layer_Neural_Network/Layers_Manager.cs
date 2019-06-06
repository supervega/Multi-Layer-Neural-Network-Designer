using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Threading;

namespace Multi_Layer_Neural_Network
{
    public class Layers_Manager
    {
        public List<Layer> Layers;
        private Layer currentlayer;
        private int inputslotsize;
        private Debugger dynamicDebugger;
        public Dictionary<ArrayList, ArrayList> ExternalDataSource;
        public float MaxError = 0.3f;
        public ImageProcessing ImageProcessing_ref;
        public bool StopImageTraining = false;
        private int IterationNumber = 0;

        private Graphics g;
        private int height;
        private int width;
        private Pen drawingPen;
        private int NodeHeightSpace;
        private int LayerWidthSpace;
        private int Layer_0_X;
        private List<Point> Source;
        private List<Point> Destination;
        private bool testing = false;

        #region Drawing Staff

        public Graphics G
        {
            get
            {
                return g;
            }
            set
            {
                g = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public Pen DrawingPen
        {
            get
            {
                return drawingPen;
            }
            set
            {
                drawingPen = value;
            }
        }

        #endregion

        #region Processing Staff

        public int Count
        {
            get
            {
                return Layers.Count;
            }
        }

        public Layer CurrentLayer
        {
            get
            {
                return currentlayer;
            }
            set
            {
                currentlayer = value;
            }
        }

        public int InputSlotSize
        {
            get
            {
                return inputslotsize;
            }
            set
            {
                inputslotsize = value;
            }
        }

        public Debugger DynamicDebugger
        {
            get
            {
                return dynamicDebugger;
            }
            set
            {
                dynamicDebugger = value;
            }
        }

        public bool Testing
        {
            get
            {
                return testing;
            }
            set
            {
                testing = value;
            }
        }

        #endregion

        public Layers_Manager()
        {
            Layers = new List<Layer>();
            DrawingPen = new Pen(Color.White);
            Source = new List<Point>();
            Destination = new List<Point>();
            InputSlotSize = 0;
            ExternalDataSource = new Dictionary<ArrayList, ArrayList>();
        }



        public void CreateNewLayer()
        {
            Layer L = new Layer(Count);
            CurrentLayer = L;            
        }

        public void SubmitLayerChanges()        
        {
            if (CurrentLayer != null)
            {
                CurrentLayer.ID = Layers.Count;                
                CurrentLayer.InitializeLayer();
                Layers.Add(CurrentLayer);
                foreach (Layer L in Layers)
                {
                    L.MaxID = Layers.Count;
                }
            }
            CurrentLayer = null;
        }

         public bool DoTrainingCycle()
        {
            Testing = false;
             IterationNumber=0;
             do
             {
                 foreach (KeyValuePair<ArrayList,ArrayList> AR in ExternalDataSource)
                 {
                     if (!StopImageTraining)
                     {
                         SetDesiredResponseVector(AR.Key);
                         BroadCastFunctionSignal(AR.Value, 0);
                         IterationNumber++;
                         ImageProcessing_ref.UpdateIteration(IterationNumber);
                         ImageProcessing_ref.UpdateError(GetError());
                         if (ImageProcessing_ref.ManualReset.WaitOne(0, true))
                             StopImageTraining = true;
                     }
                     else
                         return false;
                 }
             } while (GetError() > MaxError);
            return true;            
        }

         public string DoTrainingCycle(ArrayList Parameters)
        {
            return BroadCastFunctionSignal(Parameters, 0);
        }

        private string BroadCastFunctionSignal(ArrayList Parameters,int LayerIndex)// Initially we start with layerIndex 0
        {            
            if (LayerIndex < Layers.Count-1)
            {                
                for (int i = 0; i < Parameters.Count; i++)
                {
                    Layers[LayerIndex].BroadCastSignal((float)Convert.ToDouble(Parameters[i].ToString()));
                }
                return BroadCastFunctionSignal(Layers[LayerIndex].GetNextInputVector(), ++LayerIndex);
            }
            else
                if (LayerIndex == Layers.Count - 1)
                {
                    for (int i = 0; i < Parameters.Count; i++)
                    {
                        Layers[LayerIndex].BroadCastSignal((float)Convert.ToDouble(Parameters[i].ToString()));
                    }
                    if(!Testing)
                        BoradCastFeedbackSignal(Layers[LayerIndex].GetNextLocalGradiantsVector(null,null), Layers.Count - 2);
                    else
                    {
                        float Max = -1;
                        string MaxTag = "";
                        foreach (Neuron N in Layers[LayerIndex].Neurons)
                        {
                            if (N.Type == Neuron.NeuronType.Output)
                            {
                                N.HyperbolicTangent_ActivationFunction();
                                if (N.ActualResponse > Max)
                                {
                                    Max = N.ActualResponse;
                                    MaxTag = N.Tag;
                                }
                            }
                        }
                        Testing = false;
                        return MaxTag;
                    }
                }
            return "No Tags Found.";
        }

        public float GetError()
        {
            float total = 0;
            int OutputNum = Layers[Layers.Count-1].Neurons.Count;
            for (int j = 0; j < OutputNum; j++)
            {
                total += (float)Math.Pow((double)Layers[Layers.Count-1].Neurons[j].ActualResponse - (double)Layers[Layers.Count-1].Neurons[j].DesiredResponse, 2) / 2;
            }
            if (DynamicDebugger != null)
                DynamicDebugger.LBTrace.Items.Add("Error : " + total);
            return total;
        }

        private void BoradCastFeedbackSignal(ArrayList LocalGradiantsVector,int LayerIndex)
        {
            if (LayerIndex >= 0)
            {
                for (int i = 0; i < LocalGradiantsVector.Count; i++)
                {
                    Layers[LayerIndex].BroadCastFeedBack((float)Convert.ToDouble(LocalGradiantsVector[i].ToString()));
                }
                BoradCastFeedbackSignal(Layers[LayerIndex].GetNextLocalGradiantsVector(Layers[LayerIndex],Layers[LayerIndex+1]), --LayerIndex);
            }
            else
            {
                for (int i = 0; i < Layers.Count; i++)
			    {
                    if (DynamicDebugger != null)
                    {
                        if (Layers[i].LayerType == Neuron.NeuronType.Output)
                            DynamicDebugger.LBTrace.Items.Add("Output Layer ");
                        else
                            DynamicDebugger.LBTrace.Items.Add("Layer Number " + i);
                        for (int j = 0; j < Layers[i].Neurons.Count; j++)
                        {
                            DynamicDebugger.LBTrace.Items.Add("     Neuron Number " + j);
                            for (int k = 0; k < Layers[i].Neurons[j].Weights.Count; k++)
                            {
                                DynamicDebugger.LBTrace.Items.Add("          Weight Number " + k + " : " + Layers[i].Neurons[j].Weights[k]);
                            }
                            DynamicDebugger.LBTrace.Items.Add("         Actual Response  : " + Layers[i].Neurons[j].ActualResponse);
                            if (Layers[i].LayerType == Neuron.NeuronType.Output)
                                DynamicDebugger.LBTrace.Items.Add("         Desired Response  : " + Layers[i].Neurons[j].DesiredResponse);
                        }
                    }
                    Layers[i].ClearDynamicInfo();
			    }
            }
        }

        public void SetDesiredResponseVector(ArrayList Vector)
        {
            foreach (Layer L in Layers)
            {
                if (L.LayerType == Neuron.NeuronType.Output)
                {
                    if (L.Count != Vector.Count)
                    {
                        System.Windows.Forms.MessageBox.Show("Please check you output vector and try again.");
                        return;
                    }
                    for (int i = 0; i < Vector.Count; i++)
                    {
                        L.Neurons[i].DesiredResponse = (float)Convert.ToDouble(Vector[i].ToString());
                    }
                    break;
                }
            }            
        }

        public int GetoutputLayerSize()
        {
            foreach (Layer L in Layers)
            {
                if (L.LayerType == Neuron.NeuronType.Output)
                {
                    return L.Neurons.Count;
                }
            }
            return -1;
        }

        public void Draw()
        {
            while (true)
            {
                G.Clear(Color.Black);
                if (InputSlotSize != 0)
                    NodeHeightSpace = (Height - 40) / InputSlotSize;
                if(Layers.Count!=0)
                    LayerWidthSpace = (Width - 40) / (Layers.Count+1);
                DrawInputSlot();
                DrawLayers();
                Thread.Sleep(100);
            }
        }

        private void DrawInputSlot()
        {
            if (InputSlotSize != 0)
            {
                G.DrawRectangle(DrawingPen, (Width / (Layers.Count + 2)) - 20, 20, 40, Height - 40); //Draw Container                
                for (int i = 0; i < InputSlotSize; i++)
                {
                    G.DrawRectangle(DrawingPen, (Width / (Layers.Count + 2)) - 5, ((Height)/(inputslotsize+1)) + (i * NodeHeightSpace) , 10, 10); //Draw Container            
                    Source.Add(new Point((Width / (Layers.Count + 2)), ((Height) / (inputslotsize + 1)) + (i * NodeHeightSpace) + 5));
                }
                Layer_0_X = (Width / (Layers.Count + 2)) - 40;
            }
        }

        private void DrawLayers()
        {
            for (int i = 0; i < Layers.Count; i++)
            {
                G.DrawRectangle(DrawingPen, Layer_0_X + (i+1)*LayerWidthSpace -20, 20, 60, Height - 40); //Draw Container
                int NodesHeightSpace = (Height) / Layers[i].Count + 1;
                for (int j = 0; j < Layers[i].Count; j++)
                {
                    G.DrawEllipse(DrawingPen, Layer_0_X + (i + 1) * LayerWidthSpace -10, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace)-50, 40, 40);
                    if (Layers[i].LayerType == Neuron.NeuronType.Output)
                    {
                        G.DrawLine(DrawingPen, Layer_0_X + (i + 1) * LayerWidthSpace + 30, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 30, Layer_0_X + (i + 1) * LayerWidthSpace + 50, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 30);
                        G.DrawLine(DrawingPen, Layer_0_X + (i + 1) * LayerWidthSpace + 45, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 20, Layer_0_X + (i + 1) * LayerWidthSpace + 50, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 30);
                        G.DrawLine(DrawingPen, Layer_0_X + (i + 1) * LayerWidthSpace + 45, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 40, Layer_0_X + (i + 1) * LayerWidthSpace + 50, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 30);
                    }
                    Destination.Add(new Point(Layer_0_X + (i + 1) * LayerWidthSpace - 10, ((Height) / (Layers[i].Count + 1)) + (j * NodesHeightSpace) - 30));
                }
                DrawConnections();
                Source = new List<Point>();
                foreach (Point P in Destination)
                {
                    Point NP = new Point(P.X + 40, P.Y);
                    Source.Add(NP);
                }
                Destination.Clear();
            }
            Source.Clear();
        }

        private void DrawConnections()
        {
            foreach (Point S in Source)
	        {
                foreach (Point D in Destination)
	            {
                    G.DrawLine(DrawingPen, S, D);
	            }
	        }            
        }
    }
}
