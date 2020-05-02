using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SealedEnclosure
    {
        public double Vb { get; set; }
        public double Fb { get; set; }
        public double F3 { get; set; }

        public SealedEnclosure(double Vas, double Qts, double Qtc, double Fs = -1)
        {
            Vb = CalculateVb(Vas, Qts, Qtc);
            Fb = CalculateFb(Qts, Qtc, Fs);
            F3 = CalculateF3(Qtc);
        }

        private double CalculateVb(double Vas, double Qts, double Qtc) 
        {
            double newVb = -1;
            double X = 0;

            X = Math.Pow((Qtc / Qts), 2) - 1;
            newVb = Vas / X;

            return newVb;
        }



        private double CalculateFb(double Qts, double Qtc, double Fs)
        {
            Fb = (Qtc / Qts) * Fs;
            return Fb;
        }
        private double CalculateF3(double Qtc)
        {
            double a = 1 / Math.Pow(Qtc, 2) - 2;
            return Fb * Math.Pow((a + (Math.Pow(Math.Pow(a, 2) + 4, 0.5)) / 2), 0.5);

        }

    }
}
