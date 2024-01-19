
namespace WindowsFormsApp2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bang_gia = new System.Windows.Forms.CheckedListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tong_tien = new System.Windows.Forms.TextBox();
            this.tinh_tien = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.ten_kh = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tên khách hàng";
            // 
            // bang_gia
            // 
            this.bang_gia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bang_gia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bang_gia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bang_gia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bang_gia.FormattingEnabled = true;
            this.bang_gia.Items.AddRange(new object[] {
            "Cạo vôi\t\t      100 000 VNĐ",
            "Tẩy trắng              1 200 000 VNĐ",
            "Chụp hình\t      150 000 VNĐ",
            "Lấy cao\t\t      100 000 VNĐ"});
            this.bang_gia.Location = new System.Drawing.Point(114, 96);
            this.bang_gia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bang_gia.Name = "bang_gia";
            this.bang_gia.Size = new System.Drawing.Size(304, 144);
            this.bang_gia.TabIndex = 2;
            this.bang_gia.Tag = "";
            this.bang_gia.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AllowDrop = true;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(202, 202);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(122, 202);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Hàn răng";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(263, 202);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "90 000 VNĐ / cái";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(122, 255);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 29);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Tổng tiền";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tong_tien
            // 
            this.tong_tien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tong_tien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong_tien.Location = new System.Drawing.Point(233, 255);
            this.tong_tien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tong_tien.Name = "tong_tien";
            this.tong_tien.Size = new System.Drawing.Size(128, 26);
            this.tong_tien.TabIndex = 7;
            this.tong_tien.Text = "0";
            this.tong_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tinh_tien
            // 
            this.tinh_tien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tinh_tien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_tien.Location = new System.Drawing.Point(134, 288);
            this.tinh_tien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tinh_tien.Name = "tinh_tien";
            this.tinh_tien.Size = new System.Drawing.Size(80, 24);
            this.tinh_tien.TabIndex = 8;
            this.tinh_tien.Text = "Tính tiền";
            this.tinh_tien.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(294, 288);
            this.thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(66, 24);
            this.thoat.TabIndex = 9;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // ten_kh
            // 
            this.ten_kh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_kh.Location = new System.Drawing.Point(181, 3);
            this.ten_kh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ten_kh.Name = "ten_kh";
            this.ten_kh.Size = new System.Drawing.Size(238, 29);
            this.ten_kh.TabIndex = 10;
            this.ten_kh.TextChanged += new System.EventHandler(this.ten_kh_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(114, 70);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(304, 31);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Bảng giá";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(526, 318);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ten_kh);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tinh_tien);
            this.Controls.Add(this.tong_tien);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bang_gia);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ten_kh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox bang_gia;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tong_tien;
        private System.Windows.Forms.Button tinh_tien;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox ten_kh;
        private System.Windows.Forms.TextBox textBox5;
    }
}

