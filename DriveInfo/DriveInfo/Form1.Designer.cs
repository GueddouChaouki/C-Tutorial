namespace DriveInfo
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.totalSpaceprogressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.usedSpaceProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.freeSpaceprogressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.totalSpaceLabel = new System.Windows.Forms.Label();
            this.freeSpaceLabel = new System.Windows.Forms.Label();
            this.usedSpaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonX1.Location = new System.Drawing.Point(34, 68);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(204, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Drive Informations";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // totalSpaceprogressBar
            // 
            // 
            // 
            // 
            this.totalSpaceprogressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.totalSpaceprogressBar.Location = new System.Drawing.Point(34, 140);
            this.totalSpaceprogressBar.Name = "totalSpaceprogressBar";
            this.totalSpaceprogressBar.Size = new System.Drawing.Size(204, 23);
            this.totalSpaceprogressBar.TabIndex = 1;
            this.totalSpaceprogressBar.Text = "totalSpaceprogressBar";
            // 
            // usedSpaceProgressBar
            // 
            // 
            // 
            // 
            this.usedSpaceProgressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usedSpaceProgressBar.Location = new System.Drawing.Point(34, 227);
            this.usedSpaceProgressBar.Name = "usedSpaceProgressBar";
            this.usedSpaceProgressBar.Size = new System.Drawing.Size(204, 23);
            this.usedSpaceProgressBar.TabIndex = 2;
            this.usedSpaceProgressBar.Text = "usedSpaceProgressBar";
            // 
            // freeSpaceprogressBar
            // 
            // 
            // 
            // 
            this.freeSpaceprogressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.freeSpaceprogressBar.Location = new System.Drawing.Point(34, 185);
            this.freeSpaceprogressBar.Name = "freeSpaceprogressBar";
            this.freeSpaceprogressBar.Size = new System.Drawing.Size(204, 23);
            this.freeSpaceprogressBar.TabIndex = 3;
            this.freeSpaceprogressBar.Text = "freeSpaceprogressBar";
            // 
            // totalSpaceLabel
            // 
            this.totalSpaceLabel.AutoSize = true;
            this.totalSpaceLabel.Location = new System.Drawing.Point(34, 121);
            this.totalSpaceLabel.Name = "totalSpaceLabel";
            this.totalSpaceLabel.Size = new System.Drawing.Size(58, 13);
            this.totalSpaceLabel.TabIndex = 4;
            this.totalSpaceLabel.Text = "totalSpace";
            // 
            // freeSpaceLabel
            // 
            this.freeSpaceLabel.AutoSize = true;
            this.freeSpaceLabel.Location = new System.Drawing.Point(34, 169);
            this.freeSpaceLabel.Name = "freeSpaceLabel";
            this.freeSpaceLabel.Size = new System.Drawing.Size(56, 13);
            this.freeSpaceLabel.TabIndex = 5;
            this.freeSpaceLabel.Text = "freeSpace";
            // 
            // usedSpaceLabel
            // 
            this.usedSpaceLabel.AutoSize = true;
            this.usedSpaceLabel.Location = new System.Drawing.Point(34, 211);
            this.usedSpaceLabel.Name = "usedSpaceLabel";
            this.usedSpaceLabel.Size = new System.Drawing.Size(61, 13);
            this.usedSpaceLabel.TabIndex = 6;
            this.usedSpaceLabel.Text = "usedSpace";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.usedSpaceLabel);
            this.Controls.Add(this.freeSpaceLabel);
            this.Controls.Add(this.totalSpaceLabel);
            this.Controls.Add(this.freeSpaceprogressBar);
            this.Controls.Add(this.usedSpaceProgressBar);
            this.Controls.Add(this.totalSpaceprogressBar);
            this.Controls.Add(this.buttonX1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.ProgressBarX totalSpaceprogressBar;
        private DevComponents.DotNetBar.Controls.ProgressBarX usedSpaceProgressBar;
        private DevComponents.DotNetBar.Controls.ProgressBarX freeSpaceprogressBar;
        private System.Windows.Forms.Label totalSpaceLabel;
        private System.Windows.Forms.Label freeSpaceLabel;
        private System.Windows.Forms.Label usedSpaceLabel;
    }
}

