using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Multi_Layer_Neural_Network
{
    public partial class MainForm : Form
    {
        public Layers_Manager Manager;
        bool InputSlotExsistence;
        public Thread DrawingThread;
        Debugger Debugger_Ref;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Manager==null)
                Manager = new Layers_Manager();
            Manager.G = PanelProjection.CreateGraphics();
            Manager.Height = PanelProjection.Size.Height;
            Manager.Width = PanelProjection.Size.Width;
            InputSlotExsistence = false;
            DrawingThread=new Thread(new ThreadStart(Manager.Draw));
        }

        private void GBLayerOptions_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!GBNeuronOptions.Enabled)
                GBNeuronOptions.Enabled = true;
            if (NUDInputCount.Value > NUDInputSlot.Value)
            {
                MessageBox.Show("Cannot exceeds input slot size.");
                return;
            }            
            Manager.CurrentLayer.AddNeuron((int)NUDInputCount.Value, (float)NUDBias.Value, (float)NUDLearningRate.Value,TXTTag.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Manager.CurrentLayer == null)
            {
                MessageBox.Show("Please create a new layer.");
                return;
            }
            Manager.SubmitLayerChanges();
            LblLayerID.Text = Manager.Count.ToString();
            if (CBMarkAsOutput.Checked)
            {
                GBLayerOptions.Enabled = false;
            }
            GBNeuronOptions.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DrawingThread.IsAlive)
                DrawingThread.Abort();
            Manager = new Layers_Manager();
            if (Debugger_Ref != null)
            {
                Debugger_Ref.LBTrace.Items.Clear();
                Manager.DynamicDebugger = Debugger_Ref;
            }
            Manager.G = PanelProjection.CreateGraphics();
            Manager.Height = PanelProjection.Size.Height;
            Manager.Width = PanelProjection.Size.Width;
            InputSlotExsistence = false;
            DrawingThread = new Thread(new ThreadStart(Manager.Draw));

            GBLayerOptions.Enabled = true;
            NUDInputSlot.Enabled = true;
            BtnInputLayer.Enabled = true;
            DrawingThread.Start();//Draw Network
        }

        private void NUDInputCount_ValueChanged(object sender, EventArgs e)
        {
            if (NUDInputCount.Value > NUDInputSlot.Value)
            {
                MessageBox.Show("Cannot exceeds input slot size.");
                NUDInputCount.Value--;
                return;
            }
            Manager.CurrentLayer.TempInputNumber = (int)NUDInputCount.Value;
        }

        private void BtnInputLayer_Click(object sender, EventArgs e)
        {
            InputSlotExsistence = true;
            Manager.InputSlotSize = (int)NUDInputSlot.Value;
        }

        private void BtnCreateNewLayer_Click(object sender, EventArgs e)
        {
            if (InputSlotExsistence)
                Manager.CreateNewLayer();
            else
                MessageBox.Show("An Input Slot must be defined before creating any layer.");
        }

        private void CBMarkAsOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (Manager.CurrentLayer == null)
            {
                CBMarkAsOutput.CheckState = CheckState.Unchecked;
                MessageBox.Show("Please create a new layer first.");
                return;
            }
            if(CBMarkAsOutput.Checked)
                Manager.CurrentLayer.LayerType = Neuron.NeuronType.Output;
            else
                Manager.CurrentLayer.LayerType = Neuron.NeuronType.Hidden;
        }

        private void BtnAddNeuron_Click(object sender, EventArgs e)
        {
            if (NUDInputCount.Value > NUDInputSlot.Value)
            {
                MessageBox.Show("Cannot exceeds input slot size.");
                return;
            }
            if (Manager.CurrentLayer == null)
            {
                MessageBox.Show("PLease create a new layer first.");
                return;
            }
            Manager.CurrentLayer.SubmitNeuronChanges();
            Manager.CurrentLayer.AddNeuron((int)NUDInputCount.Value, (float)NUDBias.Value, (float)NUDLearningRate.Value,TXTTag.Text);            
        }

        private void BtnClearLayerInfo_Click(object sender, EventArgs e)
        {
            Manager.CurrentLayer = null;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (LblInputVector.Text.Split(',').Length  > NUDInputSlot.Value)
                MessageBox.Show("The input slot is full.");
            else
                LblInputVector.Text += TXTInput.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList Parameters = new ArrayList();
            string[] Vector = LblInputVector.Text.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            if (Vector.Length != NUDInputSlot.Value)
            {
                MessageBox.Show("You have to fill all the input slot in order to proceed.");
                return;
            }
            for (int i = 0; i < Vector.Length; i++)
            {
                Parameters.Add(Vector[i]);
            }
            ArrayList OutputVector = new ArrayList();
            string[] Vector2 = LblOutputVector.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Vector2.Length; i++)
            {
                OutputVector.Add(Vector2[i]);
            }
            Manager.SetDesiredResponseVector(OutputVector);
            Manager.DoTrainingCycle(Parameters);
            LblInputVector.Text = "";
            LblOutputVector.Text = "";
        }

        private void NUDInputSlot_ValueChanged(object sender, EventArgs e)
        {
            Manager.InputSlotSize = (int)NUDInputSlot.Value;
        }

        private void NUDBias_ValueChanged(object sender, EventArgs e)
        {
            Manager.CurrentLayer.CurrentNeuron.Bias = (float)NUDBias.Value;
        }

        private void NUDLearningRate_ValueChanged(object sender, EventArgs e)
        {
            Manager.CurrentLayer.CurrentNeuron.LearningRate = (float)NUDLearningRate.Value;
        }

        public void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DrawingThread!=null && DrawingThread.IsAlive)
                DrawingThread.Abort();
        }

        private void BtnAddDesiredOutput_Click(object sender, EventArgs e)
        {
            if (LblOutputVector.Text.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries).Length > Manager.GetoutputLayerSize())
                MessageBox.Show("The Output Layer is full or it is not created yet.");
            else
                LblOutputVector.Text += TXTDesiredOutput.Text + ",";
        }

        private void BtnDebug_Click(object sender, EventArgs e)
        {
            Debugger DB=new Debugger();
            Debugger_Ref = DB;
            Manager.DynamicDebugger = DB;
            DB.Show();
        }

        private void BtnXORScript_Click(object sender, EventArgs e)
        {
            do
            {
                ArrayList OutputVector = new ArrayList();
                ArrayList Parameters = new ArrayList();
                Parameters.Add(0);
                Parameters.Add(0);
                OutputVector.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(0);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);

                Parameters.Clear();
                OutputVector.Clear();
                Parameters.Add(1);
                Parameters.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(1);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);

                Parameters.Clear();
                OutputVector.Clear();
                Parameters.Add(0);
                Parameters.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(0);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);

                Parameters.Clear();
                OutputVector.Clear();
                Parameters.Add(1);
                Parameters.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(1);
                OutputVector.Add(0);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);                
            } while (Manager.GetError() > Manager.MaxError);
            LblError.Text = Manager.GetError().ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string[] Vector = LblTestInput.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            ArrayList Parameters = new ArrayList();
            if (Vector.Length == NUDInputSlot.Value)
            {
                for (int i = 0; i < Vector.Length; i++)
                {
                    Parameters.Add(Vector[i]);
                }
                for (int i = 0; i < Manager.Layers.Count; i++)
                {
                    Manager.Layers[i].ClearDynamicInfo();
                }
                Manager.Testing = true;
                MessageBox.Show(Manager.DoTrainingCycle(Parameters).ToString());
                LblTestInput.Text = "";
            }
            else
                MessageBox.Show("Please Check your test vector.");
        }

        private void btnTestSample_Click(object sender, EventArgs e)
        {
            if (LblTestInput.Text.Split(',').Length > NUDInputSlot.Value)
                MessageBox.Show("The input slot is full.");
            else
                LblTestInput.Text += TXTTest.Text + ",";
        }

        private void BtnAndSample_Click(object sender, EventArgs e)
        {
            while (Manager.GetError() > Manager.MaxError)
            {
                ArrayList OutputVector = new ArrayList();
                ArrayList Parameters = new ArrayList();
                Parameters.Add(0);
                Parameters.Add(0);
                OutputVector.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(0);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);

                Parameters.Clear();
                OutputVector.Clear();
                Parameters.Add(1);
                Parameters.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(1);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);

                Parameters.Clear();
                OutputVector.Clear();
                Parameters.Add(0);
                Parameters.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(1);
                OutputVector.Add(0);
                OutputVector.Add(0);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);

                Parameters.Clear();
                OutputVector.Clear();
                Parameters.Add(1);
                Parameters.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(0);
                OutputVector.Add(1);
                OutputVector.Add(0);
                Manager.SetDesiredResponseVector(OutputVector);
                Manager.DoTrainingCycle(Parameters);
            }          
        }

        private void TXTTag_TextChanged(object sender, EventArgs e)
        {
            Manager.CurrentLayer.CurrentNeuron.Tag = TXTTag.Text;
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            Manager = null;
            this.Close();
        }

        private void SettingsGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
