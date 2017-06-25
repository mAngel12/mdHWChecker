using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public class MotherboardService : InformationService
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
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in baseboardInfo.Get())
                {
                    viewGroup = listView.Groups.Add(mObject["Name"].ToString(), mObject["Name"].ToString());
                    foreach (PropertyData data in mObject.Properties)
                    {
                        if (data.Name == "Product")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Model:";
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
                            item.Text = "Brand:";
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
                    foreach (ManagementObject mObj in motherboardInfo.Get())
                    {
                        foreach (PropertyData data in mObj.Properties)
                        {
                            if (data.Name == "PrimaryBusType")
                            {
                                ListViewItem item = new ListViewItem(viewGroup);
                                item.Text = "Primary Bus Type:";
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
                            else if (data.Name == "SecondaryBusType")
                            {
                                ListViewItem item = new ListViewItem(viewGroup);
                                item.Text = "Secondary Bus Type:";
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
                foreach (ManagementObject mObject in biosInfo.Get())
                {
                    viewGroup = listView.Groups.Add("BIOS", "BIOS");

                    foreach (PropertyData data in mObject.Properties)
                    {
                        if (data.Name == "Manufacturer")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "BIOS Manufacturer:";
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
                        else if (data.Name == "SMBIOSBIOSVersion")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "BIOS Version:";
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
                        else if (data.Name == "ReleaseDate")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "BIOS Date:";
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
