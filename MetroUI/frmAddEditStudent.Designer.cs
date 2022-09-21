namespace MetroUI
{
    partial class frmAddEditStudent
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkGender = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboCity = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 73);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(128, 73);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(153, 23);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(128, 114);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(272, 23);
            this.txtFullName.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 114);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Full name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 153);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Gender";
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(128, 153);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(28, 15);
            this.chkGender.TabIndex = 5;
            this.chkGender.Text = "?";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 192);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "City";
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.ItemHeight = 23;
            this.cboCity.Location = new System.Drawing.Point(128, 192);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(153, 29);
            this.cboCity.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(52, 233);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 233);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 70);
            this.textBox3.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            // 
            // frmAddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 397);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.chkGender);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAddEditStudent";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 12);
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private TextBox txtStudentID;
        private TextBox txtFullName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkGender;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboCity;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private TextBox textBox3;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}