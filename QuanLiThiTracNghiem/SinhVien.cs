using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThiTracNghiem
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel1, new SinhVien_UC.ThongTinSinhVien_UC());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void thôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher frm = new teacher();
            frm.Show();
            this.Hide();
        }

        private void thâyĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel1, new SinhVien_UC.DoiMatKhau_UC());
        }

        private void nhậpThôngTinTHiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel1, new SinhVien_UC.ThongTinThi());
        }

        private void đăngKíThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel1, new SinhVien_UC.DangKyThi_UC());
        }

        private void xemLạiBàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel1, new SinhVien_UC.XemLaiBaiThi_UC());
        }

        private void thiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thi thi = new Thi();
            thi.Show();
            this.Hide();
        }
    }
}
