using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThiTracNghiem.Teacher_UC
{
    public partial class UC_ThongTInGV : UserControl
    {
        public UC_ThongTInGV()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        String query;
        public string tendn = Login.DangNhap;
        public string mk = Login.MatKhau;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UC_ThongTInGV_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Tài khoản: " + tendn;

            query = "select MAGV, HOTENGV,MAKHOA from GIAOVIEN a join TAIKHOAN b on a.PASS = b.PASS where TENDANGNHAP = '" + tendn + "'";
            DataSet ds = fn.GetData(query);

            txt1.Text = ds.Tables[0].Rows[0][0].ToString();
            txt2.Text = ds.Tables[0].Rows[0][1].ToString();
            txt3.Text = ds.Tables[0].Rows[0][2].ToString();

            txtTenGiaoVien.Text = ds.Tables[0].Rows[0][1].ToString();
            txtKhoa.Text = ds.Tables[0].Rows[0][2].ToString();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMKC.PasswordChar = txtMKM.PasswordChar = txtXN.PasswordChar = '\0';
            }
            else
            {
                txtMKC.PasswordChar = txtMKM.PasswordChar = txtXN.PasswordChar = '*';
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (txtMKC.Text == "" || txtMKM.Text == "" || txtXN.Text == "")
            {
                MessageBox.Show("\t Vui lòng nhập đầy đủ thông tin \t");
                return;
            }
            if (txtMKC.Text != mk)
            {
                MessageBox.Show("\t Mật khẩu cũ không đúng \t");
                return;
            }
            if (txtMKM.Text != txtXN.Text)
            {
                MessageBox.Show("\t Mật khẩu xác nhận không đúng \t");
                return;
            }
            query = "update TAIKHOAN set PASS = '" + txtMKM.Text + "'  where TENDANGNHAP = '" + tendn + "' ";
            DataSet ds = fn.GetData(query);
            fn.setData(query, "Tên Đăng Nhập: " + tendn + "\n Mặt Khẩu: " + mk + "\n is Updated. ");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMKC.Clear();
            txtMKM.Clear();
            txtXN.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TenGiaoVien = txtTenGiaoVien.Text;
            String Khoa = txtKhoa.Text;

            query = "update GiaoVien set HoTenGV = '" + TenGiaoVien + "', MAKHOA = '" + Khoa + "'  where PASS = '" + mk + "'";


            fn.setData(query, "Giáo Viên: " + txtTenGiaoVien.Text + "\n Khoa: " + Khoa + "\n is Updated. ");
        }
    }
}
