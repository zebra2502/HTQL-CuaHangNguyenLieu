namespace QuanLyBanHang
{
    partial class frmBCHangTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCHangTon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoBC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvBCHangTon = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHangTon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 155);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(216, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO HÀNG TỒN";
            // 
            // btnTaoBC
            // 
            this.btnTaoBC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaoBC.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoBC.Image")));
            this.btnTaoBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoBC.Location = new System.Drawing.Point(163, 23);
            this.btnTaoBC.Name = "btnTaoBC";
            this.btnTaoBC.Size = new System.Drawing.Size(174, 54);
            this.btnTaoBC.TabIndex = 11;
            this.btnTaoBC.Text = "&Tạo báo cáo";
            this.btnTaoBC.UseVisualStyleBackColor = false;
            this.btnTaoBC.Click += new System.EventHandler(this.btnTaoBC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnTaoBC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 89);
            this.panel1.TabIndex = 19;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(445, 23);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(174, 54);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvBCHangTon
            // 
            this.dgvBCHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCHangTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBCHangTon.Location = new System.Drawing.Point(0, 155);
            this.dgvBCHangTon.Name = "dgvBCHangTon";
            this.dgvBCHangTon.RowHeadersWidth = 62;
            this.dgvBCHangTon.RowTemplate.Height = 28;
            this.dgvBCHangTon.Size = new System.Drawing.Size(791, 454);
            this.dgvBCHangTon.TabIndex = 23;
            // 
            // frmBCHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 698);
            this.Controls.Add(this.dgvBCHangTon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmBCHangTon";
            this.Text = "frmBCHangTon";
            this.Load += new System.EventHandler(this.frmBCHangTon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHangTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoBC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBCHangTon;
        private System.Windows.Forms.Button btnDong;
    }
}