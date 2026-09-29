namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkGaming = new System.Windows.Forms.CheckBox();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.chkCoding = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Registration Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(30, 110);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(68, 13);
            this.lblRollNo.TabIndex = 3;
            this.lblRollNo.Text = "Roll Number:";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(150, 107);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(280, 20);
            this.txtRollNo.TabIndex = 4;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(30, 150);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(150, 147);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(280, 21);
            this.cmbDepartment.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(30, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(150, 188);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(220, 188);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(300, 188);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(51, 17);
            this.rbOther.TabIndex = 10;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(30, 230);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(49, 13);
            this.lblHobbies.TabIndex = 11;
            this.lblHobbies.Text = "Hobbies:";
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(150, 229);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(66, 17);
            this.chkReading.TabIndex = 12;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkGaming
            // 
            this.chkGaming.AutoSize = true;
            this.chkGaming.Location = new System.Drawing.Point(240, 229);
            this.chkGaming.Name = "chkGaming";
            this.chkGaming.Size = new System.Drawing.Size(62, 17);
            this.chkGaming.TabIndex = 13;
            this.chkGaming.Text = "Gaming";
            this.chkGaming.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(150, 255);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(56, 17);
            this.chkSports.TabIndex = 14;
            this.chkSports.Text = "Sports";
            this.chkSports.UseVisualStyleBackColor = true;
            // 
            // chkCoding
            // 
            this.chkCoding.AutoSize = true;
            this.chkCoding.Location = new System.Drawing.Point(240, 255);
            this.chkCoding.Name = "chkCoding";
            this.chkCoding.Size = new System.Drawing.Size(59, 17);
            this.chkCoding.TabIndex = 15;
            this.chkCoding.Text = "Coding";
            this.chkCoding.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(270, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkCoding);
            this.Controls.Add(this.chkSports);
            this.Controls.Add(this.chkGaming);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Student Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkGaming;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.CheckBox chkCoding;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}

