using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Plant : Life//植物
    {
        public Plant(DateTime bd, string n, float w = 0, float h = 0, float d = 0,
            float we = 0, int l = 0)
            : base(bd, n, w, h, d, we, l)
        {
        }
    }
}
