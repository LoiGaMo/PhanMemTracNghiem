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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel2, new Teacher_UC.SoanLuaChonCauHoi_UC());
        }

        private void btnViewDeleteQuestion_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel2, new Teacher_UC.UC_ViewDeleteQuestion());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel2, new Teacher_UC.UC_ThongTInGV());
        }

        private void btnSoanCauHoi_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel2, new Teacher_UC.SoanCauHoi_UC());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kn.ThemUserControl(panel2, new Teacher_UC.InBangDiem_UC());
        }
    }
}
