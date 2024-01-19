namespace BaiThiHetMon
{
    partial class Khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khoa));
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.quanLySinhVienDataSet = new BaiThiHetMon.QuanLySinhVienDataSet();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new BaiThiHetMon.QuanLySinhVienDataSetTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new BaiThiHetMon.QuanLySinhVienDataSetTableAdapters.TableAdapterManager();
            this.khoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.khoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.tenKhoaTextBox = new System.Windows.Forms.TextBox();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingNavigator)).BeginInit();
            this.khoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLySinhVienDataSet
            // 
            this.quanLySinhVienDataSet.DataSetName = "QuanLySinhVienDataSet";
            this.quanLySinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = this.khoaTableAdapter;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BaiThiHetMon.QuanLySinhVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khoaBindingNavigator
            // 
            this.khoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.khoaBindingNavigator.BindingSource = this.khoaBindingSource;
            this.khoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.khoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.khoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.khoaBindingNavigatorSaveItem});
            this.khoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.khoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.khoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.khoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.khoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.khoaBindingNavigator.Name = "khoaBindingNavigator";
            this.khoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.khoaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.khoaBindingNavigator.TabIndex = 0;
            this.khoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // khoaBindingNavigatorSaveItem
            // 
            this.khoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.khoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("khoaBindingNavigatorSaveItem.Image")));
            this.khoaBindingNavigatorSaveItem.Name = "khoaBindingNavigatorSaveItem";
            this.khoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.khoaBindingNavigatorSaveItem.Text = "Save Data";
            this.khoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.khoaBindingNavigatorSaveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.khoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(381, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 273);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaKhoa";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaKhoa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenKhoa";
            this.dataGridViewTextBoxColumn4.HeaderText = "TenKhoa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(176, 149);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(53, 13);
            maKhoaLabel.TabIndex = 6;
            maKhoaLabel.Text = "Ma Khoa:";
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Location = new System.Drawing.Point(239, 146);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.maKhoaTextBox.TabIndex = 7;
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(176, 215);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(57, 13);
            tenKhoaLabel.TabIndex = 8;
            tenKhoaLabel.Text = "Ten Khoa:";
            // 
            // tenKhoaTextBox
            // 
            this.tenKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "TenKhoa", true));
            this.tenKhoaTextBox.Location = new System.Drawing.Point(239, 212);
            this.tenKhoaTextBox.Name = "tenKhoaTextBox";
            this.tenKhoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenKhoaTextBox.TabIndex = 9;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(maKhoaLabel);
            this.Controls.Add(this.maKhoaTextBox);
            this.Controls.Add(tenKhoaLabel);
            this.Controls.Add(this.tenKhoaTextBox);
            this.Controls.Add(this.khoaBindingNavigator);
            this.Name = "Khoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingNavigator)).EndInit();
            this.khoaBindingNavigator.ResumeLayout(false);
            this.khoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLySinhVienDataSet quanLySinhVienDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QuanLySinhVienDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private QuanLySinhVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator khoaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton khoaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox maKhoaTextBox;
        private System.Windows.Forms.TextBox tenKhoaTextBox;
    }
}