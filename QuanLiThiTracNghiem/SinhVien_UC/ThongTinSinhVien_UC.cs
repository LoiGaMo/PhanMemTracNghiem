using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThiTracNghiem.SinhVien_UC
{
    public partial class ThongTinSinhVien_UC : UserControl
    {
        public ThongTinSinhVien_UC()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        String query;
        public string tendn = Login.DangNhap;
        public string mk = Login.MatKhau;
        private void comboQuestionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select HOTEN, PHAI,NGAYSINH,MALOP from SinhVien where MaSV = '" + cmbMaSinhVien.Text + "'";
            DataSet ds = fn.GetData(query);
            txtTenSinhVien.Text = ds.Tables[0].Rows[0][0].ToString();
            cmbPhai.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNgaySinh.Text = ds.Tables[0].Rows[0][2].ToString();
            txtLop.Text = ds.Tables[0].Rows[0][3].ToString();

        }

        private void ThongTinSinhVien_UC_Load(object sender, EventArgs e)
        {
            cmbMaSinhVien.Items.Clear();
            query = "select HOTEN, PHAI,NGAYSINH,MALOP, MASV from SinhVien a join taikhoan b on a.PASS = b.PASS where b.TENDANGNHAP = '" + tendn+"'";
            DataSet ds = fn.GetData(query);
            txtTenSinhVien.Text = ds.Tables[0].Rows[0][0].ToString();
            cmbPhai.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNgaySinh.Text = ds.Tables[0].Rows[0][2].ToString();
            txtLop.Text = ds.Tables[0].Rows[0][3].ToString();
            cmbMaSinhVien.Text = ds.Tables[0].Rows[0][4].ToString();

        }
    }
}
