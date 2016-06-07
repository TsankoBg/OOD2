using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pipes
{
    class Component
    {
        PointF x; 
        
        public Component(PointF loc)
        {
            x = loc;
        }  


        // Methods

            /// <summary>
            /// removes the pipe
            /// </summary>
            /// <returns></returns>
        public  bool removePipes()
        {
            return true;
        }
        /// <summary>
        /// Assignes the next component
        /// </summary>
        public void SetNextComponent()
        {

        }
        /// <summary>
        /// return the output flow as integer
        /// </summary>
        /// <returns></returns>
        public int OutputFlow ()
        {
            return -1;
        }


    }
}
