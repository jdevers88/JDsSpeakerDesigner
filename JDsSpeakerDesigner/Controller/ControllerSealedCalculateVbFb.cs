using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Windows.Forms;
using View.Interfaces;
namespace Controller
{
    class ControllerSealedCalculateVbFb
    {

  
        public ControllerSealedCalculateVbFb(View.Interfaces.ISealed piSealed, View.Interfaces.IDriver piDriver)
        {
            SealedEnclosure ActiveEnclosure = new Model.SealedEnclosure(piDriver.Vas, piDriver.Qts, piSealed.Qtc, piDriver.Fs);
            piSealed.Vb = ActiveEnclosure.Vb;
            piSealed.Fb = ActiveEnclosure.Fb;
            piSealed.F3 = ActiveEnclosure.F3; 

        }

    
        }
}
