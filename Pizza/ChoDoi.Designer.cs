namespace Pizza
{
    partial class ChoDoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoDoi));
            this.panel3001 = new System.Windows.Forms.Panel();
            this.label2001 = new System.Windows.Forms.Label();
            this.pictureBox1001 = new System.Windows.Forms.PictureBox();
            this.pictureBox125 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3001.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3001
            // 
            this.panel3001.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3001.Controls.Add(this.label2001);
            this.panel3001.Controls.Add(this.pictureBox1001);
            this.panel3001.Location = new System.Drawing.Point(31, 0);
            this.panel3001.Name = "panel3001";
            this.panel3001.Size = new System.Drawing.Size(102, 137);
            this.panel3001.TabIndex = 6;
            // 
            // label2001
            // 
            this.label2001.AutoSize = true;
            this.label2001.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2001.ForeColor = System.Drawing.Color.White;
            this.label2001.Location = new System.Drawing.Point(9, 94);
            this.label2001.Name = "label2001";
            this.label2001.Size = new System.Drawing.Size(87, 19);
            this.label2001.TabIndex = 3;
            this.label2001.Text = "PIZZA ZAPI";
            // 
            // pictureBox1001
            // 
            this.pictureBox1001.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1001.Image")));
            this.pictureBox1001.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1001.Name = "pictureBox1001";
            this.pictureBox1001.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1001.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1001.TabIndex = 4;
            this.pictureBox1001.TabStop = false;
            // 
            // pictureBox125
            // 
            this.pictureBox125.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox125.Image")));
            this.pictureBox125.Location = new System.Drawing.Point(159, -35);
            this.pictureBox125.Name = "pictureBox125";
            this.pictureBox125.Size = new System.Drawing.Size(412, 276);
            this.pictureBox125.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox125.TabIndex = 25;
            this.pictureBox125.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Các món ăn đang được thực hiện, vui lòng chờ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(495, 55);
            this.progressBar1.TabIndex = 27;
            this.progressBar1.Value = 10;
            // 
            // ChoDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox125);
            this.Controls.Add(this.panel3001);
            this.Name = "ChoDoi";
            this.Size = new System.Drawing.Size(590, 500);
            this.panel3001.ResumeLayout(false);
            this.panel3001.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3001;
        private System.Windows.Forms.Label label2001;
        private System.Windows.Forms.PictureBox pictureBox1001;
        private System.Windows.Forms.PictureBox pictureBox125;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
