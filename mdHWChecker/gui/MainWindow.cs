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
        }
    }
}
