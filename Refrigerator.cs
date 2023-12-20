using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_2023_template
{
    internal class Refrigerator:Thing//冷蔵庫
    {
        public Refrigerator(string n, float w = 0, float h = 0, float d = 0,
            float we = 0)
            : base(n, w, h, d, we)
        {
            
        }
    }
}
