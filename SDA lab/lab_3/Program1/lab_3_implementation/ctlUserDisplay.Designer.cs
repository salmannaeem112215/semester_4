namespace lab_3_implementation
{
    partial class ctlUserDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbctlDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbctlDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbctlDisplay
            // 
            this.pbctlDisplay.Location = new System.Drawing.Point(3, 3);
            this.pbctlDisplay.Name = "pbctlDisplay";
            this.pbctlDisplay.Size = new System.Drawing.Size(144, 110);
            this.pbctlDisplay.TabIndex = 0;
            this.pbctlDisplay.TabStop = false;
            this.pbctlDisplay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ctlUserDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbctlDisplay);
            this.Name = "ctlUserDisplay";
            this.Load += new System.EventHandler(this.ctlUserDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbctlDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbctlDisplay;
        private Label label1;
    }
}
