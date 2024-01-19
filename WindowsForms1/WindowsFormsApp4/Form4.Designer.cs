
namespace WindowsFormsApp4
{
    partial class Form4
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
            this.msv = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.gioitinh = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.que = new System.Windows.Forms.ComboBox();
            this.lop = new System.Windows.Forms.ComboBox();
            this.khoa = new System.Windows.Forms.ComboBox();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.nam = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.que_quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // msv
            // 
            this.msv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msv.Location = new System.Drawing.Point(110, 2);
            this.msv.Name = "msv";
            this.msv.Size = new System.Drawing.Size(185, 27);
            this.msv.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(0, 10);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(58, 25);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Mã SV";
            this.lb1.UseCompatibleTextRendering = true;
            // 
            // lb4
            // 
            this.lb4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(360, 10);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(81, 20);
            this.lb4.TabIndex = 2;
            this.lb4.Text = "Quê quán";
            // 
            // lb2
            // 
            this.lb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(0, 70);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(59, 20);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Họ tên";
            // 
            // lb5
            // 
            this.lb5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(360, 70);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(37, 20);
            this.lb5.TabIndex = 4;
            this.lb5.Text = "Lớp";
            // 
            // lb3
            // 
            this.lb3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(0, 130);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(83, 20);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Ngày sinh";
            // 
            // lb6
            // 
            this.lb6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(360, 130);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(47, 20);
            this.lb6.TabIndex = 6;
            this.lb6.Text = "Khoa";
            // 
            // gioitinh
            // 
            this.gioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gioitinh.AutoSize = true;
            this.gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioitinh.Location = new System.Drawing.Point(0, 190);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(71, 20);
            this.gioitinh.TabIndex = 7;
            this.gioitinh.Text = "Giới tính";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(110, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(185, 27);
            this.name.TabIndex = 8;
            // 
            // que
            // 
            this.que.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.que.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.que.FormattingEnabled = true;
            this.que.Items.AddRange(new object[] {
            "Hà Nội ",
            "Hồ Chí Minh ",
            "Sóc Sơn",
            "Yên Bái "});
            this.que.Location = new System.Drawing.Point(464, 2);
            this.que.Name = "que";
            this.que.Size = new System.Drawing.Size(185, 28);
            this.que.TabIndex = 10;
            // 
            // lop
            // 
            this.lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.FormattingEnabled = true;
            this.lop.Items.AddRange(new object[] {
            "62TH1",
            "62TH2",
            "62THNB",
            "62THVA"});
            this.lop.Location = new System.Drawing.Point(464, 67);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(185, 28);
            this.lop.TabIndex = 11;
            // 
            // khoa
            // 
            this.khoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoa.FormattingEnabled = true;
            this.khoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Quản trị kinh doanh",
            "Dược "});
            this.khoa.Location = new System.Drawing.Point(464, 130);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(185, 28);
            this.khoa.TabIndex = 12;
            // 
            // birth
            // 
            this.birth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth.Location = new System.Drawing.Point(110, 131);
            this.birth.Name = "birth";
            this.birth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birth.Size = new System.Drawing.Size(185, 27);
            this.birth.TabIndex = 14;
            this.birth.Value = new System.DateTime(2022, 3, 7, 0, 0, 0, 0);
            this.birth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // nam
            // 
            this.nam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nam.AutoSize = true;
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.Location = new System.Drawing.Point(110, 188);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(65, 24);
            this.nam.TabIndex = 15;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.CheckedChanged += new System.EventHandler(this.nam_CheckedChanged);
            // 
            // nu
            // 
            this.nu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nu.AutoSize = true;
            this.nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu.Location = new System.Drawing.Point(203, 187);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(51, 24);
            this.nu.TabIndex = 16;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            this.them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(364, 190);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(105, 40);
            this.them.TabIndex = 17;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sv,
            this.ho_ten,
            this.ngay_sinh,
            this.gioi_tinh,
            this.que_quan,
            this.l,
            this.k});
            this.dataGridView1.Location = new System.Drawing.Point(0, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 203);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ma_sv
            // 
            this.ma_sv.HeaderText = "Mã SV";
            this.ma_sv.MinimumWidth = 6;
            this.ma_sv.Name = "ma_sv";
            this.ma_sv.Width = 125;
            // 
            // ho_ten
            // 
            this.ho_ten.HeaderText = "Họ tên";
            this.ho_ten.MinimumWidth = 6;
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.Width = 125;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.MinimumWidth = 6;
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.Width = 125;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.MinimumWidth = 6;
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.Width = 125;
            // 
            // que_quan
            // 
            this.que_quan.HeaderText = "Quê quán";
            this.que_quan.MinimumWidth = 6;
            this.que_quan.Name = "que_quan";
            this.que_quan.Width = 125;
            // 
            // l
            // 
            this.l.HeaderText = "Lớp";
            this.l.MinimumWidth = 6;
            this.l.Name = "l";
            this.l.Width = 125;
            // 
            // k
            // 
            this.k.HeaderText = "Khoa";
            this.k.MinimumWidth = 6;
            this.k.Name = "k";
            this.k.Width = 125;
            // 
            // xoa
            // 
            this.xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(574, 190);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(105, 40);
            this.xoa.TabIndex = 19;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.them);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.que);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.msv);
            this.Name = "Form4";
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msv;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label gioitinh;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox que;
        private System.Windows.Forms.ComboBox lop;
        private System.Windows.Forms.ComboBox khoa;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn que_quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn l;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
        private System.Windows.Forms.Button xoa;
    }
}

