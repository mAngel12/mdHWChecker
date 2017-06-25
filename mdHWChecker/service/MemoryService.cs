using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public class MemoryService : InformationService
    {
        ManagementObjectSearcher memoryInfo;

        public MemoryService()
        {
            memoryInfo = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in memoryInfo.Get())
                {
                    try
                    {
                        viewGroup = listView.Groups.Add(mObject["Tag"].ToString(), mObject["Tag"].ToString());
                    }
                    catch
                    {
                        viewGroup = listView.Groups.Add(mObject.ToString(), mObject.ToString());
                    }

                    foreach (PropertyData data in mObject.Properties)
                    {
                        if (data.Name == "Capacity")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Memory Size:";
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
                        else if (data.Name == "Manufacturer")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Memory Manufacturer:";
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
                        else if (data.Name == "PartNumber")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Memory Part Number:";
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
                        else if (data.Name == "Speed")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Memory Speed:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data) + " MHz");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "DeviceLocator")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Device Location:";
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
                        else if (data.Name == "TotalWidth")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Total Width:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data) + " bits");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "MinVoltage")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Minimum Voltage:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(((float)(Int32.Parse(CheckSystem(data)))/1000).ToString() + " V");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "MaxVoltage")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Maximum Voltage:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(((float)(Int32.Parse(CheckSystem(data))) / 1000).ToString() + " V");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "SerialNumber")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Module Serial Number:";
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
                        else if (data.Name == "FormFactor")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Module Type:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
                                {
                                    case "0":
                                        item.SubItems.Add("Unknown");
                                        break;
                                    case "2":
                                        item.SubItems.Add("SIP");
                                        break;
                                    case "3":
                                        item.SubItems.Add("DIP");
                                        break;
                                    case "4":
                                        item.SubItems.Add("ZIP");
                                        break;
                                    case "5":
                                        item.SubItems.Add("SOJ");
                                        break;
                                    case "6":
                                        item.SubItems.Add("Proprietary");
                                        break;
                                    case "7":
                                        item.SubItems.Add("SIMM");
                                        break;
                                    case "8":
                                        item.SubItems.Add("DIMM");
                                        break;
                                    case "9":
                                        item.SubItems.Add("TSOP");
                                        break;
                                    case "10":
                                        item.SubItems.Add("PGA");
                                        break;
                                    case "11":
                                        item.SubItems.Add("RIMM");
                                        break;
                                    case "12":
                                        item.SubItems.Add("SODIMM");
                                        break;
                                    case "13":
                                        item.SubItems.Add("SRIMM");
                                        break;
                                    case "14":
                                        item.SubItems.Add("SMD");
                                        break;
                                    case "15":
                                        item.SubItems.Add("SSMP");
                                        break;
                                    case "16":
                                        item.SubItems.Add("QFP");
                                        break;
                                    case "17":
                                        item.SubItems.Add("TQFP");
                                        break;
                                    case "18":
                                        item.SubItems.Add("SOIC");
                                        break;
                                    case "19":
                                        item.SubItems.Add("LCC");
                                        break;
                                    case "20":
                                        item.SubItems.Add("PLCC");
                                        break;
                                    case "21":
                                        item.SubItems.Add("BGA");
                                        break;
                                    case "22":
                                        item.SubItems.Add("FPBGA");
                                        break;
                                    case "23":
                                        item.SubItems.Add("LGA");
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
                        else if (data.Name == "MemoryType")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Memory Type:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
                                {
                                    case "0":
                                        item.SubItems.Add("Unknown");
                                        break;
                                    case "2":
                                        item.SubItems.Add("DRAM");
                                        break;
                                    case "3":
                                        item.SubItems.Add("Synchronous DRAM");
                                        break;
                                    case "4":
                                        item.SubItems.Add("Cache DRAM");
                                        break;
                                    case "5":
                                        item.SubItems.Add("EDO");
                                        break;
                                    case "6":
                                        item.SubItems.Add("EDRAM");
                                        break;
                                    case "7":
                                        item.SubItems.Add("VRAM");
                                        break;
                                    case "8":
                                        item.SubItems.Add("SRAM");
                                        break;
                                    case "9":
                                        item.SubItems.Add("RAM");
                                        break;
                                    case "10":
                                        item.SubItems.Add("ROM");
                                        break;
                                    case "11":
                                        item.SubItems.Add("Flash");
                                        break;
                                    case "12":
                                        item.SubItems.Add("EEPROM");
                                        break;
                                    case "13":
                                        item.SubItems.Add("FEPROM");
                                        break;
                                    case "14":
                                        item.SubItems.Add("EPROM");
                                        break;
                                    case "15":
                                        item.SubItems.Add("CDRAM");
                                        break;
                                    case "16":
                                        item.SubItems.Add("3DRAM");
                                        break;
                                    case "17":
                                        item.SubItems.Add("SDRAM");
                                        break;
                                    case "18":
                                        item.SubItems.Add("SGRAM");
                                        break;
                                    case "19":
                                        item.SubItems.Add("RDRAM");
                                        break;
                                    case "20":
                                        item.SubItems.Add("DDR");
                                        break;
                                    case "21":
                                        item.SubItems.Add("DDR2");
                                        break;
                                    case "22":
                                        item.SubItems.Add("DDR2 FB-DIMM");
                                        break;
                                    case "24":
                                        item.SubItems.Add("DDR3");
                                        break;
                                    case "25":
                                        item.SubItems.Add("FBD2");
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
                        else if (data.Name == "Description")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Memory Description:";
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
