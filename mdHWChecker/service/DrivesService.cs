using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class DrivesService : InformationService
    {
        ManagementObjectSearcher cddvdDrivesInfo;
        ManagementObjectSearcher diskDrivesInfo;

        public DrivesService()
        {
            cddvdDrivesInfo = new ManagementObjectSearcher("select * from Win32_CDROMDrive");
            diskDrivesInfo = new ManagementObjectSearcher("select * from Win32_DiskDrive");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in diskDrivesInfo.Get())
                {
                    try
                    {
                        viewGroup = listView.Groups.Add(mObject["Model"].ToString(), mObject["Model"].ToString());
                    }
                    catch
                    {
                        viewGroup = listView.Groups.Add(mObject.ToString(), mObject.ToString());
                    }

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Model", "Drive Model"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "FirmwareRevision", "Drive Revision"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "SerialNumber", "Drive Serial Number"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "DeviceID", "Drive Device ID"));
                    listView.Items.Add(SizeDecoder(GenerateInformation(mObject, viewGroup, "Size", "Drive Size")));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "InterfaceType", "Drive Interface Type"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Partitions", "Numer of Partitions"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Status", "Drive Status"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "MediaType", "Drive Media Type"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "TotalCylinders", "Number of Cylinders"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "TotalHeads", "Number of Heads"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "TotalSectors", "Number of Sectors"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "TotalTracks", "Number of Tracks"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "TracksPerCylinder", "Tracks Per Cylinder"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "BytesPerSector", "Bytes Per Sector"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "SectorsPerTrack", "SectorsPerTrack"));
                }

                foreach (ManagementObject mObject in cddvdDrivesInfo.Get())
                {
                    try
                    {
                        viewGroup = listView.Groups.Add(mObject["Name"].ToString(), mObject["Name"].ToString());
                    }
                    catch
                    {
                        viewGroup = listView.Groups.Add(mObject.ToString(), mObject.ToString());
                    }

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Name", "Drive Model Name"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "MfrAssignedRevisionLevel", "Revision"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "SerialNumber", "Serial Number"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "MediaType", "Drive Type"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "DeviceID", "Device ID"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Id", "Drive Letter"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Description", "Drive Description"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Status", "Status"));

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ListViewItem SizeDecoder(ListViewItem item)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    item.SubItems.Add((Int64.Parse(value) / 1024 / 1024 / 1024).ToString() + " GB");
                }
            }
            return item;
        }
    }
}
