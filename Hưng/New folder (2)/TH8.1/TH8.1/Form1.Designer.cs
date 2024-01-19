
namespace TH8._1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.màuĐỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuXanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuVàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.so_luong = new System.Windows.Forms.NumericUpDown();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dONHANGTableAdapter = new TH8._1.DonhangDataSetTableAdapters.DONHANGTableAdapter();
            this.donhangDataSet = new TH8._1.DonhangDataSet();
            this.dONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.so_luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(260, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(88, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.màuĐỏToolStripMenuItem,
            this.màuXanhToolStripMenuItem,
            this.màuVàngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            // 
            // màuĐỏToolStripMenuItem
            // 
            this.màuĐỏToolStripMenuItem.Name = "màuĐỏToolStripMenuItem";
            this.màuĐỏToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.màuĐỏToolStripMenuItem.Text = "Màu đỏ";
            this.màuĐỏToolStripMenuItem.Click += new System.EventHandler(this.màuĐỏToolStripMenuItem_Click);
            // 
            // màuXanhToolStripMenuItem
            // 
            this.màuXanhToolStripMenuItem.Name = "màuXanhToolStripMenuItem";
            this.màuXanhToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.màuXanhToolStripMenuItem.Text = "Màu xanh";
            this.màuXanhToolStripMenuItem.Click += new System.EventHandler(this.màuXanhToolStripMenuItem_Click);
            // 
            // màuVàngToolStripMenuItem
            // 
            this.màuVàngToolStripMenuItem.Name = "màuVàngToolStripMenuItem";
            this.màuVàngToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.màuVàngToolStripMenuItem.Text = "Màu vàng";
            this.màuVàngToolStripMenuItem.Click += new System.EventHandler(this.màuVàngToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(218, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.Location = new System.Drawing.Point(218, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.Location = new System.Drawing.Point(88, 262);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Thanh toán";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(2, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(2, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(2, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(2, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKH.ContextMenuStrip = this.contextMenuStrip1;
            this.txtTenKH.Location = new System.Drawing.Point(62, 85);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(140, 20);
            this.txtTenKH.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDonGia.Location = new System.Drawing.Point(62, 190);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(140, 20);
            this.txtDonGia.TabIndex = 12;
            // 
            // cbTenHang
            // 
            this.cbTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTenHang.ContextMenuStrip = this.contextMenuStrip1;
            this.cbTenHang.DataSource = this.dONHANGBindingSource;
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Location = new System.Drawing.Point(62, 120);
            this.cbTenHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(140, 21);
            this.cbTenHang.TabIndex = 13;
            // 
            // so_luong
            // 
            this.so_luong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.so_luong.ContextMenuStrip = this.contextMenuStrip1;
            this.so_luong.Location = new System.Drawing.Point(62, 156);
            this.so_luong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.so_luong.Name = "so_luong";
            this.so_luong.Size = new System.Drawing.Size(57, 20);
            this.so_luong.TabIndex = 14;
            // 
            // txtTongTien
            // 
            this.txtTongTien.ContextMenuStrip = this.contextMenuStrip1;
            this.txtTongTien.Location = new System.Drawing.Point(62, 317);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(140, 20);
            this.txtTongTien.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(2, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng tiền";
            // 
            // dONHANGTableAdapter
            // 
            this.dONHANGTableAdapter.ClearBeforeFill = true;
            // 
            // donhangDataSet
            // 
            this.donhangDataSet.DataSetName = "DonhangDataSet";
            this.donhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dONHANGBindingSource
            // 
            this.dONHANGBindingSource.DataMember = "DONHANG";
            this.dONHANGBindingSource.DataSource = this.donhangDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(786, 366);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.so_luong);
            this.Controls.Add(this.cbTenHang);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "                       Quản lý bán hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.so_luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem màuĐỏToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuXanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuVàngToolStripMenuItem;
        private System.Windows.Forms.BindingSource dONHANGBindingSource;
        private DonhangDataSet donhangDataSet;
        private DonhangDataSetTableAdapters.DONHANGTableAdapter dONHANGTableAdapter;
    }
}

