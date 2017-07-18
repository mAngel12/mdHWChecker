using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdHWChecker.converter
{
    public sealed class ListViewToStringConverter
    {
        public ListViewToStringConverter()
        { }

        public string Convert(ListView listView, string name)
        {
            String informations = "";
            informations += GetTitle(name);
            foreach (ListViewGroup listViewGroup in listView.Groups)
            {
                informations += Environment.NewLine + listViewGroup.ToString() + ":" + Environment.NewLine + Environment.NewLine;
                foreach (ListViewItem listViewItem in listView.Items)
                {
                    if (listViewItem.Group == listViewGroup && !string.IsNullOrEmpty(listViewItem.ToString()))
                    {
                        try
                        {
                            informations += listViewItem.Text.ToString() + " " + listViewItem.SubItems[1].Text.ToString() + Environment.NewLine;
                        }
                        catch { }
                    }
                }
            }
            return informations;
        }

        private string GetTitle(string name)
        {
            return "================"
                + Environment.NewLine
                + name.ToUpper()
                + Environment.NewLine
                + "================"
                + Environment.NewLine;
        }
    }
}
