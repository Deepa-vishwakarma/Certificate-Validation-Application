namespace myproject
{
    partial class new_stud
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFathers_Name = new System.Windows.Forms.Label();
            this.lblReg_no = new System.Windows.Forms.Label();
            this.lblCourse_Name = new System.Windows.Forms.Label();
            this.lblDoj = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.btnAdd_Details = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFathers_Name = new System.Windows.Forms.TextBox();
            this.txtReg_no = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtDoj = new System.Windows.Forms.TextBox();
            this.txtCompletionDate = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblStudDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblFathers_Name
            // 
            this.lblFathers_Name.AutoSize = true;
            this.lblFathers_Name.Location = new System.Drawing.Point(16, 82);
            this.lblFathers_Name.Name = "lblFathers_Name";
            this.lblFathers_Name.Size = new System.Drawing.Size(73, 13);
            this.lblFathers_Name.TabIndex = 2;
            this.lblFathers_Name.Text = "Father\'s name";
            // 
            // lblReg_no
            // 
            this.lblReg_no.AutoSize = true;
            this.lblReg_no.Location = new System.Drawing.Point(17, 116);
            this.lblReg_no.Name = "lblReg_no";
            this.lblReg_no.Size = new System.Drawing.Size(48, 13);
            this.lblReg_no.TabIndex = 3;
            this.lblReg_no.Text = "Reg. no.";
            this.lblReg_no.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCourse_Name
            // 
            this.lblCourse_Name.AutoSize = true;
            this.lblCourse_Name.Location = new System.Drawing.Point(17, 148);
            this.lblCourse_Name.Name = "lblCourse_Name";
            this.lblCourse_Name.Size = new System.Drawing.Size(40, 13);
            this.lblCourse_Name.TabIndex = 4;
            this.lblCourse_Name.Text = "Course";
            // 
            // lblDoj
            // 
            this.lblDoj.AutoSize = true;
            this.lblDoj.Location = new System.Drawing.Point(17, 182);
            this.lblDoj.Name = "lblDoj";
            this.lblDoj.Size = new System.Drawing.Size(75, 13);
            this.lblDoj.TabIndex = 5;
            this.lblDoj.Text = "Date of joining";
            this.lblDoj.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(16, 216);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(96, 13);
            this.lblCompletionDate.TabIndex = 6;
            this.lblCompletionDate.Text = "Date of completion";
            // 
            // btnAdd_Details
            // 
            this.btnAdd_Details.Location = new System.Drawing.Point(176, 362);
            this.btnAdd_Details.Name = "btnAdd_Details";
            this.btnAdd_Details.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Details.TabIndex = 13;
            this.btnAdd_Details.Text = "Add details";
            this.btnAdd_Details.UseVisualStyleBackColor = true;
            this.btnAdd_Details.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(56, 362);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtFathers_Name
            // 
            this.txtFathers_Name.Location = new System.Drawing.Point(166, 82);
            this.txtFathers_Name.Name = "txtFathers_Name";
            this.txtFathers_Name.Size = new System.Drawing.Size(100, 20);
            this.txtFathers_Name.TabIndex = 16;
            this.txtFathers_Name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtReg_no
            // 
            this.txtReg_no.Location = new System.Drawing.Point(166, 116);
            this.txtReg_no.Name = "txtReg_no";
            this.txtReg_no.Size = new System.Drawing.Size(100, 20);
            this.txtReg_no.TabIndex = 17;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(166, 148);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 18;
            // 
            // txtDoj
            // 
            this.txtDoj.Location = new System.Drawing.Point(166, 182);
            this.txtDoj.Name = "txtDoj";
            this.txtDoj.Size = new System.Drawing.Size(100, 20);
            this.txtDoj.TabIndex = 19;
            this.txtDoj.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtCompletionDate
            // 
            this.txtCompletionDate.Location = new System.Drawing.Point(166, 216);
            this.txtCompletionDate.Name = "txtCompletionDate";
            this.txtCompletionDate.Size = new System.Drawing.Size(100, 20);
            this.txtCompletionDate.TabIndex = 20;
            this.txtCompletionDate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(166, 252);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 21;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(166, 290);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 22;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(17, 252);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 23;
            this.lblGrade.Text = "Grade";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(17, 290);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(36, 13);
            this.lblMarks.TabIndex = 24;
            this.lblMarks.Text = "Marks";
            // 
            // lblStudDetails
            // 
            this.lblStudDetails.AutoSize = true;
            this.lblStudDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudDetails.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStudDetails.Location = new System.Drawing.Point(87, 9);
            this.lblStudDetails.Name = "lblStudDetails";
            this.lblStudDetails.Size = new System.Drawing.Size(149, 24);
            this.lblStudDetails.TabIndex = 0;
            this.lblStudDetails.Text = "Student Details";
            // 
            // new_stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 400);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtCompletionDate);
            this.Controls.Add(this.txtDoj);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtReg_no);
            this.Controls.Add(this.txtFathers_Name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd_Details);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.lblDoj);
            this.Controls.Add(this.lblCourse_Name);
            this.Controls.Add(this.lblReg_no);
            this.Controls.Add(this.lblFathers_Name);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudDetails);
            this.Name = "new_stud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new_stud";
            this.Load += new System.EventHandler(this.new_stud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFathers_Name;
        private System.Windows.Forms.Label lblReg_no;
        private System.Windows.Forms.Label lblCourse_Name;
        private System.Windows.Forms.Label lblDoj;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.Button btnAdd_Details;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFathers_Name;
        private System.Windows.Forms.TextBox txtReg_no;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtDoj;
        private System.Windows.Forms.TextBox txtCompletionDate;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblStudDetails;
    }
}