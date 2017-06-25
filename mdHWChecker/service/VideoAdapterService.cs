using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public class VideoAdapterService : InformationService
    {
        ManagementObjectSearcher videoAdapterInfo;
        public VideoAdapterService()
        {
            videoAdapterInfo = new ManagementObjectSearcher("select * from Win32_VideoController");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
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

                    foreach (PropertyData data in mObject.Properties)
                    {
                        if (data.Name == "Name")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Card:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "AdapterRAM")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Memory:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add((Int64.Parse(CheckSystem(data)) / 1024 / 1024).ToString() + " MBytes");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "AdapterDACType")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video RAMDAC:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "VideoProcessor")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Processor:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "VideoModeDescription")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Mode:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "CurrentRefreshRate")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Refresh Rate:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data) + " Hz");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "DriverVersion")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Driver Version:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "DriverDate")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Driver Date:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "PNPDeviceID")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Hardware ID";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "CurrentBitsPerPixel")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Bits Per Pixel:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data));
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "VideoArchitecture")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Architecture:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
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
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "VideoMemoryType")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Video Memory Type:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
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
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
