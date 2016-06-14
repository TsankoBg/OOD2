using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;


namespace Pipes
{
    class Component
    {

        PointP location;
      public int Flow { get; set; }
        
        public Component(PointP loc)
        {
             location= loc;
        }  


        // Methods

       
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
        //public virtual int OutputFlow ()
        //{
        //    return -1;
        //}

        public Component AttachComponent()
        {

            Component c = new Component() ;
            return c;
        }
    }
}
