using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class MemoryService : InformationService
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

                    listView.Items.Add(SizeDecoder(GenerateInformation(mObject, viewGroup, "Capacity", "Memory Size")));
                    listView.Items.Add(MemoryTypeDecoder(GenerateInformation(mObject, viewGroup, "MemoryType", "Memory Type")));
                    listView.Items.Add(ModuleTypeDecoder(GenerateInformation(mObject, viewGroup, "FormFactor", "Module Type")));
                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "Speed", "Memory Speed"), "MHz"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Manufacturer", "Memory Manufacturer"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "PartNumber", "Memory Part Number"));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "Description", "Memory Description"));

                    listView.Items.Add(GenerateEmpty(viewGroup));

                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "DeviceLocator", "Device Location"));
                    listView.Items.Add(SimpleDecoder(GenerateInformation(mObject, viewGroup, "TotalWidth", "Total Width"), "bits"));
                    listView.Items.Add(VoltageDecoder(GenerateInformation(mObject, viewGroup, "MinVoltage", "Minimum Voltage")));
                    listView.Items.Add(VoltageDecoder(GenerateInformation(mObject, viewGroup, "MaxVoltage", "Maximum Voltage")));
                    listView.Items.Add(GenerateInformation(mObject, viewGroup, "SerialNumber", "Module Serial Number"));
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
                    item.SubItems.Add((Int64.Parse(value) / 1024 / 1024).ToString() + " MB");
                }
            }
            return item;
        }

        private ListViewItem VoltageDecoder(ListViewItem item)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    item.SubItems.Add(((float)(Int32.Parse(value)) / 1000).ToString() + " V");
                }
            }
            return item;
        }

        private ListViewItem ModuleTypeDecoder(ListViewItem item)
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
            }
            return item;
        }

        private ListViewItem MemoryTypeDecoder(ListViewItem item)
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
            }
            return item;
        }
    }
}
