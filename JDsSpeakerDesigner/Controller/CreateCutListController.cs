using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View;
using Model;

namespace Controller
{
    class CreateCutListController
    {
        public CreateCutListController()
        { }
        public CreateCutListController(double height,
                                       double depth,
                                       double width,
                                       double thickness)
        {
            List<Brace> lstBrace = new List<Brace> ();
            Port lPort = new Port();
            Enclosure lEnclosure = new Enclosure(height, width, depth, thickness, lstBrace, lPort);
            Dictionary <string,Cut> activeCutList = lEnclosure.CalculateCutList();

            frmCutList activeForm = new frmCutList(activeCutList["Front"],
                                                   activeCutList["Back"],
                                                   activeCutList["Left"],
                                                   activeCutList["Right"],
                                                   activeCutList["Top"],
                                                   activeCutList["Bottom"]);
            activeForm.Show();
            /*meters to inches 39.3700787 */

            
        }
    }
}
