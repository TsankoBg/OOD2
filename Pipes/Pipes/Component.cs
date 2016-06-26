﻿using System;
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

     public   PointP location;
     private int flow;

     
        public int Flow
        {
            get
            {
                return flow;

            }
            set
            {
                flow = value;
                
            }
        }
        
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

        public virtual void AttachComponent(Component current)
        {

         
        }
        public bool RemovePipes()
        {



            return false;

        }
        public virtual void SetFlow(int x)
        {

        }

        public virtual void SetSafetyLimit(int x)
        {

        }
    }
}
