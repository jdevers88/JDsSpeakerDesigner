using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Cut
    {
        public Cut(double plength, double pwidth, double pthickness)
        { 
            length = plength;
            width = pwidth;
            thickness = pthickness; 
        }

        public double length
        {
            get;
            set;
        }
        public double width
        {
            get;
            set;
        }
        public double thickness
        {
            get;
            set;
        }
      
    }
}
