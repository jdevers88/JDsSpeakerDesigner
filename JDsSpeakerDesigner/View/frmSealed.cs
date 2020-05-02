using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
namespace View
{
    public partial class frmSealed : Form, Interfaces.ISealed, Interfaces.IDriver 
    {

        public frmSealed()
        {
            InitializeComponent();
        }

        private void btnCalculateVb_Click(object sender, EventArgs e)
        {
                    
                ControllerSealedCalculateVbFb CalculateVB = new ControllerSealedCalculateVbFb(this, this);
                btnEnclosureDesign.Visible = true;
                btnDrawGraph.Visible = true;
        }

        

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            frmGraph lfrmGraph = new frmGraph();

 
           DBMagSealedCalculationController GraphFormController = new DBMagSealedCalculationController(this, lfrmGraph);

           lfrmGraph.Show();
        }

        private void btnEnclosureDesign_Click(object sender, EventArgs e)
        {
            Interfaces.IEnclosureDesign  lfrmEnclosureDesign = new frmEnclosureDesign();

            lfrmEnclosureDesign.Vb = this.Vb;
 
            SealedEnclosureDesignController activeForm = new SealedEnclosureDesignController(ref lfrmEnclosureDesign);
            lfrmEnclosureDesign.show();
        }

        public double Vas { get { return double.Parse(txtVas.Text); } set { txtVas.Text = value.ToString(); } }
        public double Qts { get { return double.Parse(txtQts.Text); } set { txtQts.Text = value.ToString(); } }
        public double Qes { get { return double.Parse(txtQes.Text); } set { txtQes.Text = value.ToString(); } }

       public double Fs { get { return double.Parse(txtFs.Text); } set {txtFs.Text = value.ToString(); } }
       public double Qtc { get { return double.Parse(txtQtc.Text); } }
       public double Vb { get { return double.Parse(txtVb.Text); }  set { txtVb.Text = value.ToString(); } }
       public double Sd { get; set; }
       public double Xmax { get; set; }

       public double Fb { set { txtFb.Text = value.ToString(); } get { return double.Parse(txtFb.Text); } }
       public double F3 { set { txtF3.Text = value.ToString(); } }

       private void btnLoadDriver_Click(object sender, EventArgs e)
       {
           ofdWDR.ShowDialog();
           LoadDriver LD = new LoadDriver(ofdWDR.FileName, this);
       }
    }
}
