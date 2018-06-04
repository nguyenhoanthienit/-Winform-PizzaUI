using System.Collections;
using System.Windows.Forms;
namespace Pizza
{
    partial class DaChon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaChon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3001 = new System.Windows.Forms.Panel();
            this.label2001 = new System.Windows.Forms.Label();
            this.pictureBox1001 = new System.Windows.Forms.PictureBox();
            this.pictureBox125 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.choDoi1 = new Pizza.ChoDoi();
            this.panel3001.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel3001.TabIndex = 5;
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
            this.pictureBox125.TabIndex = 24;
            this.pictureBox125.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(31, 181);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 238);
            this.dataGridView2.TabIndex = 26;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "TÊN MÓN ĂN / NƯỚC GIẢI KHÁT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SỐ LƯỢNG";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "GIÁ TIỀN";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(224, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 72);
            this.button1.TabIndex = 31;
            this.button1.Text = "XÁC NHẬN GỌI MÓN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // choDoi1
            // 
            this.choDoi1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choDoi1.Location = new System.Drawing.Point(3, 0);
            this.choDoi1.Name = "choDoi1";
            this.choDoi1.Size = new System.Drawing.Size(590, 500);
            this.choDoi1.TabIndex = 32;
            // 
            // DaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.choDoi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox125);
            this.Controls.Add(this.panel3001);
            this.Name = "DaChon";
            this.Size = new System.Drawing.Size(590, 500);
            this.panel3001.ResumeLayout(false);
            this.panel3001.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            //ADD ROWS DATA
            ArrayList row = new ArrayList();
            row.Add("Bánh tự làm (Sốt cà chua,....) - Dòn - Trung");
            row.Add("1");
            row.Add("20000");
            dataGridView2.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Pizza thịt và xúc xích - Dòn - Nhỏ");
            row.Add("1");
            row.Add("109000");
            dataGridView2.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Coca Cola");
            row.Add("1");
            row.Add("6000");
            dataGridView2.Rows.Add(row.ToArray());

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "button";
            btn.Text = "X";
            btn.HeaderText = "HỦY";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
        }

        #endregion

        private System.Windows.Forms.Panel panel3001;
        private System.Windows.Forms.Label label2001;
        private System.Windows.Forms.PictureBox pictureBox1001;
        private System.Windows.Forms.PictureBox pictureBox125;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private ChoDoi choDoi1;
        private Timer timer1;
    }
}
