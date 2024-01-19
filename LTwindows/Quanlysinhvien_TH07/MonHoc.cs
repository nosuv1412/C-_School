using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_TH07
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        //    this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLySinhVienDataSet);

        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLySinhVienDataSet);

        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.quanLySinhVienDataSet.Mon);

        }
    }
}
