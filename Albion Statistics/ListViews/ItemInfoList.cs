using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_Statistics
{
    public class ItemInfoList
    {
        public static void FillViewList(List<string> ItemsList, System.Windows.Controls.ListView ItemInfoList)
        {
            if (ItemsList != null)
            {   
                foreach (string str in ItemsList)
                {
                    ItemInfoList.Items.Add(str);
                }
            }
        }
    }
}
