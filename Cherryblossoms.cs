﻿using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_2023_template
{
    internal class Cherryblossoms:Plant//桜
    {
        public Cherryblossoms(DateTime bd, string n, float w = 0, float h = 0, float d = 0,
            float we = 0, int l = 0)
            : base(bd, n, w, h, d, we, l)
        {
        }
    }
}