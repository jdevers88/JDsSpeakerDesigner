using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Brace
    {
        private double length;
        private double height;      
        private double width;

        public double volume { get; set; }

        public Brace(double pLength, double pHeight, double pWidth)
        {
            this.length = pLength;
            this.height = pHeight;
            this.width = pWidth;

            volume = length * width * height;
        }

        
    }
}
