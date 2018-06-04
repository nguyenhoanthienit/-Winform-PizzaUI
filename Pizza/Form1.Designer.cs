using System.Drawing;
namespace Pizza
{
    partial class fPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPizza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDaChon = new System.Windows.Forms.Panel();
            this.labelDaChon = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelThanhToan = new System.Windows.Forms.Panel();
            this.labelThanhToan = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelGiaiKhat = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelCoSan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panelTuLam = new System.Windows.Forms.Panel();
            this.labelTuLam = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelTrangChu = new System.Windows.Forms.Panel();
            this.labelTrangChu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.daChon1 = new Pizza.DaChon();
            this.thanhToan1 = new Pizza.ThanhToan();
            this.giaiKhat1 = new Pizza.GiaiKhat();
            this.coSan1 = new Pizza.CoSan();
            this.tuLam1 = new Pizza.TuLam();
            this.controlTrangChu1 = new Pizza.ControlTrangChu();
            this.panel1.SuspendLayout();
            this.panelDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelGiaiKhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelCoSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTuLam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panelDaChon);
            this.panel1.Controls.Add(this.panelThanhToan);
            this.panel1.Controls.Add(this.panelGiaiKhat);
            this.panel1.Controls.Add(this.panelCoSan);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.panelTuLam);
            this.panel1.Controls.Add(this.panelTrangChu);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 511);
            this.panel1.TabIndex = 1;
            // 
            // panelDaChon
            // 
            this.panelDaChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelDaChon.Controls.Add(this.labelDaChon);
            this.panelDaChon.Controls.Add(this.pictureBox5);
            this.panelDaChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDaChon.Location = new System.Drawing.Point(19, 308);
            this.panelDaChon.Margin = new System.Windows.Forms.Padding(0);
            this.panelDaChon.Name = "panelDaChon";
            this.panelDaChon.Size = new System.Drawing.Size(182, 53);
            this.panelDaChon.TabIndex = 13;
            this.panelDaChon.Click += new System.EventHandler(this.panelDaChon_Click);
            this.panelDaChon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDaChon_Paint);
            // 
            // labelDaChon
            // 
            this.labelDaChon.AutoSize = true;
            this.labelDaChon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaChon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDaChon.Location = new System.Drawing.Point(66, 2);
            this.labelDaChon.Name = "labelDaChon";
            this.labelDaChon.Size = new System.Drawing.Size(82, 50);
            this.labelDaChon.TabIndex = 7;
            this.labelDaChon.Text = "Món ăn \r\nđã chọn";
            this.labelDaChon.Click += new System.EventHandler(this.labelDaChon_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panelThanhToan
            // 
            this.panelThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelThanhToan.Controls.Add(this.labelThanhToan);
            this.panelThanhToan.Controls.Add(this.pictureBox4);
            this.panelThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelThanhToan.Location = new System.Drawing.Point(19, 381);
            this.panelThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.panelThanhToan.Name = "panelThanhToan";
            this.panelThanhToan.Size = new System.Drawing.Size(182, 53);
            this.panelThanhToan.TabIndex = 13;
            this.panelThanhToan.Click += new System.EventHandler(this.panelThanhToan_Click);
            // 
            // labelThanhToan
            // 
            this.labelThanhToan.AutoSize = true;
            this.labelThanhToan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelThanhToan.Location = new System.Drawing.Point(60, 14);
            this.labelThanhToan.Name = "labelThanhToan";
            this.labelThanhToan.Size = new System.Drawing.Size(110, 25);
            this.labelThanhToan.TabIndex = 7;
            this.labelThanhToan.Text = "Thanh Toán";
            this.labelThanhToan.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panelGiaiKhat
            // 
            this.panelGiaiKhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelGiaiKhat.Controls.Add(this.label2);
            this.panelGiaiKhat.Controls.Add(this.pictureBox3);
            this.panelGiaiKhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelGiaiKhat.Location = new System.Drawing.Point(19, 242);
            this.panelGiaiKhat.Margin = new System.Windows.Forms.Padding(0);
            this.panelGiaiKhat.Name = "panelGiaiKhat";
            this.panelGiaiKhat.Size = new System.Drawing.Size(182, 53);
            this.panelGiaiKhat.TabIndex = 13;
            this.panelGiaiKhat.Click += new System.EventHandler(this.panelGiaiKhat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giải Khát";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelCoSan
            // 
            this.panelCoSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelCoSan.Controls.Add(this.label1);
            this.panelCoSan.Controls.Add(this.pictureBox2);
            this.panelCoSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCoSan.Location = new System.Drawing.Point(19, 175);
            this.panelCoSan.Margin = new System.Windows.Forms.Padding(0);
            this.panelCoSan.Name = "panelCoSan";
            this.panelCoSan.Size = new System.Drawing.Size(182, 53);
            this.panelCoSan.TabIndex = 12;
            this.panelCoSan.Click += new System.EventHandler(this.panelCoSan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizza Có Sẵn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 46);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 53);
            this.SidePanel.TabIndex = 10;
            // 
            // panelTuLam
            // 
            this.panelTuLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelTuLam.Controls.Add(this.labelTuLam);
            this.panelTuLam.Controls.Add(this.pictureBox6);
            this.panelTuLam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTuLam.Location = new System.Drawing.Point(19, 111);
            this.panelTuLam.Margin = new System.Windows.Forms.Padding(0);
            this.panelTuLam.Name = "panelTuLam";
            this.panelTuLam.Size = new System.Drawing.Size(182, 53);
            this.panelTuLam.TabIndex = 11;
            this.panelTuLam.Click += new System.EventHandler(this.panelTuLam_Click);
            // 
            // labelTuLam
            // 
            this.labelTuLam.AutoSize = true;
            this.labelTuLam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuLam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTuLam.Location = new System.Drawing.Point(60, 14);
            this.labelTuLam.Name = "labelTuLam";
            this.labelTuLam.Size = new System.Drawing.Size(122, 25);
            this.labelTuLam.TabIndex = 7;
            this.labelTuLam.Text = "Pizza Tự Làm";
            this.labelTuLam.Click += new System.EventHandler(this.labelTuLam_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panelTrangChu
            // 
            this.panelTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelTrangChu.Controls.Add(this.labelTrangChu);
            this.panelTrangChu.Controls.Add(this.pictureBox1);
            this.panelTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTrangChu.Location = new System.Drawing.Point(19, 46);
            this.panelTrangChu.Margin = new System.Windows.Forms.Padding(0);
            this.panelTrangChu.Name = "panelTrangChu";
            this.panelTrangChu.Size = new System.Drawing.Size(182, 53);
            this.panelTrangChu.TabIndex = 6;
            this.panelTrangChu.Click += new System.EventHandler(this.panelTrangChu_Click);
            // 
            // labelTrangChu
            // 
            this.labelTrangChu.AutoSize = true;
            this.labelTrangChu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTrangChu.Location = new System.Drawing.Point(60, 15);
            this.labelTrangChu.Name = "labelTrangChu";
            this.labelTrangChu.Size = new System.Drawing.Size(98, 25);
            this.labelTrangChu.TabIndex = 7;
            this.labelTrangChu.Text = "Trang Chủ";
            this.labelTrangChu.Click += new System.EventHandler(this.labelTrangChu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // daChon1
            // 
            this.daChon1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.daChon1.Location = new System.Drawing.Point(221, -1);
            this.daChon1.Name = "daChon1";
            this.daChon1.Size = new System.Drawing.Size(602, 500);
            this.daChon1.TabIndex = 7;
            // 
            // thanhToan1
            // 
            this.thanhToan1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thanhToan1.Location = new System.Drawing.Point(221, -1);
            this.thanhToan1.Name = "thanhToan1";
            this.thanhToan1.Size = new System.Drawing.Size(590, 500);
            this.thanhToan1.TabIndex = 6;
            // 
            // giaiKhat1
            // 
            this.giaiKhat1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.giaiKhat1.Location = new System.Drawing.Point(221, -1);
            this.giaiKhat1.Name = "giaiKhat1";
            this.giaiKhat1.Size = new System.Drawing.Size(590, 500);
            this.giaiKhat1.TabIndex = 5;
            // 
            // coSan1
            // 
            this.coSan1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coSan1.Location = new System.Drawing.Point(221, -1);
            this.coSan1.Name = "coSan1";
            this.coSan1.Size = new System.Drawing.Size(590, 500);
            this.coSan1.TabIndex = 4;
            // 
            // tuLam1
            // 
            this.tuLam1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tuLam1.Location = new System.Drawing.Point(221, -1);
            this.tuLam1.Name = "tuLam1";
            this.tuLam1.Size = new System.Drawing.Size(590, 500);
            this.tuLam1.TabIndex = 3;
            // 
            // controlTrangChu1
            // 
            this.controlTrangChu1.Location = new System.Drawing.Point(221, -1);
            this.controlTrangChu1.Name = "controlTrangChu1";
            this.controlTrangChu1.Size = new System.Drawing.Size(590, 500);
            this.controlTrangChu1.TabIndex = 2;
            // 
            // fPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(816, 501);
            this.Controls.Add(this.daChon1);
            this.Controls.Add(this.thanhToan1);
            this.Controls.Add(this.giaiKhat1);
            this.Controls.Add(this.coSan1);
            this.Controls.Add(this.tuLam1);
            this.Controls.Add(this.controlTrangChu1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Zapi - Ngon Hết Sẩy";
            this.panel1.ResumeLayout(false);
            this.panelDaChon.ResumeLayout(false);
            this.panelDaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelThanhToan.ResumeLayout(false);
            this.panelThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelGiaiKhat.ResumeLayout(false);
            this.panelGiaiKhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelCoSan.ResumeLayout(false);
            this.panelCoSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTuLam.ResumeLayout(false);
            this.panelTuLam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelTrangChu.ResumeLayout(false);
            this.panelTrangChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panelTrangChu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTrangChu;
        private System.Windows.Forms.Label labelTuLam;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panelTuLam;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panelCoSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelThanhToan;
        private System.Windows.Forms.Label labelThanhToan;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelGiaiKhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ControlTrangChu controlTrangChu1;
        private TuLam tuLam1;
        private CoSan coSan1;
        private GiaiKhat giaiKhat1;
        private ThanhToan thanhToan1;
        private System.Windows.Forms.Panel panelDaChon;
        private System.Windows.Forms.Label labelDaChon;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DaChon daChon1;
    }
}

