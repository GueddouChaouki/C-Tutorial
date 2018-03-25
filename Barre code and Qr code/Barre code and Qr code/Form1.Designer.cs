namespace Barre_code_and_Qr_code
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
            this.BarreCodeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BarreCodetextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QrCodetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QrCodeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarreCodeBtn
            // 
            this.BarreCodeBtn.Location = new System.Drawing.Point(353, 262);
            this.BarreCodeBtn.Name = "BarreCodeBtn";
            this.BarreCodeBtn.Size = new System.Drawing.Size(75, 23);
            this.BarreCodeBtn.TabIndex = 0;
            this.BarreCodeBtn.Text = "Barre Code";
            this.BarreCodeBtn.UseVisualStyleBackColor = true;
            this.BarreCodeBtn.Click += new System.EventHandler(this.BarreCodeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barre Code";
            // 
            // BarreCodetextBox
            // 
            this.BarreCodetextBox.Location = new System.Drawing.Point(78, 264);
            this.BarreCodetextBox.Name = "BarreCodetextBox";
            this.BarreCodetextBox.Size = new System.Drawing.Size(260, 20);
            this.BarreCodetextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 234);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // QrCodetextBox
            // 
            this.QrCodetextBox.Location = new System.Drawing.Point(78, 303);
            this.QrCodetextBox.Name = "QrCodetextBox";
            this.QrCodetextBox.Size = new System.Drawing.Size(260, 20);
            this.QrCodetextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barre Code";
            // 
            // QrCodeBtn
            // 
            this.QrCodeBtn.Location = new System.Drawing.Point(353, 303);
            this.QrCodeBtn.Name = "QrCodeBtn";
            this.QrCodeBtn.Size = new System.Drawing.Size(75, 23);
            this.QrCodeBtn.TabIndex = 4;
            this.QrCodeBtn.Text = "QrCode";
            this.QrCodeBtn.UseVisualStyleBackColor = true;
            this.QrCodeBtn.Click += new System.EventHandler(this.QrCodeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 365);
            this.Controls.Add(this.QrCodetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QrCodeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarreCodetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarreCodeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BarreCodeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarreCodetextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox QrCodetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QrCodeBtn;
    }
}

