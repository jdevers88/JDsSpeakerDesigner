using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Interfaces
{
    interface IBrace 
    {
        double length { get; set; }
        double width { get; set; }
        double height { get; set; }

        double volume { get; set; }

    }
}
