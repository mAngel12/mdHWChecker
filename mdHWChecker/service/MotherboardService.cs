using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class MotherboardService : InformationService
    {
        ManagementObjectSearcher baseboardInfo;
        ManagementObjectSearcher motherboardInfo;
        ManagementObjectSearcher biosInfo;

        public MotherboardService()
        {
            baseboardInfo = new ManagementObjectSearcher("select * from Win32_BaseBoard");
            motherboardInfo = new ManagementObjectSearcher("select * from Win32_MotherboardDevice");
            biosInfo = new ManagementObjectSearcher("select * from Win32_BIOS");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            ClearListView(ref listView);
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in baseboardInfo.Get())
                {
                    viewGroup = listView.Groups.Add(mObject["Name"].ToString(), mObject["Name"].ToString());

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Manufacturer", "Brand"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Product", "Model"));

                    foreach (ManagementObject mObj in motherboardInfo.Get())
                    {
                        listView.Items.Add(GenerateInformation(mObj, viewGroup, "PrimaryBusType", "Primary Bus Type"));
                        listView.Items.Add(GenerateInformation(mObj, viewGroup, "SecondaryBusType", "Secondary Bus Type"));
                    }
                }
                foreach (ManagementObject mObject in biosInfo.Get())
                {
                    viewGroup = listView.Groups.Add("BIOS", "BIOS");

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Manufacturer", "BIOS Manufacturer"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "ReleaseDate", "BIOS Date"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "SMBIOSBIOSVersion", "BIOS Version"));
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
