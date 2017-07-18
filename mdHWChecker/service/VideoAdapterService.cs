using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class VideoAdapterService : InformationService
    {
        ManagementObjectSearcher videoAdapterInfo;
        public VideoAdapterService()
        {
            videoAdapterInfo = new ManagementObjectSearcher("select * from Win32_VideoController");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            ClearListView(ref listView);
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in videoAdapterInfo.Get())
                {
                    try
                    {
                        viewGroup = listView.Groups.Add(mObject["Name"].ToString(), mObject["Name"].ToString());
                    }
                    catch
                    {
                        viewGroup = listView.Groups.Add(mObject.ToString(), mObject.ToString());
                    }

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Name", "Video Card"));
                    listView.Items.Add(MemoryDecoder(GenerateInformation(mObject, viewGroup, "AdapterRAM", "Video Memory")));
                    listView.Items.Add(VideoMemoryTypeDecoder(GenerateInformation(mObject, viewGroup, "VideoMemoryType", "Video Memory Type")));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "AdapterDACType", "Video RAMDAC"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "VideoProcessor", "Video Processor"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "DriverVersion", "Video Driver Version"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "DriverDate", "Video Driver Date"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "VideoModeDescription", "Video Mode"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "CurrentBitsPerPixel", "Bits Per Pixel"));
                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "CurrentRefreshRate", "Refresh Rate"), "Hz"));
                    listView.Items.Add(VideoArchitectureDecoder(GenerateInformation(mObject, viewGroup, "VideoArchitecture", "Video Architecture")));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "PNPDeviceID", "PNPDeviceID"));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ListViewItem MemoryDecoder(ListViewItem item)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    item.SubItems.Add((Int64.Parse(value) / 1024 / 1024).ToString() + " MBytes");
                }
            }
            return item;
        }

        private ListViewItem VideoArchitectureDecoder(ListViewItem item)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    switch (value)
                    {
                        case "2":
                            item.SubItems.Add("Unknown");
                            break;
                        case "3":
                            item.SubItems.Add("CGA");
                            break;
                        case "4":
                            item.SubItems.Add("EGA");
                            break;
                        case "5":
                            item.SubItems.Add("VGA");
                            break;
                        case "6":
                            item.SubItems.Add("SVGA");
                            break;
                        case "7":
                            item.SubItems.Add("MDA");
                            break;
                        case "8":
                            item.SubItems.Add("HGC");
                            break;
                        case "9":
                            item.SubItems.Add("MCGA");
                            break;
                        case "10":
                            item.SubItems.Add("8514A");
                            break;
                        case "11":
                            item.SubItems.Add("XGA");
                            break;
                        case "12":
                            item.SubItems.Add("Linear Frame Buffer");
                            break;
                        case "160":
                            item.SubItems.Add("PC-98");
                            break;
                        default:
                            item.SubItems.Add("Other");
                            break;
                    }
                }
            }
            return item;
        }

        private ListViewItem VideoMemoryTypeDecoder(ListViewItem item)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    switch (value)
                    {
                        case "2":
                            item.SubItems.Add("Unknown");
                            break;
                        case "3":
                            item.SubItems.Add("VRAM");
                            break;
                        case "4":
                            item.SubItems.Add("DRAM");
                            break;
                        case "5":
                            item.SubItems.Add("SRAM");
                            break;
                        case "6":
                            item.SubItems.Add("WRAM");
                            break;
                        case "7":
                            item.SubItems.Add("EDO RAM");
                            break;
                        case "8":
                            item.SubItems.Add("Burst Synchronous DRAM");
                            break;
                        case "9":
                            item.SubItems.Add("Pipelined Burst SRAM");
                            break;
                        case "10":
                            item.SubItems.Add("CDRAM");
                            break;
                        case "11":
                            item.SubItems.Add("3DRAM");
                            break;
                        case "12":
                            item.SubItems.Add("SDRAM");
                            break;
                        case "13":
                            item.SubItems.Add("SGRAM");
                            break;
                        default:
                            item.SubItems.Add("Other");
                            break;
                    }
                }
            }
            return item;
        }
    }
}
