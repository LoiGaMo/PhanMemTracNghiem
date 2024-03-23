using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLiThiTracNghiem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        DataSet ds_kiemtradn = new DataSet();
        String query;
        DataSet ds;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }
       public static String DangNhap = "";
       public static String MatKhau = "";
        private void btnDN_Click(object sender, EventArgs e)
        {

            Login.DangNhap = txtDN.Text;
            Login.MatKhau = txtMK.Text;
            query = "Select TENDANGNHAP, PASS from TAIKHOAN where PASS = '" + txtMK.Text + "' and TENDANGNHAP = '" + txtDN.Text + "'";

            DataSet ds = fn.GetData(query);
            SqlDataReader sdr = fn.getForCombo(query);
            if (sdr.Read() == true)
            {
                if (rdbGV.Checked == true)
                {
                    teacher ts = new teacher();
                    ts.Show();
                    this.Hide();
                }
                else if (rdbSV.Checked == true)
                {
                    SinhVien sv = new SinhVien();
                    sv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kiểm tra đăng nhập", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra đăng nhập", "Thông Báo!");

            }

        }
        String taikhoan = "";
        String password = "";
        void kiemtra()
        {
            Login.DangNhap = txtDN.Text;
            Login.MatKhau = txtMK.Text;
            SqlDataReader sdr = fn.getForCombo(query);
            if (DangNhap == taikhoan && MatKhau == password)
            {
                if (sdr.Read() == true)
                {
                    if (rdbGV.Checked == true)
                    {
                        teacher ts = new teacher();
                        ts.Show();
                        this.Hide();
                    }
                    else if (rdbSV.Checked == true)
                    {
                        SinhVien sv = new SinhVien();
                        sv.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra đăng nhập", "Thông Báo!");
            }

        }
        private void Login_Load(object sender, EventArgs e)
        {
            //query = "Select TENDANGNHAP, PASS from TAIKHOAN";
            //ds_kiemtradn = fn.GetData(query);
            //taikhoan = ds_kiemtradn.Tables[0].Rows[0][0].ToString();
            //password = ds_kiemtradn.Tables[0].Rows[0][1].ToString();
       
        }
    }
}
