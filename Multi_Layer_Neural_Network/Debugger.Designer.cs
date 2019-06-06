namespace Multi_Layer_Neural_Network
{
    partial class Debugger
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
            this.LBTrace = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBTrace
            // 
            this.LBTrace.FormattingEnabled = true;
            this.LBTrace.Location = new System.Drawing.Point(12, 12);
            this.LBTrace.Name = "LBTrace";
            this.LBTrace.Size = new System.Drawing.Size(263, 329);
            this.LBTrace.TabIndex = 0;
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(346, 414);
            this.Controls.Add(this.LBTrace);
            this.Name = "Debugger";
            this.ShowIcon = false;
            this.Text = "Debugger";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox LBTrace;

    }
}