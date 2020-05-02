using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Port
    {
        public double length { get; set; }
        public double diameter { get; set; }
        public double wallThickness { get; set; }
        public double Fb { get; set; }
        public double PortV { get; set; }
        public int numofPorts { get; set; }
        public Port()
        { }

        public Port(double inputLength, double inputDiameter, double inputWallThickness, int inputNumOfPorts)
        {
            length = inputLength;
            diameter = inputDiameter;
            wallThickness = inputWallThickness;


            PortV = CalculatePortV();
        }

        public Port(double Vb, double inputFb, double Sd, double Xmax)
        {
            Fb = inputFb;
            numofPorts = 1;
            diameter = CalculateOptimalPortDiameter(Vb, inputFb, numofPorts , Sd, Xmax)/100;
            length = CalculateLength(Vb, diameter * 100);
            wallThickness = CalclulateWallThickness(diameter);
            PortV = CalculatePortV();
        }

        private double CalculateOptimalPortDiameter(double Vb, double Fb,  double Np, double Sd, double Xmax)
        {
            double Vd = Sd * Xmax / 1000;
       
            double dmin =(20.3 * Math.Pow((Math.Pow(Vd , 2) / Fb), 0.25)) / Math.Pow(Np,0.5);

            if (dmin < 7.79272)
                return 7.9272;/*standard 3" Pvc in meters */
            else if (dmin < 10.22604)
                return 10.22604;
            else if (dmin < 15.4051)
                return 15.4051;
            else if (dmin < 20.32)
                return 20.32;
            else
                return dmin; 
          
        }

        private double CalclulateWallThickness(double inputDiameter)
        {
            if (diameter < 0.08)
                return 0.0054864;/*standard 3" Pvc in meters */
            else if (diameter < 0.11)
                return 0.0060198;
            else
                return 0.007112;
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
           newPortV = (Math.PI * Math.Pow(((diameter / 2) + wallThickness), 2)) * length;
           newPortV = newPortV * 1000;
           return newPortV;
        }
    }
}
