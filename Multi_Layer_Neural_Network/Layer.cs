using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Multi_Layer_Neural_Network
{
    public class Layer
    {
        private int id;
        private int count;
        public List<Neuron> Neurons;
        private Neuron.NeuronType layerType;
        private Neuron currentNeuron;
        private int tempInputNumber;
        public int MaxID;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if(value>=0)
                    count = value;
            }
        }

        public Neuron.NeuronType LayerType
        {
            get
            {
                return layerType;
            }
            set
            {
                layerType = value;
            }
        }

        public Neuron CurrentNeuron
        {
            get
            {
                return currentNeuron;
            }
            set
            {
                currentNeuron = value;
            }
        }

        public int TempInputNumber
        {
            get
            {
                return tempInputNumber;
            }
            set
            {
                tempInputNumber = value;
            }
        }

        public Layer(int LID)
        {
            Neurons = new List<Neuron>();
            ID = LID;
            Count = 0;
        }

        public void AddNeuron(int InputNumber,float Bias,float LearningRate,string tag)
        {
            Neuron NewNeuron = new Neuron();
            NewNeuron.ParentLayer_Ref = this;       
            NewNeuron.ID = Count;
            NewNeuron.Initialize(LayerType);
            NewNeuron.Bias = Bias;
            NewNeuron.Weights.Add(Bias);
            NewNeuron.LearningRate = LearningRate;
            NewNeuron.Tag = tag;
            //if (LayerType == Neuron.NeuronType.Output)
            //    NewNeuron.DesiredResponse = DesiredOutput;  
            TempInputNumber = InputNumber;
            CurrentNeuron = NewNeuron;           
        }

        public void SubmitNeuronChanges()
        {
            if (CurrentNeuron != null)
            {
                for (int i = 0; i < TempInputNumber; i++)
                {
                    CurrentNeuron.Weights.Add(0);
                    CurrentNeuron.OldWeights.Add(0);                   
                }
                Neurons.Add(CurrentNeuron);
                Count++;
            }
            CurrentNeuron = null;          
        }

        public void BroadCastSignal(float InputValue)
        {
            foreach (Neuron N in Neurons)
            {
                N.Inputs.Add(InputValue);
            }            
        }

        public void ClearDynamicInfo()
        {
            foreach (Neuron N in Neurons)
            {
                N.NextLocalGradiants = new ArrayList();
                N.Inputs.Clear();
                N.Inputs.Add(1);
            }
        }

        public void BroadCastFeedBack(float LocalGradiant)
        {
            foreach (Neuron N in Neurons)
            {
                N.NextLocalGradiants.Add(LocalGradiant);
            }
        }

        public ArrayList GetNextInputVector()
        {
            ArrayList NewParameters = new ArrayList();
            foreach (Neuron N in Neurons)
            {
                NewParameters.Add(N.Forward());
            }
            return NewParameters;
        }

        public ArrayList GetNextLocalGradiantsVector(Layer Layer_Ref,Layer NextLayer_Ref)
        {
            ArrayList NewVector = new ArrayList();
            ArrayList Weights;
            int Neuron_Counter = 1;
            foreach (Neuron N in Neurons)
            {
                if (Layer_Ref != null)
                {
                    Weights = new ArrayList();
                    for (int i = 0; i < NextLayer_Ref.Neurons.Count; i++)
                    {
                        Weights.Add(NextLayer_Ref.Neurons[i].Weights[Neuron_Counter]);
                    }
                    NewVector.Add(N.Backward(Weights));
                }
                else
                    NewVector.Add(N.Backward(null));
                Neuron_Counter++;
            }
            return NewVector;
        }

        public void InitializeLayer()
        {           
             Random rand = new Random();
            foreach (Neuron N in Neurons)
            {
                for (int i = 1; i < N.Weights.Count; i++)
                {
                    N.Weights[i] = 0.01 + ((double)rand.Next(0, 2+(ID*3)) / 100);
                }
            }
        }

    }
}
