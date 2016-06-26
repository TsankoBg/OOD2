using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Pump : Component
    {
        public Component OutputA;
        //private int flow;
        private int maxFlow;

        //public int Flow
        //{
        //    get
        //    {
        //        return flow;
        //    }
        //    set
        //    {
        //        flow = value;
        //    }
        //}
        public int MaxFlow
        {
            get
            {
                return maxFlow;
            }
            set
            {
                maxFlow = value;
            }
        }
        public Pump(PointP loc) : base(loc)
        {
        }

        /// <summary>
        /// Sets the flow to the given value
        /// </summary>
        /// <param name="x"></param>
        public override void SetFlow(int x)
        {
            this.Flow = x;
            if (OutputA != null) OutputA.SetFlow(Flow);
        }
        /// <summary>
        /// Sets the maxFlow  to the given value
        /// </summary>
        /// <param name="x"></param>
        public void SetMaxFlow(int x)
        {
            this.MaxFlow = x;
        }

        public override void attachOutputA(Component x)
        {
            if ((x is Pipe) && (((Pipe)x).InputA == null))
            {
                this.OutputA = x;
                ((Pipe)x).InputA = this;
            }

        }
    }
}
