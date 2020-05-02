using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Interfaces
{
    public interface IPort
    {
        double length { get; set; }
        double diameter { get; set; }
        double wallThickness { get; set; }
        double PortV { get; set; }
        double width { get; set; }
        double height { get; set; }
        PortType type { get; set; }
        int numOfPorts { get; set; }
    }
    public enum PortType
    {
        Slot,
        Cylinder
    }
}
