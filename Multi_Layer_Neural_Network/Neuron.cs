using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;

namespace Multi_Layer_Neural_Network
{
    public class Neuron
    {
        private int id;
        private ArrayList inputs;
        private ArrayList weights;
        private ArrayList oldWeights;
        private ArrayList nextlocalGradiants;
        private float bias;
        private float learningrate;
        private float threashold;
        private float response;
        private float actualresponse;
        private int inputnum;
        private float momentum;
        private NeuronType type;
        private const float a =0.5f;
        private const float b = 0.6666f;
        private Layer parentLayer_Ref;
        private int nextLayerIndex;
        private string tag;
        private Image imageTag;

        public enum NeuronType
        {
            Hidden,Output
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (id >= 0)
                    id = value;
            }
        }

        public ArrayList Inputs
        {
            get
            {
                return inputs;
            }
            set
            {
                inputs = value;
            }
        }

        public ArrayList Weights
        {
            get
            {
                return weights;
            }
            set
            {
                weights = value;
            }
        }

        public string Tag
        {
            get
            {
                return tag;
            }
            set
            {
                tag = value;
            }
        }

        public Image ImageTag
        {
            get
            {
                return imageTag;
            }
            set
            {
                imageTag = value;
            }
        }             

        public ArrayList OldWeights
        {
            get
            {
                return oldWeights;
            }
            set
            {
                oldWeights = value;
            }
        }

        public float Bias
        {
            get
            {
                return bias;
            }
            set
            {
                bias = value;
            }
        }

        public float LearningRate
        {
            get
            {
                return learningrate;
            }
            set
            {
                if (value > 0 && value <= 1)
                    learningrate = value;
                else
                    System.Windows.Forms.MessageBox.Show("Learning Rate must be a positive number less than 1.");
            }
        }

        public float DesiredResponse
        {
            get
            {
                return response;
            }
            set
            {
                if (this.Type == NeuronType.Output)
                    response = value;
                else
                    System.Windows.Forms.MessageBox.Show("You Cannot alter the hidden desired response.\nIt is altered automatically.");
            }
        }

        public float ActualResponse
        {
            get
            {
                return actualresponse;
            }
            set
            {
                actualresponse = value;
            }
        }

        public float Threashold
        {
            get
            {
                return threashold;
            }
            set
            {
                threashold = value;
            }
        }

        public NeuronType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public float MomentumConstant
        {
            get
            {
                return momentum;
            }
            set
            {
                momentum = value;
            }
        }

        public int InputCount
        {
            get
            {
                return inputnum;
            }
            set
            {
                inputnum = value;
            }
        }

        public ArrayList NextLocalGradiants
        {
            get
            {
                return nextlocalGradiants;
            }
            set
            {
                nextlocalGradiants = value;
            }
        }

        public Layer ParentLayer_Ref
        {
            get
            {
                return parentLayer_Ref;
            }
            set
            {
                parentLayer_Ref = value;
            }
        }

        public int NextLayerIndex
        {
            get
            {
                return nextLayerIndex;
            }
            set
            {
                nextLayerIndex = value;
            }            
        }

        public Neuron()
        {
            Inputs = new ArrayList();
            Weights = new ArrayList();
            OldWeights = new ArrayList();
            NextLocalGradiants = new ArrayList();
            NextLayerIndex = 0;
        }

        public void Initialize(NeuronType T)
        {
            this.Type = T;
            Bias = 0.5f;
            LearningRate = 0.2f;
            MomentumConstant = 0.4f;
            Inputs.Clear();
            Weights.Clear();
            Inputs.Add(1);
        }

        public void AddInput(float In)
        {
            if (Inputs.Count <= InputCount)
                Inputs.Add(In);
            else
                System.Windows.Forms.MessageBox.Show("No more inputs are avialable.");
        }

        //Forward Pass

        private float CalculateTheInducedLocalField()
        {           
            float Result = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                Result += (float)(Convert.ToDouble(Inputs[i].ToString()) * Convert.ToDouble(Weights[i].ToString()));
            }
            return Result;
        }

        public void HyperbolicTangent_ActivationFunction()
        {
            double v=CalculateTheInducedLocalField(); 
            //ActualResponse= (float)(1/(1+Math.Exp(-a*v)));
            //ActualResponse = (float)((1 - Math.Exp(-2 * v)) / (1 + Math.Exp(-2 * v)));
            ActualResponse= (float)(1 / (1 + Math.Exp(-v)));
        }

        private int HardLimiter()
        {
            if (CalculateTheInducedLocalField() > Threashold)
            {
                ActualResponse = 1;
                return 1;
            }
            else
            {
                ActualResponse = 0;
                return 0;
            }
        }

        //Backward Pass
    
        private float Output_LocalGradiant()
        {
            if (this.Type == NeuronType.Output)
            {          
               // return (b / a) * (DesiredResponse - ActualResponse) * (a - ActualResponse) * (a + ActualResponse);
                //return a * (DesiredResponse - ActualResponse) * ActualResponse*(1 - ActualResponse) ;
                //return (float)((DesiredResponse - ActualResponse) * ((-4 * Math.Exp(-2*ActualResponse))/ Math.Pow((1-Math.Exp(-2*ActualResponse)),2)));
                return (DesiredResponse - ActualResponse) * (ActualResponse) * (1 - ActualResponse);
            }
            else
                return -1234;
        }

        private float Hidden_LocalGradinat(ArrayList NextLocalGradiants,ArrayList ConnectionWeights)
        {
            float Sigma = 0;
            for (int i = 0; i < NextLocalGradiants.Count; i++)
            {
                Sigma += (float)(Convert.ToDouble(NextLocalGradiants[i].ToString()) * Convert.ToDouble(ConnectionWeights[i].ToString()));
            }
            //return (b / a) * (a - ActualResponse) * (a + ActualResponse)*Sigma;
            //return a * ActualResponse*(1 - ActualResponse)  * Sigma;
            //return (float)(((-4 * Math.Exp(-2 * ActualResponse)) / Math.Pow((1 - Math.Exp(-2 * ActualResponse)), 2)) * Sigma);
            return Sigma;
        }

        public float UpdateSynapticWeights(ArrayList NExtWeights)
        {
            float Delta = 0;
            if (this.Type == NeuronType.Output)
            {
                HyperbolicTangent_ActivationFunction();
            }
            for (int i = 1; i < Weights.Count; i++)
            {
                OldWeights[i-1]=weights[i];
                if (this.Type == NeuronType.Output)
                {
                    Delta = Output_LocalGradiant();
                    //Weights[i] = (float)Convert.ToDouble(Weights[i].ToString()) + MomentumConstant * ((float)Convert.ToDouble(OldWeights[i-1].ToString())) + LearningRate * Delta * (float)Convert.ToDouble(Inputs[i].ToString());
                    Weights[i] = (float)Convert.ToDouble(Weights[i].ToString()) + LearningRate * Delta * (float)Convert.ToDouble(Inputs[i].ToString());                    
                }
                else
                {
                    Delta = Hidden_LocalGradinat(NextLocalGradiants, NExtWeights);
                    //Weights[i] = (float)Convert.ToDouble(Weights[i].ToString()) + MomentumConstant * ((float)Convert.ToDouble(OldWeights[i-1].ToString())) + LearningRate * Delta * (float)Convert.ToDouble(Inputs[i].ToString());
                    Weights[i] = (float)Convert.ToDouble(Weights[i].ToString()) +  LearningRate * Delta * (float)Convert.ToDouble(Inputs[i].ToString());                    
                }
            }
            return Delta;
        }

        public float Forward()
        {
            HyperbolicTangent_ActivationFunction();
            return ActualResponse;
        }

        public float Backward(ArrayList NextWeights)
        {
            /*
            ArrayList Result = new ArrayList();
            float Delta= UpdateSynapticWeights(Next, Weights);
            for (int i = 1; i < Weights.Count; i++)
            {
                FeedBack_Data FBD = new FeedBack_Data();
                FBD.ID = ID;
                FBD.Delta = Delta;
                FBD.Weight = (float)Convert.ToDouble(Weights[i].ToString());
                Result.Add(FBD);
            }
            return Result;
             */
            return UpdateSynapticWeights(NextWeights);
        }
    }
}
