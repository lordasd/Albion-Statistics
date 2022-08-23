using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_Statistics
{
    internal class QualityInfoList
    {
        public static void FillViewList(List<string> QualityList, System.Windows.Controls.ListView QualityInfoList)
        {
            if (QualityList != null)
            {
                foreach (string str in QualityList)
                {
                    QualityInfoList.Items.Add(str);
                }
            }
        }
    }
}
