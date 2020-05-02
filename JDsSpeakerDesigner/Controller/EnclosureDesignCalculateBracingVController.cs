using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View.Interfaces;
using Model;

namespace Controller
{
    class EnclosureDesignCalculateBracingVController
    {
        Brace activeBracing;

        public EnclosureDesignCalculateBracingVController()
        { }
        public EnclosureDesignCalculateBracingVController(IBrace Bracing)
        {
            activeBracing = new Brace(Bracing.height * /* in to m */ 0.0254, Bracing.width * /* in to m */ 0.0254, Bracing.length * /* in to m */ 0.0254);
            Bracing.volume = activeBracing.volume;
        }

    }
}
