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
        public Component inPutA { get; set; }
        Component OutputA { get; set; }
        Component OutputB { get; set; }
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
        public override void AttachComponent(Component output)
        {

            if(OutputA == null)
            {
                this.OutputA = output;
            }
            else
            {
                this.OutputB = output;
            }
        }

    }
}
