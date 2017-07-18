using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class SystemService : InformationService
    {
        ManagementObjectSearcher computerInfo;
        ManagementObjectSearcher systemInfo;

        public SystemService()
        {
            computerInfo = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            systemInfo = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            ClearListView(ref listView);
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in computerInfo.Get())
                {
                    viewGroup = listView.Groups.Add("Current Computer", "Current Computer");

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Name", "Computer Name"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Manufacturer", "Computer Brand"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Model", "Computer Model Name"));
                }

                foreach (ManagementObject mObject in systemInfo.Get())
                {
                    viewGroup = listView.Groups.Add("Operating System", "Operating System");

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Caption", "Operating System"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "OSArchitecture", "System Architecture"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Version", "System Version"));
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
