namespace RadioButton
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
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.add = new DevComponents.DotNetBar.RadialMenuItem();
            this.minus = new DevComponents.DotNetBar.RadialMenuItem();
            this.mult = new DevComponents.DotNetBar.RadialMenuItem();
            this.division = new DevComponents.DotNetBar.RadialMenuItem();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelResult = new DevComponents.DotNetBar.LabelX();
            this.labelResultat = new DevComponents.DotNetBar.LabelX();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radialMenu1
            // 
            // 
            // 
            // 
            this.radialMenu1.Colors.RadialMenuItemDisabledForeground = System.Drawing.Color.Empty;
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.add,
            this.minus,
            this.mult,
            this.division});
            this.radialMenu1.Location = new System.Drawing.Point(214, 101);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(28, 28);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 13F;
            this.radialMenu1.TabIndex = 0;
            this.radialMenu1.Text = "radialMenu1";
            this.radialMenu1.ItemClick += new System.EventHandler(this.radialMenu1_ItemClick);
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Text = "add";
            // 
            // minus
            // 
            this.minus.Name = "minus";
            this.minus.Text = "minus";
            // 
            // mult
            // 
            this.mult.Name = "mult";
            this.mult.Text = "mult";
            // 
            // division
            // 
            this.division.Name = "division";
            this.division.Text = "division";
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(21, 92);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(43, 17);
            this.radioButtonAdd.TabIndex = 1;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(99, 92);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMinus.TabIndex = 2;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "minus";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            this.radioButtonMinus.CheckedChanged += new System.EventHandler(this.radioButtonMinus_CheckedChanged);
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(157, 11);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 3;
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(157, 50);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 4;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(130, 20);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Enter the first number";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(21, 50);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(130, 20);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Enter the second number";
            // 
            // labelResult
            // 
            // 
            // 
            // 
            this.labelResult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelResult.Location = new System.Drawing.Point(32, 157);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(75, 20);
            this.labelResult.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Result : ";
            // 
            // labelResultat
            // 
            // 
            // 
            // 
            this.labelResultat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelResultat.Location = new System.Drawing.Point(167, 157);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(90, 20);
            this.labelResultat.TabIndex = 8;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(99, 123);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDivision.TabIndex = 9;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            this.radioButtonDivision.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(21, 123);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(44, 17);
            this.radioButtonMult.TabIndex = 10;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "mult";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            this.radioButtonMult.CheckedChanged += new System.EventHandler(this.radioButtonMult_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.radioButtonMult);
            this.Controls.Add(this.radioButtonDivision);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.radioButtonMinus);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.radialMenu1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem add;
        private DevComponents.DotNetBar.RadialMenuItem minus;
        private DevComponents.DotNetBar.RadialMenuItem mult;
        private DevComponents.DotNetBar.RadialMenuItem division;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelResult;
        private DevComponents.DotNetBar.LabelX labelResultat;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonMult;
    }
}

