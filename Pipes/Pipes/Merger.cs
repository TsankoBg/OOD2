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
        

        Component InputA { get; set; }
        Component InputB { get; set; }
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

        public override void AttachComponent(Component output)
        {

            this.OutputA = output;
        }

    }
}
