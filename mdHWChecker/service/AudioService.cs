using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class AudioService : InformationService
    {
        ManagementObjectSearcher audioInfo;
        public AudioService()
        {
            audioInfo = new ManagementObjectSearcher("select * from Win32_SoundDevice");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in audioInfo.Get())
                {
                    try
                    {
                        viewGroup = listView.Groups.Add(mObject["Name"].ToString(), mObject["Name"].ToString());
                    }
                    catch
                    {
                        viewGroup = listView.Groups.Add(mObject.ToString(), mObject.ToString());
                    }

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Manufacturer", "Brand"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "ProductName", "Audio Adapter"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Description", "Description"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "DeviceID", "Audio Codec Hardware ID"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Status", "Status"));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
