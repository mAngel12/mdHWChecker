using mdHWChecker.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.gui
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeInformations();
        }

        private void InitializeInformations()
        {
            PleaseWaitWindow pleaseWaitWindow = new PleaseWaitWindow();
            pleaseWaitWindow.Show();

            SystemService systemService = new SystemService();
            systemService.InsertInformationsToListView(ref systemView);
            ProcessorService processorService = new ProcessorService();
            processorService.InsertInformationsToListView(ref processorView);
            MotherboardService motherboardService = new MotherboardService();
            motherboardService.InsertInformationsToListView(ref motherboardView);
            MemoryService memoryService = new MemoryService();
            memoryService.InsertInformationsToListView(ref memoryView);
            VideoAdapterService videoAdapterService = new VideoAdapterService();
            videoAdapterService.InsertInformationsToListView(ref videoAdapterView);
            AudioService audioService = new AudioService();
            audioService.InsertInformationsToListView(ref audioView);
            DrivesService drivesService = new DrivesService();
            drivesService.InsertInformationsToListView(ref drivesView);
            TemperatureService temperatureService = new TemperatureService();
            temperatureService.InsertInformationsToListView(ref temperatureView);

            pleaseWaitWindow.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeInformations();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mdHWChecker is a simple application to checking your computer's configuration. \n" +
                "Copyright © 2017 DultzDev. \n" +
                "mdHWChecker v0.1 \n" +
                "Visit www.dultzdev.com for updates and more informations. \n"
                , "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
