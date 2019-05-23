namespace myproject
{
    partial class choose_reg_no
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblReg_no = new System.Windows.Forms.Label();
            this.cmbBoxReg_no = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(41, 130);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblReg_no
            // 
            this.lblReg_no.AutoSize = true;
            this.lblReg_no.Location = new System.Drawing.Point(38, 51);
            this.lblReg_no.Name = "lblReg_no";
            this.lblReg_no.Size = new System.Drawing.Size(45, 13);
            this.lblReg_no.TabIndex = 1;
            this.lblReg_no.Text = "Reg no.";
            // 
            // cmbBoxReg_no
            // 
            this.cmbBoxReg_no.FormattingEnabled = true;
            this.cmbBoxReg_no.Location = new System.Drawing.Point(103, 43);
            this.cmbBoxReg_no.Name = "cmbBoxReg_no";
            this.cmbBoxReg_no.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxReg_no.TabIndex = 2;
            this.cmbBoxReg_no.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // choose_reg_no
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 188);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbBoxReg_no);
            this.Controls.Add(this.lblReg_no);
            this.Controls.Add(this.btnOk);
            this.Name = "choose_reg_no";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choose_reg_no";
            this.Load += new System.EventHandler(this.choose_reg_no_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblReg_no;
        private System.Windows.Forms.ComboBox cmbBoxReg_no;
        private System.Windows.Forms.Button btnCancel;
    }
}