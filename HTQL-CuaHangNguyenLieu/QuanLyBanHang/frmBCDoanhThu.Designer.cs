namespace QuanLyBanHang
{
    partial class frmBCDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCDoanhThu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBCHangTon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTaoBC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHangTon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtNam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 230);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(126, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU THÁNG";
            // 
            // dgvBCHangTon
            // 
            this.dgvBCHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCHangTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBCHangTon.Location = new System.Drawing.Point(0, 230);
            this.dgvBCHangTon.Name = "dgvBCHangTon";
            this.dgvBCHangTon.RowHeadersWidth = 62;
            this.dgvBCHangTon.RowTemplate.Height = 28;
            this.dgvBCHangTon.Size = new System.Drawing.Size(794, 308);
            this.dgvBCHangTon.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnTaoBC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 89);
            this.panel3.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(463, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Đóng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTaoBC
            // 
            this.btnTaoBC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaoBC.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoBC.Image")));
            this.btnTaoBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoBC.Location = new System.Drawing.Point(256, 14);
            this.btnTaoBC.Name = "btnTaoBC";
            this.btnTaoBC.Size = new System.Drawing.Size(174, 54);
            this.btnTaoBC.TabIndex = 11;
            this.btnTaoBC.Text = "&Tạo báo cáo";
            this.btnTaoBC.UseVisualStyleBackColor = false;
            this.btnTaoBC.Click += new System.EventHandler(this.btnTaoBC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(104, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(221, 94);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 26);
            this.txtThang.TabIndex = 25;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(221, 133);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 26);
            this.txtNam.TabIndex = 30;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(432, 97);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(152, 54);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmBCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvBCHangTon);
            this.Controls.Add(this.panel2);
            this.Name = "frmBCDoanhThu";
            this.Text = "frmBCDoanhThu";
            this.Load += new System.EventHandler(this.frmBCDoanhThu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHangTon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBCHangTon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTaoBC;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnTimKiem;
    }
}