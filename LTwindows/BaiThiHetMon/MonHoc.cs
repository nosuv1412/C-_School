using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThiHetMon
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.quanLySinhVienDataSet.Mon);

        }
    }
}
