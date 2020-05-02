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
    public partial class frmPorted : Form, Interfaces.IPorted, Interfaces.IDriver, Interfaces.IPort
    {
        public frmPorted()
        {
            InitializeComponent();
        }

        public string alignment { get { return cboAlignment.Text; } set { cboAlignment.Text = value; } }
        public double Vas { get { return double.Parse(txtVas.Text); } set { txtVas.Text = value.ToString(); } }
        public double Qts { get { return double.Parse(txtQts.Text); } set { txtQts.Text = value.ToString(); } }

        public double Fs { get { return double.Parse(txtFs.Text); } set { txtFs.Text = value.ToString(); } }
        public double Sd { get { return double.Parse(txtSd.Text); } set { txtSd.Text = value.ToString(); } }
        public double Xmax { get { return double.Parse(txtXmax.Text); } set { txtXmax.Text = value.ToString(); } }
        public double Qes { get; set; }
        public double Vb { get { return double.Parse(txtVb.Text); } set { txtVb.Text = value.ToString(); } }
        public double Fb { get { return double.Parse(txtFb.Text); } set { txtFb.Text = value.ToString(); } }
        public double F3 { get { return double.Parse(txtF3.Text); } set { txtF3.Text = value.ToString(); } }
        public double length { set { txtPortLength.Text = value.ToString(); } get { return double.Parse(txtPortLength.Text); } }
        public double diameter { set { txtPortDiameter.Text = value.ToString(); } get { return double.Parse(txtPortDiameter.Text); }  }
        public int numOfPorts { set { txtNumofPort.Text = value.ToString(); } get { return int.Parse(txtNumofPort.Text); } }
        public double wallThickness { set { txtPortWallThickness.Text = value.ToString(); } get { return double.Parse(txtPortWallThickness.Text); } }
        public double PortV { get; set; }
        public double width { get { return double.Parse(txtWidth.Text); } set { txtWidth.Text = value.ToString(); } }
        public double height 
        { 
            get
            {
                return double.Parse(txtPortDiameter.Text);
            }
            set
            {
                txtPortDiameter.Text = value.ToString();
            } 
        }
        public Interfaces.PortType type {
            get
            {
                if (cboPortType.Text == "Slot")
                {
                    return Interfaces.PortType.Slot;
                }
                else
                {
                    return Interfaces.PortType.Cylinder;
                }
            }
            set
            {
                if (value == Interfaces.PortType.Cylinder )
                {
                    cboPortType.Text = "Pipe";
                    lblDiameter.Text = "Diameter";
                    txtWidth.Visible = false;
                }
                else
                {
                    cboPortType.Text = "Slot";
                    lblDiameter.Text = "Height";
                    txtWidth.Visible = true;
                }

            }
        }
        private void btnCalculateVbFb_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == Interfaces.PortType.Cylinder)
                {
                    ControllerPortedCalculateVbFb CalculateVB = new ControllerPortedCalculateVbFb(this, this, this);
                }
                else
                {
                    CalculateSlotPortedEnclosure CalculateSlotPort = new CalculateSlotPortedEnclosure(this, this, this);
                }
                txtVb.Text = string.Format("{0:0.##}", Vb);
                txtFb.Text = string.Format("{0:0.##}", Fb);

                btnEnclosureDesign.Visible = true;
                btnDrawGraph.Visible = true;
                btnDrawVelocity.Visible = true;
            }
            catch
            {
                MessageBox.Show("VB calculation error. Please make sure you use numbers in Vas, Qts, and Qtc.");
            }
        }



        private void btnEnclosureDesign_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnclosureDesign lfrmEnclosureDesign = new frmEnclosureDesign();
                Interfaces.IEnclosureDesign lEnclosureDesign = lfrmEnclosureDesign;
                Interfaces.IPort lPort = lfrmEnclosureDesign;
                PortedEnclosureDesignController activeController = new PortedEnclosureDesignController(Vb, this, ref lPort, ref lEnclosureDesign);
                lfrmEnclosureDesign.Show();
            }
            catch 
            {
                MessageBox.Show("Ported Enclosure Design Controller Failure");
            }
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            try
            {
                PortDrawMagnitudeController Graph =  new PortDrawMagnitudeController(double.Parse(txtVb.Text),
                                                                                     double.Parse(txtFs.Text),
                                                                                     double.Parse(txtQts.Text),
                                                                                     double.Parse(txtFb.Text),
                                                                                     double.Parse(txtVas.Text));
            }
            catch 
            {
                MessageBox.Show("Draw Graph Controller Failure");
            }
        }

        private void btnLoadDriver_Click(object sender, EventArgs e)
        {
            ofdWDR.ShowDialog();
           
                LoadDriver LD = new LoadDriver(ofdWDR.FileName, this);
        }

        private void btnDrawVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                PortDrawVelocityController Graph = new PortDrawVelocityController(double.Parse(txtPortDiameter.Text),
                                                                                  double.Parse(txtSd.Text),
                                                                                  double.Parse(txtNumofPort.Text),
                                                                                  double.Parse(txtXmax.Text));
            }
            catch
            {
                MessageBox.Show("Draw Graph Controller Failure");
            }
        }

        private void lblWallThickness_Click(object sender, EventArgs e)
        {

        }
    }
}
