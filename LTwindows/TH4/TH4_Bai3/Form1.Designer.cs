namespace TH4_Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(117, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 75);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(267, 38);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(58, 21);
            this.rdChia.TabIndex = 0;
            this.rdChia.TabStop = true;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            this.rdChia.Click += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(176, 38);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(64, 21);
            this.rdNhan.TabIndex = 0;
            this.rdNhan.TabStop = true;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            this.rdNhan.Click += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(96, 38);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(51, 21);
            this.rdTru.TabIndex = 0;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            this.rdTru.Click += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(6, 38);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(63, 21);
            this.rdCong.TabIndex = 0;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            this.rdCong.Click += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số 2";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(114, 41);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(38, 16);
            this.lb.TabIndex = 8;
            this.lb.Text = "Số 1";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(183, 244);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(259, 20);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(175, 64);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(267, 20);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(175, 38);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(267, 20);
            this.txt1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
    }
}

