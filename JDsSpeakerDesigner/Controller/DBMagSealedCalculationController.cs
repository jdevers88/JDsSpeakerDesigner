using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using Model;
using View;


namespace Controller
{
    class DBMagSealedCalculationController
    {
        double [] DBMag;
        int DBMagPoints = 150;

        public DBMagSealedCalculationController(View .Interfaces .ISealed piSealed, View.Interfaces.IGraph piGraph)
        {
            double DBMagValue = 0;
            List<Series> lstSeries = new List<Series> ();
            Series lSeries = new Series ();
            lSeries.Name = "SPL";
       
            DBMag = new double[DBMagPoints];

            for (int i = 10; i < 150; i++)
            {
                DBMagValue = CalculateDBMagSealed(i, piSealed.Fb , piSealed.Qtc );

                lSeries.Points.AddXY(i, DBMagValue);
               
            }

            lstSeries.Add(lSeries);

            piGraph.scGraph = lstSeries ;
        }

        public double CalculateDBMagSealed(int inputFrequency, double Fb, double Qtc)
        {
            double dBmag = 0;
            double Fr = 0;
            double F = inputFrequency;
            Fr = Math.Pow((F / Fb), 2);
            dBmag = 10 * Math.Log10(Math.Pow(Fr, 2) / (Math.Pow((Fr - 1), 2) + Fr / Math.Pow(Qtc, 2)));
            return dBmag;
        }
    }
}
