using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Enclosure
    {
        
        public double height { get; set; }
        public double width { get; set; }
        public double depth { get; set; }
        public double internalHeight { get; set; }
        public double internalWidth { get; set; }
        public double internalDepth { get; set; }
        public double thickness { get; set; }
        List<Brace> Braces { get; set; }
        public double Vb { get; set; }


        public double BracingV
        {
            get
            {
                double bracingV = 0;

             ///   foreach (Brace b in Braces)
               // {
                 //   bracingV += b.volume;
                //}

                return bracingV;
            }
        }
        string enclosureType { get; set; }
        public Port Ports { get; set; }
        public int numPorts { get; set; }

        public Enclosure() 
        {
            Vb = -1;
            enclosureType = "Sealed";
        }
        public Enclosure(double inputVb)
        {
            double power = 0;
            double temp = 0;
            double VbCubicMeters = 0;

            enclosureType = "Sealed";
            thickness = 0.019;


            Vb = inputVb;
            VbCubicMeters = Vb * /* liters to cubic meters */0.001;
            power = 1.0 / 3.0;
            temp = Math.Pow(VbCubicMeters, power);
            height = temp + 2 * thickness;
            width = temp + 2 * thickness;
            depth = temp + 2 * thickness;
    
        }

        public Enclosure(double inputVb, Port inputPort)
        {

            double power = 0;
            double temp = 0;
            double VCubicMeters = 0;

            enclosureType = "Ported";
            thickness = 0.019;
            Ports = inputPort;
            numPorts = 1;
            Vb = inputVb;
            double V = inputVb + inputPort.PortV * inputPort.numofPorts;
            VCubicMeters = V * /* liters to cubic meters */0.001;
            power = 1.0 / 3.0;
            temp = Math.Pow(VCubicMeters, power);
            height = temp + 2 * thickness;
            width = temp + 2 * thickness;
            depth = temp + 2 * thickness;

            Ports = inputPort;
        }

       
        
        

        public Enclosure(double inputHeight, 
                         double inputWidth, 
                         double inputDepth, 
                         double inputThickness, 
                         List<Brace> inputBraces,
                         Port inputPort)
        {


            height = inputHeight;
            width = inputWidth;
            depth = inputDepth;
            thickness = inputThickness;

            foreach (Brace b in inputBraces)
            {
                Vb -= b.volume ;                
            }
            
            //enclosureBracing = new Brace(inputBracingX, inputBracingY, inputBracingLength); replaced with individual brace input
            Ports = inputPort;

            internalHeight = height - 2 * (thickness);
            internalWidth = width - 2 * (thickness);
            internalDepth = depth - 2 * (thickness);

            Vb = (internalHeight * internalWidth * internalDepth * /* meters to liters */ 1000) - Ports.PortV * Ports.numofPorts;
        }

        public Enclosure(double inputHeight,
                          double inputWidth,
                          double inputDepth,
                          double inputThickness,
                          //List<Brace> inputBraces,
                          int inputNumPorts = 1)
        {
            
            height = inputHeight;
            width = inputWidth;
            depth = inputDepth;
            thickness = inputThickness;
         

            //foreach (Brace b in inputBraces)
            //{
            //    Vb -= b.volume;
            //}

            //enclosureBracing = new Brace(inputBracingX, inputBracingY, inputBracingLength); replaced with individual brace input
            

            internalHeight = height - 2 * (thickness);
            internalWidth = width - 2 * (thickness);
            internalDepth = depth - 2 * (thickness);

            Vb = (internalHeight * internalWidth * internalDepth * /* meters to liters */ 1000) - BracingV;
        }

        
        
        public Dictionary <string, Cut> CalculateCutList()
        { 
            Dictionary  <string, Cut> lCutList = new Dictionary<string,Cut> ();

            double doubleThickness = 0;

            doubleThickness = 2 * thickness;

            lCutList.Add("Front", new Cut(height, width, thickness));
            lCutList.Add("Back", new Cut(height, width, thickness));
            lCutList.Add("Left", new Cut(height, depth - doubleThickness , thickness));
            lCutList.Add("Right", new Cut(height, depth - doubleThickness, thickness));
            lCutList.Add("Top", new Cut(depth - doubleThickness, width - doubleThickness , thickness));
            lCutList.Add("Bottom", new Cut(depth - doubleThickness, width - doubleThickness, thickness));       

            return lCutList; 
        }
    }
}
