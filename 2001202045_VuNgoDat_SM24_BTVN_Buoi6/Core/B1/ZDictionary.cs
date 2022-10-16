using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001202045_VuNgoDat_SM24_Buoi6.Core.B1
{
    class ZDictionary
    {
        public Dictionary<string, string> dics;

        public ZDictionary()
        {
            dics = new Dictionary<string, string>();
        }
        public void Load()
        {
            int count = 0;
            string[] lines = System.IO.File.ReadAllLines(@"..\..\Core\B1\Source.txt");
            foreach (var line in lines)
            {
                count++;
                if (count == 1000)
                {
                    break;
                }
                var tmp = line.Split(':');
                if (!dics.ContainsKey(tmp[0]))
                {
                    dics.Add(tmp[0].Trim(), tmp[1].Trim());
                }
            }
        }
    }
}
