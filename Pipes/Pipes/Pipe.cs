using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Pipe : Component
    {
        // a pipe has an input and an output
        public Component InputA { get; set; }
        public Component OutputA { get; set; }

        private int safetyLimit;
        private int SafetyLimit
        {
            get
            {
                return safetyLimit;

            }
            set
            {
                safetyLimit = value;
            }
        }
        // constructor
        public Pipe(PointP loc) : base(loc)
        {
        }
        /// <summary>
        /// returnes the  safety limit
        /// </summary>
        /// <returns></returns>
        public int GetSafetyLimit()
        {
            return SafetyLimit;
        }
        /// <summary>
        /// sets the safety limit to the given value 
        /// </summary>
        /// <param name="limit"></param>
        public override void SetSafetyLimit(int limit)
        {
            this.SafetyLimit = limit;

            if (OutputA is Pipe)
            {
                Pipe temp = (Pipe)OutputA;
                if (temp.GetSafetyLimit()!=limit)
                {
                    OutputA.SetSafetyLimit(limit);
                }
            }

            if (InputA is Pipe)
            {
                Pipe temp = (Pipe)InputA;
                if (temp.GetSafetyLimit() != limit)
                {
                    InputA.SetSafetyLimit(limit);
                }
            }

        }
        public override void SetFlow(int x)
        {
            this.Flow = x;
            if (OutputA != null) OutputA.SetFlow(Flow);
        }
        public override void AttachComponent(Component current)
        {
            OutputA = current;
        }
        public int checkSystemFlow()
        {
            //return if true
            if (Flow < safetyLimit)
            {
                return 1;

            }
            //If false
            else if (Flow >= SafetyLimit)
            {
                return 0;
            }

            //return if system not complete
            else
            {
                return -1;
            }
           
        }
        
    }
}
