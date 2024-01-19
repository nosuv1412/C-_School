
namespace WindowsFormsApp3
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cong = new System.Windows.Forms.RadioButton();
            this.tru = new System.Windows.Forms.RadioButton();
            this.nhan = new System.Windows.Forms.RadioButton();
            this.chia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(454, 27);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chia);
            this.groupBox1.Controls.Add(this.nhan);
            this.groupBox1.Controls.Add(this.tru);
            this.groupBox1.Controls.Add(this.cong);
            this.groupBox1.Location = new System.Drawing.Point(61, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Location = new System.Drawing.Point(8, 35);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(69, 24);
            this.cong.TabIndex = 0;
            this.cong.TabStop = true;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.CheckedChanged += new System.EventHandler(this.cong_CheckedChanged);
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Location = new System.Drawing.Point(134, 35);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(55, 24);
            this.tru.TabIndex = 1;
            this.tru.TabStop = true;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.CheckedChanged += new System.EventHandler(this.tru_CheckedChanged);
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Location = new System.Drawing.Point(264, 35);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(69, 24);
            this.nhan.TabIndex = 2;
            this.nhan.TabStop = true;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Location = new System.Drawing.Point(419, 35);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(64, 24);
            this.chia.TabIndex = 3;
            this.chia.TabStop = true;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.CheckedChanged += new System.EventHandler(this.chia_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả:";
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(119, 286);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(454, 27);
            this.kq.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 353);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "                                                         Phép tính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chia;
        private System.Windows.Forms.RadioButton nhan;
        private System.Windows.Forms.RadioButton tru;
        private System.Windows.Forms.RadioButton cong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

