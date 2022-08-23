namespace Albion_Statistics
{
    public class ItemJson
    {
        public string item_id { get; set; }
        public string city { get; set; }
        public int quality { get; set; }
        public int sell_price_min { get; set; }
        public string sell_price_min_date { get; set; }
        public int sell_price_max { get; set; }
        public string sell_price_max_date { get; set; }
        public int buy_price_min { get; set; }
        public string buy_price_min_date { get; set; }
        public int buy_price_max { get; set; }
        public string buy_price_max_date { get; set; }
    }
}
