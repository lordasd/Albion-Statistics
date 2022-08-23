using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_Statistics
{
    public class ItemList
    {
        public static void FillViewList(List<ItemJson> itemjson, System.Windows.Controls.ListView ItemList)
        {
            if (itemjson != null)
            {   
                foreach (ItemJson item in itemjson)
                {
                    ItemList.Items.Add($"{item.item_id}\nCity: {item.city}\nQuality: {item.quality}\nsell_price_min: " +
                        $"{item.sell_price_min}\nsell_price_min_date: {item.sell_price_min_date}\nsell_price_max: " +
                        $"{item.sell_price_max}\nsell_price_max_date: {item.sell_price_max_date}\nbuy_price_min: " +
                        $"{item.buy_price_min}\nbuy_price_min_date: {item.buy_price_min_date}\nbuy_price_max: " +
                        $"{item.buy_price_max}\nbuy_price_max_date: {item.buy_price_max_date}\n");
                }
            }
        }
    }
}
