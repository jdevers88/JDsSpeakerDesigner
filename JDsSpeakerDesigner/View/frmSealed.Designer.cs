namespace View
{
    partial class frmSealed
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
            this.grpDriver = new System.Windows.Forms.GroupBox();
            this.lblQes = new System.Windows.Forms.Label();
            this.txtQes = new System.Windows.Forms.TextBox();
            this.lblUnitFs = new System.Windows.Forms.Label();
            this.lblFs = new System.Windows.Forms.Label();
            this.txtFs = new System.Windows.Forms.TextBox();
            this.lblVasUnits = new System.Windows.Forms.Label();
            this.txtVas = new System.Windows.Forms.TextBox();
            this.txtQts = new System.Windows.Forms.TextBox();
            this.lblVas = new System.Windows.Forms.Label();
            this.lblQts = new System.Windows.Forms.Label();
            this.grpEnclosure = new System.Windows.Forms.GroupBox();
            this.lblUnitFb = new System.Windows.Forms.Label();
            this.txtFb = new System.Windows.Forms.TextBox();
            this.lblFb = new System.Windows.Forms.Label();
            this.lblVbUnits = new System.Windows.Forms.Label();
            this.txtVb = new System.Windows.Forms.TextBox();
            this.txtQtc = new System.Windows.Forms.TextBox();
            this.lblVb = new System.Windows.Forms.Label();
            this.lblQtc = new System.Windows.Forms.Label();
            this.btnCalculateVb = new System.Windows.Forms.Button();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnEnclosureDesign = new System.Windows.Forms.Button();
            this.txtF3 = new System.Windows.Forms.TextBox();
            this.lblF3 = new System.Windows.Forms.Label();
            this.lblF3Unit = new System.Windows.Forms.Label();
            this.btnLoadDriver = new System.Windows.Forms.Button();
            this.ofdWDR = new System.Windows.Forms.OpenFileDialog();
            this.grpDriver.SuspendLayout();
            this.grpEnclosure.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDriver
            // 
            this.grpDriver.Controls.Add(this.lblQes);
            this.grpDriver.Controls.Add(this.txtQes);
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
            this.grpDriver.Size = new System.Drawing.Size(200, 124);
            this.grpDriver.TabIndex = 0;
            this.grpDriver.TabStop = false;
            this.grpDriver.Text = "Driver";
            // 
            // lblQes
            // 
            this.lblQes.AutoSize = true;
            this.lblQes.Location = new System.Drawing.Point(16, 98);
            this.lblQes.Name = "lblQes";
            this.lblQes.Size = new System.Drawing.Size(26, 13);
            this.lblQes.TabIndex = 13;
            this.lblQes.Text = "Qes";
            // 
            // txtQes
            // 
            this.txtQes.Location = new System.Drawing.Point(48, 95);
            this.txtQes.Name = "txtQes";
            this.txtQes.Size = new System.Drawing.Size(100, 20);
            this.txtQes.TabIndex = 12;
            // 
            // lblUnitFs
            // 
            this.lblUnitFs.AutoSize = true;
            this.lblUnitFs.Location = new System.Drawing.Point(153, 73);
            this.lblUnitFs.Name = "lblUnitFs";
            this.lblUnitFs.Size = new System.Drawing.Size(20, 13);
            this.lblUnitFs.TabIndex = 11;
            this.lblUnitFs.Text = "Hz";
            // 
            // lblFs
            // 
            this.lblFs.AutoSize = true;
            this.lblFs.Location = new System.Drawing.Point(24, 72);
            this.lblFs.Name = "lblFs";
            this.lblFs.Size = new System.Drawing.Size(18, 13);
            this.lblFs.TabIndex = 10;
            this.lblFs.Text = "Fs";
            // 
            // txtFs
            // 
            this.txtFs.Location = new System.Drawing.Point(48, 69);
            this.txtFs.Name = "txtFs";
            this.txtFs.Size = new System.Drawing.Size(100, 20);
            this.txtFs.TabIndex = 9;
            // 
            // lblVasUnits
            // 
            this.lblVasUnits.AutoSize = true;
            this.lblVasUnits.Location = new System.Drawing.Point(153, 47);
            this.lblVasUnits.Name = "lblVasUnits";
            this.lblVasUnits.Size = new System.Drawing.Size(9, 13);
            this.lblVasUnits.TabIndex = 4;
            this.lblVasUnits.Text = "l";
            // 
            // txtVas
            // 
            this.txtVas.Location = new System.Drawing.Point(48, 43);
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
            this.lblVas.Location = new System.Drawing.Point(17, 47);
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
            // grpEnclosure
            // 
            this.grpEnclosure.Controls.Add(this.lblF3Unit);
            this.grpEnclosure.Controls.Add(this.lblF3);
            this.grpEnclosure.Controls.Add(this.txtF3);
            this.grpEnclosure.Controls.Add(this.lblUnitFb);
            this.grpEnclosure.Controls.Add(this.txtFb);
            this.grpEnclosure.Controls.Add(this.lblFb);
            this.grpEnclosure.Controls.Add(this.lblVbUnits);
            this.grpEnclosure.Controls.Add(this.txtVb);
            this.grpEnclosure.Controls.Add(this.txtQtc);
            this.grpEnclosure.Controls.Add(this.lblVb);
            this.grpEnclosure.Controls.Add(this.lblQtc);
            this.grpEnclosure.Location = new System.Drawing.Point(12, 142);
            this.grpEnclosure.Name = "grpEnclosure";
            this.grpEnclosure.Size = new System.Drawing.Size(200, 127);
            this.grpEnclosure.TabIndex = 1;
            this.grpEnclosure.TabStop = false;
            this.grpEnclosure.Text = "Enclosure";
            // 
            // lblUnitFb
            // 
            this.lblUnitFb.AutoSize = true;
            this.lblUnitFb.Location = new System.Drawing.Point(154, 76);
            this.lblUnitFb.Name = "lblUnitFb";
            this.lblUnitFb.Size = new System.Drawing.Size(20, 13);
            this.lblUnitFb.TabIndex = 10;
            this.lblUnitFb.Text = "Hz";
            // 
            // txtFb
            // 
            this.txtFb.Location = new System.Drawing.Point(48, 72);
            this.txtFb.Name = "txtFb";
            this.txtFb.ReadOnly = true;
            this.txtFb.Size = new System.Drawing.Size(100, 20);
            this.txtFb.TabIndex = 9;
            // 
            // lblFb
            // 
            this.lblFb.AutoSize = true;
            this.lblFb.Location = new System.Drawing.Point(23, 76);
            this.lblFb.Name = "lblFb";
            this.lblFb.Size = new System.Drawing.Size(19, 13);
            this.lblFb.TabIndex = 8;
            this.lblFb.Text = "Fb";
            // 
            // lblVbUnits
            // 
            this.lblVbUnits.AutoSize = true;
            this.lblVbUnits.Location = new System.Drawing.Point(154, 49);
            this.lblVbUnits.Name = "lblVbUnits";
            this.lblVbUnits.Size = new System.Drawing.Size(9, 13);
            this.lblVbUnits.TabIndex = 4;
            this.lblVbUnits.Text = "l";
            // 
            // txtVb
            // 
            this.txtVb.Location = new System.Drawing.Point(48, 46);
            this.txtVb.Name = "txtVb";
            this.txtVb.ReadOnly = true;
            this.txtVb.Size = new System.Drawing.Size(100, 20);
            this.txtVb.TabIndex = 3;
            // 
            // txtQtc
            // 
            this.txtQtc.Location = new System.Drawing.Point(48, 20);
            this.txtQtc.Name = "txtQtc";
            this.txtQtc.Size = new System.Drawing.Size(100, 20);
            this.txtQtc.TabIndex = 2;
            // 
            // lblVb
            // 
            this.lblVb.AutoSize = true;
            this.lblVb.Location = new System.Drawing.Point(22, 50);
            this.lblVb.Name = "lblVb";
            this.lblVb.Size = new System.Drawing.Size(20, 13);
            this.lblVb.TabIndex = 1;
            this.lblVb.Text = "Vb";
            // 
            // lblQtc
            // 
            this.lblQtc.AutoSize = true;
            this.lblQtc.Location = new System.Drawing.Point(18, 23);
            this.lblQtc.Name = "lblQtc";
            this.lblQtc.Size = new System.Drawing.Size(24, 13);
            this.lblQtc.TabIndex = 0;
            this.lblQtc.Text = "Qtc";
            // 
            // btnCalculateVb
            // 
            this.btnCalculateVb.Location = new System.Drawing.Point(12, 291);
            this.btnCalculateVb.Name = "btnCalculateVb";
            this.btnCalculateVb.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateVb.TabIndex = 2;
            this.btnCalculateVb.Text = "Calculate Vb";
            this.btnCalculateVb.UseVisualStyleBackColor = true;
            this.btnCalculateVb.Click += new System.EventHandler(this.btnCalculateVb_Click);
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(218, 41);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(107, 23);
            this.btnDrawGraph.TabIndex = 3;
            this.btnDrawGraph.Text = "Draw Graph";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Visible = false;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // btnEnclosureDesign
            // 
            this.btnEnclosureDesign.Location = new System.Drawing.Point(218, 12);
            this.btnEnclosureDesign.Name = "btnEnclosureDesign";
            this.btnEnclosureDesign.Size = new System.Drawing.Size(107, 23);
            this.btnEnclosureDesign.TabIndex = 4;
            this.btnEnclosureDesign.Text = "Enclosure Design";
            this.btnEnclosureDesign.UseVisualStyleBackColor = true;
            this.btnEnclosureDesign.Visible = false;
            this.btnEnclosureDesign.Click += new System.EventHandler(this.btnEnclosureDesign_Click);
            // 
            // txtF3
            // 
            this.txtF3.Location = new System.Drawing.Point(47, 98);
            this.txtF3.Name = "txtF3";
            this.txtF3.ReadOnly = true;
            this.txtF3.Size = new System.Drawing.Size(100, 20);
            this.txtF3.TabIndex = 11;
            // 
            // lblF3
            // 
            this.lblF3.AutoSize = true;
            this.lblF3.Location = new System.Drawing.Point(22, 103);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(19, 13);
            this.lblF3.TabIndex = 12;
            this.lblF3.Text = "F3";
            // 
            // lblF3Unit
            // 
            this.lblF3Unit.AutoSize = true;
            this.lblF3Unit.Location = new System.Drawing.Point(154, 101);
            this.lblF3Unit.Name = "lblF3Unit";
            this.lblF3Unit.Size = new System.Drawing.Size(20, 13);
            this.lblF3Unit.TabIndex = 13;
            this.lblF3Unit.Text = "Hz";
            // 
            // btnLoadDriver
            // 
            this.btnLoadDriver.Location = new System.Drawing.Point(218, 291);
            this.btnLoadDriver.Name = "btnLoadDriver";
            this.btnLoadDriver.Size = new System.Drawing.Size(107, 23);
            this.btnLoadDriver.TabIndex = 5;
            this.btnLoadDriver.Text = "Load Driver";
            this.btnLoadDriver.UseVisualStyleBackColor = true;
            this.btnLoadDriver.Click += new System.EventHandler(this.btnLoadDriver_Click);
            // 
            // ofdWDR
            // 
            this.ofdWDR.Filter = "WinISD(*.wdr)|*.wdr";
            // 
            // frmSealed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 326);
            this.Controls.Add(this.btnLoadDriver);
            this.Controls.Add(this.btnEnclosureDesign);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.btnCalculateVb);
            this.Controls.Add(this.grpEnclosure);
            this.Controls.Add(this.grpDriver);
            this.Name = "frmSealed";
            this.Text = "Sealed Vb Calculator";
            this.grpDriver.ResumeLayout(false);
            this.grpDriver.PerformLayout();
            this.grpEnclosure.ResumeLayout(false);
            this.grpEnclosure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDriver;
        private System.Windows.Forms.TextBox txtVas;
        private System.Windows.Forms.TextBox txtQts;
        private System.Windows.Forms.Label lblVas;
        private System.Windows.Forms.Label lblQts;
        private System.Windows.Forms.GroupBox grpEnclosure;
        private System.Windows.Forms.TextBox txtVb;
        private System.Windows.Forms.TextBox txtQtc;
        private System.Windows.Forms.Label lblVb;
        private System.Windows.Forms.Label lblQtc;
        private System.Windows.Forms.Button btnCalculateVb;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnEnclosureDesign;
        private System.Windows.Forms.Label lblVasUnits;
        private System.Windows.Forms.Label lblVbUnits;
        private System.Windows.Forms.Label lblUnitFs;
        private System.Windows.Forms.Label lblFs;
        private System.Windows.Forms.TextBox txtFs;
        private System.Windows.Forms.Label lblQes;
        private System.Windows.Forms.TextBox txtQes;
        private System.Windows.Forms.Label lblUnitFb;
        private System.Windows.Forms.TextBox txtFb;
        private System.Windows.Forms.Label lblFb;
        private System.Windows.Forms.Label lblF3Unit;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.Button btnLoadDriver;
        private System.Windows.Forms.OpenFileDialog ofdWDR;
    }
}