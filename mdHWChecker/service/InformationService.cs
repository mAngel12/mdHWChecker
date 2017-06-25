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

        protected string CheckSystem(PropertyData data)
        {
            switch (data.Value.GetType().ToString())
            {
                case "System.String[]":
                    string[] str = (string[])data.Value;
                    string str2 = "";
                    foreach (string st in str)
                        str2 += st + " ";
                    return str2;
                    break;

                case "System.UInt16[]":
                    ushort[] shortData = (ushort[])data.Value;
                    string tstr2 = "";
                    foreach (ushort st in shortData)
                        tstr2 += st.ToString() + " ";
                    return tstr2;
                    break;

                default:
                    return data.Value.ToString();
                    break;
            }
        }
    }
}
