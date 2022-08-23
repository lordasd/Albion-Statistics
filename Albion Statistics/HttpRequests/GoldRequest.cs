using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace Albion_Statistics
{
    public class GoldRequest
    {
        public static async Task<List<GoldJson>> GetRequest(string strtmonth, string strtday, string strtyear,
                                                            string endmonth, string endday, string endyear)
        {
            using var client = new HttpClient();
            var result = await client.GetAsync($"https://www.albion-online-data.com/api/v2/stats/gold.json?date={strtmonth}-{strtday}-{strtyear}"
                                                                                                  + $"&end_date={endmonth}-{endday}-{endyear}");
            if (result.ReasonPhrase == "OK")
            {  
                var json = await result.Content.ReadAsStringAsync();
                List<GoldJson> goldjson = JsonSerializer.Deserialize<List<GoldJson>>(json);

                //Replace T with Time in timestamp
                foreach (var gold in goldjson)
                    if (gold != null)
                        gold.timestamp = gold.timestamp.Replace("T", " Time: ");

                return goldjson;
            }
            return null;
        }
    }
}