namespace WindowsFormsApplication1
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblPerson_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(79, 37);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(128, 20);
            this.txtFName.TabIndex = 0;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(307, 37);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(115, 20);
            this.txtMName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(511, 37);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(154, 20);
            this.txtLName.TabIndex = 2;
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(78, 77);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(244, 20);
            this.txtStreet1.TabIndex = 3;
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(419, 77);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(246, 20);
            this.txtStreet2.TabIndex = 4;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(12, 41);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "First Name:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(229, 41);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(72, 13);
            this.lblMName.TabIndex = 6;
            this.lblMName.Text = "Middle Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(444, 41);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name:";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(12, 80);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(47, 13);
            this.lblStreet1.TabIndex = 8;
            this.lblStreet1.Text = "Street 1:";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(353, 80);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(47, 13);
            this.lblStreet2.TabIndex = 9;
            this.lblStreet2.Text = "Street 2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 118);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(257, 118);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(500, 118);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(53, 13);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(206, 157);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(46, 116);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(168, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(297, 116);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(157, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(559, 116);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(106, 20);
            this.txtZipCode.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(252, 155);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(416, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(458, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(383, 240);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 20);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Add Contact";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(12, 289);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 21;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 157);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(64, 155);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(130, 20);
            this.txtCountry.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(535, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 20);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkEmployee
            // 
            this.chkEmployee.AutoSize = true;
            this.chkEmployee.Location = new System.Drawing.Point(14, 198);
            this.chkEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Size = new System.Drawing.Size(72, 17);
            this.chkEmployee.TabIndex = 11;
            this.chkEmployee.Text = "Employee";
            this.chkEmployee.UseVisualStyleBackColor = true;
            this.chkEmployee.CheckedChanged += new System.EventHandler(this.chkEmployee_CheckedChanged);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(120, 198);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 23;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(196, 197);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(126, 20);
            this.txtEmployeeID.TabIndex = 12;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(367, 198);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblHourlyRate.TabIndex = 24;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(442, 197);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(126, 20);
            this.txtHourlyRate.TabIndex = 13;
            // 
            // lblPerson_ID
            // 
            this.lblPerson_ID.AutoSize = true;
            this.lblPerson_ID.Location = new System.Drawing.Point(323, 244);
            this.lblPerson_ID.Name = "lblPerson_ID";
            this.lblPerson_ID.Size = new System.Drawing.Size(0, 13);
            this.lblPerson_ID.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 459);
            this.Controls.Add(this.lblPerson_ID);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.chkEmployee);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet2);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Name = "Form1";
            this.Text = "Lab 5 - Drill-Down Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblPerson_ID;
    }
}

