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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnSealed_Click(object sender, EventArgs e)
        {
            frmSealed lfrmSealed = new frmSealed();
           lfrmSealed.Show ();
        }

        private void btnPorted_Click(object sender, EventArgs e)
        {
            frmPorted lfrmPorted = new frmPorted();
            lfrmPorted.Show();
        }
    }
}
