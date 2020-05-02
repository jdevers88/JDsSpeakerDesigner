using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using View;

namespace Controller
{
    class SealedEnclosureDesignController
    {

        public SealedEnclosureDesignController(ref View.Interfaces.IEnclosureDesign pFrmEnclosureDesign)
        {
            Enclosure ActiveEnclosure = new Enclosure(pFrmEnclosureDesign.Vb); 

            double height = ActiveEnclosure.height;
            double width = ActiveEnclosure.width;
            double depth = ActiveEnclosure.depth;
            double thickness = ActiveEnclosure.thickness;
            double targetVb = ActiveEnclosure.Vb;

            height = height * /*meters to inches*/39.3700787;
            width = width * /*meters to inches*/39.3700787;
            depth = depth * /*meters to inches*/39.3700787;
            thickness = thickness * /*meters to inches*/39.3700787;
            pFrmEnclosureDesign.height = Math.Round(height, 2);
            pFrmEnclosureDesign.depth = Math.Round(depth, 2);
            pFrmEnclosureDesign.width = Math.Round(width, 2);
            pFrmEnclosureDesign.thickness = Math.Round(thickness, 2);
            pFrmEnclosureDesign.TargetVb = Math.Round(targetVb, 2);
           
        }

    }
}
