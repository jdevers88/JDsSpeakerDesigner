using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using View;

namespace Controller
{
    class ControllerPortedCalculateVbFb
    {
        private PortedEnclosure ActiveEnclosure;
        public ControllerPortedCalculateVbFb()
        {
        }
        public ControllerPortedCalculateVbFb(View.Interfaces.IPorted pIPorted, View.Interfaces.IDriver pIDriver, View.Interfaces.IPort pIPort)
        {
            ActiveEnclosure = new PortedEnclosure(pIDriver.Vas, pIDriver.Qts, pIDriver.Fs, pIDriver.Sd, pIDriver.Xmax, pIPorted.alignment);

            pIPorted.Fb = ActiveEnclosure.Fb;
            pIPorted.Vb = ActiveEnclosure.Vb;
            pIPorted.F3 = ActiveEnclosure.F3;
            pIPort.diameter = ActiveEnclosure.Ports.diameter  * /*meters to inches*/39.3700787;
            pIPort.length = ActiveEnclosure.Ports.length * /*meters to inches*/39.3700787;
            pIPort.numOfPorts = ActiveEnclosure.Ports.numofPorts;
            pIPort.wallThickness = ActiveEnclosure.Ports.wallThickness * /*meters to inches*/39.3700787;
        }              
    }
}

