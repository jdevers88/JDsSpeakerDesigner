using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View;

namespace Controller
{
    class PortDrawMagnitudeController
    {
        double [] Points;
        int NumPoints;
        public PortDrawMagnitudeController()
        { 
        }

        public PortDrawMagnitudeController(double Vb, double Fs, double Qts, double Fb, double Vas, double Ql = 7)
        {
            NumPoints = 150;
            Points = new double[NumPoints];
            for (int i = 10; i < NumPoints; i++)
                Points[i] = CalculateMagnitude(i, Vb, Fs, Qts, Fb, Vas, Ql);

            DrawGraph();
        }
        private double CalculateMagnitude(double F, double Vb, double Fs, double Qts, double Fb, double Vas, double Ql = 7)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            double Fn2 = 0;
            double Fn4 = 0;
            double dBMag = 0;

            Fn2 = Math.Pow((F / Fs), 2);
            Fn4 = Math.Pow(Fn2, 2);
            A = Math.Pow((Fb / Fs), 2);
            B = A / Qts + Fb / (Fs * Ql);
            C = 1 + A + (Vas / Vb) + Fb / (Fs * Qts * Ql);
            D = 1 / Qts + Fb / (Fs * Ql);

            // dBmag = 10 * LOG(Fn4^2 / ((Fn4 - C * Fn2 + A)^2 + Fn2 * (D * Fn2 - B)^2))
            dBMag = 10 * Math.Log(Math.Pow(Fn4, 2) / (Math.Pow((Fn4 - (C * Fn2) + A), 2) + Fn2 * Math.Pow(((D * Fn2) - B), 2)));

            return dBMag;
        }

        public void DrawGraph()
        {
            frmGraph activeform = new frmGraph(Points, "DB Mag", NumPoints);
            activeform.Show();
        }
    }
}
