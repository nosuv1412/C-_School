namespace Quanlysinhvien_TH07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbttSinhVien = new System.Windows.Forms.ToolStripButton();
            this.tsbttKhoa = new System.Windows.Forms.ToolStripButton();
            this.tsbttMonHoc = new System.Windows.Forms.ToolStripButton();
            this.tsbttNhapDiem = new System.Windows.Forms.ToolStripButton();
            this.tsbttXemDiem = new System.Windows.Forms.ToolStripButton();
            this.tsbttThongKe = new System.Windows.Forms.ToolStripButton();
            this.tsbttThoat = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbttSinhVien,
            this.tsbttKhoa,
            this.tsbttMonHoc,
            this.tsbttNhapDiem,
            this.tsbttXemDiem,
            this.tsbttThongKe,
            this.toolStripLabel1,
            this.tsbttThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbttSinhVien
            // 
            this.tsbttSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("tsbttSinhVien.Image")));
            this.tsbttSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttSinhVien.Name = "tsbttSinhVien";
            this.tsbttSinhVien.Size = new System.Drawing.Size(73, 36);
            this.tsbttSinhVien.Text = "SinhVien";
            this.tsbttSinhVien.Click += new System.EventHandler(this.tsbttSinhVien_Click);
            // 
            // tsbttKhoa
            // 
            this.tsbttKhoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbttKhoa.Image")));
            this.tsbttKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttKhoa.Name = "tsbttKhoa";
            this.tsbttKhoa.Size = new System.Drawing.Size(54, 36);
            this.tsbttKhoa.Text = "Khoa";
            this.tsbttKhoa.Click += new System.EventHandler(this.tsbttKhoa_Click);
            // 
            // tsbttMonHoc
            // 
            this.tsbttMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("tsbttMonHoc.Image")));
            this.tsbttMonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttMonHoc.Name = "tsbttMonHoc";
            this.tsbttMonHoc.Size = new System.Drawing.Size(77, 36);
            this.tsbttMonHoc.Text = "Môn Học";
            this.tsbttMonHoc.Click += new System.EventHandler(this.tsbttMonHoc_Click);
            // 
            // tsbttNhapDiem
            // 
            this.tsbttNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbttNhapDiem.Image")));
            this.tsbttNhapDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttNhapDiem.Name = "tsbttNhapDiem";
            this.tsbttNhapDiem.Size = new System.Drawing.Size(86, 36);
            this.tsbttNhapDiem.Text = "Nhập điểm";
            this.tsbttNhapDiem.Click += new System.EventHandler(this.tsbttNhapDiem_Click);
            // 
            // tsbttXemDiem
            // 
            this.tsbttXemDiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbttXemDiem.Image")));
            this.tsbttXemDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttXemDiem.Name = "tsbttXemDiem";
            this.tsbttXemDiem.Size = new System.Drawing.Size(81, 36);
            this.tsbttXemDiem.Text = "Xem điểm";
            this.tsbttXemDiem.Click += new System.EventHandler(this.tsbttXemDiem_Click);
            // 
            // tsbttThongKe
            // 
            this.tsbttThongKe.AutoSize = false;
            this.tsbttThongKe.Image = ((System.Drawing.Image)(resources.GetObject("tsbttThongKe.Image")));
            this.tsbttThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttThongKe.Name = "tsbttThongKe";
            this.tsbttThongKe.Size = new System.Drawing.Size(80, 36);
            this.tsbttThongKe.Text = "Thống kê";
            this.tsbttThongKe.Click += new System.EventHandler(this.tsbttThongKe_Click);
            // 
            // tsbttThoat
            // 
            this.tsbttThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbttThoat.Image")));
            this.tsbttThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbttThoat.Name = "tsbttThoat";
            this.tsbttThoat.Size = new System.Drawing.Size(57, 36);
            this.tsbttThoat.Text = "Thoát";
            this.tsbttThoat.Click += new System.EventHandler(this.tsbttThoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 36);
            this.toolStripLabel1.Text = "                                          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbttSinhVien;
        private System.Windows.Forms.ToolStripButton tsbttKhoa;
        private System.Windows.Forms.ToolStripButton tsbttMonHoc;
        private System.Windows.Forms.ToolStripButton tsbttNhapDiem;
        private System.Windows.Forms.ToolStripButton tsbttXemDiem;
        private System.Windows.Forms.ToolStripButton tsbttThongKe;
        private System.Windows.Forms.ToolStripButton tsbttThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

