using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH8_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=qlsinhvien_TH8;Integrated Security=True");
           
        }
    }
}
