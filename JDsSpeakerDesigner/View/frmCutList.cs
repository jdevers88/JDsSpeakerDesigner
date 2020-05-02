using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class frmCutList : Form
    {
        public frmCutList()
        {
            InitializeComponent();
        }

        public frmCutList(Cut front, Cut back, Cut left, Cut right, Cut top, Cut bottom)
        {
            InitializeComponent();


            txtFrontLength.Text = string.Format("{0:0.##}", front.length);
            txtFrontWidth.Text = string.Format("{0:0.##}", front.width);
            txtBackLength.Text = string.Format("{0:0.##}", back.length);
            txtBackWidth.Text = string.Format("{0:0.##}", back.width);
            txtLeftLength.Text = string.Format("{0:0.##}", left.length);
            txtLeftWidth.Text = string.Format("{0:0.##}", left.width);
            txtRightLength.Text = string.Format("{0:0.##}", right.length);
            txtRightWidth.Text = string.Format("{0:0.##}", right.width);
            txtTopLength.Text = string.Format("{0:0.##}", top.length);
            txtTopWidth.Text = string.Format("{0:0.##}", top.width);
            txtBottomLength.Text = string.Format("{0:0.##}", bottom.length);
            txtBottomWidth.Text = string.Format("{0:0.##}", bottom.width);
        }
    }
}
