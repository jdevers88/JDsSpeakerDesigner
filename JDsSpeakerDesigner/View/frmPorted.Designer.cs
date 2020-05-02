namespace View
{
    partial class frmPorted
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnclosureDesign = new System.Windows.Forms.Button();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnCalculateVbFb = new System.Windows.Forms.Button();
            this.grpEnclosure = new System.Windows.Forms.GroupBox();
            this.cboPortType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUnitF3 = new System.Windows.Forms.Label();
            this.txtF3 = new System.Windows.Forms.TextBox();
            this.lblF3 = new System.Windows.Forms.Label();
            this.cboAlignment = new System.Windows.Forms.ComboBox();
            this.lblUnitFb = new System.Windows.Forms.Label();
            this.txtFb = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblVbUnits = new System.Windows.Forms.Label();
            this.txtVb = new System.Windows.Forms.TextBox();
            this.lblVb = new System.Windows.Forms.Label();
            this.grpDriver = new System.Windows.Forms.GroupBox();
            this.lblUnitXmax = new System.Windows.Forms.Label();
            this.lblUnitSd = new System.Windows.Forms.Label();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblSd = new System.Windows.Forms.Label();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtSd = new System.Windows.Forms.TextBox();
            this.lblUnitFs = new System.Windows.Forms.Label();
            this.lblFs = new System.Windows.Forms.Label();
            this.txtFs = new System.Windows.Forms.TextBox();
            this.lblVasUnits = new System.Windows.Forms.Label();
            this.txtVas = new System.Windows.Forms.TextBox();
            this.txtQts = new System.Windows.Forms.TextBox();
            this.lblVas = new System.Windows.Forms.Label();
            this.lblQts = new System.Windows.Forms.Label();
            this.grpPort = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblUnitPortThickness = new System.Windows.Forms.Label();
            this.txtPortWallThickness = new System.Windows.Forms.TextBox();
            this.lblWallThickness = new System.Windows.Forms.Label();
            this.lblUnitDiameter = new System.Windows.Forms.Label();
            this.lblUnitPortLength = new System.Windows.Forms.Label();
            this.txtNumofPort = new System.Windows.Forms.TextBox();
            this.lblNumPorts = new System.Windows.Forms.Label();
            this.txtPortLength = new System.Windows.Forms.TextBox();
            this.txtPortDiameter = new System.Windows.Forms.TextBox();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblPortLength = new System.Windows.Forms.Label();
            this.btnLoadDriver = new System.Windows.Forms.Button();
            this.ofdWDR = new System.Windows.Forms.OpenFileDialog();
            this.btnDrawVelocity = new System.Windows.Forms.Button();
            this.grpEnclosure.SuspendLayout();
            this.grpDriver.SuspendLayout();
            this.grpPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnclosureDesign
            // 
            this.btnEnclosureDesign.Location = new System.Drawing.Point(218, 212);
            this.btnEnclosureDesign.Name = "btnEnclosureDesign";
            this.btnEnclosureDesign.Size = new System.Drawing.Size(107, 23);
            this.btnEnclosureDesign.TabIndex = 9;
            this.btnEnclosureDesign.Text = "Enclosure Design";
            this.btnEnclosureDesign.UseVisualStyleBackColor = true;
            this.btnEnclosureDesign.Visible = false;
            this.btnEnclosureDesign.Click += new System.EventHandler(this.btnEnclosureDesign_Click);
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(218, 241);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(107, 23);
            this.btnDrawGraph.TabIndex = 8;
            this.btnDrawGraph.Text = "Draw Graph";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Visible = false;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // btnCalculateVbFb
            // 
            this.btnCalculateVbFb.Location = new System.Drawing.Point(12, 342);
            this.btnCalculateVbFb.Name = "btnCalculateVbFb";
            this.btnCalculateVbFb.Size = new System.Drawing.Size(148, 23);
            this.btnCalculateVbFb.TabIndex = 7;
            this.btnCalculateVbFb.Text = "Calculate Optimal Vb Fb";
            this.btnCalculateVbFb.UseVisualStyleBackColor = true;
            this.btnCalculateVbFb.Click += new System.EventHandler(this.btnCalculateVbFb_Click);
            // 
            // grpEnclosure
            // 
            this.grpEnclosure.Controls.Add(this.cboPortType);
            this.grpEnclosure.Controls.Add(this.label1);
            this.grpEnclosure.Controls.Add(this.lblType);
            this.grpEnclosure.Controls.Add(this.lblUnitF3);
            this.grpEnclosure.Controls.Add(this.txtF3);
            this.grpEnclosure.Controls.Add(this.lblF3);
            this.grpEnclosure.Controls.Add(this.cboAlignment);
            this.grpEnclosure.Controls.Add(this.lblUnitFb);
            this.grpEnclosure.Controls.Add(this.txtFb);
            this.grpEnclosure.Controls.Add(this.lbl);
            this.grpEnclosure.Controls.Add(this.lblVbUnits);
            this.grpEnclosure.Controls.Add(this.txtVb);
            this.grpEnclosure.Controls.Add(this.lblVb);
            this.grpEnclosure.Location = new System.Drawing.Point(12, 171);
            this.grpEnclosure.Name = "grpEnclosure";
            this.grpEnclosure.Size = new System.Drawing.Size(200, 165);
            this.grpEnclosure.TabIndex = 6;
            this.grpEnclosure.TabStop = false;
            this.grpEnclosure.Text = "Enclosure";
            // 
            // cboPortType
            // 
            this.cboPortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortType.FormattingEnabled = true;
            this.cboPortType.Items.AddRange(new object[] {
            "Slot",
            "Pipe"});
            this.cboPortType.Location = new System.Drawing.Point(46, 127);
            this.cboPortType.Name = "cboPortType";
            this.cboPortType.Size = new System.Drawing.Size(99, 21);
            this.cboPortType.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Port";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(9, 22);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type";
            // 
            // lblUnitF3
            // 
            this.lblUnitF3.AutoSize = true;
            this.lblUnitF3.Location = new System.Drawing.Point(152, 104);
            this.lblUnitF3.Name = "lblUnitF3";
            this.lblUnitF3.Size = new System.Drawing.Size(20, 13);
            this.lblUnitF3.TabIndex = 16;
            this.lblUnitF3.Text = "Hz";
            // 
            // txtF3
            // 
            this.txtF3.Location = new System.Drawing.Point(46, 101);
            this.txtF3.Name = "txtF3";
            this.txtF3.ReadOnly = true;
            this.txtF3.Size = new System.Drawing.Size(100, 20);
            this.txtF3.TabIndex = 15;
            // 
            // lblF3
            // 
            this.lblF3.AutoSize = true;
            this.lblF3.Location = new System.Drawing.Point(21, 104);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(19, 13);
            this.lblF3.TabIndex = 14;
            this.lblF3.Text = "F3";
            // 
            // cboAlignment
            // 
            this.cboAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlignment.FormattingEnabled = true;
            this.cboAlignment.Items.AddRange(new object[] {
            "Standard",
            "EBS"});
            this.cboAlignment.Location = new System.Drawing.Point(47, 19);
            this.cboAlignment.Name = "cboAlignment";
            this.cboAlignment.Size = new System.Drawing.Size(99, 21);
            this.cboAlignment.TabIndex = 13;
            // 
            // lblUnitFb
            // 
            this.lblUnitFb.AutoSize = true;
            this.lblUnitFb.Location = new System.Drawing.Point(152, 78);
            this.lblUnitFb.Name = "lblUnitFb";
            this.lblUnitFb.Size = new System.Drawing.Size(20, 13);
            this.lblUnitFb.TabIndex = 7;
            this.lblUnitFb.Text = "Hz";
            // 
            // txtFb
            // 
            this.txtFb.Location = new System.Drawing.Point(46, 75);
            this.txtFb.Name = "txtFb";
            this.txtFb.Size = new System.Drawing.Size(100, 20);
            this.txtFb.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(21, 78);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(19, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Fb";
            // 
            // lblVbUnits
            // 
            this.lblVbUnits.AutoSize = true;
            this.lblVbUnits.Location = new System.Drawing.Point(153, 51);
            this.lblVbUnits.Name = "lblVbUnits";
            this.lblVbUnits.Size = new System.Drawing.Size(9, 13);
            this.lblVbUnits.TabIndex = 4;
            this.lblVbUnits.Text = "l";
            // 
            // txtVb
            // 
            this.txtVb.Location = new System.Drawing.Point(47, 48);
            this.txtVb.Name = "txtVb";
            this.txtVb.Size = new System.Drawing.Size(100, 20);
            this.txtVb.TabIndex = 3;
            // 
            // lblVb
            // 
            this.lblVb.AutoSize = true;
            this.lblVb.Location = new System.Drawing.Point(21, 51);
            this.lblVb.Name = "lblVb";
            this.lblVb.Size = new System.Drawing.Size(20, 13);
            this.lblVb.TabIndex = 1;
            this.lblVb.Text = "Vb";
            // 
            // grpDriver
            // 
            this.grpDriver.Controls.Add(this.lblUnitXmax);
            this.grpDriver.Controls.Add(this.lblUnitSd);
            this.grpDriver.Controls.Add(this.lblXmax);
            this.grpDriver.Controls.Add(this.lblSd);
            this.grpDriver.Controls.Add(this.txtXmax);
            this.grpDriver.Controls.Add(this.txtSd);
            this.grpDriver.Controls.Add(this.lblUnitFs);
            this.grpDriver.Controls.Add(this.lblFs);
            this.grpDriver.Controls.Add(this.txtFs);
            this.grpDriver.Controls.Add(this.lblVasUnits);
            this.grpDriver.Controls.Add(this.txtVas);
            this.grpDriver.Controls.Add(this.txtQts);
            this.grpDriver.Controls.Add(this.lblVas);
            this.grpDriver.Controls.Add(this.lblQts);
            this.grpDriver.Location = new System.Drawing.Point(12, 12);
            this.grpDriver.Name = "grpDriver";
            this.grpDriver.Size = new System.Drawing.Size(200, 153);
            this.grpDriver.TabIndex = 5;
            this.grpDriver.TabStop = false;
            this.grpDriver.Text = "Driver";
            // 
            // lblUnitXmax
            // 
            this.lblUnitXmax.AutoSize = true;
            this.lblUnitXmax.Location = new System.Drawing.Point(153, 128);
            this.lblUnitXmax.Name = "lblUnitXmax";
            this.lblUnitXmax.Size = new System.Drawing.Size(23, 13);
            this.lblUnitXmax.TabIndex = 14;
            this.lblUnitXmax.Text = "mm";
            // 
            // lblUnitSd
            // 
            this.lblUnitSd.AutoSize = true;
            this.lblUnitSd.Location = new System.Drawing.Point(154, 101);
            this.lblUnitSd.Name = "lblUnitSd";
            this.lblUnitSd.Size = new System.Drawing.Size(33, 13);
            this.lblUnitSd.TabIndex = 13;
            this.lblUnitSd.Text = "cm^2";
            // 
            // lblXmax
            // 
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(9, 128);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(33, 13);
            this.lblXmax.TabIndex = 12;
            this.lblXmax.Text = "Xmax";
            // 
            // lblSd
            // 
            this.lblSd.AutoSize = true;
            this.lblSd.Location = new System.Drawing.Point(22, 101);
            this.lblSd.Name = "lblSd";
            this.lblSd.Size = new System.Drawing.Size(20, 13);
            this.lblSd.TabIndex = 11;
            this.lblSd.Text = "Sd";
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(48, 125);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(100, 20);
            this.txtXmax.TabIndex = 10;
            // 
            // txtSd
            // 
            this.txtSd.Location = new System.Drawing.Point(48, 98);
            this.txtSd.Name = "txtSd";
            this.txtSd.Size = new System.Drawing.Size(100, 20);
            this.txtSd.TabIndex = 9;
            // 
            // lblUnitFs
            // 
            this.lblUnitFs.AutoSize = true;
            this.lblUnitFs.Location = new System.Drawing.Point(154, 74);
            this.lblUnitFs.Name = "lblUnitFs";
            this.lblUnitFs.Size = new System.Drawing.Size(20, 13);
            this.lblUnitFs.TabIndex = 8;
            this.lblUnitFs.Text = "Hz";
            // 
            // lblFs
            // 
            this.lblFs.AutoSize = true;
            this.lblFs.Location = new System.Drawing.Point(23, 74);
            this.lblFs.Name = "lblFs";
            this.lblFs.Size = new System.Drawing.Size(18, 13);
            this.lblFs.TabIndex = 6;
            this.lblFs.Text = "Fs";
            // 
            // txtFs
            // 
            this.txtFs.Location = new System.Drawing.Point(48, 71);
            this.txtFs.Name = "txtFs";
            this.txtFs.Size = new System.Drawing.Size(100, 20);
            this.txtFs.TabIndex = 5;
            // 
            // lblVasUnits
            // 
            this.lblVasUnits.AutoSize = true;
            this.lblVasUnits.Location = new System.Drawing.Point(154, 47);
            this.lblVasUnits.Name = "lblVasUnits";
            this.lblVasUnits.Size = new System.Drawing.Size(9, 13);
            this.lblVasUnits.TabIndex = 4;
            this.lblVasUnits.Text = "l";
            // 
            // txtVas
            // 
            this.txtVas.Location = new System.Drawing.Point(47, 44);
            this.txtVas.Name = "txtVas";
            this.txtVas.Size = new System.Drawing.Size(100, 20);
            this.txtVas.TabIndex = 3;
            // 
            // txtQts
            // 
            this.txtQts.Location = new System.Drawing.Point(48, 17);
            this.txtQts.Name = "txtQts";
            this.txtQts.Size = new System.Drawing.Size(100, 20);
            this.txtQts.TabIndex = 2;
            // 
            // lblVas
            // 
            this.lblVas.AutoSize = true;
            this.lblVas.Location = new System.Drawing.Point(16, 47);
            this.lblVas.Name = "lblVas";
            this.lblVas.Size = new System.Drawing.Size(25, 13);
            this.lblVas.TabIndex = 1;
            this.lblVas.Text = "Vas";
            // 
            // lblQts
            // 
            this.lblQts.AutoSize = true;
            this.lblQts.Location = new System.Drawing.Point(19, 20);
            this.lblQts.Name = "lblQts";
            this.lblQts.Size = new System.Drawing.Size(23, 13);
            this.lblQts.TabIndex = 0;
            this.lblQts.Text = "Qts";
            // 
            // grpPort
            // 
            this.grpPort.Controls.Add(this.label2);
            this.grpPort.Controls.Add(this.txtWidth);
            this.grpPort.Controls.Add(this.lblWidth);
            this.grpPort.Controls.Add(this.lblUnitPortThickness);
            this.grpPort.Controls.Add(this.txtPortWallThickness);
            this.grpPort.Controls.Add(this.lblWallThickness);
            this.grpPort.Controls.Add(this.lblUnitDiameter);
            this.grpPort.Controls.Add(this.lblUnitPortLength);
            this.grpPort.Controls.Add(this.txtNumofPort);
            this.grpPort.Controls.Add(this.lblNumPorts);
            this.grpPort.Controls.Add(this.txtPortLength);
            this.grpPort.Controls.Add(this.txtPortDiameter);
            this.grpPort.Controls.Add(this.lblDiameter);
            this.grpPort.Controls.Add(this.lblPortLength);
            this.grpPort.Location = new System.Drawing.Point(218, 12);
            this.grpPort.Name = "grpPort";
            this.grpPort.Size = new System.Drawing.Size(164, 153);
            this.grpPort.TabIndex = 11;
            this.grpPort.TabStop = false;
            this.grpPort.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "in";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(86, 69);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(49, 20);
            this.txtWidth.TabIndex = 20;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(40, 71);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 19;
            this.lblWidth.Text = "Width";
            this.lblWidth.Visible = false;
            // 
            // lblUnitPortThickness
            // 
            this.lblUnitPortThickness.AutoSize = true;
            this.lblUnitPortThickness.Location = new System.Drawing.Point(143, 128);
            this.lblUnitPortThickness.Name = "lblUnitPortThickness";
            this.lblUnitPortThickness.Size = new System.Drawing.Size(15, 13);
            this.lblUnitPortThickness.TabIndex = 18;
            this.lblUnitPortThickness.Text = "in";
            // 
            // txtPortWallThickness
            // 
            this.txtPortWallThickness.Location = new System.Drawing.Point(86, 121);
            this.txtPortWallThickness.Name = "txtPortWallThickness";
            this.txtPortWallThickness.ReadOnly = true;
            this.txtPortWallThickness.Size = new System.Drawing.Size(50, 20);
            this.txtPortWallThickness.TabIndex = 17;
            // 
            // lblWallThickness
            // 
            this.lblWallThickness.AutoSize = true;
            this.lblWallThickness.Location = new System.Drawing.Point(0, 124);
            this.lblWallThickness.Name = "lblWallThickness";
            this.lblWallThickness.Size = new System.Drawing.Size(80, 13);
            this.lblWallThickness.TabIndex = 16;
            this.lblWallThickness.Text = "Wall Thickness";
            this.lblWallThickness.Click += new System.EventHandler(this.lblWallThickness_Click);
            // 
            // lblUnitDiameter
            // 
            this.lblUnitDiameter.AutoSize = true;
            this.lblUnitDiameter.Location = new System.Drawing.Point(141, 46);
            this.lblUnitDiameter.Name = "lblUnitDiameter";
            this.lblUnitDiameter.Size = new System.Drawing.Size(15, 13);
            this.lblUnitDiameter.TabIndex = 10;
            this.lblUnitDiameter.Text = "in";
            // 
            // lblUnitPortLength
            // 
            this.lblUnitPortLength.AutoSize = true;
            this.lblUnitPortLength.Location = new System.Drawing.Point(141, 20);
            this.lblUnitPortLength.Name = "lblUnitPortLength";
            this.lblUnitPortLength.Size = new System.Drawing.Size(15, 13);
            this.lblUnitPortLength.TabIndex = 9;
            this.lblUnitPortLength.Text = "in";
            // 
            // txtNumofPort
            // 
            this.txtNumofPort.Location = new System.Drawing.Point(86, 95);
            this.txtNumofPort.Name = "txtNumofPort";
            this.txtNumofPort.ReadOnly = true;
            this.txtNumofPort.Size = new System.Drawing.Size(25, 20);
            this.txtNumofPort.TabIndex = 5;
            // 
            // lblNumPorts
            // 
            this.lblNumPorts.AutoSize = true;
            this.lblNumPorts.Location = new System.Drawing.Point(17, 98);
            this.lblNumPorts.Name = "lblNumPorts";
            this.lblNumPorts.Size = new System.Drawing.Size(63, 13);
            this.lblNumPorts.TabIndex = 4;
            this.lblNumPorts.Text = "Num of Port";
            // 
            // txtPortLength
            // 
            this.txtPortLength.Location = new System.Drawing.Point(86, 17);
            this.txtPortLength.Name = "txtPortLength";
            this.txtPortLength.ReadOnly = true;
            this.txtPortLength.Size = new System.Drawing.Size(49, 20);
            this.txtPortLength.TabIndex = 3;
            // 
            // txtPortDiameter
            // 
            this.txtPortDiameter.Location = new System.Drawing.Point(86, 43);
            this.txtPortDiameter.Name = "txtPortDiameter";
            this.txtPortDiameter.ReadOnly = true;
            this.txtPortDiameter.Size = new System.Drawing.Size(49, 20);
            this.txtPortDiameter.TabIndex = 2;
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(31, 46);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(49, 13);
            this.lblDiameter.TabIndex = 1;
            this.lblDiameter.Text = "Diameter";
            // 
            // lblPortLength
            // 
            this.lblPortLength.AutoSize = true;
            this.lblPortLength.Location = new System.Drawing.Point(40, 20);
            this.lblPortLength.Name = "lblPortLength";
            this.lblPortLength.Size = new System.Drawing.Size(40, 13);
            this.lblPortLength.TabIndex = 0;
            this.lblPortLength.Text = "Length";
            // 
            // btnLoadDriver
            // 
            this.btnLoadDriver.Location = new System.Drawing.Point(218, 183);
            this.btnLoadDriver.Name = "btnLoadDriver";
            this.btnLoadDriver.Size = new System.Drawing.Size(107, 23);
            this.btnLoadDriver.TabIndex = 12;
            this.btnLoadDriver.Text = "Load Driver";
            this.btnLoadDriver.UseVisualStyleBackColor = true;
            this.btnLoadDriver.Click += new System.EventHandler(this.btnLoadDriver_Click);
            // 
            // ofdWDR
            // 
            this.ofdWDR.Filter = "WinISD(*.wdr)|*.wdr";
            // 
            // btnDrawVelocity
            // 
            this.btnDrawVelocity.Location = new System.Drawing.Point(218, 270);
            this.btnDrawVelocity.Name = "btnDrawVelocity";
            this.btnDrawVelocity.Size = new System.Drawing.Size(107, 23);
            this.btnDrawVelocity.TabIndex = 13;
            this.btnDrawVelocity.Text = "Draw Velocity";
            this.btnDrawVelocity.UseVisualStyleBackColor = true;
            this.btnDrawVelocity.Visible = false;
            this.btnDrawVelocity.Click += new System.EventHandler(this.btnDrawVelocity_Click);
            // 
            // frmPorted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 377);
            this.Controls.Add(this.btnDrawVelocity);
            this.Controls.Add(this.btnLoadDriver);
            this.Controls.Add(this.grpPort);
            this.Controls.Add(this.btnEnclosureDesign);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.btnCalculateVbFb);
            this.Controls.Add(this.grpEnclosure);
            this.Controls.Add(this.grpDriver);
            this.Name = "frmPorted";
            this.Text = "frmPorted";
            this.grpEnclosure.ResumeLayout(false);
            this.grpEnclosure.PerformLayout();
            this.grpDriver.ResumeLayout(false);
            this.grpDriver.PerformLayout();
            this.grpPort.ResumeLayout(false);
            this.grpPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnclosureDesign;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnCalculateVbFb;
        private System.Windows.Forms.GroupBox grpEnclosure;
        private System.Windows.Forms.Label lblVbUnits;
        private System.Windows.Forms.TextBox txtVb;
        private System.Windows.Forms.Label lblVb;
        private System.Windows.Forms.GroupBox grpDriver;
        private System.Windows.Forms.Label lblVasUnits;
        private System.Windows.Forms.TextBox txtVas;
        private System.Windows.Forms.TextBox txtQts;
        private System.Windows.Forms.Label lblVas;
        private System.Windows.Forms.Label lblQts;
        private System.Windows.Forms.Label lblUnitFb;
        private System.Windows.Forms.TextBox txtFb;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblUnitFs;
        private System.Windows.Forms.Label lblFs;
        private System.Windows.Forms.TextBox txtFs;
        private System.Windows.Forms.Label lblUnitXmax;
        private System.Windows.Forms.Label lblUnitSd;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.Label lblSd;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtSd;
        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.Label lblUnitPortThickness;
        private System.Windows.Forms.TextBox txtPortWallThickness;
        private System.Windows.Forms.Label lblWallThickness;
        private System.Windows.Forms.Label lblUnitDiameter;
        private System.Windows.Forms.Label lblUnitPortLength;
        private System.Windows.Forms.TextBox txtNumofPort;
        private System.Windows.Forms.Label lblNumPorts;
        private System.Windows.Forms.TextBox txtPortLength;
        private System.Windows.Forms.TextBox txtPortDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblPortLength;
        private System.Windows.Forms.Button btnLoadDriver;
        private System.Windows.Forms.OpenFileDialog ofdWDR;
        private System.Windows.Forms.ComboBox cboAlignment;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUnitF3;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.Button btnDrawVelocity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPortType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
    }
}