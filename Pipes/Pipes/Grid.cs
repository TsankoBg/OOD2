using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pipes
{
    class Grid
    {
        Panel panel;
        PointP xy = new PointP();
        float height;
        float width;
        float xSpace;
        float ySpace;
        
        public int lines { get; set; }
        Pen pen;
        
        public Grid(Panel pan,int NumberOfLines)
        {
            pen = new Pen(Brushes.Black, 1);
            this.panel = pan;
            this.xy.X = 0f;
            this.xy.Y = 0f;
            this.height = pan.Height;
            this.width = pan.Width;
            this.lines = NumberOfLines;
            

        }
       public void drawGrid(Graphics graphic,int NumberOfLines)
        {
            Graphics graph = graphic;
            lines = NumberOfLines;
            xy.X = 0f;
            xy.Y = 0f;
            xSpace = width / NumberOfLines;
            ySpace = height / NumberOfLines;

            //Draws the Vertical Grid Lines
            for (int i = 0; i <= lines; i++)
            {
                graph.DrawLine(pen, xy.X, xy.Y, xy.X, this.height);
                xy.X += xSpace;

            }
            xy.X = 0f;
            //Draw the Horizontal Grid Lines
            for (int i = 0; i < lines; i++)
            {
                graph.DrawLine(pen, xy.X, xy.Y, this.width, xy.Y);
                xy.Y += ySpace;
            }

        }
        public PointP returnMousePosition(Point mousePosition)
        {
            PointP gridSpace = new PointP();
            gridSpace.X = Convert.ToSingle(mousePosition.X / xSpace);
            gridSpace.Y = Convert.ToSingle(mousePosition.Y / ySpace);
            gridSpace.X = (float)Math.Floor(gridSpace.X);
            gridSpace.Y = (float)Math.Floor(gridSpace.Y);
            return gridSpace;
        }
       /* public bool enlarge()
        {
            int max = 15;
            if (lines >= max)
            {
                lines = 15;
                drawGrid(lines);
                return false;
            }
            else
            {
                lines++;
                drawGrid(lines);
                return true;
            }
        }
        public bool lessen()
        {
            int min = 6;
            if (lines <= min)
            {
                lines = 6;
                drawGrid(lines);
                return false;
            }
            else
            {
                lines--;
                drawGrid(lines);
                return true;
            }
        }*/
        public void drawComponent(Component component,Graphics graphic)
        {
            if(component != null)
            {
                Image img;
                int x = Convert.ToInt32(component.location.X * xSpace);
                int y = Convert.ToInt32(component.location.Y * ySpace);
                int w = Convert.ToInt32(xSpace);
                int h = Convert.ToInt32(ySpace);

                Rectangle rect = new Rectangle(x,y,w,h);
                if(getImage(component,out img) == true)
                {
                    graphic.DrawImage(img, rect);
                }
            }
          

        }
        private bool getImage(Component component,out Image img)
        {
            if(component != null)
            {
                if (component is Pipe)
                {
                    PointP next = new PointP();
                    PointP previous = new PointP();

                    previous = ((Pipe)component).InputA.location;

                    PointP test = new PointP();
                    PointP test2 = new PointP();
                    //gets cooridnates of the input and outputs
                    if (((Pipe)component).OutputA != null)
                    {
                        next = ((Pipe)component).OutputA.location;
                        //pipe has an output

                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X - 1;
                        test2.X = component.location.X + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            //Is horizontal Pipe
                            img = Pipes.Properties.Resources.HorizontalPipe;
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.Y = component.location.Y - 1;
                        test2.Y = component.location.Y + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            img = Pipes.Properties.Resources.WestSouthPipe;
                            return true;
                        }

                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X - 1;
                        test2.Y = component.location.Y + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            img = Pipes.Properties.Resources.WestSouthPipe;
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X - 1;
                        test2.Y = component.location.Y - 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            img = Pipes.Properties.Resources.WestNorthPipe;
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X + 1;
                        test2.Y = component.location.Y - 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            img = Pipes.Properties.Resources.NorthEastPipe;
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X + 1;
                        test2.Y = component.location.Y + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            img = Pipes.Properties.Resources.EastSouthPipe;
                            return true;
                        }
                        img = null;
                        return false;
                    }
                    else
                    {
                        //Pipe does not yet have an output
                        //Therefore can only a horizontal or vertical
                        test = component.location;
                        test2 = component.location;
                        test.Y = component.location.Y - 1;
                        test2.Y = component.location.Y + 1;
                        if ((previous == test) || (previous == test2))
                        {
                            //test vertical
                            img = Pipes.Properties.Resources.VerticalPipe;
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X - 1;
                        test2.X = component.location.X + 1;
                        if ((previous == test) || (previous == test2))
                        {
                            //test horizontal
                            img = Pipes.Properties.Resources.HorizontalPipe;
                            return true;
                        }
                        img = null;
                        return false;
                    }

                }
                else if (component is Sink)
                {
                    img = Pipes.Properties.Resources.sink;
                    return true;
                }
                else if (component is Splitter)
                {
                    PointP previous = new PointP();
                    previous = ((Splitter)component).inPutA.location;
 
                    PointP test = new PointP();
                    test = component.location;
                    test.X = component.location.X + 1;
                    if (test == previous)
                    {
                        img = Pipes.Properties.Resources.splitterEast;
                        return true;
                    }
                    test = component.location;
                    test.Y = component.location.Y - 1;
                    if (test == previous)
                    {
                        img = Pipes.Properties.Resources.splitterNorth;
                        return true;
                    }
                    test = component.location;
                    test.Y = component.location.Y + 1;
                    if (test == previous)
                    {
                        img = Pipes.Properties.Resources.splitterSouth;
                        return true;
                    }
                    //Must be SpiltterWest Image
                    img = Pipes.Properties.Resources.splitterWest;
                    return true;
                }
                else if (component is Merger)
                {
                    PointP next = new PointP();
                    if (((Merger)component).location != null){
                        next = ((Merger)component).OutputA.location;
                        PointP test = new PointP(component.location);
                   
                        test.X = component.location.X + 1;
                        if (test == next)
                        {
                            img = Pipes.Properties.Resources.mergerEast;
                            return true;
                        }
                        test.Y = component.location.Y - 1;
                        if (test == next)
                        {
                            img = Pipes.Properties.Resources.mergerNorth;
                            return true;
                        }
                        test.X = component.location.X + 1;
                        if (test == next)
                        {
                            img = Pipes.Properties.Resources.mergerSouth;
                            return true;
                        }
                        //Defeault image
                        img = Pipes.Properties.Resources.mergerWest;
                        return true;
                    }
                    else
                    {
                        //Output not yet determined default image
                        img = Pipes.Properties.Resources.mergerEast;
                        return true;
                    }
                    
                   
                }
                else if (component is Pump)
                {
                    img = Pipes.Properties.Resources.pump;
                    return true;
                }
                else
                {
                    img = null;
                    return false;
                }
            }
            else
            {
                img = null;
                return false;
            }
        }

    }
}
