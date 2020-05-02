using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace View.Interfaces
{
    public interface IGraph
    {
        List<Series> scGraph { set; }
    }
}
