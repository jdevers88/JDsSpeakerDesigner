namespace View
{
    partial class frmMainMenu
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            { 
             
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSealed = new System.Windows.Forms.Button();
            this.btnPorted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSealed
            // 
            this.btnSealed.Location = new System.Drawing.Point(13, 13);
            this.btnSealed.Name = "btnSealed";
            this.btnSealed.Size = new System.Drawing.Size(75, 23);
            this.btnSealed.TabIndex = 0;
            this.btnSealed.Text = "Sealed";
            this.btnSealed.UseVisualStyleBackColor = true;
            this.btnSealed.Click += new System.EventHandler(this.btnSealed_Click);
            // 
            // btnPorted
            // 
            this.btnPorted.Location = new System.Drawing.Point(184, 12);
            this.btnPorted.Name = "btnPorted";
            this.btnPorted.Size = new System.Drawing.Size(75, 23);
            this.btnPorted.TabIndex = 1;
            this.btnPorted.Text = "Ported";
            this.btnPorted.UseVisualStyleBackColor = true;
            this.btnPorted.Click += new System.EventHandler(this.btnPorted_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 51);
            this.Controls.Add(this.btnPorted);
            this.Controls.Add(this.btnSealed);
            this.Name = "frmMainMenu";
            this.Text = "Siberian\'s Speaker Designer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSealed;
        private System.Windows.Forms.Button btnPorted;

    }
}

