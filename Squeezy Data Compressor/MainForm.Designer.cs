namespace Squeezy_Data_Compressor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Compress = new System.Windows.Forms.Button();
            this.btn_Decompress = new System.Windows.Forms.Button();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textCompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCompressionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickCompressJPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decompress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 386);
            this.label3.MaximumSize = new System.Drawing.Size(400, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 386);
            this.label4.MaximumSize = new System.Drawing.Size(400, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Compress
            // 
            this.btn_Compress.Location = new System.Drawing.Point(287, 551);
            this.btn_Compress.Name = "btn_Compress";
            this.btn_Compress.Size = new System.Drawing.Size(126, 54);
            this.btn_Compress.TabIndex = 5;
            this.btn_Compress.Text = "Compress";
            this.btn_Compress.UseVisualStyleBackColor = true;
            this.btn_Compress.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Decompress
            // 
            this.btn_Decompress.Location = new System.Drawing.Point(857, 551);
            this.btn_Decompress.Name = "btn_Decompress";
            this.btn_Decompress.Size = new System.Drawing.Size(146, 54);
            this.btn_Decompress.TabIndex = 7;
            this.btn_Decompress.Text = "Decompress";
            this.btn_Decompress.UseVisualStyleBackColor = true;
            this.btn_Decompress.Click += new System.EventHandler(this.btn_Decompress_Click);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(642, 551);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(152, 54);
            this.btn_SelectFile.TabIndex = 6;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(996, 120);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compress Text File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textCompressionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 42);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textCompressionToolStripMenuItem
            // 
            this.textCompressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textCompressionToolStripMenuItem1,
            this.quickCompressJPEGToolStripMenuItem});
            this.textCompressionToolStripMenuItem.Name = "textCompressionToolStripMenuItem";
            this.textCompressionToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.textCompressionToolStripMenuItem.Text = "Compress";
            // 
            // textCompressionToolStripMenuItem1
            // 
            this.textCompressionToolStripMenuItem1.Name = "textCompressionToolStripMenuItem1";
            this.textCompressionToolStripMenuItem1.Size = new System.Drawing.Size(344, 38);
            this.textCompressionToolStripMenuItem1.Text = "Text Compression";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // quickCompressJPEGToolStripMenuItem
            // 
            this.quickCompressJPEGToolStripMenuItem.Name = "quickCompressJPEGToolStripMenuItem";
            this.quickCompressJPEGToolStripMenuItem.Size = new System.Drawing.Size(344, 38);
            this.quickCompressJPEGToolStripMenuItem.Text = "Quick Compress JPEG";
            this.quickCompressJPEGToolStripMenuItem.Click += new System.EventHandler(this.quickCompressJPEGToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Decompress);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.btn_Compress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "MainForm";
            this.Text = "Squeezy Data Compressor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Compress;
        private System.Windows.Forms.Button btn_Decompress;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textCompressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textCompressionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickCompressJPEGToolStripMenuItem;
    }
}

