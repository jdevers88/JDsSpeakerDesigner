using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Interfaces
{
    interface IEnclosureDesign
    {
       double height { get; set; }
       double width { get; set; }
       double depth { get; set; }
       double thickness { get; set; }
       double Vb { get; set; }
       double TargetVb { get; set; }

       void show();
    }
}
