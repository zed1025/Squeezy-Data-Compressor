namespace Squeezy_Data_Compressor
{
    partial class JPEG_Compress
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
            this.btn_select_file = new System.Windows.Forms.Button();
            this.btn_compress = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_select_file
            // 
            this.btn_select_file.Location = new System.Drawing.Point(94, 574);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(279, 118);
            this.btn_select_file.TabIndex = 0;
            this.btn_select_file.Text = "Select File";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // btn_compress
            // 
            this.btn_compress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_compress.Location = new System.Drawing.Point(628, 574);
            this.btn_compress.Name = "btn_compress";
            this.btn_compress.Size = new System.Drawing.Size(307, 118);
            this.btn_compress.TabIndex = 1;
            this.btn_compress.Text = "Compress";
            this.btn_compress.UseVisualStyleBackColor = false;
            this.btn_compress.Click += new System.EventHandler(this.btn_compress_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 174);
            this.label1.MaximumSize = new System.Drawing.Size(800, 200);
            this.label1.MinimumSize = new System.Drawing.Size(800, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 200);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 449);
            this.label2.MaximumSize = new System.Drawing.Size(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select compression level 0-100";
            // 
            // JPEG_Compress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_compress);
            this.Controls.Add(this.btn_select_file);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "JPEG_Compress";
            this.Text = "Quick Compress JPEG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.Button btn_compress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}