
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.giai = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX + B = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập B";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nghiệm phương trình";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(223, 119);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(355, 27);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(223, 184);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(355, 27);
            this.textBoxB.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(355, 27);
            this.textBox3.TabIndex = 6;
            // 
            // giai
            // 
            this.giai.Location = new System.Drawing.Point(171, 322);
            this.giai.Name = "giai";
            this.giai.Size = new System.Drawing.Size(80, 35);
            this.giai.TabIndex = 7;
            this.giai.Text = "&Giải";
            this.giai.UseVisualStyleBackColor = true;
            this.giai.Click += new System.EventHandler(this.giai_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(338, 322);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(80, 35);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "&Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(503, 322);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(80, 35);
            this.thoat.TabIndex = 9;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 415);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.giai);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "                                                               Giải phương trình " +
    "bậc nhất";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button giai;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

