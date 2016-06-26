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
        public Component InputA { get; set; }
        public Component OutputA { get; set; }
        public Component OutputB { get; set; }
        public int Ratio { get; set; }

        public Splitter(PointP loc) : base(loc)
        {
            Ratio = 50;
        }

        public override void SetFlow(int x)
        {
            this.Flow = x;
            if (OutputA != null) OutputA.SetFlow(Ratio*Flow);
            if (OutputB != null) OutputB.SetFlow((100 - Ratio) * Flow);
        }
        public void ChangeRatio(int ratio)
        {
            Ratio = ratio;

            if (OutputA != null) OutputA.SetFlow(Ratio * Flow);
            if (OutputB != null) OutputB.SetFlow((100 - Ratio) * Flow);
        }
        
        public override void attachInputA(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).OutputA == null))
            {
                this.InputA = x;
                ((Pipe)x).OutputA = this;
            }
        }
        public override void attachOutputA(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).InputA == null))
            {
                this.OutputA = x;
                ((Pipe)x).InputA = this;
            }
        }
        public override void attachOutputB(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).InputA == null))
            {
                this.OutputB = x;
                ((Pipe)x).InputA = this;
            }
        }


    }
}
