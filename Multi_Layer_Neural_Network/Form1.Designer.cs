namespace Multi_Layer_Neural_Network
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsGB = new System.Windows.Forms.GroupBox();
            this.BtnCLose = new System.Windows.Forms.Button();
            this.BtnXORScript = new System.Windows.Forms.Button();
            this.BtnDebug = new System.Windows.Forms.Button();
            this.NUDInputSlot = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnInputLayer = new System.Windows.Forms.Button();
            this.GBLayerOptions = new System.Windows.Forms.GroupBox();
            this.BtnClearLayerInfo = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CBMarkAsOutput = new System.Windows.Forms.CheckBox();
            this.AddLayer = new System.Windows.Forms.Button();
            this.EditNeurons = new System.Windows.Forms.Button();
            this.BtnCreateNewLayer = new System.Windows.Forms.Button();
            this.GBNeuronOptions = new System.Windows.Forms.GroupBox();
            this.TXTTag = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnAddNeuron = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDInputCount = new System.Windows.Forms.NumericUpDown();
            this.NUDLearningRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDBias = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLayerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreateNeuralNetwork = new System.Windows.Forms.Button();
            this.ViewGroupBox = new System.Windows.Forms.GroupBox();
            this.SCTraining_Test = new System.Windows.Forms.SplitContainer();
            this.LblOutputVector = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnAddDesiredOutput = new System.Windows.Forms.Button();
            this.BtnDoTraining = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTDesiredOutput = new System.Windows.Forms.TextBox();
            this.LblInputVector = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblTestInput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTTest = new System.Windows.Forms.TextBox();
            this.btnTestSample = new System.Windows.Forms.Button();
            this.PanelProjection = new System.Windows.Forms.Panel();
            this.SettingsGB.SuspendLayout();
            this.GBLayerOptions.SuspendLayout();
            this.GBNeuronOptions.SuspendLayout();
            this.ViewGroupBox.SuspendLayout();
            this.SCTraining_Test.Panel1.SuspendLayout();
            this.SCTraining_Test.Panel2.SuspendLayout();
            this.SCTraining_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGB
            // 
            this.SettingsGB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SettingsGB.Controls.Add(this.BtnCLose);
            this.SettingsGB.Controls.Add(this.BtnXORScript);
            this.SettingsGB.Controls.Add(this.BtnDebug);
            this.SettingsGB.Controls.Add(this.NUDInputSlot);
            this.SettingsGB.Controls.Add(this.label8);
            this.SettingsGB.Controls.Add(this.BtnInputLayer);
            this.SettingsGB.Controls.Add(this.GBLayerOptions);
            this.SettingsGB.Controls.Add(this.BtnCreateNeuralNetwork);
            this.SettingsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsGB.Location = new System.Drawing.Point(4, 12);
            this.SettingsGB.Name = "SettingsGB";
            this.SettingsGB.Size = new System.Drawing.Size(322, 583);
            this.SettingsGB.TabIndex = 0;
            this.SettingsGB.TabStop = false;
            this.SettingsGB.Text = "Settings";
            this.SettingsGB.Enter += new System.EventHandler(this.SettingsGB_Enter);
            // 
            // BtnCLose
            // 
            this.BtnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCLose.Location = new System.Drawing.Point(224, 545);
            this.BtnCLose.Name = "BtnCLose";
            this.BtnCLose.Size = new System.Drawing.Size(87, 29);
            this.BtnCLose.TabIndex = 26;
            this.BtnCLose.Text = "Close";
            this.BtnCLose.UseVisualStyleBackColor = true;
            this.BtnCLose.Click += new System.EventHandler(this.BtnCLose_Click);
            // 
            // BtnXORScript
            // 
            this.BtnXORScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXORScript.Location = new System.Drawing.Point(91, 546);
            this.BtnXORScript.Name = "BtnXORScript";
            this.BtnXORScript.Size = new System.Drawing.Size(87, 29);
            this.BtnXORScript.TabIndex = 18;
            this.BtnXORScript.Text = "XORScript";
            this.BtnXORScript.UseVisualStyleBackColor = true;
            this.BtnXORScript.Click += new System.EventHandler(this.BtnXORScript_Click);
            // 
            // BtnDebug
            // 
            this.BtnDebug.Location = new System.Drawing.Point(15, 542);
            this.BtnDebug.Name = "BtnDebug";
            this.BtnDebug.Size = new System.Drawing.Size(70, 35);
            this.BtnDebug.TabIndex = 25;
            this.BtnDebug.Text = "Debug";
            this.BtnDebug.UseVisualStyleBackColor = true;
            this.BtnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // NUDInputSlot
            // 
            this.NUDInputSlot.Enabled = false;
            this.NUDInputSlot.Location = new System.Drawing.Point(208, 35);
            this.NUDInputSlot.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDInputSlot.Name = "NUDInputSlot";
            this.NUDInputSlot.Size = new System.Drawing.Size(87, 26);
            this.NUDInputSlot.TabIndex = 18;
            this.NUDInputSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDInputSlot.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUDInputSlot.ValueChanged += new System.EventHandler(this.NUDInputSlot_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(154, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Size :";
            // 
            // BtnInputLayer
            // 
            this.BtnInputLayer.Enabled = false;
            this.BtnInputLayer.Location = new System.Drawing.Point(153, 61);
            this.BtnInputLayer.Name = "BtnInputLayer";
            this.BtnInputLayer.Size = new System.Drawing.Size(142, 26);
            this.BtnInputLayer.TabIndex = 5;
            this.BtnInputLayer.Text = "Add Input Slot";
            this.BtnInputLayer.UseVisualStyleBackColor = true;
            this.BtnInputLayer.Click += new System.EventHandler(this.BtnInputLayer_Click);
            // 
            // GBLayerOptions
            // 
            this.GBLayerOptions.Controls.Add(this.BtnClearLayerInfo);
            this.GBLayerOptions.Controls.Add(this.LblStatus);
            this.GBLayerOptions.Controls.Add(this.CBMarkAsOutput);
            this.GBLayerOptions.Controls.Add(this.AddLayer);
            this.GBLayerOptions.Controls.Add(this.EditNeurons);
            this.GBLayerOptions.Controls.Add(this.BtnCreateNewLayer);
            this.GBLayerOptions.Controls.Add(this.GBNeuronOptions);
            this.GBLayerOptions.Controls.Add(this.LblLayerID);
            this.GBLayerOptions.Controls.Add(this.label1);
            this.GBLayerOptions.Enabled = false;
            this.GBLayerOptions.Location = new System.Drawing.Point(6, 93);
            this.GBLayerOptions.Name = "GBLayerOptions";
            this.GBLayerOptions.Size = new System.Drawing.Size(305, 442);
            this.GBLayerOptions.TabIndex = 1;
            this.GBLayerOptions.TabStop = false;
            this.GBLayerOptions.Text = "Layer Options";
            this.GBLayerOptions.Enter += new System.EventHandler(this.GBLayerOptions_Enter);
            // 
            // BtnClearLayerInfo
            // 
            this.BtnClearLayerInfo.Location = new System.Drawing.Point(9, 403);
            this.BtnClearLayerInfo.Name = "BtnClearLayerInfo";
            this.BtnClearLayerInfo.Size = new System.Drawing.Size(146, 35);
            this.BtnClearLayerInfo.TabIndex = 24;
            this.BtnClearLayerInfo.Text = "Clear Layer Info";
            this.BtnClearLayerInfo.UseVisualStyleBackColor = true;
            this.BtnClearLayerInfo.Click += new System.EventHandler(this.BtnClearLayerInfo_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.LblStatus.Location = new System.Drawing.Point(17, 431);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 20);
            this.LblStatus.TabIndex = 23;
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBMarkAsOutput
            // 
            this.CBMarkAsOutput.AutoSize = true;
            this.CBMarkAsOutput.Location = new System.Drawing.Point(74, 80);
            this.CBMarkAsOutput.Name = "CBMarkAsOutput";
            this.CBMarkAsOutput.Size = new System.Drawing.Size(202, 24);
            this.CBMarkAsOutput.TabIndex = 5;
            this.CBMarkAsOutput.Text = "Mark As Output Layer";
            this.CBMarkAsOutput.UseVisualStyleBackColor = true;
            this.CBMarkAsOutput.CheckedChanged += new System.EventHandler(this.CBMarkAsOutput_CheckedChanged);
            // 
            // AddLayer
            // 
            this.AddLayer.Location = new System.Drawing.Point(197, 403);
            this.AddLayer.Name = "AddLayer";
            this.AddLayer.Size = new System.Drawing.Size(100, 35);
            this.AddLayer.TabIndex = 4;
            this.AddLayer.Text = "Add Layer";
            this.AddLayer.UseVisualStyleBackColor = true;
            this.AddLayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditNeurons
            // 
            this.EditNeurons.Location = new System.Drawing.Point(56, 151);
            this.EditNeurons.Name = "EditNeurons";
            this.EditNeurons.Size = new System.Drawing.Size(233, 35);
            this.EditNeurons.TabIndex = 3;
            this.EditNeurons.Text = "Edit Assocciated Neurons";
            this.EditNeurons.UseVisualStyleBackColor = true;
            this.EditNeurons.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCreateNewLayer
            // 
            this.BtnCreateNewLayer.Location = new System.Drawing.Point(95, 110);
            this.BtnCreateNewLayer.Name = "BtnCreateNewLayer";
            this.BtnCreateNewLayer.Size = new System.Drawing.Size(166, 35);
            this.BtnCreateNewLayer.TabIndex = 2;
            this.BtnCreateNewLayer.Text = "Create New Layer";
            this.BtnCreateNewLayer.UseVisualStyleBackColor = true;
            this.BtnCreateNewLayer.Click += new System.EventHandler(this.BtnCreateNewLayer_Click);
            // 
            // GBNeuronOptions
            // 
            this.GBNeuronOptions.Controls.Add(this.TXTTag);
            this.GBNeuronOptions.Controls.Add(this.label13);
            this.GBNeuronOptions.Controls.Add(this.BtnAddNeuron);
            this.GBNeuronOptions.Controls.Add(this.label4);
            this.GBNeuronOptions.Controls.Add(this.NUDInputCount);
            this.GBNeuronOptions.Controls.Add(this.NUDLearningRate);
            this.GBNeuronOptions.Controls.Add(this.label2);
            this.GBNeuronOptions.Controls.Add(this.NUDBias);
            this.GBNeuronOptions.Controls.Add(this.label3);
            this.GBNeuronOptions.Enabled = false;
            this.GBNeuronOptions.Location = new System.Drawing.Point(9, 192);
            this.GBNeuronOptions.Name = "GBNeuronOptions";
            this.GBNeuronOptions.Size = new System.Drawing.Size(288, 205);
            this.GBNeuronOptions.TabIndex = 0;
            this.GBNeuronOptions.TabStop = false;
            this.GBNeuronOptions.Text = "Neuron Options";
            // 
            // TXTTag
            // 
            this.TXTTag.Location = new System.Drawing.Point(160, 88);
            this.TXTTag.Name = "TXTTag";
            this.TXTTag.Size = new System.Drawing.Size(120, 26);
            this.TXTTag.TabIndex = 25;
            this.TXTTag.TextChanged += new System.EventHandler(this.TXTTag_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(21, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tag :";
            // 
            // BtnAddNeuron
            // 
            this.BtnAddNeuron.Location = new System.Drawing.Point(164, 164);
            this.BtnAddNeuron.Name = "BtnAddNeuron";
            this.BtnAddNeuron.Size = new System.Drawing.Size(116, 35);
            this.BtnAddNeuron.TabIndex = 22;
            this.BtnAddNeuron.Text = "Add Neuron";
            this.BtnAddNeuron.UseVisualStyleBackColor = true;
            this.BtnAddNeuron.Click += new System.EventHandler(this.BtnAddNeuron_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Input Counts :";
            // 
            // NUDInputCount
            // 
            this.NUDInputCount.Location = new System.Drawing.Point(160, 121);
            this.NUDInputCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDInputCount.Name = "NUDInputCount";
            this.NUDInputCount.Size = new System.Drawing.Size(120, 26);
            this.NUDInputCount.TabIndex = 20;
            this.NUDInputCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDInputCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDInputCount.ValueChanged += new System.EventHandler(this.NUDInputCount_ValueChanged);
            // 
            // NUDLearningRate
            // 
            this.NUDLearningRate.DecimalPlaces = 2;
            this.NUDLearningRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NUDLearningRate.Location = new System.Drawing.Point(160, 57);
            this.NUDLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDLearningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NUDLearningRate.Name = "NUDLearningRate";
            this.NUDLearningRate.Size = new System.Drawing.Size(120, 26);
            this.NUDLearningRate.TabIndex = 19;
            this.NUDLearningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDLearningRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.NUDLearningRate.ValueChanged += new System.EventHandler(this.NUDLearningRate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Learning Rate :";
            // 
            // NUDBias
            // 
            this.NUDBias.DecimalPlaces = 2;
            this.NUDBias.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NUDBias.Location = new System.Drawing.Point(160, 25);
            this.NUDBias.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDBias.Name = "NUDBias";
            this.NUDBias.Size = new System.Drawing.Size(120, 26);
            this.NUDBias.TabIndex = 17;
            this.NUDBias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDBias.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUDBias.ValueChanged += new System.EventHandler(this.NUDBias_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bias :";
            // 
            // LblLayerID
            // 
            this.LblLayerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLayerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblLayerID.Location = new System.Drawing.Point(182, 33);
            this.LblLayerID.Name = "LblLayerID";
            this.LblLayerID.Size = new System.Drawing.Size(107, 35);
            this.LblLayerID.TabIndex = 1;
            this.LblLayerID.Text = "0";
            this.LblLayerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Layer ID :";
            // 
            // BtnCreateNeuralNetwork
            // 
            this.BtnCreateNeuralNetwork.Location = new System.Drawing.Point(6, 35);
            this.BtnCreateNeuralNetwork.Name = "BtnCreateNeuralNetwork";
            this.BtnCreateNeuralNetwork.Size = new System.Drawing.Size(144, 52);
            this.BtnCreateNeuralNetwork.TabIndex = 6;
            this.BtnCreateNeuralNetwork.Text = "Create New Neural Network";
            this.BtnCreateNeuralNetwork.UseVisualStyleBackColor = true;
            this.BtnCreateNeuralNetwork.Click += new System.EventHandler(this.button4_Click);
            // 
            // ViewGroupBox
            // 
            this.ViewGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ViewGroupBox.Controls.Add(this.SCTraining_Test);
            this.ViewGroupBox.Controls.Add(this.PanelProjection);
            this.ViewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewGroupBox.Location = new System.Drawing.Point(321, 12);
            this.ViewGroupBox.Name = "ViewGroupBox";
            this.ViewGroupBox.Size = new System.Drawing.Size(667, 583);
            this.ViewGroupBox.TabIndex = 1;
            this.ViewGroupBox.TabStop = false;
            this.ViewGroupBox.Text = "Training";
            // 
            // SCTraining_Test
            // 
            this.SCTraining_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCTraining_Test.Dock = System.Windows.Forms.DockStyle.Top;
            this.SCTraining_Test.Location = new System.Drawing.Point(3, 22);
            this.SCTraining_Test.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.SCTraining_Test.Name = "SCTraining_Test";
            // 
            // SCTraining_Test.Panel1
            // 
            this.SCTraining_Test.Panel1.Controls.Add(this.LblOutputVector);
            this.SCTraining_Test.Panel1.Controls.Add(this.label12);
            this.SCTraining_Test.Panel1.Controls.Add(this.BtnAddDesiredOutput);
            this.SCTraining_Test.Panel1.Controls.Add(this.BtnDoTraining);
            this.SCTraining_Test.Panel1.Controls.Add(this.label7);
            this.SCTraining_Test.Panel1.Controls.Add(this.label6);
            this.SCTraining_Test.Panel1.Controls.Add(this.TXTDesiredOutput);
            this.SCTraining_Test.Panel1.Controls.Add(this.LblInputVector);
            this.SCTraining_Test.Panel1.Controls.Add(this.label5);
            this.SCTraining_Test.Panel1.Controls.Add(this.TXTInput);
            this.SCTraining_Test.Panel1.Controls.Add(this.btnInput);
            // 
            // SCTraining_Test.Panel2
            // 
            this.SCTraining_Test.Panel2.Controls.Add(this.LblError);
            this.SCTraining_Test.Panel2.Controls.Add(this.label14);
            this.SCTraining_Test.Panel2.Controls.Add(this.btnTest);
            this.SCTraining_Test.Panel2.Controls.Add(this.label10);
            this.SCTraining_Test.Panel2.Controls.Add(this.LblTestInput);
            this.SCTraining_Test.Panel2.Controls.Add(this.label9);
            this.SCTraining_Test.Panel2.Controls.Add(this.TXTTest);
            this.SCTraining_Test.Panel2.Controls.Add(this.btnTestSample);
            this.SCTraining_Test.Size = new System.Drawing.Size(661, 158);
            this.SCTraining_Test.SplitterDistance = 327;
            this.SCTraining_Test.TabIndex = 1;
            // 
            // LblOutputVector
            // 
            this.LblOutputVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutputVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutputVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblOutputVector.Location = new System.Drawing.Point(142, 125);
            this.LblOutputVector.Name = "LblOutputVector";
            this.LblOutputVector.Size = new System.Drawing.Size(118, 20);
            this.LblOutputVector.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Output Vector :";
            // 
            // BtnAddDesiredOutput
            // 
            this.BtnAddDesiredOutput.Location = new System.Drawing.Point(266, 79);
            this.BtnAddDesiredOutput.Name = "BtnAddDesiredOutput";
            this.BtnAddDesiredOutput.Size = new System.Drawing.Size(54, 35);
            this.BtnAddDesiredOutput.TabIndex = 20;
            this.BtnAddDesiredOutput.Text = "Add";
            this.BtnAddDesiredOutput.UseVisualStyleBackColor = true;
            this.BtnAddDesiredOutput.Click += new System.EventHandler(this.BtnAddDesiredOutput_Click);
            // 
            // BtnDoTraining
            // 
            this.BtnDoTraining.Location = new System.Drawing.Point(266, 118);
            this.BtnDoTraining.Name = "BtnDoTraining";
            this.BtnDoTraining.Size = new System.Drawing.Size(62, 27);
            this.BtnDoTraining.TabIndex = 19;
            this.BtnDoTraining.Text = "Train";
            this.BtnDoTraining.UseVisualStyleBackColor = true;
            this.BtnDoTraining.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Input :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desired Output :";
            // 
            // TXTDesiredOutput
            // 
            this.TXTDesiredOutput.Location = new System.Drawing.Point(151, 83);
            this.TXTDesiredOutput.Name = "TXTDesiredOutput";
            this.TXTDesiredOutput.Size = new System.Drawing.Size(109, 26);
            this.TXTDesiredOutput.TabIndex = 16;
            // 
            // LblInputVector
            // 
            this.LblInputVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInputVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInputVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblInputVector.Location = new System.Drawing.Point(129, 56);
            this.LblInputVector.Name = "LblInputVector";
            this.LblInputVector.Size = new System.Drawing.Size(191, 20);
            this.LblInputVector.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Input Vector :";
            // 
            // TXTInput
            // 
            this.TXTInput.Location = new System.Drawing.Point(71, 16);
            this.TXTInput.Name = "TXTInput";
            this.TXTInput.Size = new System.Drawing.Size(138, 26);
            this.TXTInput.TabIndex = 13;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(215, 12);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(105, 35);
            this.btnInput.TabIndex = 12;
            this.btnInput.Text = "Add Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // LblError
            // 
            this.LblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblError.Location = new System.Drawing.Point(111, 116);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(119, 20);
            this.LblError.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Error :";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(249, 89);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(58, 31);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(4, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Test Input :";
            // 
            // LblTestInput
            // 
            this.LblTestInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTestInput.Location = new System.Drawing.Point(129, 66);
            this.LblTestInput.Name = "LblTestInput";
            this.LblTestInput.Size = new System.Drawing.Size(178, 20);
            this.LblTestInput.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Input Vector :";
            // 
            // TXTTest
            // 
            this.TXTTest.Location = new System.Drawing.Point(111, 17);
            this.TXTTest.Name = "TXTTest";
            this.TXTTest.Size = new System.Drawing.Size(104, 26);
            this.TXTTest.TabIndex = 13;
            // 
            // btnTestSample
            // 
            this.btnTestSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestSample.Location = new System.Drawing.Point(221, 13);
            this.btnTestSample.Name = "btnTestSample";
            this.btnTestSample.Size = new System.Drawing.Size(86, 35);
            this.btnTestSample.TabIndex = 12;
            this.btnTestSample.Text = "Add Input";
            this.btnTestSample.UseVisualStyleBackColor = true;
            this.btnTestSample.Click += new System.EventHandler(this.btnTestSample_Click);
            // 
            // PanelProjection
            // 
            this.PanelProjection.BackColor = System.Drawing.Color.Black;
            this.PanelProjection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelProjection.Location = new System.Drawing.Point(3, 186);
            this.PanelProjection.Name = "PanelProjection";
            this.PanelProjection.Size = new System.Drawing.Size(662, 388);
            this.PanelProjection.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(990, 634);
            this.Controls.Add(this.ViewGroupBox);
            this.Controls.Add(this.SettingsGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(990, 634);
            this.MinimumSize = new System.Drawing.Size(990, 634);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Layer Neural Networks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SettingsGB.ResumeLayout(false);
            this.SettingsGB.PerformLayout();
            this.GBLayerOptions.ResumeLayout(false);
            this.GBLayerOptions.PerformLayout();
            this.GBNeuronOptions.ResumeLayout(false);
            this.GBNeuronOptions.PerformLayout();
            this.ViewGroupBox.ResumeLayout(false);
            this.SCTraining_Test.Panel1.ResumeLayout(false);
            this.SCTraining_Test.Panel1.PerformLayout();
            this.SCTraining_Test.Panel2.ResumeLayout(false);
            this.SCTraining_Test.Panel2.PerformLayout();
            this.SCTraining_Test.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGB;
        private System.Windows.Forms.GroupBox ViewGroupBox;
        private System.Windows.Forms.Panel PanelProjection;
        private System.Windows.Forms.GroupBox GBLayerOptions;
        private System.Windows.Forms.GroupBox GBNeuronOptions;
        private System.Windows.Forms.Label LblLayerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreateNewLayer;
        private System.Windows.Forms.Button EditNeurons;
        private System.Windows.Forms.Button AddLayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDInputCount;
        private System.Windows.Forms.NumericUpDown NUDLearningRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDBias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CBMarkAsOutput;
        private System.Windows.Forms.Button BtnAddNeuron;
        private System.Windows.Forms.Button BtnInputLayer;
        private System.Windows.Forms.SplitContainer SCTraining_Test;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTDesiredOutput;
        private System.Windows.Forms.Label LblInputVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button BtnDoTraining;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTestInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTTest;
        private System.Windows.Forms.Button btnTestSample;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnCreateNeuralNetwork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnClearLayerInfo;
        private System.Windows.Forms.Button BtnAddDesiredOutput;
        private System.Windows.Forms.Label LblOutputVector;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnDebug;
        private System.Windows.Forms.Button BtnXORScript;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTTag;
        private System.Windows.Forms.Button BtnCLose;
        public System.Windows.Forms.NumericUpDown NUDInputSlot;
    }
}

