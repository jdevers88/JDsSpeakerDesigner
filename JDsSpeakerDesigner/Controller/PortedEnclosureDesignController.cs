using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using View;

namespace Controller
{
    class PortedEnclosureDesignController
    {
        Port ActivePort;

        public PortedEnclosureDesignController()
        {
        }
        public PortedEnclosureDesignController(double Vb,
                                                View.Interfaces.IPort pIPort,
                                                ref View.Interfaces.IPort pIPort2,
                                                ref View.Interfaces.IEnclosureDesign pIEnclosureDesign)
        {
            Enclosure ActiveEnclosure;
            ActivePort = new Port(pIPort.length * /* in to m */ 0.0254, pIPort.diameter * /* in to m */ 0.0254, pIPort.wallThickness * /* in to m */ 0.0254, pIPort.numOfPorts);

            if (Vb > 0)
            {
                ActiveEnclosure = new Enclosure(Vb, ActivePort);
                pIEnclosureDesign.Vb = ActiveEnclosure.Vb;
                pIEnclosureDesign.TargetVb = ActiveEnclosure.Vb;
                pIEnclosureDesign.height = ActiveEnclosure.height * /*meters to inches*/39.3700787;
                pIEnclosureDesign.width = ActiveEnclosure.width * /*meters to inches*/39.3700787;
                pIEnclosureDesign.depth = ActiveEnclosure.depth * /*meters to inches*/39.3700787;
                pIEnclosureDesign.thickness = ActiveEnclosure.thickness * /*meters to inches*/39.3700787;
                pIPort2.PortV = ActiveEnclosure.Ports.PortV; 
                pIPort2.diameter = ActiveEnclosure.Ports.diameter * /*meters to inches*/39.3700787;
                pIPort2.length = ActiveEnclosure.Ports.length * /*meters to inches*/39.3700787;
                pIPort2.wallThickness = ActiveEnclosure.Ports.wallThickness * /*meters to inches*/39.3700787;
                pIPort2.numOfPorts = ActiveEnclosure.Ports.numofPorts;
            }
        }
               
    }
}
