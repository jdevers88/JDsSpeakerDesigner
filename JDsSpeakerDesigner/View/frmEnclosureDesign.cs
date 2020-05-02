using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using View.Interfaces;

namespace View
{
    public partial class frmEnclosureDesign : Form, Interfaces.IEnclosureDesign, Interfaces.IPort, Interfaces.IBrace
    {

        double IEnclosureDesign.height { get { return double.Parse(txtHeight.Text); } set { txtHeight.Text = value.ToString("#.##"); } }
        double IEnclosureDesign.width { get { return double.Parse(txtWidth.Text); } set { txtWidth.Text = value.ToString("#.##"); } }
        double IEnclosureDesign.depth { get { return double.Parse(txtDepth.Text); } set { txtDepth.Text = value.ToString("#.##"); } }
        double IEnclosureDesign.thickness { get { return double.Parse(txtThickness.Text); } set { txtThickness.Text = value.ToString("#.##"); } }
        double IPort.diameter { get { return double.Parse(txtPortDiameter.Text); } set { txtPortDiameter.Text = value.ToString("#.##"); } }
        double IPort.length { get { return double.Parse(txtPortLength.Text); } set { txtPortLength.Text = value.ToString("#.##"); } }
        double IPort.wallThickness { get { return double.Parse(txtPortWallThickness.Text); } set { txtPortWallThickness.Text = value.ToString("#.##"); } }
        double IPort.PortV { get { return double.Parse(txtPortV.Text); } set { txtPortV.Text = value.ToString("#.##"); } }
        double Interfaces.IEnclosureDesign.Vb { get { return double.Parse(txtActualVb.Text); } set { txtActualVb.Text = value.ToString("#.##"); } }
        int IPort.numOfPorts { get { return int.Parse(txtNumofPort.Text); } set { txtNumofPort.Text = value.ToString("#.##"); } }
        PortType IPort.type { get; set; }
        double IBrace.length { get => double.Parse(txtBracingLength.Text); set => txtBracingLength.Text = value.ToString("#.##"); }
        double IBrace.width { get => double.Parse(txtBracingWidth.Text); set => txtBracingWidth.Text = value.ToString("#.##"); }
        double IBrace.height { get => double.Parse(txtBracingThickness.Text); set => txtBracingThickness.Text = value.ToString("#.##"); }
        double IBrace.volume { get => double.Parse(txtBracingV.Text); set => txtBracingV.Text = value.ToString("#.##"); }
        public double TargetVb { get { return double.Parse(txtTargetVb.Text); } set { txtTargetVb.Text = value.ToString("#.##"); } }

        double IPort.width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IPort.height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void Interfaces.IEnclosureDesign.show()
        {
            Show();
        }

        public frmEnclosureDesign()
        {
            InitializeComponent();
 
        }
                 
     

        public frmEnclosureDesign(double height,
                                    double width,
                                    double depth,
                                    double thickness,
                                    double targetVb,
                                    double actualVb,
                                    double portLength,
                                    double portDiameter,
                                    double portWallThickness,
                                    double portV,
                                    bool hasPort)
        {
            InitializeComponent();

            grpPort.Visible = hasPort;
               
                txtHeight.Text = string.Format("{0:0.##}", height);
                txtWidth.Text = string.Format("{0:0.##}", width);
                txtDepth.Text = string.Format("{0:0.##}", depth);
                txtThickness.Text = string.Format("{0:0.##}", thickness);
                txtTargetVb.Text = string.Format("{0:0.##}", targetVb);
                txtActualVb.Text = string.Format("{0:0.##}", actualVb);
                txtPortLength.Text = string.Format("{0:0.##}", portLength);
                txtPortDiameter.Text = string.Format("{0:0.##}", portDiameter);
                txtPortWallThickness.Text = string.Format("{0:0.##}", portWallThickness);
                txtPortV.Text = string.Format("{0:0.##}", portV);
                txtNumofPort.Text = string.Format("{0:0.##}", 1);
        }

        private void btnCalculateVb_Click(object sender, EventArgs e)
        {
            try
            {

                CalculateActualVbController activeController = new CalculateActualVbController(this,this,this);

                txtActualVb.Text = string.Format("{0:0.##}", activeController.GetVb());
            }
            catch
            {
                MessageBox.Show("Calculate Actual Vb Fails");
            }
        }

        private void btnCalculateBracinV_Click(object sender, EventArgs e)
        {
            EnclosureDesignCalculateBracingVController activeController = new EnclosureDesignCalculateBracingVController(this);
      
        }

        private void btnCreateCutList_Click(object sender, EventArgs e)
        {
            CreateCutListController activeController = new CreateCutListController(double.Parse(txtHeight.Text),
                                                                                   double.Parse(txtDepth.Text),
                                                                                   double.Parse(txtWidth.Text),
                                                                                   double.Parse(txtThickness.Text));
            
            
        }


        
    }
}
