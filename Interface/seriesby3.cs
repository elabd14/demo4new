﻿using demo4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.Interface
{
    public class seriesby3 :iseries
    {
        public int current { get; set; }
        public void getnext() { current += 3; }
        
    }
}
