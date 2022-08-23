using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace Albion_Statistics
{
    public class ItemRequest
    {
        public static async Task<List<ItemJson>> GetRequest(string items, string locations, string qualities)
        {  
            FixStrings(ref items, ref locations, ref qualities);
            string url = GetCorrectUrl(items, locations, qualities);
            using var client = new HttpClient();
            var result = await client.GetAsync(url);
            if (result.ReasonPhrase == "OK")
            {
                var json = await result.Content.ReadAsStringAsync();
                List<ItemJson> itemjson = JsonSerializer.Deserialize<List<ItemJson>>(json);
                return itemjson;
            }
            return null;
        }

        //Replaces ',' with "%2C" to have multiple choices
        public static void FixStrings(ref string items, ref string locations, ref string qualities)
        {
            items = items.Replace(",", "%2C");
            locations = locations.Replace(",", "%2C");
            qualities = qualities.Replace(",", "%2C");
        }

        //Get the correct url depending on the input
        public static string GetCorrectUrl(string items, string locations, string qualities)
        {
            string url = "https://www.albion-online-data.com/api/v2/stats/Prices/T5_BAG.json/";
            if (locations != null && qualities != null)
            {
                url = $"https://www.albion-online-data.com/api/v2/stats/Prices/{items}?locations={locations}&qualities={qualities}";
            }
            else if(locations != null)
            {
                url = $"https://www.albion-online-data.com/api/v2/stats/Prices/{items}?locations={locations}";
            }
            else if(qualities != null)
            {
                url = $"https://www.albion-online-data.com/api/v2/stats/Prices/{items}?qualities={qualities}";
            }

            return url;
        }
    }
}
