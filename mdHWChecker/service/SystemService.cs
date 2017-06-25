using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public class SystemService : InformationService
    {
        ManagementObjectSearcher computerInfo;
        ManagementObjectSearcher systemInfo;

        public SystemService()
        {
            computerInfo = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            systemInfo = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in computerInfo.Get())
                {
                    viewGroup = listView.Groups.Add("Current Computer", "Current Computer");

                    foreach (PropertyData data in mObject.Properties)
                    {
                        if (data.Name == "Name")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Computer Name:";
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
                            item.Text = "Computer Brand:";
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
                        else if (data.Name == "Model")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Computer Model Name:";
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

                foreach (ManagementObject mObject in systemInfo.Get())
                {
                    viewGroup = listView.Groups.Add("Operating System", "Operating System");

                    foreach (PropertyData data in mObject.Properties)
                    {
                        if (data.Name == "Caption")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "Operating System:";
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
                        else if (data.Name == "OSArchitecture")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "System Architecture:";
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
                        else if (data.Name == "Version")
                        {
                            ListViewItem item = new ListViewItem(viewGroup);
                            item.Text = "System Version:";
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
