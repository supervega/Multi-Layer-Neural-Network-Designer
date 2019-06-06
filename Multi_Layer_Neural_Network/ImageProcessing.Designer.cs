namespace Multi_Layer_Neural_Network
{
    partial class ImageProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcessing));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLastImage = new System.Windows.Forms.Button();
            this.BtnFirstImage = new System.Windows.Forms.Button();
            this.BtnRecognize = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.GBImages = new System.Windows.Forms.GroupBox();
            this.PBImage1 = new System.Windows.Forms.PictureBox();
            this.PBImage2 = new System.Windows.Forms.PictureBox();
            this.PBImage5 = new System.Windows.Forms.PictureBox();
            this.PBImage4 = new System.Windows.Forms.PictureBox();
            this.PBImage3 = new System.Windows.Forms.PictureBox();
            this.PBBorder = new System.Windows.Forms.PictureBox();
            this.BtnPreviousImage = new System.Windows.Forms.Button();
            this.BtnNextImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NUDOutputNumber = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnCreateNetwork = new System.Windows.Forms.Button();
            this.NUDLayerNumber = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NUDImageHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDImageWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblIteration = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.NUDMaxError = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTrain = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.NUDHeight = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NUDWidth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.RBCameraSource = new System.Windows.Forms.RadioButton();
            this.TXTBrowse = new System.Windows.Forms.TextBox();
            this.RBFileSource = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.TimerTime = new System.Windows.Forms.Timer();
            this.CBFD = new System.Windows.Forms.CheckBox();
            this.PBMain = new Multi_Layer_Neural_Network.DrawingPanel();
            this.groupBox1.SuspendLayout();
            this.GBImages.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.PBMain);
            this.groupBox1.Controls.Add(this.BtnLastImage);
            this.groupBox1.Controls.Add(this.BtnFirstImage);
            this.groupBox1.Controls.Add(this.BtnRecognize);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.GBImages);
            this.groupBox1.Controls.Add(this.BtnPreviousImage);
            this.groupBox1.Controls.Add(this.BtnNextImage);
            this.groupBox1.Location = new System.Drawing.Point(316, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 660);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnLastImage
            // 
            this.BtnLastImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLastImage.Location = new System.Drawing.Point(619, 414);
            this.BtnLastImage.Name = "BtnLastImage";
            this.BtnLastImage.Size = new System.Drawing.Size(46, 31);
            this.BtnLastImage.TabIndex = 18;
            this.BtnLastImage.Text = ">|";
            this.BtnLastImage.UseVisualStyleBackColor = true;
            this.BtnLastImage.Click += new System.EventHandler(this.BtnLastImage_Click);
            // 
            // BtnFirstImage
            // 
            this.BtnFirstImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirstImage.Location = new System.Drawing.Point(16, 414);
            this.BtnFirstImage.Name = "BtnFirstImage";
            this.BtnFirstImage.Size = new System.Drawing.Size(46, 31);
            this.BtnFirstImage.TabIndex = 17;
            this.BtnFirstImage.Text = "|<";
            this.BtnFirstImage.UseVisualStyleBackColor = true;
            this.BtnFirstImage.Click += new System.EventHandler(this.BtnFirstImage_Click);
            // 
            // BtnRecognize
            // 
            this.BtnRecognize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecognize.Location = new System.Drawing.Point(576, 291);
            this.BtnRecognize.Name = "BtnRecognize";
            this.BtnRecognize.Size = new System.Drawing.Size(93, 40);
            this.BtnRecognize.TabIndex = 16;
            this.BtnRecognize.Text = "Recognize";
            this.BtnRecognize.UseVisualStyleBackColor = true;
            this.BtnRecognize.Click += new System.EventHandler(this.BtnRecognize_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(598, 349);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(71, 26);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // GBImages
            // 
            this.GBImages.Controls.Add(this.PBImage1);
            this.GBImages.Controls.Add(this.PBImage2);
            this.GBImages.Controls.Add(this.PBImage5);
            this.GBImages.Controls.Add(this.PBImage4);
            this.GBImages.Controls.Add(this.PBImage3);
            this.GBImages.Controls.Add(this.PBBorder);
            this.GBImages.Location = new System.Drawing.Point(11, 503);
            this.GBImages.Name = "GBImages";
            this.GBImages.Size = new System.Drawing.Size(665, 151);
            this.GBImages.TabIndex = 8;
            this.GBImages.TabStop = false;
            // 
            // PBImage1
            // 
            this.PBImage1.BackColor = System.Drawing.Color.DimGray;
            this.PBImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImage1.Location = new System.Drawing.Point(6, 19);
            this.PBImage1.Name = "PBImage1";
            this.PBImage1.Size = new System.Drawing.Size(125, 125);
            this.PBImage1.TabIndex = 1;
            this.PBImage1.TabStop = false;
            this.PBImage1.Click += new System.EventHandler(this.PBImage1_Click);
            // 
            // PBImage2
            // 
            this.PBImage2.BackColor = System.Drawing.Color.DimGray;
            this.PBImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImage2.Location = new System.Drawing.Point(137, 19);
            this.PBImage2.Name = "PBImage2";
            this.PBImage2.Size = new System.Drawing.Size(125, 125);
            this.PBImage2.TabIndex = 2;
            this.PBImage2.TabStop = false;
            this.PBImage2.Click += new System.EventHandler(this.PBImage2_Click);
            // 
            // PBImage5
            // 
            this.PBImage5.BackColor = System.Drawing.Color.DimGray;
            this.PBImage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImage5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImage5.Location = new System.Drawing.Point(268, 19);
            this.PBImage5.Name = "PBImage5";
            this.PBImage5.Size = new System.Drawing.Size(125, 125);
            this.PBImage5.TabIndex = 5;
            this.PBImage5.TabStop = false;
            this.PBImage5.Click += new System.EventHandler(this.PBImage5_Click);
            // 
            // PBImage4
            // 
            this.PBImage4.BackColor = System.Drawing.Color.DimGray;
            this.PBImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImage4.Location = new System.Drawing.Point(402, 19);
            this.PBImage4.Name = "PBImage4";
            this.PBImage4.Size = new System.Drawing.Size(125, 125);
            this.PBImage4.TabIndex = 4;
            this.PBImage4.TabStop = false;
            this.PBImage4.Click += new System.EventHandler(this.PBImage4_Click);
            // 
            // PBImage3
            // 
            this.PBImage3.BackColor = System.Drawing.Color.DimGray;
            this.PBImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImage3.Location = new System.Drawing.Point(533, 19);
            this.PBImage3.Name = "PBImage3";
            this.PBImage3.Size = new System.Drawing.Size(125, 125);
            this.PBImage3.TabIndex = 3;
            this.PBImage3.TabStop = false;
            this.PBImage3.Click += new System.EventHandler(this.PBImage3_Click);
            // 
            // PBBorder
            // 
            this.PBBorder.BackColor = System.Drawing.Color.Red;
            this.PBBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBBorder.Location = new System.Drawing.Point(265, 15);
            this.PBBorder.Name = "PBBorder";
            this.PBBorder.Size = new System.Drawing.Size(131, 132);
            this.PBBorder.TabIndex = 6;
            this.PBBorder.TabStop = false;
            // 
            // BtnPreviousImage
            // 
            this.BtnPreviousImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousImage.Location = new System.Drawing.Point(17, 466);
            this.BtnPreviousImage.Name = "BtnPreviousImage";
            this.BtnPreviousImage.Size = new System.Drawing.Size(45, 31);
            this.BtnPreviousImage.TabIndex = 7;
            this.BtnPreviousImage.Text = "<";
            this.BtnPreviousImage.UseVisualStyleBackColor = true;
            this.BtnPreviousImage.Click += new System.EventHandler(this.BtnPreviousImage_Click);
            // 
            // BtnNextImage
            // 
            this.BtnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextImage.Location = new System.Drawing.Point(620, 466);
            this.BtnNextImage.Name = "BtnNextImage";
            this.BtnNextImage.Size = new System.Drawing.Size(45, 31);
            this.BtnNextImage.TabIndex = 6;
            this.BtnNextImage.Text = ">";
            this.BtnNextImage.UseVisualStyleBackColor = true;
            this.BtnNextImage.Click += new System.EventHandler(this.BtnNextImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 660);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NUDOutputNumber);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.BtnCreateNetwork);
            this.groupBox5.Controls.Add(this.NUDLayerNumber);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.NUDImageHeight);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.NUDImageWidth);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 474);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 180);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create Corresponding Neural Network";
            // 
            // NUDOutputNumber
            // 
            this.NUDOutputNumber.Location = new System.Drawing.Point(157, 118);
            this.NUDOutputNumber.Name = "NUDOutputNumber";
            this.NUDOutputNumber.Size = new System.Drawing.Size(120, 22);
            this.NUDOutputNumber.TabIndex = 13;
            this.NUDOutputNumber.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Number of Outputs :";
            // 
            // BtnCreateNetwork
            // 
            this.BtnCreateNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateNetwork.Location = new System.Drawing.Point(143, 142);
            this.BtnCreateNetwork.Name = "BtnCreateNetwork";
            this.BtnCreateNetwork.Size = new System.Drawing.Size(135, 31);
            this.BtnCreateNetwork.TabIndex = 10;
            this.BtnCreateNetwork.Text = "Create Network";
            this.BtnCreateNetwork.UseVisualStyleBackColor = true;
            this.BtnCreateNetwork.Click += new System.EventHandler(this.BtnCreateNetwork_Click);
            // 
            // NUDLayerNumber
            // 
            this.NUDLayerNumber.Location = new System.Drawing.Point(157, 91);
            this.NUDLayerNumber.Name = "NUDLayerNumber";
            this.NUDLayerNumber.Size = new System.Drawing.Size(120, 22);
            this.NUDLayerNumber.TabIndex = 11;
            this.NUDLayerNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Layers Number :";
            // 
            // NUDImageHeight
            // 
            this.NUDImageHeight.Location = new System.Drawing.Point(157, 63);
            this.NUDImageHeight.Name = "NUDImageHeight";
            this.NUDImageHeight.Size = new System.Drawing.Size(120, 22);
            this.NUDImageHeight.TabIndex = 9;
            this.NUDImageHeight.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Image Height :";
            // 
            // NUDImageWidth
            // 
            this.NUDImageWidth.Location = new System.Drawing.Point(157, 37);
            this.NUDImageWidth.Name = "NUDImageWidth";
            this.NUDImageWidth.Size = new System.Drawing.Size(120, 22);
            this.NUDImageWidth.TabIndex = 7;
            this.NUDImageWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image Width :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LblIteration);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.LblTime);
            this.groupBox4.Controls.Add(this.LblError);
            this.groupBox4.Controls.Add(this.NUDMaxError);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.BtnTrain);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Training";
            // 
            // LblIteration
            // 
            this.LblIteration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIteration.ForeColor = System.Drawing.Color.Red;
            this.LblIteration.Location = new System.Drawing.Point(157, 101);
            this.LblIteration.Name = "LblIteration";
            this.LblIteration.Size = new System.Drawing.Size(120, 16);
            this.LblIteration.TabIndex = 9;
            this.LblIteration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Iteration :";
            // 
            // LblTime
            // 
            this.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Red;
            this.LblTime.Location = new System.Drawing.Point(157, 128);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(120, 16);
            this.LblTime.TabIndex = 7;
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblError
            // 
            this.LblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(157, 29);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(120, 16);
            this.LblError.TabIndex = 6;
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDMaxError
            // 
            this.NUDMaxError.DecimalPlaces = 3;
            this.NUDMaxError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NUDMaxError.Location = new System.Drawing.Point(157, 61);
            this.NUDMaxError.Name = "NUDMaxError";
            this.NUDMaxError.Size = new System.Drawing.Size(120, 22);
            this.NUDMaxError.TabIndex = 5;
            this.NUDMaxError.ValueChanged += new System.EventHandler(this.NUDMaxError_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maximum Error :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Error :";
            // 
            // BtnTrain
            // 
            this.BtnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrain.Location = new System.Drawing.Point(164, 157);
            this.BtnTrain.Name = "BtnTrain";
            this.BtnTrain.Size = new System.Drawing.Size(113, 31);
            this.BtnTrain.TabIndex = 0;
            this.BtnTrain.Text = "Start Training";
            this.BtnTrain.UseVisualStyleBackColor = true;
            this.BtnTrain.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBFD);
            this.groupBox3.Controls.Add(this.BtnLoad);
            this.groupBox3.Controls.Add(this.NUDHeight);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.NUDWidth);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.BtnCapture);
            this.groupBox3.Controls.Add(this.RBCameraSource);
            this.groupBox3.Controls.Add(this.TXTBrowse);
            this.groupBox3.Controls.Add(this.RBFileSource);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BtnBrowse);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 243);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Source";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Location = new System.Drawing.Point(206, 165);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(71, 26);
            this.BtnLoad.TabIndex = 14;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // NUDHeight
            // 
            this.NUDHeight.Location = new System.Drawing.Point(158, 127);
            this.NUDHeight.Name = "NUDHeight";
            this.NUDHeight.Size = new System.Drawing.Size(120, 22);
            this.NUDHeight.TabIndex = 13;
            this.NUDHeight.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.NUDHeight.ValueChanged += new System.EventHandler(this.NUDHeight_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Image Height :";
            // 
            // NUDWidth
            // 
            this.NUDWidth.Location = new System.Drawing.Point(158, 101);
            this.NUDWidth.Name = "NUDWidth";
            this.NUDWidth.Size = new System.Drawing.Size(120, 22);
            this.NUDWidth.TabIndex = 11;
            this.NUDWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NUDWidth.ValueChanged += new System.EventHandler(this.NUDWidth_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Image Width :";
            // 
            // BtnCapture
            // 
            this.BtnCapture.Enabled = false;
            this.BtnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapture.Location = new System.Drawing.Point(75, 211);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(134, 26);
            this.BtnCapture.TabIndex = 3;
            this.BtnCapture.Text = "Capture Image";
            this.BtnCapture.UseVisualStyleBackColor = true;
            // 
            // RBCameraSource
            // 
            this.RBCameraSource.AutoSize = true;
            this.RBCameraSource.Location = new System.Drawing.Point(16, 185);
            this.RBCameraSource.Name = "RBCameraSource";
            this.RBCameraSource.Size = new System.Drawing.Size(80, 20);
            this.RBCameraSource.TabIndex = 1;
            this.RBCameraSource.Text = "Camera";
            this.RBCameraSource.UseVisualStyleBackColor = true;
            this.RBCameraSource.CheckedChanged += new System.EventHandler(this.RBCameraSource_CheckedChanged);
            // 
            // TXTBrowse
            // 
            this.TXTBrowse.Location = new System.Drawing.Point(16, 68);
            this.TXTBrowse.Name = "TXTBrowse";
            this.TXTBrowse.Size = new System.Drawing.Size(193, 22);
            this.TXTBrowse.TabIndex = 2;
            this.TXTBrowse.Text = "C:\\Users\\cec\\Documents\\Visual Studio 2008\\Projects\\Multi_Layer_Neural_Network\\Mul" +
                "ti_Layer_Neural_Network\\bin\\Debug\\Yale Faces DB";
            // 
            // RBFileSource
            // 
            this.RBFileSource.AutoSize = true;
            this.RBFileSource.Checked = true;
            this.RBFileSource.Location = new System.Drawing.Point(16, 21);
            this.RBFileSource.Name = "RBFileSource";
            this.RBFileSource.Size = new System.Drawing.Size(52, 20);
            this.RBFileSource.TabIndex = 0;
            this.RBFileSource.TabStop = true;
            this.RBFileSource.Text = "File";
            this.RBFileSource.UseVisualStyleBackColor = true;
            this.RBFileSource.CheckedChanged += new System.EventHandler(this.RBFileSource_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Images Directory :";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(215, 69);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(71, 26);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(24, 33);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TimerTime
            // 
            this.TimerTime.Interval = 1000;
            this.TimerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // CBFD
            // 
            this.CBFD.AutoSize = true;
            this.CBFD.Location = new System.Drawing.Point(16, 159);
            this.CBFD.Name = "CBFD";
            this.CBFD.Size = new System.Drawing.Size(132, 20);
            this.CBFD.TabIndex = 15;
            this.CBFD.Text = "Face Detection";
            this.CBFD.UseVisualStyleBackColor = true;
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.Color.White;
            this.PBMain.ImageOnPanel = ((System.Drawing.Bitmap)(resources.GetObject("PBMain.ImageOnPanel")));
            this.PBMain.Location = new System.Drawing.Point(70, 12);
            this.PBMain.Name = "PBMain";
            this.PBMain.PointSize = 10;
            this.PBMain.Size = new System.Drawing.Size(500, 500);
            this.PBMain.TabIndex = 19;
            // 
            // ImageProcessing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1020, 710);
            this.MinimumSize = new System.Drawing.Size(1020, 710);
            this.Name = "ImageProcessing";
            this.ShowIcon = false;
            this.Text = "ImageProcessing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImageProcessing_Load);
            this.groupBox1.ResumeLayout(false);
            this.GBImages.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PBImage5;
        private System.Windows.Forms.PictureBox PBImage4;
        private System.Windows.Forms.PictureBox PBImage3;
        private System.Windows.Forms.PictureBox PBImage2;
        private System.Windows.Forms.PictureBox PBImage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RBCameraSource;
        private System.Windows.Forms.RadioButton RBFileSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnTrain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.NumericUpDown NUDMaxError;
        private System.Windows.Forms.Timer TimerTime;
        private System.Windows.Forms.Label LblIteration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NUDImageHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDImageWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDLayerNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCreateNetwork;
        private System.Windows.Forms.Button BtnPreviousImage;
        private System.Windows.Forms.Button BtnNextImage;
        private System.Windows.Forms.GroupBox GBImages;
        private System.Windows.Forms.NumericUpDown NUDHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.PictureBox PBBorder;
        private System.Windows.Forms.NumericUpDown NUDOutputNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRecognize;
        private System.Windows.Forms.Button BtnLastImage;
        private System.Windows.Forms.Button BtnFirstImage;
        private DrawingPanel PBMain;
        public System.Windows.Forms.CheckBox CBFD;

    }
}