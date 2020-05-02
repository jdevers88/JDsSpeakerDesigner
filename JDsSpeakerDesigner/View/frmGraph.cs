using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace View
{
    public partial class frmGraph : Form, Interfaces .IGraph 
    {
        public List<Series> scGraph
        {
            set
            {
                chtSPL.Series.Clear();

                foreach (Series D in value)
                {
                    D.ChartType = SeriesChartType.Spline;
                    chtSPL.Series.Add(D);
                }
                
            }
        }
        
        
        public frmGraph()
        {               
            InitializeComponent();
        }

        public frmGraph(double[] newPoints, string plotName, int numPoints)
        {
             InitializeComponent(); 
             double F = 0;

             for (int i = 10; i < numPoints; i++)
             {
                 F = i;
                 if (newPoints[i] >= -10)
                 {
                     chtSPL.Series["Plot"].Points.AddXY(F, newPoints[i]);
                 }
                 else
                 {
                     chtSPL.Series["Plot"].Points.AddXY(F, -10);
                 }
             }
        }

        private void chtSPL_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
