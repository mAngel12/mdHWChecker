using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class ProcessorService : InformationService
    {
        ManagementObjectSearcher processorInfo;

        public ProcessorService()
        {
            processorInfo = new ManagementObjectSearcher("select * from Win32_Processor");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            ClearListView(ref listView);
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

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Manufacturer", "Processor Brand"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Name", "Processor Name"));
                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "CurrentClockSpeed", "Processor Frequency"), "MHz"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(ProcessorTypeDecoder(GenerateInformation(mObject, viewGroup, "ProcessorType", "Processor Type")));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "ProcessorId", "CPU ID"));
                    listView.Items.Add(CPUArchitectureDecoder(GenerateInformation(mObject, viewGroup, "Architecture", "CPU Architecture")));
                    listView.Items.Add(CPUStatusDecoder(GenerateInformation(mObject, viewGroup, "CpuStatus", "CPU Status")));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Description", "CPU Description"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "NumberOfCores", "Number of CPU Cores"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "NumberOfLogicalProcessors", "Number of Logical CPUs"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "L2CacheSize", "L2 Cache"), "kB"));
                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "MaxClockSpeed", "Maximum CPU Frequency"), "MHz"));
                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "ExtClock", "External Clock Frequency"), "MHz"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Version", "CPU Version"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "SocketDesignation", "Socket Designation"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Status", "Status"));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ListViewItem CPUArchitectureDecoder(ListViewItem item)
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
            }
            return item;
        }

        private ListViewItem CPUStatusDecoder(ListViewItem item)
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
            }
            return item;
        }

        private ListViewItem ProcessorTypeDecoder(ListViewItem item)
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
            }
            return item;
        }
    }
}
