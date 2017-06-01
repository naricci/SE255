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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbWho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(158, 71);
            this.txtFName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(252, 31);
            this.txtFName.TabIndex = 0;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(614, 71);
            this.txtMName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(226, 31);
            this.txtMName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(1022, 71);
            this.txtLName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(304, 31);
            this.txtLName.TabIndex = 2;
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(156, 148);
            this.txtStreet1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(484, 31);
            this.txtStreet1.TabIndex = 3;
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(838, 148);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(488, 31);
            this.txtStreet2.TabIndex = 4;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(24, 79);
            this.lblFName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(122, 25);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "First Name:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(458, 79);
            this.lblMName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(144, 25);
            this.lblMName.TabIndex = 6;
            this.lblMName.Text = "Middle Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(888, 79);
            this.lblLName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(121, 25);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name:";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(24, 154);
            this.lblStreet1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(93, 25);
            this.lblStreet1.TabIndex = 8;
            this.lblStreet1.Text = "Street 1:";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(706, 154);
            this.lblStreet2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(93, 25);
            this.lblStreet2.TabIndex = 9;
            this.lblStreet2.Text = "Street 2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(24, 227);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 25);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(514, 227);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 25);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(1000, 227);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(105, 25);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(412, 302);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 25);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 223);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(332, 31);
            this.txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(594, 223);
            this.txtState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(108, 31);
            this.txtState.TabIndex = 6;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(1118, 223);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(208, 31);
            this.txtZipCode.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(504, 298);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(294, 31);
            this.txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(832, 302);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(916, 298);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(410, 31);
            this.txtEmail.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1074, 450);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(256, 63);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Add Contact";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(24, 556);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 25);
            this.lblFeedback.TabIndex = 21;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(24, 302);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(93, 25);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(128, 298);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(256, 31);
            this.txtCountry.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1074, 525);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(256, 63);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkEmployee
            // 
            this.chkEmployee.AutoSize = true;
            this.chkEmployee.Location = new System.Drawing.Point(28, 381);
            this.chkEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Size = new System.Drawing.Size(139, 29);
            this.chkEmployee.TabIndex = 11;
            this.chkEmployee.Text = "Employee";
            this.chkEmployee.UseVisualStyleBackColor = true;
            this.chkEmployee.CheckedChanged += new System.EventHandler(this.chkEmployee_CheckedChanged);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(240, 381);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(139, 25);
            this.lblEmployeeID.TabIndex = 23;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(392, 379);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(248, 31);
            this.txtEmployeeID.TabIndex = 12;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(734, 381);
            this.lblHourlyRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(131, 25);
            this.lblHourlyRate.TabIndex = 24;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(884, 379);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(248, 31);
            this.txtHourlyRate.TabIndex = 13;
            // 
            // lblPerson_ID
            // 
            this.lblPerson_ID.AutoSize = true;
            this.lblPerson_ID.Location = new System.Drawing.Point(646, 469);
            this.lblPerson_ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerson_ID.Name = "lblPerson_ID";
            this.lblPerson_ID.Size = new System.Drawing.Size(0, 25);
            this.lblPerson_ID.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1074, 600);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 63);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update Contact";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1074, 675);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 63);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(740, 223);
            this.cmbState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(216, 33);
            this.cmbState.TabIndex = 28;
            // 
            // cmbWho
            // 
            this.cmbWho.FormattingEnabled = true;
            this.cmbWho.Location = new System.Drawing.Point(257, 629);
            this.cmbWho.Name = "cmbWho";
            this.cmbWho.Size = new System.Drawing.Size(121, 33);
            this.cmbWho.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1362, 883);
            this.Controls.Add(this.cmbWho);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Lab 6 - Update, Delete & UX";
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbWho;
    }
}

