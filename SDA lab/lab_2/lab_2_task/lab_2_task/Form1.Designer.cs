namespace lab_2_task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.program1 = new System.Windows.Forms.Button();
            this.program2 = new System.Windows.Forms.Button();
            this.program3 = new System.Windows.Forms.Button();
            this.program4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // program1
            // 
            this.program1.Location = new System.Drawing.Point(60, 45);
            this.program1.Name = "program1";
            this.program1.Size = new System.Drawing.Size(171, 23);
            this.program1.TabIndex = 0;
            this.program1.Text = "Start Program 1";
            this.program1.UseVisualStyleBackColor = true;
            this.program1.Click += new System.EventHandler(this.program1_Click);
            // 
            // program2
            // 
            this.program2.Location = new System.Drawing.Point(60, 74);
            this.program2.Name = "program2";
            this.program2.Size = new System.Drawing.Size(171, 23);
            this.program2.TabIndex = 1;
            this.program2.Text = "Start Program 2";
            this.program2.UseVisualStyleBackColor = true;
            this.program2.Click += new System.EventHandler(this.program2_Click);
            // 
            // program3
            // 
            this.program3.Location = new System.Drawing.Point(60, 103);
            this.program3.Name = "program3";
            this.program3.Size = new System.Drawing.Size(171, 23);
            this.program3.TabIndex = 2;
            this.program3.Text = "Start Program 3";
            this.program3.UseVisualStyleBackColor = true;
            this.program3.Click += new System.EventHandler(this.program3_Click);
            // 
            // program4
            // 
            this.program4.Location = new System.Drawing.Point(60, 132);
            this.program4.Name = "program4";
            this.program4.Size = new System.Drawing.Size(171, 23);
            this.program4.TabIndex = 3;
            this.program4.Text = "Start Program 4";
            this.program4.UseVisualStyleBackColor = true;
            this.program4.Click += new System.EventHandler(this.program4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 215);
            this.Controls.Add(this.program4);
            this.Controls.Add(this.program3);
            this.Controls.Add(this.program2);
            this.Controls.Add(this.program1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button program1;
        private Button program2;
        private Button program3;
        private Button program4;
    }
}