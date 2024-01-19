using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChuongTrinhBanSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            if(txtTenKH.Text.Trim() == "")
                errorProvider1.SetError(txtTenKH, "Hãy nhập tên Khách Hàng!");
            else
            {
                errorProvider1.Clear();
            }
            //int soluongsach = Convert.ToInt32(txtSoLuongSach);
            //if (soluongsach <= 0)
            //    errorProvider1.SetError(txtSoLuongSach, "Số nhập không được nhỏ hơn 0!");
            //else
            //    errorProvider1.Clear();

            
        }
    }
}
