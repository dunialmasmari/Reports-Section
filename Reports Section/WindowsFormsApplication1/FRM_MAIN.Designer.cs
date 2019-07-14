namespace WindowsFormsApplication1
{
    partial class FRM_MAIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerMajorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiverSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majorReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.receiverSectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workerManagementToolStripMenuItem,
            this.workerMajorToolStripMenuItem});
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.workersToolStripMenuItem.Text = "Workers";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // workerManagementToolStripMenuItem
            // 
            this.workerManagementToolStripMenuItem.Name = "workerManagementToolStripMenuItem";
            this.workerManagementToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.workerManagementToolStripMenuItem.Text = "Worker Management";
            this.workerManagementToolStripMenuItem.Click += new System.EventHandler(this.workerManagementToolStripMenuItem_Click_1);
            // 
            // workerMajorToolStripMenuItem
            // 
            this.workerMajorToolStripMenuItem.Name = "workerMajorToolStripMenuItem";
            this.workerMajorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.workerMajorToolStripMenuItem.Text = "Worker_Major";
            this.workerMajorToolStripMenuItem.Click += new System.EventHandler(this.workerMajorToolStripMenuItem_Click_1);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uToolStripMenuItem,
            this.addUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.usersToolStripMenuItem.Text = "Sender";
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.uToolStripMenuItem.Text = "Sender Management";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addUsersToolStripMenuItem.Text = "Department Management";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem1,
            this.workerReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.reportsToolStripMenuItem.Text = "Sender Section";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.reportsToolStripMenuItem1.Text = " New Reports";
            this.reportsToolStripMenuItem1.Click += new System.EventHandler(this.reportsToolStripMenuItem1_Click_1);
            // 
            // workerReportToolStripMenuItem
            // 
            this.workerReportToolStripMenuItem.Name = "workerReportToolStripMenuItem";
            this.workerReportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.workerReportToolStripMenuItem.Text = "View Reports ";
            this.workerReportToolStripMenuItem.Click += new System.EventHandler(this.workerReportToolStripMenuItem_Click_1);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentProblemToolStripMenuItem,
            this.viewReportsToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.departmentToolStripMenuItem.Text = "Manager Section";
            // 
            // departmentProblemToolStripMenuItem
            // 
            this.departmentProblemToolStripMenuItem.Name = "departmentProblemToolStripMenuItem";
            this.departmentProblemToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.departmentProblemToolStripMenuItem.Text = "Received Reports";
            this.departmentProblemToolStripMenuItem.Click += new System.EventHandler(this.departmentProblemToolStripMenuItem_Click);
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // receiverSectionToolStripMenuItem
            // 
            this.receiverSectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedReportsToolStripMenuItem,
            this.majorReportsToolStripMenuItem});
            this.receiverSectionToolStripMenuItem.Name = "receiverSectionToolStripMenuItem";
            this.receiverSectionToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.receiverSectionToolStripMenuItem.Text = "Receiver Section";
            this.receiverSectionToolStripMenuItem.Click += new System.EventHandler(this.receiverSectionToolStripMenuItem_Click);
            // 
            // receivedReportsToolStripMenuItem
            // 
            this.receivedReportsToolStripMenuItem.Name = "receivedReportsToolStripMenuItem";
            this.receivedReportsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.receivedReportsToolStripMenuItem.Text = "Received Reports";
            this.receivedReportsToolStripMenuItem.Click += new System.EventHandler(this.receivedReportsToolStripMenuItem_Click);
            // 
            // majorReportsToolStripMenuItem
            // 
            this.majorReportsToolStripMenuItem.Name = "majorReportsToolStripMenuItem";
            this.majorReportsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.majorReportsToolStripMenuItem.Text = "Major Reports";
            this.majorReportsToolStripMenuItem.Click += new System.EventHandler(this.majorReportsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Section in YPC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem workerManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem workerMajorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem workerReportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem receiverSectionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem receivedReportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem majorReportsToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}