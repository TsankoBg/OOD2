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
        public void drawComponent(Component component, Graphics graphic)
        {
            if (component != null)
            {
                Image img;
                int x = Convert.ToInt32(component.location.X * xSpace);
                int y = Convert.ToInt32(component.location.Y * ySpace);
                int w = Convert.ToInt32(xSpace);
                int h = Convert.ToInt32(ySpace);

                Rectangle rect = new Rectangle(x, y, w, h);
                if (getImage(component, out img) == true)
                {
                    graphic.DrawImage(img, rect);
                }
                
            }
        }
        public void unDrawComponent(Component component,Graphics graphic)
        {
            Brush brush = new SolidBrush(Color.FromArgb(224, 224, 224));
            int x = Convert.ToInt32(component.location.X * xSpace);
            int y = Convert.ToInt32(component.location.Y * ySpace);
            int w = Convert.ToInt32(xSpace);
            int h = Convert.ToInt32(ySpace);

            Rectangle rect = new Rectangle(x, y, w, h);
            graphic.FillRectangle(brush, rect);

        }
       
        private bool getImage(Component component, out Image img)
        {
            if (component != null)
            {
                if (component is Pipe)
                {
                    PointP next = new PointP();
                    PointP previous = new PointP();
                    if(((Pipe)component).InputA == null){
                        img = Pipes.Properties.Resources.RedHorizontalPipe;
                        return true;
                    }
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
                            switch (((Pipe)component).checkSystemFlow())
                            {
                                case 0:
                                    img = Pipes.Properties.Resources.RedHorizontalPipe;
                                    break;
                                case 1:
                                    img = Pipes.Properties.Resources.GreenHorizontalPipe;
                                    break;
                                default:
                                    img = Pipes.Properties.Resources.HorizontalPipe;
                                    break;
                            }
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.Y = component.location.Y - 1;
                        test2.Y = component.location.Y + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            switch (((Pipe)component).checkSystemFlow())
                            {
                                case 0:
                                    img = Pipes.Properties.Resources.verticalRedPipe;
                                    break;
                                case 1:
                                    img = Pipes.Properties.Resources.GreenVerticalPipe;
                                    break;
                                default:
                                    img = Pipes.Properties.Resources.VerticalPipe;
                                    break;
                            }
                            return true;
                        }

                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X - 1;
                        test2.Y = component.location.Y + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            switch (((Pipe)component).checkSystemFlow())
                            {
                                case 0:
                                    img = Pipes.Properties.Resources.RedWestSouthPipe;
                                    break;
                                case 1:
                                    img = Pipes.Properties.Resources.GreenWestSouthPipe;
                                    break;
                                default:
                                    img = Pipes.Properties.Resources.WestSouthPipe;
                                    break;
                            }
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X - 1;
                        test2.Y = component.location.Y - 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {

                            switch (((Pipe)component).checkSystemFlow())
                            {
                                case 0:
                                    img = Pipes.Properties.Resources.RedWestNorthPipe;
                                    break;
                                case 1:
                                    img = Pipes.Properties.Resources.GreenWestNorthPipe;
                                    break;
                                default:
                                    img = Pipes.Properties.Resources.NorthWestPipe;
                                    break;
                            }
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X + 1;
                        test2.Y = component.location.Y - 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            switch (((Pipe)component).checkSystemFlow())
                            {
                                case 0:
                                    img = Pipes.Properties.Resources.RedNorthEastPipe;
                                    break;
                                case 1:
                                    img = Pipes.Properties.Resources.GreenEastNorthPipe;
                                    break;
                                default:
                                    img = Pipes.Properties.Resources.NorthEastPipe;
                                    break;
                            }
                            return true;
                        }
                        test = component.location;
                        test2 = component.location;
                        test.X = component.location.X + 1;
                        test2.Y = component.location.Y + 1;
                        if (((previous == test) && (next == test2)) || ((previous == test2) && (next == test)))
                        {
                            switch (((Pipe)component).checkSystemFlow())
                            {
                                case 0:
                                    img = Pipes.Properties.Resources.RedEastSouthPipe;
                                    break;
                                case 1:
                                    img = Pipes.Properties.Resources.GreenEastSouthPipe;
                                    break;
                                default:
                                    img = Pipes.Properties.Resources.SouthEastPipe;
                                    break;
                            }
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
                        img = Pipes.Properties.Resources.EastSpiltter;
                        return true;
                    }
                    test = component.location;
                    test.Y = component.location.Y - 1;
                    if (test == previous)
                    {
                        img = Pipes.Properties.Resources.NorthSpiltter;
                        return true;
                    }
                    test = component.location;
                    test.Y = component.location.Y + 1;
                    if (test == previous)
                    {
                        img = Pipes.Properties.Resources.SouthSpiltter;
                        return true;
                    }
                    //Must be SpiltterWest Image
                    img = Pipes.Properties.Resources.SouthSpiltter;
                    return true;
                }
                else if (component is Merger)
                {
                    PointP next = new PointP();
                    if (((Merger)component).location != null)
                    {
                        next = ((Merger)component).OutputA.location;
                        PointP test = new PointP(component.location);

                        test.X = component.location.X + 1;
                        if (test == next)
                        {
                            img = Pipes.Properties.Resources.MergerEast;
                            return true;
                        }
                        test.Y = component.location.Y - 1;
                        if (test == next)
                        {
                            img = Pipes.Properties.Resources.MergerNorthpng;
                            return true;
                        }
                        test.X = component.location.X + 1;
                        if (test == next)
                        {
                            img = Pipes.Properties.Resources.MergerSouth;
                            return true;
                        }
                        //Defeault image
                        img = Pipes.Properties.Resources.MergerWest;
                        return true;
                    }
                    else
                    {
                        //Output not yet determined default image
                        img = Pipes.Properties.Resources.MergerEast;
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
