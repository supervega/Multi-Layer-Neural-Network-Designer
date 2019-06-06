namespace Multi_Layer_Neural_Network
{
    partial class Main_Interface
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
            this.MSList = new System.Windows.Forms.MenuStrip();
            this.neuralNetworkSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SSStatus = new System.Windows.Forms.StatusStrip();
            this.TSStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.faceDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSList.SuspendLayout();
            this.SSStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSList
            // 
            this.MSList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuralNetworkSettingsToolStripMenuItem,
            this.imageProcessingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MSList.Location = new System.Drawing.Point(0, 0);
            this.MSList.Name = "MSList";
            this.MSList.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.MSList.Size = new System.Drawing.Size(1008, 29);
            this.MSList.TabIndex = 1;
            this.MSList.Text = "menuStrip1";
            // 
            // neuralNetworkSettingsToolStripMenuItem
            // 
            this.neuralNetworkSettingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.neuralNetworkSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNetworkToolStripMenuItem,
            this.saveNetworkToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.neuralNetworkSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuralNetworkSettingsToolStripMenuItem.Name = "neuralNetworkSettingsToolStripMenuItem";
            this.neuralNetworkSettingsToolStripMenuItem.Size = new System.Drawing.Size(210, 25);
            this.neuralNetworkSettingsToolStripMenuItem.Text = "Neural Network Settings";
            this.neuralNetworkSettingsToolStripMenuItem.Click += new System.EventHandler(this.neuralNetworkSettingsToolStripMenuItem_Click);
            // 
            // loadNetworkToolStripMenuItem
            // 
            this.loadNetworkToolStripMenuItem.Name = "loadNetworkToolStripMenuItem";
            this.loadNetworkToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.loadNetworkToolStripMenuItem.Text = "Load Network";
            this.loadNetworkToolStripMenuItem.Click += new System.EventHandler(this.loadNetworkToolStripMenuItem_Click);
            // 
            // saveNetworkToolStripMenuItem
            // 
            this.saveNetworkToolStripMenuItem.Name = "saveNetworkToolStripMenuItem";
            this.saveNetworkToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveNetworkToolStripMenuItem.Text = "Save Network";
            this.saveNetworkToolStripMenuItem.Click += new System.EventHandler(this.saveNetworkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageProcessingToolStripMenuItem
            // 
            this.imageProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faceDetectionToolStripMenuItem,
            this.patternRecognitionToolStripMenuItem});
            this.imageProcessingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            this.imageProcessingToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.imageProcessingToolStripMenuItem.Text = "Image Processing";
            this.imageProcessingToolStripMenuItem.Click += new System.EventHandler(this.imageProcessingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SSStatus
            // 
            this.SSStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSStatusLbl,
            this.TSSStatusLbl});
            this.SSStatus.Location = new System.Drawing.Point(0, 710);
            this.SSStatus.Name = "SSStatus";
            this.SSStatus.Size = new System.Drawing.Size(1008, 22);
            this.SSStatus.TabIndex = 2;
            this.SSStatus.Text = "statusStrip1";
            // 
            // TSStatusLbl
            // 
            this.TSStatusLbl.Name = "TSStatusLbl";
            this.TSStatusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSStatusLbl
            // 
            this.TSSStatusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TSSStatusLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSSStatusLbl.Name = "TSSStatusLbl";
            this.TSSStatusLbl.Size = new System.Drawing.Size(72, 17);
            this.TSSStatusLbl.Text = "Welcome ...";
            this.TSSStatusLbl.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // faceDetectionToolStripMenuItem
            // 
            this.faceDetectionToolStripMenuItem.Name = "faceDetectionToolStripMenuItem";
            this.faceDetectionToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.faceDetectionToolStripMenuItem.Text = "Face Detection";
            this.faceDetectionToolStripMenuItem.Click += new System.EventHandler(this.faceDetectionToolStripMenuItem_Click);
            // 
            // patternRecognitionToolStripMenuItem
            // 
            this.patternRecognitionToolStripMenuItem.Name = "patternRecognitionToolStripMenuItem";
            this.patternRecognitionToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.patternRecognitionToolStripMenuItem.Text = "Pattern Recognition";
            this.patternRecognitionToolStripMenuItem.Click += new System.EventHandler(this.patternRecognitionToolStripMenuItem_Click);
            // 
            // Main_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.SSStatus);
            this.Controls.Add(this.MSList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSList;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 766);
            this.Name = "Main_Interface";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Interface_FormClosing);
            this.Load += new System.EventHandler(this.Main_Interface_Load);
            this.MSList.ResumeLayout(false);
            this.MSList.PerformLayout();
            this.SSStatus.ResumeLayout(false);
            this.SSStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSList;
        private System.Windows.Forms.ToolStripMenuItem neuralNetworkSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TSStatusLbl;
        private System.Windows.Forms.ToolStripMenuItem loadNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.StatusStrip SSStatus;
        public System.Windows.Forms.ToolStripStatusLabel TSSStatusLbl;
        private System.Windows.Forms.ToolStripMenuItem faceDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternRecognitionToolStripMenuItem;
    }
}