using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PortedEnclosure
    {
        public double Vb { get; set; }
        public double Fb { get; set; }
        public double F3 { get; set; }
        public Port Ports { get; set; }
        public SlotPort SlotPorts { get; set; }
        public PortedEnclosure(double Vas, double Qts, double Fs, double Sd, double Xmax, string alignment)
        {
            if (alignment == "EBS")
            {
                Vb = CalculateVb(Vas, Qts) * 1.7;
                Fb = Fs;
            }
            else
            {
                Vb = CalculateVb(Vas, Qts);
                Fb = CalculatePortedFb(Vas, Fs);
            }
            F3 = CalculateF3(Vas,Vb,Fs);
            Ports = new Port(Vb, Fb, Sd, Xmax);
            SlotPorts = new SlotPort(Vb, Fb, Sd, Xmax);

        }

        private double CalculateF3(double Vas, double Vb, double Fs)
        {
            return  Math.Pow((Vas / Vb), 0.44) * Fs; 
        }

         private double CalculatePortedFb(double Vas, double Fs)
         {
             double Fb = Math.Pow((Vas / Vb), 0.31) * Fs;
             return Fb;
         }


         private double CalculateVb(double Vas, double Qts) /* For Ported Operation */
         {
             Vb = 20.0 * Math.Pow(Qts, 3.3) * Vas;
             return Vb;
         }
    }
}
