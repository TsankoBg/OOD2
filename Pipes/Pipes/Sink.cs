﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pipes
{
    class Sink : Component
    {
        Component Input { get; set; }
        

        public Sink(PointP loc) : base(loc)
        {
            
        }
    }
}
