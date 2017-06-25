namespace mdHWChecker.gui
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturePage = new System.Windows.Forms.TabPage();
            this.temperatureView = new System.Windows.Forms.ListView();
            this.drivesPage = new System.Windows.Forms.TabPage();
            this.drivesView = new System.Windows.Forms.ListView();
            this.featureDrivesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionDrivesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.networkPage = new System.Windows.Forms.TabPage();
            this.networkView = new System.Windows.Forms.ListView();
            this.featureNetworkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionNetworkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.audioPage = new System.Windows.Forms.TabPage();
            this.audioView = new System.Windows.Forms.ListView();
            this.featureAudioColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionAudioColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.videoAdapterPage = new System.Windows.Forms.TabPage();
            this.videoAdapterView = new System.Windows.Forms.ListView();
            this.featureVideoAdapterColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionVideoAdapterColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memoryPage = new System.Windows.Forms.TabPage();
            this.memoryView = new System.Windows.Forms.ListView();
            this.featureMemoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionMemoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motherboardPage = new System.Windows.Forms.TabPage();
            this.motherboardView = new System.Windows.Forms.ListView();
            this.featureMotherboardColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionMotherboardColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processorPage = new System.Windows.Forms.TabPage();
            this.processorView = new System.Windows.Forms.ListView();
            this.featureProcessorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionProcessorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.systemPage = new System.Windows.Forms.TabPage();
            this.systemView = new System.Windows.Forms.ListView();
            this.featureSystemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionSystemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.temperaturePage.SuspendLayout();
            this.drivesPage.SuspendLayout();
            this.networkPage.SuspendLayout();
            this.audioPage.SuspendLayout();
            this.videoAdapterPage.SuspendLayout();
            this.memoryPage.SuspendLayout();
            this.motherboardPage.SuspendLayout();
            this.processorPage.SuspendLayout();
            this.systemPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.helpStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(569, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "File";
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpStripMenuItem.Text = "Help";
            // 
            // temperaturePage
            // 
            this.temperaturePage.Controls.Add(this.temperatureView);
            this.temperaturePage.Location = new System.Drawing.Point(4, 22);
            this.temperaturePage.Name = "temperaturePage";
            this.temperaturePage.Padding = new System.Windows.Forms.Padding(3);
            this.temperaturePage.Size = new System.Drawing.Size(561, 406);
            this.temperaturePage.TabIndex = 0;
            this.temperaturePage.Text = "Temperature";
            this.temperaturePage.UseVisualStyleBackColor = true;
            // 
            // temperatureView
            // 
            this.temperatureView.BackColor = System.Drawing.SystemColors.Window;
            this.temperatureView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureView.Location = new System.Drawing.Point(3, 3);
            this.temperatureView.Name = "temperatureView";
            this.temperatureView.Size = new System.Drawing.Size(555, 400);
            this.temperatureView.TabIndex = 0;
            this.temperatureView.UseCompatibleStateImageBehavior = false;
            // 
            // drivesPage
            // 
            this.drivesPage.Controls.Add(this.drivesView);
            this.drivesPage.Location = new System.Drawing.Point(4, 22);
            this.drivesPage.Name = "drivesPage";
            this.drivesPage.Padding = new System.Windows.Forms.Padding(3);
            this.drivesPage.Size = new System.Drawing.Size(561, 406);
            this.drivesPage.TabIndex = 0;
            this.drivesPage.Text = "Drives";
            this.drivesPage.UseVisualStyleBackColor = true;
            // 
            // drivesView
            // 
            this.drivesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureDrivesColumnHeader,
            this.descriptionDrivesColumnHeader});
            this.drivesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drivesView.Location = new System.Drawing.Point(3, 3);
            this.drivesView.Name = "drivesView";
            this.drivesView.Size = new System.Drawing.Size(555, 400);
            this.drivesView.TabIndex = 0;
            this.drivesView.UseCompatibleStateImageBehavior = false;
            this.drivesView.View = System.Windows.Forms.View.Details;
            // 
            // featureDrivesColumnHeader
            // 
            this.featureDrivesColumnHeader.Text = "Feature";
            this.featureDrivesColumnHeader.Width = 150;
            // 
            // descriptionDrivesColumnHeader
            // 
            this.descriptionDrivesColumnHeader.Text = "Description";
            this.descriptionDrivesColumnHeader.Width = 400;
            // 
            // networkPage
            // 
            this.networkPage.Controls.Add(this.networkView);
            this.networkPage.Location = new System.Drawing.Point(4, 22);
            this.networkPage.Name = "networkPage";
            this.networkPage.Padding = new System.Windows.Forms.Padding(3);
            this.networkPage.Size = new System.Drawing.Size(561, 406);
            this.networkPage.TabIndex = 0;
            this.networkPage.Text = "Network";
            this.networkPage.UseVisualStyleBackColor = true;
            // 
            // networkView
            // 
            this.networkView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureNetworkColumnHeader,
            this.descriptionNetworkColumnHeader});
            this.networkView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkView.Location = new System.Drawing.Point(3, 3);
            this.networkView.Name = "networkView";
            this.networkView.Size = new System.Drawing.Size(555, 400);
            this.networkView.TabIndex = 0;
            this.networkView.UseCompatibleStateImageBehavior = false;
            this.networkView.View = System.Windows.Forms.View.Details;
            // 
            // featureNetworkColumnHeader
            // 
            this.featureNetworkColumnHeader.Text = "Feature";
            this.featureNetworkColumnHeader.Width = 150;
            // 
            // descriptionNetworkColumnHeader
            // 
            this.descriptionNetworkColumnHeader.Text = "Description";
            this.descriptionNetworkColumnHeader.Width = 400;
            // 
            // audioPage
            // 
            this.audioPage.Controls.Add(this.audioView);
            this.audioPage.Location = new System.Drawing.Point(4, 22);
            this.audioPage.Name = "audioPage";
            this.audioPage.Padding = new System.Windows.Forms.Padding(3);
            this.audioPage.Size = new System.Drawing.Size(561, 406);
            this.audioPage.TabIndex = 0;
            this.audioPage.Text = "Audio";
            this.audioPage.UseVisualStyleBackColor = true;
            // 
            // audioView
            // 
            this.audioView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureAudioColumnHeader,
            this.descriptionAudioColumnHeader});
            this.audioView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioView.Location = new System.Drawing.Point(3, 3);
            this.audioView.Name = "audioView";
            this.audioView.Size = new System.Drawing.Size(555, 400);
            this.audioView.TabIndex = 0;
            this.audioView.UseCompatibleStateImageBehavior = false;
            this.audioView.View = System.Windows.Forms.View.Details;
            // 
            // featureAudioColumnHeader
            // 
            this.featureAudioColumnHeader.Text = "Feature";
            this.featureAudioColumnHeader.Width = 150;
            // 
            // descriptionAudioColumnHeader
            // 
            this.descriptionAudioColumnHeader.Text = "Description";
            this.descriptionAudioColumnHeader.Width = 400;
            // 
            // videoAdapterPage
            // 
            this.videoAdapterPage.Controls.Add(this.videoAdapterView);
            this.videoAdapterPage.Location = new System.Drawing.Point(4, 22);
            this.videoAdapterPage.Name = "videoAdapterPage";
            this.videoAdapterPage.Padding = new System.Windows.Forms.Padding(3);
            this.videoAdapterPage.Size = new System.Drawing.Size(561, 406);
            this.videoAdapterPage.TabIndex = 0;
            this.videoAdapterPage.Text = "Video Adapter";
            this.videoAdapterPage.UseVisualStyleBackColor = true;
            // 
            // videoAdapterView
            // 
            this.videoAdapterView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureVideoAdapterColumnHeader,
            this.descriptionVideoAdapterColumnHeader});
            this.videoAdapterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoAdapterView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.videoAdapterView.Location = new System.Drawing.Point(3, 3);
            this.videoAdapterView.Name = "videoAdapterView";
            this.videoAdapterView.Size = new System.Drawing.Size(555, 400);
            this.videoAdapterView.TabIndex = 0;
            this.videoAdapterView.UseCompatibleStateImageBehavior = false;
            this.videoAdapterView.View = System.Windows.Forms.View.Details;
            // 
            // featureVideoAdapterColumnHeader
            // 
            this.featureVideoAdapterColumnHeader.Text = "Feature";
            this.featureVideoAdapterColumnHeader.Width = 150;
            // 
            // descriptionVideoAdapterColumnHeader
            // 
            this.descriptionVideoAdapterColumnHeader.Text = "Description";
            this.descriptionVideoAdapterColumnHeader.Width = 400;
            // 
            // memoryPage
            // 
            this.memoryPage.Controls.Add(this.memoryView);
            this.memoryPage.Location = new System.Drawing.Point(4, 22);
            this.memoryPage.Name = "memoryPage";
            this.memoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.memoryPage.Size = new System.Drawing.Size(561, 406);
            this.memoryPage.TabIndex = 0;
            this.memoryPage.Text = "Memory";
            this.memoryPage.UseVisualStyleBackColor = true;
            // 
            // memoryView
            // 
            this.memoryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureMemoryColumnHeader,
            this.descriptionMemoryColumnHeader});
            this.memoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryView.Location = new System.Drawing.Point(3, 3);
            this.memoryView.Name = "memoryView";
            this.memoryView.Size = new System.Drawing.Size(555, 400);
            this.memoryView.TabIndex = 0;
            this.memoryView.UseCompatibleStateImageBehavior = false;
            this.memoryView.View = System.Windows.Forms.View.Details;
            // 
            // featureMemoryColumnHeader
            // 
            this.featureMemoryColumnHeader.Text = "Feature";
            this.featureMemoryColumnHeader.Width = 150;
            // 
            // descriptionMemoryColumnHeader
            // 
            this.descriptionMemoryColumnHeader.Text = "Description";
            this.descriptionMemoryColumnHeader.Width = 400;
            // 
            // motherboardPage
            // 
            this.motherboardPage.Controls.Add(this.motherboardView);
            this.motherboardPage.Location = new System.Drawing.Point(4, 22);
            this.motherboardPage.Name = "motherboardPage";
            this.motherboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.motherboardPage.Size = new System.Drawing.Size(561, 406);
            this.motherboardPage.TabIndex = 0;
            this.motherboardPage.Text = "Motherboard";
            this.motherboardPage.UseVisualStyleBackColor = true;
            // 
            // motherboardView
            // 
            this.motherboardView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureMotherboardColumnHeader,
            this.descriptionMotherboardColumnHeader});
            this.motherboardView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motherboardView.Location = new System.Drawing.Point(3, 3);
            this.motherboardView.Name = "motherboardView";
            this.motherboardView.Size = new System.Drawing.Size(555, 400);
            this.motherboardView.TabIndex = 0;
            this.motherboardView.UseCompatibleStateImageBehavior = false;
            this.motherboardView.View = System.Windows.Forms.View.Details;
            // 
            // featureMotherboardColumnHeader
            // 
            this.featureMotherboardColumnHeader.Text = "Feature";
            this.featureMotherboardColumnHeader.Width = 150;
            // 
            // descriptionMotherboardColumnHeader
            // 
            this.descriptionMotherboardColumnHeader.Text = "Description";
            this.descriptionMotherboardColumnHeader.Width = 400;
            // 
            // processorPage
            // 
            this.processorPage.Controls.Add(this.processorView);
            this.processorPage.Location = new System.Drawing.Point(4, 22);
            this.processorPage.Name = "processorPage";
            this.processorPage.Padding = new System.Windows.Forms.Padding(3);
            this.processorPage.Size = new System.Drawing.Size(561, 406);
            this.processorPage.TabIndex = 0;
            this.processorPage.Text = "Processor";
            this.processorPage.UseVisualStyleBackColor = true;
            // 
            // processorView
            // 
            this.processorView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureProcessorColumnHeader,
            this.descriptionProcessorColumnHeader});
            this.processorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processorView.Location = new System.Drawing.Point(3, 3);
            this.processorView.Name = "processorView";
            this.processorView.Size = new System.Drawing.Size(555, 400);
            this.processorView.TabIndex = 0;
            this.processorView.UseCompatibleStateImageBehavior = false;
            this.processorView.View = System.Windows.Forms.View.Details;
            // 
            // featureProcessorColumnHeader
            // 
            this.featureProcessorColumnHeader.Text = "Feature";
            this.featureProcessorColumnHeader.Width = 150;
            // 
            // descriptionProcessorColumnHeader
            // 
            this.descriptionProcessorColumnHeader.Text = "Description";
            this.descriptionProcessorColumnHeader.Width = 400;
            // 
            // systemPage
            // 
            this.systemPage.Controls.Add(this.systemView);
            this.systemPage.Location = new System.Drawing.Point(4, 22);
            this.systemPage.Name = "systemPage";
            this.systemPage.Padding = new System.Windows.Forms.Padding(3);
            this.systemPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.systemPage.Size = new System.Drawing.Size(561, 406);
            this.systemPage.TabIndex = 0;
            this.systemPage.Text = "System";
            this.systemPage.UseVisualStyleBackColor = true;
            // 
            // systemView
            // 
            this.systemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.featureSystemColumnHeader,
            this.descriptionSystemColumnHeader});
            this.systemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemView.Location = new System.Drawing.Point(3, 3);
            this.systemView.Name = "systemView";
            this.systemView.Size = new System.Drawing.Size(555, 400);
            this.systemView.TabIndex = 0;
            this.systemView.UseCompatibleStateImageBehavior = false;
            this.systemView.View = System.Windows.Forms.View.Details;
            // 
            // featureSystemColumnHeader
            // 
            this.featureSystemColumnHeader.Text = "Feature";
            this.featureSystemColumnHeader.Width = 150;
            // 
            // descriptionSystemColumnHeader
            // 
            this.descriptionSystemColumnHeader.Text = "Description";
            this.descriptionSystemColumnHeader.Width = 400;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.systemPage);
            this.tabControl.Controls.Add(this.processorPage);
            this.tabControl.Controls.Add(this.motherboardPage);
            this.tabControl.Controls.Add(this.memoryPage);
            this.tabControl.Controls.Add(this.videoAdapterPage);
            this.tabControl.Controls.Add(this.audioPage);
            this.tabControl.Controls.Add(this.networkPage);
            this.tabControl.Controls.Add(this.drivesPage);
            this.tabControl.Controls.Add(this.temperaturePage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(569, 432);
            this.tabControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(569, 456);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "mdHWChecker";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.temperaturePage.ResumeLayout(false);
            this.drivesPage.ResumeLayout(false);
            this.networkPage.ResumeLayout(false);
            this.audioPage.ResumeLayout(false);
            this.videoAdapterPage.ResumeLayout(false);
            this.memoryPage.ResumeLayout(false);
            this.motherboardPage.ResumeLayout(false);
            this.processorPage.ResumeLayout(false);
            this.systemPage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage temperaturePage;
        private System.Windows.Forms.TabPage drivesPage;
        private System.Windows.Forms.TabPage networkPage;
        private System.Windows.Forms.TabPage audioPage;
        private System.Windows.Forms.TabPage videoAdapterPage;
        private System.Windows.Forms.TabPage memoryPage;
        private System.Windows.Forms.TabPage motherboardPage;
        private System.Windows.Forms.TabPage processorPage;
        private System.Windows.Forms.TabPage systemPage;
        private System.Windows.Forms.ListView processorView;
        private System.Windows.Forms.ListView systemView;
        private System.Windows.Forms.ListView motherboardView;
        private System.Windows.Forms.ListView memoryView;
        private System.Windows.Forms.ListView videoAdapterView;
        private System.Windows.Forms.ListView audioView;
        private System.Windows.Forms.ListView networkView;
        private System.Windows.Forms.ListView drivesView;
        private System.Windows.Forms.ListView temperatureView;
        private System.Windows.Forms.ColumnHeader featureProcessorColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionProcessorColumnHeader;
        private System.Windows.Forms.ColumnHeader featureSystemColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionSystemColumnHeader;
        private System.Windows.Forms.ColumnHeader featureVideoAdapterColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionVideoAdapterColumnHeader;
        private System.Windows.Forms.ColumnHeader featureMemoryColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionMemoryColumnHeader;
        private System.Windows.Forms.ColumnHeader featureMotherboardColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionMotherboardColumnHeader;
        private System.Windows.Forms.ColumnHeader featureDrivesColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionDrivesColumnHeader;
        private System.Windows.Forms.ColumnHeader featureNetworkColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionNetworkColumnHeader;
        private System.Windows.Forms.ColumnHeader featureAudioColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionAudioColumnHeader;
    }
}