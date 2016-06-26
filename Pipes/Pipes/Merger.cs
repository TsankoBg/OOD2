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
        

        public Component InputA { get; set; }
        public Component InputB { get; set; }
        public Component OutputA { get; set; }


        // connstructor
        public Merger(PointP loc) : base(loc)
        {
            
        }

        public override void SetFlow(int x)
        {
             Flow = InputA.Flow + InputB.Flow;
            
            if (OutputA != null) OutputA.SetFlow(Flow);
        }

        

        public override void attachOutputA(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).InputA == null))
            {
                this.OutputA = x;
                ((Pipe)x).InputA = this;
            }
        }

        public override void attachInputA(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).OutputA == null))
            {
                this.InputA = x;
                ((Pipe)x).OutputA = this;
            }
        }
        public override void attachInputB(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).OutputA == null))
            {
                this.InputA = x;
                ((Pipe)x).OutputA = this;
            }
        }
    }
}
