namespace Program2
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
            this.components = new System.ComponentModel.Container();
            this.txtPostTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbApprovedPoint = new System.Windows.Forms.CheckBox();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPostTitle
            // 
            this.txtPostTitle.Location = new System.Drawing.Point(519, 66);
            this.txtPostTitle.Name = "txtPostTitle";
            this.txtPostTitle.Size = new System.Drawing.Size(100, 23);
            this.txtPostTitle.TabIndex = 0;
            this.txtPostTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostTitle_Validating);
            this.txtPostTitle.Validated += new System.EventHandler(this.txtPostTitle_Validated);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(466, 117);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(217, 199);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Post Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // cbApprovedPoint
            // 
            this.cbApprovedPoint.AutoSize = true;
            this.cbApprovedPoint.Location = new System.Drawing.Point(466, 322);
            this.cbApprovedPoint.Name = "cbApprovedPoint";
            this.cbApprovedPoint.Size = new System.Drawing.Size(109, 19);
            this.cbApprovedPoint.TabIndex = 4;
            this.cbApprovedPoint.Text = "Approved Point";
            this.cbApprovedPoint.UseVisualStyleBackColor = true;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(466, 364);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(75, 23);
            this.btnAddPost.TabIndex = 6;
            this.btnAddPost.Text = "Add Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(400, 275);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(190, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 44);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit Post";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(65, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Selected Post";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.cbApprovedPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPostTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPostTitle;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private CheckBox cbApprovedPoint;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Details;
        private Button btnAddPost;
        private Button btnEdit;
        private Button btnDelete;
        private Button button3;
        private ErrorProvider errorProvider1;
        private DataGridViewLinkColumn Column1;
        private ErrorProvider errorProvider2;
    }
}