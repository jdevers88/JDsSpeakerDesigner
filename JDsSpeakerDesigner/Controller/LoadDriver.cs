using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class LoadDriver
    {
        public LoadDriver(string fileName, View.Interfaces.IDriver pIDriver)
        {
            if (System.IO.File.Exists(fileName))
            {
                Model.Driver lDriver = Model.Driver.Load(fileName);

                pIDriver.Fs = lDriver.Fs; 
                pIDriver.Qes = lDriver.Qes; 
                pIDriver.Qts = lDriver.Qts;
                pIDriver.Sd = lDriver.Sd;
                pIDriver.Vas = lDriver.Vas;
                pIDriver.Xmax = lDriver.Xmax;
            }
        }
    }
}
