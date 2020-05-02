using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using View.Interfaces;

namespace Controller
{
    class CalculateActualVbController
    {
        Enclosure activeEnclosure;
        public CalculateActualVbController()
        { }

        public CalculateActualVbController(IEnclosureDesign enclosure, IPort port, IBrace brace)
        {

            Port activePort = new Port(port.length, port.diameter, port.wallThickness, port.numOfPorts);
            List<Brace> activeBraces = new List<Brace>();
            activeBraces.Add(new Brace(brace.length, brace.height, brace.width));

            activeEnclosure = new Enclosure(enclosure.height,
                                            enclosure.width,
                                            enclosure.depth,
                                            enclosure.thickness,
                                            activeBraces,
                                            activePort);
           
                                            //activeEnclosure .bracingX= pIEnclosureDesign.bracingX  * /* inch to meters */0.0254;
                                            //activeEnclosure .bracingY=  pIEnclosureDesign.bracingY  * /* inch to meters */0.0254;
                                            //activeEnclosure .bracingLength = pIEnclosureDesign.bracingLength  * /* inch to meters */0.0254;
                                            //activeEnclosure .portDiameter = pIEnclosureDesign.portDiameter * /* inch to meters */0.0254;
                                            //activeEnclosure .portLength= pIEnclosureDesign.portLength  * /* inch to meters */0.0254;
                                            //activeEnclosure .portWallThickness = pIEnclosureDesign.portWallThickness  * /* inch to meters */0.0254;
                                            //activeEnclosure .numPort = = pIEnclosureDesign.numPort ;    
            enclosure.Vb = activeEnclosure.Vb;
        }

        private double InchtoMeters(double inches)
        {
            return inches * 0.0254;
        }
        public double GetVb()
        {
            return activeEnclosure.Vb;
        }
    }
}
