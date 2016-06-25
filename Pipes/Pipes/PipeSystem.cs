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

        private int currentXsize = 10;
        private int currentYsize = 10;
        private bool alterSinceSave = false;
        public Component selectedComponent;
        public List<Component> Components;
        public SaveLoad saveload;
        public Grid grid;
        public delegate void ShowSaveButton(bool ShowifSaved);
        public event ShowSaveButton showsave;
        PointP p; // for testing right click

        public PipeSystem()
        {
            Components = new List<Component>();
            p = new PointP();
            // populating the list for testing purposes
           
        }

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
                if(alterSinceSave == false)
                {
                    if(showsave != null)
                    {
                        //event rised if alterSinceSave turns to false
                        showsave(alterSinceSave);
                    }
                }
            }
        }

        // Methods
        public void addComponent( Component x)
        {
           
            Components.Add(x);
           
        }
        /// <summary>
        /// removes the pipe
        /// </summary>
        /// <returns></returns>
        public bool removePipes()
        {
            return true;
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
