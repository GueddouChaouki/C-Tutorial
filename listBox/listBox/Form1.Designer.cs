namespace listBox
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
            this.listBoxAdv1 = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addButton = new DevComponents.DotNetBar.ButtonX();
            this.removeButton = new DevComponents.DotNetBar.ButtonX();
            this.removeAllButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
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
            this.listBoxAdv1.Location = new System.Drawing.Point(12, 32);
            this.listBoxAdv1.Name = "listBoxAdv1";
            this.listBoxAdv1.SelectionMode = DevComponents.DotNetBar.eSelectionMode.MultiSimple;
            this.listBoxAdv1.Size = new System.Drawing.Size(260, 169);
            this.listBoxAdv1.TabIndex = 0;
            this.listBoxAdv1.Text = "listBoxAdv";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "enter your name :";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX.Border.Class = "TextBoxBorder";
            this.textBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxX.ForeColor = System.Drawing.Color.Black;
            this.textBoxX.Location = new System.Drawing.Point(100, 3);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.PreventEnterBeep = true;
            this.textBoxX.Size = new System.Drawing.Size(135, 23);
            this.textBoxX.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addButton.Location = new System.Drawing.Point(241, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 23);
            this.addButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.removeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.removeButton.Location = new System.Drawing.Point(139, 208);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(132, 23);
            this.removeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "remove";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.removeAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.removeAllButton.Location = new System.Drawing.Point(13, 207);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(120, 23);
            this.removeAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.removeAllButton.TabIndex = 5;
            this.removeAllButton.Text = "removeAll";
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.listBoxAdv1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ListBoxAdv listBoxAdv1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX;
        private DevComponents.DotNetBar.ButtonX addButton;
        private DevComponents.DotNetBar.ButtonX removeButton;
        private DevComponents.DotNetBar.ButtonX removeAllButton;
    }
}

