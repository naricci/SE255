namespace MidTermProject
{
    partial class ControlPanel
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
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAppointments = new System.Windows.Forms.Button();
            this.btnUpdateAppointments = new System.Windows.Forms.Button();
            this.btnSearchAppointments = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(18, 28);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(70, 38);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPlayer);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roster Manager";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAppointments);
            this.groupBox2.Controls.Add(this.btnUpdateAppointments);
            this.groupBox2.Controls.Add(this.btnSearchAppointments);
            this.groupBox2.Controls.Add(this.btnAddAppointment);
            this.groupBox2.Location = new System.Drawing.Point(25, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Manager";
            // 
            // btnDeleteAppointments
            // 
            this.btnDeleteAppointments.Location = new System.Drawing.Point(246, 28);
            this.btnDeleteAppointments.Name = "btnDeleteAppointments";
            this.btnDeleteAppointments.Size = new System.Drawing.Size(70, 38);
            this.btnDeleteAppointments.TabIndex = 3;
            this.btnDeleteAppointments.Text = "Delete";
            this.btnDeleteAppointments.UseVisualStyleBackColor = true;
            this.btnDeleteAppointments.Click += new System.EventHandler(this.btnDeleteAppointments_Click);
            // 
            // btnUpdateAppointments
            // 
            this.btnUpdateAppointments.Location = new System.Drawing.Point(170, 28);
            this.btnUpdateAppointments.Name = "btnUpdateAppointments";
            this.btnUpdateAppointments.Size = new System.Drawing.Size(70, 38);
            this.btnUpdateAppointments.TabIndex = 2;
            this.btnUpdateAppointments.Text = "Update";
            this.btnUpdateAppointments.UseVisualStyleBackColor = true;
            this.btnUpdateAppointments.Click += new System.EventHandler(this.btnUpdateAppointments_Click);
            // 
            // btnSearchAppointments
            // 
            this.btnSearchAppointments.Location = new System.Drawing.Point(94, 28);
            this.btnSearchAppointments.Name = "btnSearchAppointments";
            this.btnSearchAppointments.Size = new System.Drawing.Size(70, 38);
            this.btnSearchAppointments.TabIndex = 1;
            this.btnSearchAppointments.Text = "Search";
            this.btnSearchAppointments.UseVisualStyleBackColor = true;
            this.btnSearchAppointments.Click += new System.EventHandler(this.btnSearchAppointments_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(18, 28);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(70, 38);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click_1);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteAppointments;
        private System.Windows.Forms.Button btnUpdateAppointments;
        private System.Windows.Forms.Button btnSearchAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}