namespace checkBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxCSharp = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxJava = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxPaython = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxHTML = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxCPlusPlus = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkBoxCSharp
            // 
            // 
            // 
            // 
            this.checkBoxCSharp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxCSharp.Checked = true;
            this.checkBoxCSharp.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxCSharp.CheckValue = null;
            this.checkBoxCSharp.Location = new System.Drawing.Point(22, 56);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(100, 23);
            this.checkBoxCSharp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxCSharp.TabIndex = 0;
            this.checkBoxCSharp.Text = "C#";
            // 
            // checkBoxJava
            // 
            // 
            // 
            // 
            this.checkBoxJava.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxJava.Location = new System.Drawing.Point(22, 85);
            this.checkBoxJava.Name = "checkBoxJava";
            this.checkBoxJava.Size = new System.Drawing.Size(100, 23);
            this.checkBoxJava.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxJava.TabIndex = 1;
            this.checkBoxJava.Text = "Java";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(164, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "What is your favourt Language";
            // 
            // checkBoxPaython
            // 
            // 
            // 
            // 
            this.checkBoxPaython.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxPaython.Location = new System.Drawing.Point(22, 146);
            this.checkBoxPaython.Name = "checkBoxPaython";
            this.checkBoxPaython.Size = new System.Drawing.Size(100, 23);
            this.checkBoxPaython.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxPaython.TabIndex = 3;
            this.checkBoxPaython.Text = "Paython";
            // 
            // checkBoxHTML
            // 
            // 
            // 
            // 
            this.checkBoxHTML.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxHTML.Location = new System.Drawing.Point(22, 175);
            this.checkBoxHTML.Name = "checkBoxHTML";
            this.checkBoxHTML.Size = new System.Drawing.Size(100, 23);
            this.checkBoxHTML.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxHTML.TabIndex = 4;
            this.checkBoxHTML.Text = "HTML";
            // 
            // checkBoxCPlusPlus
            // 
            // 
            // 
            // 
            this.checkBoxCPlusPlus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxCPlusPlus.Location = new System.Drawing.Point(22, 114);
            this.checkBoxCPlusPlus.Name = "checkBoxCPlusPlus";
            this.checkBoxCPlusPlus.Size = new System.Drawing.Size(100, 23);
            this.checkBoxCPlusPlus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxCPlusPlus.TabIndex = 5;
            this.checkBoxCPlusPlus.Text = "C++";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonX1.Location = new System.Drawing.Point(169, 214);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(103, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Answer";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "gssgfdg",
            "df",
            "hfdh",
            "fd",
            "hrd",
            "shb",
            "fdh"});
            this.checkedListBox1.Location = new System.Drawing.Point(128, 56);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.checkBoxCPlusPlus);
            this.Controls.Add(this.checkBoxHTML);
            this.Controls.Add(this.checkBoxPaython);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.checkBoxJava);
            this.Controls.Add(this.checkBoxCSharp);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxCSharp;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxJava;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxPaython;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxHTML;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxCPlusPlus;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

