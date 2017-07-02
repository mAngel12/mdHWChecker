using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public sealed class TemperatureService : InformationService
    {
        ManagementObjectSearcher temperatureInfo;
        public TemperatureService()
        {
            temperatureInfo = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        }

        public override void InsertInformationsToListView(ref ListView listView)
        {
            listView.Items.Clear();
            ListViewGroup viewGroup;

            try
            {
                foreach (ManagementObject mObject in temperatureInfo.Get())
                {
                    viewGroup = listView.Groups.Add("Temperature", "Temperature");

                    listView.Items.Add(TemperatureDecoder(GenerateInformation(mObject, viewGroup, "CurrentTemperature", "Current Temperature")));
                    listView.Items.Add(TemperatureDecoder(GenerateInformation(mObject, viewGroup, "PassiveTripPoint", "Temperature to activate CPU throttling")));
                    listView.Items.Add(TemperatureDecoder(GenerateInformation(mObject, viewGroup, "CriticalTripPoint", "Temperature to shutdown the system")));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error with get data from your computer. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ListViewItem TemperatureDecoder(ListViewItem item)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    item.SubItems.Add(((Int64.Parse(value) - 2732) / 10).ToString() + " °C");
                }
            }
            return item;
        }
    }
}
