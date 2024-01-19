namespace Quanlysinhvien_TH07
{
    partial class XemDiem
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
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label maKhoaLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLySinhVienDataSet = new Quanlysinhvien_TH07.QuanLySinhVienDataSet();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new Quanlysinhvien_TH07.QuanLySinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new Quanlysinhvien_TH07.QuanLySinhVienDataSetTableAdapters.TableAdapterManager();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Quanlysinhvien_TH07.QuanLySinhVienDataSetTableAdapters.KhoaTableAdapter();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            maSoLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(60, 50);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(39, 13);
            maSoLabel.TabIndex = 4;
            maSoLabel.Text = "Mã số:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(60, 80);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 5;
            hoTenLabel.Text = "Tên SV:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sinhVienBindingSource;
            this.comboBox1.DisplayMember = "HoTen";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sinhVienBindingSource;
            this.comboBox2.DisplayMember = "MaSo";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // quanLySinhVienDataSet
            // 
            this.quanLySinhVienDataSet.DataSetName = "QuanLySinhVienDataSet";
            this.quanLySinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.quanLySinhVienDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = this.khoaTableAdapter;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quanlysinhvien_TH07.QuanLySinhVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.quanLySinhVienDataSet;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(65, 107);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(53, 13);
            maKhoaLabel.TabIndex = 11;
            maKhoaLabel.Text = "Ma Khoa:";
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Location = new System.Drawing.Point(124, 104);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.maKhoaTextBox.TabIndex = 12;
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(maKhoaLabel);
            this.Controls.Add(this.maKhoaTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(hoTenLabel);
            this.Name = "XemDiem";
            this.Text = "XemDiem";
            this.Load += new System.EventHandler(this.XemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLySinhVienDataSet quanLySinhVienDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QuanLySinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private QuanLySinhVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QuanLySinhVienDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.TextBox maKhoaTextBox;
    }
}