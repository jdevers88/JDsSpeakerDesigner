using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Interfaces
{
   public  interface IDriver
    {
       double Vas { get; set; }
       double Qts { get; set; }
       double Fs { get; set; }
       double Sd { get; set; }
       double Xmax { get; set; }
       double Qes { get; set; }
    }
}
