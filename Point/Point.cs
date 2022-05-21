using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point
    {
        int x, y;
        public Point(int x, int y)       
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public double GetDistanceToPoint(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(p.x - this.x, 2) 
                + Math.Pow(p.y - this.y, 2));
            return distance;
        }

    }
}
