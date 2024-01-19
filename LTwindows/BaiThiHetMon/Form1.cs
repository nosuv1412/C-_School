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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbttSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "SinhVien")
                {
                    f.Activate();
                    return;
                }
            SinhVien sinhVien = new SinhVien();
            sinhVien.MdiParent = this;
            sinhVien.Show();
        }

        private void tsbttThoat_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void tsbttKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Khoa")
                {
                    f.Activate();
                    return;
                }
            Khoa khoa = new Khoa();
            khoa.MdiParent = this;
            khoa.Show();
        }

        private void tsbttMonHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "MonHoc")
                {
                    f.Activate();
                    return;
                }
            MonHoc monHoc = new MonHoc();
            monHoc.MdiParent = this;
            monHoc.Show();
        }

        private void tsbttNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "NhapDiem")
                {
                    f.Activate();
                    return;
                }
            NhapDiem nhapDiem = new NhapDiem();
            nhapDiem.MdiParent = this;
            nhapDiem.Show();
        }

        private void tsbttXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "XemDiem")
                {
                    f.Activate();
                    return;
                }
            XemDiem xemDiem = new XemDiem();
            xemDiem.MdiParent = this;
            xemDiem.Show();
        }

        private void tsbttThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}
