using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SlotPort
    {
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double diameter { get; set; }
        public double wallThickness { get; set; }
        public double Fb { get; set; }
        public double PortV { get; set; }
        public int numofPorts { get; set; }

        public SlotPort(Port CylinderPort)
        {
           
        }

         public SlotPort(double Vb, double inputFb, double Sd, double Xmax)
        {
            Fb = inputFb;
            numofPorts = 1;
            
            diameter = CalculateOptimalPort(Vb, inputFb, numofPorts , Sd, Xmax)/100;
            
            length = CalculateLength(Vb, diameter * 100);
            PortV = CalculatePortV();
        }

        private double CalculateOptimalPort(double Vb, double Fb,  double Np, double Sd, double Xmax)
        {
            double Vd = Sd * Xmax / 1000;
       
            double dmin =(20.3 * Math.Pow((Math.Pow(Vd , 2) / Fb), 0.25)) / Math.Pow(Np,0.5);

            width = Math.Pow(Math.Pow((dmin/ 2),2) * Math.PI ,0.5)/100;
            height = width;
            wallThickness = 0.019;
            return dmin; 
          
        }


        private double CalculateLength(double Vb, double diameter)
        {
            double k = 0.732;
            double NumPorts= 1;
            double Lv = 0;
            Lv = (23562.5 * Math.Pow(diameter, 2) * NumPorts / (Math.Pow(Fb, 2) * Vb)) - (k * diameter);
            Lv = Lv * 0.01;/* cm to m */
            return Lv;
        }

        private double CalculatePortV()
        {
           double newPortV = 0;
           double doubleThickness = wallThickness * 2;
           newPortV =  (width + doubleThickness) * (height + doubleThickness)  * (length + doubleThickness) ;
           return newPortV;
        }
    }
}
