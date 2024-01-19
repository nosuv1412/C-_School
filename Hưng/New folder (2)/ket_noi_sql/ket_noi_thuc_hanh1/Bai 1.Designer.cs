
namespace ket_noi_thuc_hanh1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btBoqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(247, 75);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(198, 27);
            this.txtMaSach.TabIndex = 4;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(247, 179);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(198, 27);
            this.txtTieuDe.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(653, 75);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(216, 27);
            this.txtGia.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(653, 179);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(216, 27);
            this.txtSoLuong.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 257);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(999, 202);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sách";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tiêu đề";
            this.columnHeader2.Width = 373;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá ";
            this.columnHeader3.Width = 248;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 204;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(135, 485);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(110, 30);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(315, 485);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(110, 30);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(498, 485);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(110, 30);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(677, 485);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(110, 30);
            this.btBoqua.TabIndex = 12;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btBoqua;
    }
}

