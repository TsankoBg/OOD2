using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Splitter : Component
    {
        Component inPutA { get; set; }
        Component outPutA { get; set; }
        Component outPutB { get; set; }

        public Splitter(PointP loc) : base(loc)
        {
        }
    }
}
