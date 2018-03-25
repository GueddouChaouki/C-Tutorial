namespace Populating_ComboBox
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
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Publishing = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PublishingLabel = new DevComponents.DotNetBar.LabelX();
            this.Pages = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PagesLabel = new DevComponents.DotNetBar.LabelX();
            this.Author = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AuthorLabel = new DevComponents.DotNetBar.LabelX();
            this.Title = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TitleLabel = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Publishing)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Location = new System.Drawing.Point(12, 34);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(276, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 0;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Publishing);
            this.groupBox1.Controls.Add(this.PublishingLabel);
            this.groupBox1.Controls.Add(this.Pages);
            this.groupBox1.Controls.Add(this.PagesLabel);
            this.groupBox1.Controls.Add(this.Author);
            this.groupBox1.Controls.Add(this.AuthorLabel);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
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
            this.Publishing.Enabled = false;
            this.Publishing.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.Publishing.IsPopupCalendarOpen = false;
            this.Publishing.Location = new System.Drawing.Point(115, 97);
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
            this.Publishing.Size = new System.Drawing.Size(147, 20);
            this.Publishing.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Publishing.TabIndex = 12;
            // 
            // PublishingLabel
            // 
            // 
            // 
            // 
            this.PublishingLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PublishingLabel.Location = new System.Drawing.Point(12, 97);
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
            this.Pages.Enabled = false;
            this.Pages.ForeColor = System.Drawing.Color.Black;
            this.Pages.Location = new System.Drawing.Point(115, 71);
            this.Pages.Name = "Pages";
            this.Pages.PreventEnterBeep = true;
            this.Pages.Size = new System.Drawing.Size(147, 20);
            this.Pages.TabIndex = 9;
            // 
            // PagesLabel
            // 
            // 
            // 
            // 
            this.PagesLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PagesLabel.Location = new System.Drawing.Point(12, 68);
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
            this.Author.Enabled = false;
            this.Author.ForeColor = System.Drawing.Color.Black;
            this.Author.Location = new System.Drawing.Point(115, 45);
            this.Author.Name = "Author";
            this.Author.PreventEnterBeep = true;
            this.Author.Size = new System.Drawing.Size(147, 20);
            this.Author.TabIndex = 5;
            // 
            // AuthorLabel
            // 
            // 
            // 
            // 
            this.AuthorLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 42);
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
            this.Title.Enabled = false;
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(115, 19);
            this.Title.Name = "Title";
            this.Title.PreventEnterBeep = true;
            this.Title.Size = new System.Drawing.Size(147, 20);
            this.Title.TabIndex = 3;
            // 
            // TitleLabel
            // 
            // 
            // 
            // 
            this.TitleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TitleLabel.Location = new System.Drawing.Point(12, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(75, 23);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxEx1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Publishing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Publishing;
        private DevComponents.DotNetBar.LabelX PublishingLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Pages;
        private DevComponents.DotNetBar.LabelX PagesLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Author;
        private DevComponents.DotNetBar.LabelX AuthorLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Title;
        private DevComponents.DotNetBar.LabelX TitleLabel;
    }
}

