namespace StoredProcedure
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Publishing = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PublishingLabel = new DevComponents.DotNetBar.LabelX();
            this.Pages = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PagesLabel = new DevComponents.DotNetBar.LabelX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IDLabel = new DevComponents.DotNetBar.LabelX();
            this.Author = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AuthorLabel = new DevComponents.DotNetBar.LabelX();
            this.Title = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TitleLabel = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Close = new DevComponents.DotNetBar.ButtonX();
            this.New = new DevComponents.DotNetBar.ButtonX();
            this.Add = new DevComponents.DotNetBar.ButtonX();
            this.Delete = new DevComponents.DotNetBar.ButtonX();
            this.Update = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Publishing)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Publishing);
            this.groupBox1.Controls.Add(this.PublishingLabel);
            this.groupBox1.Controls.Add(this.Pages);
            this.groupBox1.Controls.Add(this.PagesLabel);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.IDLabel);
            this.groupBox1.Controls.Add(this.Author);
            this.groupBox1.Controls.Add(this.AuthorLabel);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 199);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
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
            this.Publishing.Size = new System.Drawing.Size(143, 20);
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
            this.Pages.Size = new System.Drawing.Size(143, 20);
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
            this.ID.Size = new System.Drawing.Size(143, 20);
            this.ID.TabIndex = 7;
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
            this.Author.Size = new System.Drawing.Size(143, 20);
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
            this.Title.Size = new System.Drawing.Size(143, 20);
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
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Location = new System.Drawing.Point(283, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 199);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books list";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(348, 169);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.Click += new System.EventHandler(this.dataGridViewX1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Close);
            this.groupBox3.Controls.Add(this.New);
            this.groupBox3.Controls.Add(this.Add);
            this.groupBox3.Controls.Add(this.Delete);
            this.groupBox3.Controls.Add(this.Update);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(631, 44);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations list";
            // 
            // Close
            // 
            this.Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Close.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold);
            this.Close.Location = new System.Drawing.Point(501, 15);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 23);
            this.Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Close.TabIndex = 22;
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // New
            // 
            this.New.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.New.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.New.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(6, 15);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(130, 23);
            this.New.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.New.TabIndex = 21;
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Add
            // 
            this.Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Add.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold);
            this.Add.Location = new System.Drawing.Point(142, 15);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 23);
            this.Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Delete.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold);
            this.Delete.Location = new System.Drawing.Point(266, 15);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 23);
            this.Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Update.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold);
            this.Update.Location = new System.Drawing.Point(382, 15);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(113, 23);
            this.Update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Publishing)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Publishing;
        private DevComponents.DotNetBar.LabelX PublishingLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Pages;
        private DevComponents.DotNetBar.LabelX PagesLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX ID;
        private DevComponents.DotNetBar.LabelX IDLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Author;
        private DevComponents.DotNetBar.LabelX AuthorLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX Title;
        private DevComponents.DotNetBar.LabelX TitleLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX Close;
        private DevComponents.DotNetBar.ButtonX New;
        private DevComponents.DotNetBar.ButtonX Add;
        private DevComponents.DotNetBar.ButtonX Delete;
        private DevComponents.DotNetBar.ButtonX Update;
    }
}

