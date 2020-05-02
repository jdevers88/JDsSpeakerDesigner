using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using View;

namespace Controller
{
    public class CalculateSlotPortedEnclosure
    {
        private PortedEnclosure ActiveEnclosure;

        public CalculateSlotPortedEnclosure(View.Interfaces.IPorted pIPorted, View.Interfaces.IDriver pIDriver, View.Interfaces.IPort pIPort)
        {
            ActiveEnclosure = new PortedEnclosure(pIDriver.Vas, pIDriver.Qts, pIDriver.Fs, pIDriver.Sd, pIDriver.Xmax, pIPorted.alignment);

            pIPorted.Fb = ActiveEnclosure.Fb;
            pIPorted.Vb = ActiveEnclosure.Vb;
            pIPorted.F3 = ActiveEnclosure.F3;
            pIPort.width = ActiveEnclosure.SlotPorts.width  * /*meters to inches*/39.3700787;
            pIPort.length = ActiveEnclosure.SlotPorts.length * /*meters to inches*/39.3700787;
            pIPort.height  = ActiveEnclosure.SlotPorts.height * /*meters to inches*/39.3700787;
            pIPort.numOfPorts = ActiveEnclosure.SlotPorts.numofPorts;
            pIPort.wallThickness = ActiveEnclosure.SlotPorts.wallThickness * /*meters to inches*/39.3700787;
        }
    }
}
