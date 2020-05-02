using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Interfaces
{
    public interface ISealed
    {
        double Qtc { get; }

         double Vb { set; get;  }
         double Fb { set; get; }
         double F3 { set; }
    }
}
