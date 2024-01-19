namespace BaiThiHetMon
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
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label maKhoaLabel;
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            hoTenLabel = new System.Windows.Forms.Label();
            maSoLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.Location = new System.Drawing.Point(143, 154);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.maKhoaTextBox.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(79, 130);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 14;
            hoTenLabel.Text = "Tên SV:";
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(79, 100);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(39, 13);
            maSoLabel.TabIndex = 13;
            maSoLabel.Text = "Mã số:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(79, 157);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(53, 13);
            maKhoaLabel.TabIndex = 18;
            maKhoaLabel.Text = "Ma Khoa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 316);
            this.dataGridView1.TabIndex = 21;
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(maKhoaLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.maKhoaTextBox);
            this.Name = "XemDiem";
            this.Text = "XemDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maKhoaTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}