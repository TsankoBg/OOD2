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

    }
}
