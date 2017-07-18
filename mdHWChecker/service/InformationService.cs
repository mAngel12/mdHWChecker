using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.service
{
    public abstract class InformationService
    {
        public virtual void InsertInformationsToListView(ref ListView listView)
        {

        }

        protected ListViewItem GenerateInformation(ManagementObject mObject, ListViewGroup viewGroup, String infoName, String displayName)
        {
            ListViewItem item = new ListViewItem(viewGroup);
            item.Text = displayName + ":";

            try
            {
                if (!string.IsNullOrEmpty(mObject[infoName].ToString()))
                {
                    item.SubItems.Add(mObject[infoName].ToString());
                }
                else
                {
                    item.SubItems.Add("Information not available!");
                }
            }

            catch
            {
                item.SubItems.Add("Information not available!");
            }

            return item;
        }

        protected ListViewItem GenerateEmpty(ListViewGroup viewGroup)
        {
            ListViewItem item = new ListViewItem(viewGroup);
            item.Text = String.Empty;
            return item;
        }

        protected ListViewItem SimpleDecoder(ListViewItem item, String endText)
        {
            if (!string.IsNullOrEmpty(item.SubItems[1].Text))
            {
                String value = item.SubItems[1].Text;
                String text = item.Text;
                if (value != "Information not available!")
                {
                    item.SubItems.Clear();
                    item.Text = text;
                    item.SubItems.Add(value + " " + endText);
                }
            }
            return item;
        }

        protected void ClearListView(ref ListView listView)
        {
            listView.Items.Clear();
            listView.Groups.Clear();
        }
    }
}
