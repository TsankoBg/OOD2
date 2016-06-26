using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class PointP
    {
        public float X { get; set; }
        public float Y { get; set; }
     
        
        public PointP()
        {
            this.X = 0f;
            this.Y = 0f;

        }
        public PointP(PointP point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }
        public PointP(int x, int y)
        {
            this.X = (float)x;
            this.Y = (float)y;
        }

        public PointP(float x , float y)
        {
            this.X = x;
            this.Y = y;
        }
        public bool CheckCordinates(PointP tocheck)
        {
            if(tocheck.X==X && tocheck.Y==Y)
            {
                return true;
            }


            return false;
        }
    }
}
