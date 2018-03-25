namespace ScrollBar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hScrollBarAdv1 = new DevComponents.DotNetBar.ScrollBar.HScrollBarAdv();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.hScrollBarAdv2 = new DevComponents.DotNetBar.ScrollBar.HScrollBarAdv();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.hScrollBarAdv3 = new DevComponents.DotNetBar.ScrollBar.HScrollBarAdv();
            this.SuspendLayout();
            // 
            // hScrollBarAdv1
            // 
            this.hScrollBarAdv1.BackColor = System.Drawing.Color.White;
            this.hScrollBarAdv1.ForeColor = System.Drawing.Color.Black;
            this.hScrollBarAdv1.Location = new System.Drawing.Point(81, 27);
            this.hScrollBarAdv1.Maximum = 255;
            this.hScrollBarAdv1.Name = "hScrollBarAdv1";
            this.hScrollBarAdv1.Size = new System.Drawing.Size(440, 23);
            this.hScrollBarAdv1.TabIndex = 0;
            this.hScrollBarAdv1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarAdv1_Scroll);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "RED";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "GREEN";
            // 
            // hScrollBarAdv2
            // 
            this.hScrollBarAdv2.BackColor = System.Drawing.Color.White;
            this.hScrollBarAdv2.ForeColor = System.Drawing.Color.Black;
            this.hScrollBarAdv2.Location = new System.Drawing.Point(80, 83);
            this.hScrollBarAdv2.Maximum = 255;
            this.hScrollBarAdv2.Name = "hScrollBarAdv2";
            this.hScrollBarAdv2.Size = new System.Drawing.Size(440, 23);
            this.hScrollBarAdv2.TabIndex = 2;
            this.hScrollBarAdv2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarAdv2_Scroll);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(13, 138);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(61, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "BLUE";
            // 
            // hScrollBarAdv3
            // 
            this.hScrollBarAdv3.BackColor = System.Drawing.Color.White;
            this.hScrollBarAdv3.ForeColor = System.Drawing.Color.Black;
            this.hScrollBarAdv3.Location = new System.Drawing.Point(81, 138);
            this.hScrollBarAdv3.Maximum = 255;
            this.hScrollBarAdv3.Name = "hScrollBarAdv3";
            this.hScrollBarAdv3.Size = new System.Drawing.Size(440, 23);
            this.hScrollBarAdv3.TabIndex = 4;
            this.hScrollBarAdv3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarAdv3_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 188);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.hScrollBarAdv3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.hScrollBarAdv2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.hScrollBarAdv1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ScrollBar.HScrollBarAdv hScrollBarAdv1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ScrollBar.HScrollBarAdv hScrollBarAdv2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ScrollBar.HScrollBarAdv hScrollBarAdv3;
    }
}

