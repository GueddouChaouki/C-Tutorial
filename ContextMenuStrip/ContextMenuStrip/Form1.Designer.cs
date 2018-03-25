namespace ContextMenuStrip
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ktfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ytdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ytdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fhtdhtdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yjgjygjyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jgjyfjyfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kfToolStripMenuItem,
            this.fhtdhtdToolStripMenuItem,
            this.yjgjygjyToolStripMenuItem,
            this.jgjyfjyfToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // kfToolStripMenuItem
            // 
            this.kfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ktfToolStripMenuItem});
            this.kfToolStripMenuItem.Name = "kfToolStripMenuItem";
            this.kfToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kfToolStripMenuItem.Text = "kf";
            // 
            // ktfToolStripMenuItem
            // 
            this.ktfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ytdToolStripMenuItem});
            this.ktfToolStripMenuItem.Name = "ktfToolStripMenuItem";
            this.ktfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ktfToolStripMenuItem.Text = "ktf";
            // 
            // ytdToolStripMenuItem
            // 
            this.ytdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ytdToolStripMenuItem1});
            this.ytdToolStripMenuItem.Name = "ytdToolStripMenuItem";
            this.ytdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ytdToolStripMenuItem.Text = "ytd";
            // 
            // ytdToolStripMenuItem1
            // 
            this.ytdToolStripMenuItem1.Name = "ytdToolStripMenuItem1";
            this.ytdToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ytdToolStripMenuItem1.Text = "ytd";
            // 
            // fhtdhtdToolStripMenuItem
            // 
            this.fhtdhtdToolStripMenuItem.Name = "fhtdhtdToolStripMenuItem";
            this.fhtdhtdToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.fhtdhtdToolStripMenuItem.Text = "fhtdhtd";
            // 
            // yjgjygjyToolStripMenuItem
            // 
            this.yjgjygjyToolStripMenuItem.Name = "yjgjygjyToolStripMenuItem";
            this.yjgjygjyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.yjgjygjyToolStripMenuItem.Text = "yjgjygjy";
            // 
            // jgjyfjyfToolStripMenuItem
            // 
            this.jgjyfjyfToolStripMenuItem.Name = "jgjyfjyfToolStripMenuItem";
            this.jgjyfjyfToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.jgjyfjyfToolStripMenuItem.Text = "jgjyfjyf";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ktfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ytdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ytdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fhtdhtdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yjgjygjyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jgjyfjyfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

