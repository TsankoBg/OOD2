using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Merger : Component
    {

        Component inPutA { get; set; }
        Component inPutB { get; set; }
        Component outPutA { get; set; }


        // connstructor
        public Merger(PointP loc) : base(loc)
        {
           
        }
    }
}
