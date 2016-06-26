using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pipes
{
    class Sink : Component
    {
        public Component InputA { get; set; }
        

        public Sink(PointP loc) : base(loc)
        {
            
        }
        public override void attachInputA(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).OutputA == null))
            {
                this.InputA = x;
                ((Pipe)x).OutputA = this;
            }
        }
    }
}
