using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pipes
{
    class PipeSystem
    {
        
        private int currentXsize;
        private int currentYsize;
        private bool alterSinceSave;
        Component selectedComponent;
        List<Component> Components;

        public int CurrentXsize
        {
            get
            {
                return currentXsize;
            }
            set
            {
                currentXsize = value;
            }
        }
        public int CurrentYsize
        {
            get
            {
                return currentYsize;
            }
            set
            {
                currentYsize = value;
            }
        }
        public bool AlterSinceSave
        {
            get
            {
                return alterSinceSave;
            }
            set
            {
                alterSinceSave = value;
            }
        }

        // Methods
        public void addComponent(Type y, Point x)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public Point SelectedGriddSpace()
        //{
   
        //    return Point locaiton;
        //}

        public void MOdifyComponent(int x)
        {

        }

     


    }
}
