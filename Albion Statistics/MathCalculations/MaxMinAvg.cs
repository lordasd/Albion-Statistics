using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_Statistics
{
    public class MaxMinAvg
    {   //Calculate Max,Min,Average of gold between the dates
        public static void MxMnAvg(List<GoldJson> goldjson, out int min, out int max, out double avg)
        {
            int sum = 0;
            max = 0;
            min = goldjson[0].price;
            avg = 0;
            foreach (GoldJson gold in goldjson)
            {
                sum += gold.price;
                if (gold.price > max)
                    max = gold.price;
                else if (gold.price < min)
                    min = gold.price;
            }
            avg = sum / goldjson.Count();
        }
    }
}
