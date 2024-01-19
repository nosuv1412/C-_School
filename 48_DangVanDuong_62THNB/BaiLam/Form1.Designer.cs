namespace BaiLam
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuĐỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuXanhLáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuXanhLamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuĐenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.so_luong = new System.Windows.Forms.NumericUpDown();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.so_luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.ContextMenuStrip = this.contextMenuStrip1;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.so_luong);
            this.splitContainer1.Panel1.Controls.Add(this.cbTenHang);
            this.splitContainer1.Panel1.Controls.Add(this.txtTongTien);
            this.splitContainer1.Panel1.Controls.Add(this.txtDonGia);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenKH);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.btnTaoDonHang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(766, 321);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.màuĐỏToolStripMenuItem,
            this.màuXanhLáToolStripMenuItem,
            this.màuXanhLamToolStripMenuItem,
            this.màuĐenToolStripMenuItem});
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            // 
            // màuĐỏToolStripMenuItem
            // 
            this.màuĐỏToolStripMenuItem.Name = "màuĐỏToolStripMenuItem";
            this.màuĐỏToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.màuĐỏToolStripMenuItem.Text = "Màu đỏ";
            this.màuĐỏToolStripMenuItem.Click += new System.EventHandler(this.màuĐỏToolStripMenuItem_Click);
            // 
            // màuXanhLáToolStripMenuItem
            // 
            this.màuXanhLáToolStripMenuItem.Name = "màuXanhLáToolStripMenuItem";
            this.màuXanhLáToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.màuXanhLáToolStripMenuItem.Text = "Màu xanh lá";
            this.màuXanhLáToolStripMenuItem.Click += new System.EventHandler(this.màuXanhLáToolStripMenuItem_Click);
            // 
            // màuXanhLamToolStripMenuItem
            // 
            this.màuXanhLamToolStripMenuItem.Name = "màuXanhLamToolStripMenuItem";
            this.màuXanhLamToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.màuXanhLamToolStripMenuItem.Text = "Màu xanh lam";
            this.màuXanhLamToolStripMenuItem.Click += new System.EventHandler(this.màuXanhLamToolStripMenuItem_Click);
            // 
            // màuĐenToolStripMenuItem
            // 
            this.màuĐenToolStripMenuItem.Name = "màuĐenToolStripMenuItem";
            this.màuĐenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.màuĐenToolStripMenuItem.Text = "Màu đen";
            this.màuĐenToolStripMenuItem.Click += new System.EventHandler(this.màuĐenToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(253, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(253, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // so_luong
            // 
            this.so_luong.ContextMenuStrip = this.contextMenuStrip1;
            this.so_luong.Location = new System.Drawing.Point(93, 116);
            this.so_luong.Name = "so_luong";
            this.so_luong.Size = new System.Drawing.Size(120, 23);
            this.so_luong.TabIndex = 4;
            // 
            // cbTenHang
            // 
            this.cbTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTenHang.ContextMenuStrip = this.contextMenuStrip1;
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Items.AddRange(new object[] {
            "Nước ngọt",
            "Bia",
            "Bút bi"});
            this.cbTenHang.Location = new System.Drawing.Point(93, 84);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(156, 24);
            this.cbTenHang.TabIndex = 3;
            this.cbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbTenHang_SelectedIndexChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.ContextMenuStrip = this.contextMenuStrip1;
            this.txtTongTien.Location = new System.Drawing.Point(93, 265);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(156, 23);
            this.txtTongTien.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDonGia.Location = new System.Drawing.Point(93, 146);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(156, 23);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKH.ContextMenuStrip = this.contextMenuStrip1;
            this.txtTenKH.Location = new System.Drawing.Point(93, 53);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(156, 23);
            this.txtTenKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách";
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.Location = new System.Drawing.Point(93, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thanh toán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.ContextMenuStrip = this.contextMenuStrip1;
            this.btnTaoDonHang.Location = new System.Drawing.Point(93, 12);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(115, 30);
            this.btnTaoDonHang.TabIndex = 0;
            this.btnTaoDonHang.Text = "Tạo đơn hàng";
            this.btnTaoDonHang.UseVisualStyleBackColor = true;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.ContextMenuStrip = this.contextMenuStrip1;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.ContextMenuStrip = this.contextMenuStrip1;
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.ContextMenuStrip = this.contextMenuStrip1;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.ContextMenuStrip = this.contextMenuStrip1;
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.ContextMenuStrip = this.contextMenuStrip1;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 321);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng (Đặng Văn Dương - 2051063599)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.so_luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown so_luong;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuĐỏToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuXanhLáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuXanhLamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuĐenToolStripMenuItem;
    }
}

