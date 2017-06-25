using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public class ProcessorService : InformationService
    {
        ManagementObjectSearcher processorInfo;

        public ProcessorService()
        {
            processorInfo = new ManagementObjectSearcher("select * from Win32_Processor");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in processorInfo.Get())
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
                            item.Text = "Processor Name:";
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
                        else if (data.Name == "Manufacturer")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Processor Brand:";
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
                        else if (data.Name == "CurrentClockSpeed")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Processor Frequency:";
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
                        else if (data.Name == "MaxClockSpeed")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Maximum CPU Frequency:";
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
                        else if (data.Name == "NumberOfCores")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Number of CPU Cores:";
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
                        else if (data.Name == "NumberOfLogicalProcessors")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Number of Logical CPUs:";
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
                        else if (data.Name == "ProcessorId")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "CPU ID:";
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
                        else if (data.Name == "Architecture")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "CPU Architecture:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
                                {
                                    case "0":
                                        item.SubItems.Add("x86");
                                        break;
                                    case "1":
                                        item.SubItems.Add("MIPS");
                                        break;
                                    case "2":
                                        item.SubItems.Add("Alpha");
                                        break;
                                    case "3":
                                        item.SubItems.Add("PowerPC");
                                        break;
                                    case "5":
                                        item.SubItems.Add("ARM");
                                        break;
                                    case "6":
                                        item.SubItems.Add("ia64");
                                        break;
                                    case "9":
                                        item.SubItems.Add("x64");
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
                        else if (data.Name == "L2CacheSize")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "L2 Cache:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                item.SubItems.Add(CheckSystem(data) + " kB");
                            }
                            else
                            {
                                continue;
                            }
                            listView.Items.Add(item);
                        }
                        else if (data.Name == "CpuStatus")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "CPU Status:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
                                {
                                    case "0":
                                        item.SubItems.Add("Unknown");
                                        break;
                                    case "1":
                                        item.SubItems.Add("CPU Enabled");
                                        break;
                                    case "2":
                                        item.SubItems.Add("CPU Disabled by User via BIOS Setup");
                                        break;
                                    case "3":
                                        item.SubItems.Add("CPU Disabled By BIOS(POST Error)");
                                        break;
                                    case "4":
                                        item.SubItems.Add("CPU is Idle");
                                        break;
                                    case "5":
                                    case "6":
                                        item.SubItems.Add("Reserved");
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
                        else if (data.Name == "ExtClock")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "External Clock Frequency:";
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
                        else if (data.Name == "ProcessorType")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Processor Type:";
                            if (data.Value != null && data.Value.ToString() != "")
                            {
                                switch (CheckSystem(data))
                                {
                                    case "2":
                                        item.SubItems.Add("Unknown");
                                        break;
                                    case "3":
                                        item.SubItems.Add("Central Processor");
                                        break;
                                    case "4":
                                        item.SubItems.Add("Math Processor");
                                        break;
                                    case "5":
                                        item.SubItems.Add("DSP Processor");
                                        break;
                                    case "6":
                                        item.SubItems.Add("Video Processor");
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
                        else if (data.Name == "Version")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "CPU Version:";
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
                        else if (data.Name == "SocketDesignation")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Socket Designation:";
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
                        else if (data.Name == "Status")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "CPU Status:";
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
                        else if (data.Name == "Description")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "CPU Description:";
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
