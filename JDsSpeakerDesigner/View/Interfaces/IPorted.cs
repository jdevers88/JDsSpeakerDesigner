using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Interfaces
{
    public interface IPorted
    {
        double Vb { get; set; }
        double Fb { get; set; }
        double F3 { get; set; }
        PortType type { get; set; }
        string alignment { get; set;  }
    }
}
