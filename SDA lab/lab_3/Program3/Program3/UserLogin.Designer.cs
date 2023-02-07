namespace Program3
{
    partial class UserLogin
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
            this.lTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lTitle.Location = new System.Drawing.Point(95, 18);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(111, 15);
            this.lTitle.TabIndex = 8;
            this.lTitle.Text = "Student Code Panel";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(189, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Code";
            // 
            // txtAddCode
            // 
            this.txtAddCode.Location = new System.Drawing.Point(127, 61);
            this.txtAddCode.Name = "txtAddCode";
            this.txtAddCode.Size = new System.Drawing.Size(137, 23);
            this.txtAddCode.TabIndex = 5;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 210);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddCode);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lTitle;
        private Button btnLogin;
        private Label label1;
        private TextBox txtAddCode;
    }
}