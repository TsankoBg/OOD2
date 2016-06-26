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
        public int index;
        public List<Component> Components;
        public SaveLoad saveload;
        public Grid grid;
        public delegate void ShowSaveButton(bool ShowifSaved);
        public event ShowSaveButton showsave;
        public delegate void TriggerDraw(Component component);
        public event TriggerDraw drawTheComponent;
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
            if(AlterSinceSave == false)
            {
                AlterSinceSave = true;
            }
            if(drawTheComponent != null)
            {
                drawTheComponent(x);
            }
           
        }
        /// <summary>
        /// removes the pipe
        /// </summary>
        /// <returns></returns>
        public void removeComponent(Component c,Graphics graphic)
        {
            if (c is Pump) 
            {
                if (((Pump)c).OutputA != null)
                {
                    removePipes(((Pump)c).OutputA, graphic);
                }
            }
            if (c is Sink)
            {
                if (((Sink)c).InputA != null)
                {
                    removePipes(((Sink)c).InputA, graphic);
                }
            }
            if (c is Merger)
            {
                if (((Merger)c).OutputA != null)
                {
                    removePipes(((Merger)c).OutputA, graphic);
                }
                if (((Merger)c).InputA != null)
                {
                    removePipes(((Merger)c).InputA, graphic);
                }
                if (((Merger)c).InputB != null)
                {
                    removePipes(((Merger)c).InputB, graphic);
                }
            }
            if (c is Splitter)
            {
                if (((Splitter)c).InputA != null)
                {
                    removePipes(((Splitter)c).InputA, graphic);
                }
                if (((Splitter)c).OutputA != null)
                {
                    removePipes(((Splitter)c).OutputA, graphic);
                }
                if (((Splitter)c).OutputB != null)
                {
                    removePipes(((Splitter)c).OutputB, graphic);
                }
            }
            Components.Remove(c);
            //componentToRemove just an example 
            grid.unDrawComponent(c, graphic);
            //then delete the component
            //return true;
        }
        public void removePipes(Component c, Graphics graphic)
        {
            //if ((c is Pump) || (c)
            {

            }
            Components.Remove(c);
            //componentToRemove just an example 
            grid.unDrawComponent(c, graphic);
            //then delete the component
            //return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public Point SelectedGriddSpace()
        //{

        //    return Point locaiton;
        //}

        public void MOdifyComponent(Component component)
        {
            if (AlterSinceSave == false)
            {
                AlterSinceSave = true;
            }
            if (drawTheComponent != null)
            {
                drawTheComponent(component);
            }
        }
        

     


    }
}
