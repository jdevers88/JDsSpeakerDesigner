using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Point
    {
        int x;
        double y;

        public Point(int inputX, double inputY)
        {
            x = inputX;
            y = inputY;
        }

        public int getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }
    }
}
