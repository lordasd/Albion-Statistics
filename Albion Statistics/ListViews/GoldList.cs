using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_Statistics
{
    public class GoldList
    {
        public static void FillViewList(List<GoldJson> goldjson, System.Windows.Controls.ListView ItemList)
        {
            if (goldjson != null)
            {   //Print all items of gold
                foreach (GoldJson gold in goldjson)
                {
                    ItemList.Items.Add($"Gold: {gold.price} Date: {gold.timestamp}");
                }
            }
        }
    }
}
