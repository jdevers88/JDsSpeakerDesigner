using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View;

namespace Controller
{
    class PortDrawVelocityController
    {
        double [] Points;
        int NumPoints;
        public PortDrawVelocityController()
        { 
        }

        public PortDrawVelocityController(double Dmin, double Sd, double Np, double Xmax)
        {
            NumPoints = 150;
            Points = new double[NumPoints];
            for (int i = 10; i < NumPoints; i++)
                Points[i] = CalculateVelocity(i, Dmin, Sd, Np, Xmax);
            DrawGraph();
        }
        private double CalculateVelocity(double F, double Dmin, double Sd, double Np, double Xmax)
        {

            double Vd = Sd * Xmax / 1000;
            double velocity = 0;
            velocity = (Dmin * Math.Pow(Np, 0.5) / 100) / Math.Pow((Math.Pow(Vd, 2) / F), 0.25);
            
            return velocity;
        }

        public void DrawGraph()
        {
            frmGraph activeform = new frmGraph(Points, "DB Mag", NumPoints);
            activeform.Show();
        }
    }
}
