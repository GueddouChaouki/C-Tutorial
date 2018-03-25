namespace Directory_DirectoryInfo
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.listBoxAdv1 = new DevComponents.DotNetBar.ListBoxAdv();
            this.listBoxAdv2 = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "by using Directory Class";
            // 
            // listBoxAdv1
            // 
            this.listBoxAdv1.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxAdv1.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxAdv1.CheckStateMember = null;
            this.listBoxAdv1.ContainerControlProcessDialogKey = true;
            this.listBoxAdv1.DragDropSupport = true;
            this.listBoxAdv1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBoxAdv1.Location = new System.Drawing.Point(12, 41);
            this.listBoxAdv1.Name = "listBoxAdv1";
            this.listBoxAdv1.Size = new System.Drawing.Size(459, 158);
            this.listBoxAdv1.TabIndex = 1;
            this.listBoxAdv1.Text = "listBoxAdv1";
            // 
            // listBoxAdv2
            // 
            this.listBoxAdv2.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxAdv2.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxAdv2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxAdv2.ContainerControlProcessDialogKey = true;
            this.listBoxAdv2.DragDropSupport = true;
            this.listBoxAdv2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBoxAdv2.Location = new System.Drawing.Point(12, 233);
            this.listBoxAdv2.Name = "listBoxAdv2";
            this.listBoxAdv2.Size = new System.Drawing.Size(459, 169);
            this.listBoxAdv2.TabIndex = 3;
            this.listBoxAdv2.Text = "listBoxAdv2";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 205);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(129, 22);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "by using DirectoryInfo Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 424);
            this.Controls.Add(this.listBoxAdv2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.listBoxAdv1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ListBoxAdv listBoxAdv1;
        private DevComponents.DotNetBar.ListBoxAdv listBoxAdv2;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}

