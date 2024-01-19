namespace Bai1
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
            this.button1 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(381, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(161, 38);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(179, 20);
            this.input.TabIndex = 11;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb3.Location = new System.Drawing.Point(56, 221);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(197, 17);
            this.lb3.TabIndex = 10;
            this.lb3.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb2.Location = new System.Drawing.Point(56, 160);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(213, 17);
            this.lb2.TabIndex = 9;
            this.lb2.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb1.Location = new System.Drawing.Point(56, 100);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(190, 17);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập số n  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
    }
}

