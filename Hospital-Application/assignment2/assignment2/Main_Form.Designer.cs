namespace assignment2
{
    partial class Main_Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPatientsAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementSystemToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementSystemToolStripMenuItem
            // 
            this.managementSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorManagementToolStripMenuItem,
            this.patientManagementToolStripMenuItem,
            this.apToolStripMenuItem});
            this.managementSystemToolStripMenuItem.Name = "managementSystemToolStripMenuItem";
            this.managementSystemToolStripMenuItem.Size = new System.Drawing.Size(195, 29);
            this.managementSystemToolStripMenuItem.Text = "Management System";
            this.managementSystemToolStripMenuItem.Click += new System.EventHandler(this.managementSystemToolStripMenuItem_Click);
            // 
            // doctorManagementToolStripMenuItem
            // 
            this.doctorManagementToolStripMenuItem.Name = "doctorManagementToolStripMenuItem";
            this.doctorManagementToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.doctorManagementToolStripMenuItem.Text = "Doctor Management";
            this.doctorManagementToolStripMenuItem.Click += new System.EventHandler(this.doctorManagementToolStripMenuItem_Click);
            // 
            // patientManagementToolStripMenuItem
            // 
            this.patientManagementToolStripMenuItem.Name = "patientManagementToolStripMenuItem";
            this.patientManagementToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.patientManagementToolStripMenuItem.Text = "Patient Management";
            this.patientManagementToolStripMenuItem.Click += new System.EventHandler(this.patientManagementToolStripMenuItem_Click);
            // 
            // apToolStripMenuItem
            // 
            this.apToolStripMenuItem.Name = "apToolStripMenuItem";
            this.apToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.apToolStripMenuItem.Text = "Appointment Management ";
            this.apToolStripMenuItem.Click += new System.EventHandler(this.apToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem1,
            this.searchAppointmentToolStripMenuItem,
            this.showPatientsAppointmentsToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem1
            // 
            this.consultationToolStripMenuItem1.Name = "consultationToolStripMenuItem1";
            this.consultationToolStripMenuItem1.Size = new System.Drawing.Size(347, 34);
            this.consultationToolStripMenuItem1.Text = "Show All";
            this.consultationToolStripMenuItem1.Click += new System.EventHandler(this.consultationToolStripMenuItem1_Click);
            // 
            // searchAppointmentToolStripMenuItem
            // 
            this.searchAppointmentToolStripMenuItem.Name = "searchAppointmentToolStripMenuItem";
            this.searchAppointmentToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.searchAppointmentToolStripMenuItem.Text = "Search Appointment";
            this.searchAppointmentToolStripMenuItem.Click += new System.EventHandler(this.searchAppointmentToolStripMenuItem_Click);
            // 
            // showPatientsAppointmentsToolStripMenuItem
            // 
            this.showPatientsAppointmentsToolStripMenuItem.Name = "showPatientsAppointmentsToolStripMenuItem";
            this.showPatientsAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.showPatientsAppointmentsToolStripMenuItem.Text = "Show Patient\'s Appointments";
            this.showPatientsAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.showPatientsAppointmentsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 555);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPatientsAppointmentsToolStripMenuItem;
    }
}

