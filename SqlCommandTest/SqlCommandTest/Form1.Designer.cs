namespace SqlCommandTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Validate = new DevComponents.DotNetBar.ButtonX();
            this.Cancel = new DevComponents.DotNetBar.ButtonX();
            this.Publishing = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PublishingLabel = new DevComponents.DotNetBar.LabelX();
            this.Pages = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PagesLabel = new DevComponents.DotNetBar.LabelX();
            this.Author = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AuthorLabel = new DevComponents.DotNetBar.LabelX();
            this.Title = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TitleLabel = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IDLabel = new DevComponents.DotNetBar.LabelX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IDdelete = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.UpdateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Publishing)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.Validate);
            this.groupBox1.Controls.Add(this.Publishing);
            this.groupBox1.Controls.Add(this.PublishingLabel);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.Pages);
            this.groupBox1.Controls.Add(this.PagesLabel);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.IDLabel);
            this.groupBox1.Controls.Add(this.Author);
            this.groupBox1.Controls.Add(this.AuthorLabel);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add new Book";
            // 
            // Validate
            // 
            this.Validate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Validate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Validate.Location = new System.Drawing.Point(239, 193);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(59, 23);
            this.Validate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Validate.TabIndex = 2;
            this.Validate.Text = "Validate";
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // Cancel
            // 
            this.Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(109, 193);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(60, 23);
            this.Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Publishing
            // 
            // 
            // 
            // 
            this.Publishing.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Publishing.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Publishing.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.Publishing.ButtonDropDown.Visible = true;
            this.Publishing.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.Publishing.IsPopupCalendarOpen = false;
            this.Publishing.Location = new System.Drawing.Point(109, 165);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Publishing.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Publishing.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.Publishing.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.Publishing.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Publishing.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.Publishing.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.Publishing.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Publishing.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.Publishing.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Publishing.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Publishing.MonthCalendar.TodayButtonVisible = true;
            this.Publishing.Name = "Publishing";
            this.Publishing.Size = new System.Drawing.Size(189, 20);
            this.Publishing.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Publishing.TabIndex = 12;
            // 
            // PublishingLabel
            // 
            // 
            // 
            // 
            this.PublishingLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PublishingLabel.Location = new System.Drawing.Point(6, 165);
            this.PublishingLabel.Name = "PublishingLabel";
            this.PublishingLabel.Size = new System.Drawing.Size(97, 23);
            this.PublishingLabel.TabIndex = 10;
            this.PublishingLabel.Text = "Date of Publishing";
            // 
            // Pages
            // 
            this.Pages.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Pages.Border.Class = "TextBoxBorder";
            this.Pages.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Pages.DisabledBackColor = System.Drawing.Color.White;
            this.Pages.ForeColor = System.Drawing.Color.Black;
            this.Pages.Location = new System.Drawing.Point(109, 128);
            this.Pages.Name = "Pages";
            this.Pages.PreventEnterBeep = true;
            this.Pages.Size = new System.Drawing.Size(189, 20);
            this.Pages.TabIndex = 9;
            // 
            // PagesLabel
            // 
            // 
            // 
            // 
            this.PagesLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PagesLabel.Location = new System.Drawing.Point(6, 128);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(75, 23);
            this.PagesLabel.TabIndex = 8;
            this.PagesLabel.Text = "No Pages";
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Author.Border.Class = "TextBoxBorder";
            this.Author.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Author.DisabledBackColor = System.Drawing.Color.White;
            this.Author.ForeColor = System.Drawing.Color.Black;
            this.Author.Location = new System.Drawing.Point(109, 91);
            this.Author.Name = "Author";
            this.Author.PreventEnterBeep = true;
            this.Author.Size = new System.Drawing.Size(189, 20);
            this.Author.TabIndex = 5;
            // 
            // AuthorLabel
            // 
            // 
            // 
            // 
            this.AuthorLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AuthorLabel.Location = new System.Drawing.Point(6, 91);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(75, 23);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Title.Border.Class = "TextBoxBorder";
            this.Title.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Title.DisabledBackColor = System.Drawing.Color.White;
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(109, 54);
            this.Title.Name = "Title";
            this.Title.PreventEnterBeep = true;
            this.Title.Size = new System.Drawing.Size(189, 20);
            this.Title.TabIndex = 3;
            // 
            // TitleLabel
            // 
            // 
            // 
            // 
            this.TitleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TitleLabel.Location = new System.Drawing.Point(6, 54);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(75, 23);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Controls.Add(this.IDdelete);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Location = new System.Drawing.Point(13, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "delete a Book";
            // 
            // IDLabel
            // 
            // 
            // 
            // 
            this.IDLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IDLabel.Location = new System.Drawing.Point(6, 19);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(75, 23);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "ID";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            this.ID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ID.DisabledBackColor = System.Drawing.Color.White;
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.Location = new System.Drawing.Point(109, 22);
            this.ID.Name = "ID";
            this.ID.PreventEnterBeep = true;
            this.ID.Size = new System.Drawing.Size(189, 20);
            this.ID.TabIndex = 7;
            // 
            // IDdelete
            // 
            this.IDdelete.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.IDdelete.Border.Class = "TextBoxBorder";
            this.IDdelete.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IDdelete.DisabledBackColor = System.Drawing.Color.White;
            this.IDdelete.ForeColor = System.Drawing.Color.Black;
            this.IDdelete.Location = new System.Drawing.Point(56, 19);
            this.IDdelete.Name = "IDdelete";
            this.IDdelete.PreventEnterBeep = true;
            this.IDdelete.Size = new System.Drawing.Size(158, 20);
            this.IDdelete.TabIndex = 9;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 20);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "ID";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(226, 19);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 20);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "delete";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonX2);
            this.groupBox3.Controls.Add(this.UpdateTextBox);
            this.groupBox3.Controls.Add(this.labelX2);
            this.groupBox3.Location = new System.Drawing.Point(13, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "details of a Book";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(226, 19);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 20);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Text = "détails";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UpdateTextBox.Border.Class = "TextBoxBorder";
            this.UpdateTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UpdateTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.UpdateTextBox.ForeColor = System.Drawing.Color.Black;
            this.UpdateTextBox.Location = new System.Drawing.Point(56, 19);
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.PreventEnterBeep = true;
            this.UpdateTextBox.Size = new System.Drawing.Size(158, 20);
            this.UpdateTextBox.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 20);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "ID";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(175, 193);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(58, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 13;
            this.buttonX3.Text = "Update";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonX2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(340, 74);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Publishing)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX Cancel;
        private DevComponents.DotNetBar.ButtonX Validate;
        private DevComponents.DotNetBar.Controls.TextBoxX Pages;
        private DevComponents.DotNetBar.LabelX PagesLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Author;
        private DevComponents.DotNetBar.LabelX AuthorLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Title;
        private DevComponents.DotNetBar.LabelX TitleLabel;
        private DevComponents.DotNetBar.LabelX PublishingLabel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Publishing;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX ID;
        private DevComponents.DotNetBar.LabelX IDLabel;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX IDdelete;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX UpdateTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
    }
}

