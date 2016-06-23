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
        Graphics graph;
        public int lines { get; set; }
        Pen pen = new Pen(Brushes.Black);

        public Grid(Panel pan, int NumberOfLines)
        {
            this.panel = pan;
            this.xy.X = 0f;
            this.xy.Y = 0f;
            this.height = pan.Height;
            this.width = pan.Width;
            graph = panel.CreateGraphics();
            this.lines = NumberOfLines;
            drawGrid(lines);

        }
        void drawGrid(int NumberOfLines)
        {
            lines = NumberOfLines;
            xy.X = 0f;
            xy.Y = 0f;
            xSpace = width / NumberOfLines;
            ySpace = height / NumberOfLines;

            //Draws the Vertical Grid Lines
            for (int i = 0; i <= lines; i++)
            {
                graph.DrawLine(pen, xy.X, xy.Y, xy.X, height);

            }
            xy.X = 0f;
            //Draw the Horizontal Grid Lines
            for (int i = 0; i < lines; i++)
            {
                graph.DrawLine(pen, xy.X, xy.Y, width, xy.Y);

            }

        }
        PointP returnMousePosition(Point mousePosition)
        {
            PointP gridSpace = null;
            gridSpace.X = Convert.ToSingle(mousePosition.X / xSpace);
            gridSpace.Y = Convert.ToSingle(mousePosition.Y / ySpace);
            Math.Floor(gridSpace.X);
            Math.Floor(gridSpace.Y);
            return gridSpace;
        }
        public bool enlarge()
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
        }

    }
}
