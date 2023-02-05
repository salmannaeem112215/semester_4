namespace lab_2_task
{
    partial class Program1
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.s_password_box = new System.Windows.Forms.TextBox();
            this.s_username_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(174, 34);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(143, 23);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(174, 80);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(143, 23);
            this.passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(174, 134);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(163, 160);
            this.message.Name = "message";
            this.message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message.Size = new System.Drawing.Size(100, 15);
            this.message.TabIndex = 5;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(535, 160);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(546, 134);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 10;
            this.signButton.Text = "Sign Up";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // s_password_box
            // 
            this.s_password_box.Location = new System.Drawing.Point(546, 80);
            this.s_password_box.Name = "s_password_box";
            this.s_password_box.Size = new System.Drawing.Size(143, 23);
            this.s_password_box.TabIndex = 7;
            this.s_password_box.TextChanged += new System.EventHandler(this.s_password_box_TextChanged);
            // 
            // s_username_box
            // 
            this.s_username_box.Location = new System.Drawing.Point(546, 34);
            this.s_username_box.Name = "s_username_box";
            this.s_username_box.Size = new System.Drawing.Size(143, 23);
            this.s_username_box.TabIndex = 6;
            this.s_username_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_password_box);
            this.Controls.Add(this.s_username_box);
            this.Controls.Add(this.message);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "Program1";
            this.Text = "Program1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private Label message;
        private Label label3;
        private Button signButton;
        private Label label4;
        private Label label5;
        private TextBox s_password_box;
        private TextBox s_username_box;
    }
}