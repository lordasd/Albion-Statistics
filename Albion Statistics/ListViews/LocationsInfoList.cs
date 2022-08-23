using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_Statistics
{
    public class LocationsInfoList
    {
        public static void FillViewList(List<string> LocationsList, System.Windows.Controls.ListView LocationsInfoList)
        {
            if (LocationsList != null)
            {
                foreach (string str in LocationsList)
                {
                    LocationsInfoList.Items.Add(str);
                }
            }
        }
    }
}
