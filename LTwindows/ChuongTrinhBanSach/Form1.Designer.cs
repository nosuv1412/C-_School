namespace ChuongTrinhBanSach
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuongSach = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.txtKHlaSV = new System.Windows.Forms.TextBox();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTinhTT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TIỀN BÁN SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtSoLuongSach);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoá Đơn";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(110, 88);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(150, 20);
            this.txtThanhTien.TabIndex = 7;
            // 
            // txtSoLuongSach
            // 
            this.txtSoLuongSach.Location = new System.Drawing.Point(110, 38);
            this.txtSoLuongSach.Name = "txtSoLuongSach";
            this.txtSoLuongSach.Size = new System.Drawing.Size(150, 20);
            this.txtSoLuongSach.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(110, 13);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(150, 20);
            this.txtTenKH.TabIndex = 5;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(110, 68);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(15, 14);
            this.cb.TabIndex = 4;
            this.cb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khách Hàng là SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDoanhThu);
            this.groupBox2.Controls.Add(this.txtKHlaSV);
            this.groupBox2.Controls.Add(this.txtTongKH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(16, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(106, 66);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(150, 20);
            this.txtDoanhThu.TabIndex = 7;
            // 
            // txtKHlaSV
            // 
            this.txtKHlaSV.Location = new System.Drawing.Point(106, 38);
            this.txtKHlaSV.Name = "txtKHlaSV";
            this.txtKHlaSV.ReadOnly = true;
            this.txtKHlaSV.Size = new System.Drawing.Size(150, 20);
            this.txtKHlaSV.TabIndex = 6;
            // 
            // txtTongKH
            // 
            this.txtTongKH.Location = new System.Drawing.Point(106, 13);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.ReadOnly = true;
            this.txtTongKH.Size = new System.Drawing.Size(150, 20);
            this.txtTongKH.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng Doanh Thu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng Số KH là SV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng Số KH:";
            // 
            // btnTinhTT
            // 
            this.btnTinhTT.Location = new System.Drawing.Point(9, 11);
            this.btnTinhTT.Name = "btnTinhTT";
            this.btnTinhTT.Size = new System.Drawing.Size(59, 23);
            this.btnTinhTT.TabIndex = 3;
            this.btnTinhTT.Text = "Tính TT";
            this.btnTinhTT.UseVisualStyleBackColor = true;
            this.btnTinhTT.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKetThuc);
            this.groupBox3.Controls.Add(this.btnThongKe);
            this.groupBox3.Controls.Add(this.btnTiep);
            this.groupBox3.Controls.Add(this.btnTinhTT);
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 40);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(237, 11);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(61, 23);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(158, 11);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(67, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(83, 11);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(59, 23);
            this.btnTiep.TabIndex = 4;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách ( Vũ Thanh Sơn-2051063469 )";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuongSach;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.TextBox txtKHlaSV;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTinhTT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

