using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace QuanLiThiTracNghiem.SinhVien_UC
{
    public partial class DoiMatKhau_UC : UserControl
    {
        public DoiMatKhau_UC()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        String query;
        public string tendn = Login.DangNhap;
        public string mk = Login.MatKhau;
    
        private void DoiMatKhau_UC_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Tài khoản: " + tendn;
            cmbMaSinhVien.Items.Clear();
            query = "select MASV, HOTEN,MALOP, PHAI,NGAYSINH from SinhVien a join TAIKHOAN b on a.PASS = b.PASS where TENDANGNHAP = '"+tendn+"'";
            DataSet ds = fn.GetData(query);
            txt1.Text = ds.Tables[0].Rows[0][0].ToString();
            txt2.Text = ds.Tables[0].Rows[0][1].ToString();
            txt3.Text = ds.Tables[0].Rows[0][2].ToString();
            txt4.Text = ds.Tables[0].Rows[0][3].ToString();
            txt5.Text = ds.Tables[0].Rows[0][4].ToString();

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    cmbMaSinhVien.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //}
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
            query = "update TAIKHOAN set PASS = '" + txtMKM.Text + "'  where TENDANGNHAP = '"+tendn+"' ";
            DataSet ds = fn.GetData(query);
            fn.setData(query, "Tên Đăng Nhập: " + tendn + "\n Mặt Khẩu: "+mk+  "\n is Updated. ");
            // Update MK



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMKC.Clear();
            txtMKM.Clear();
            txtXN.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select HOTEN, PHAI,NGAYSINH,MALOP from SinhVien where MaSV = '" + cmbMaSinhVien.Text + "'";
            DataSet ds = fn.GetData(query);
            txtTenSinhVien.Text = ds.Tables[0].Rows[0][0].ToString();
            cmbPhai.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNgaySinh.Text = ds.Tables[0].Rows[0][2].ToString();
            txtLop.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TenSinhVien = txtTenSinhVien.Text;
            String Phai = cmbPhai.Text;
            String NgaySinh = txtNgaySinh.Text;
            String Lop = txtLop.Text;

            query = "update SinhVien set HoTen = '"+ TenSinhVien+"', Phai = '"+Phai+"', NgaySinh = '"+NgaySinh+"', MaLop = '"+Lop+ "'  where MaSV = '" + cmbMaSinhVien.Text + "'";


            fn.setData(query, "MSSV: " + cmbMaSinhVien.Text   + "\n is Updated. ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
