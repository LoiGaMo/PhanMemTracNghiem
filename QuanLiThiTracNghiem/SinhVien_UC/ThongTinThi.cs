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
    public partial class ThongTinThi : UserControl
    {
        public ThongTinThi()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        String query;
        public string tendn = Login.DangNhap;
        public string mk = Login.MatKhau;
        public static String MSSV = "";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            
        }

        private void ThongTinThi_Load(object sender, EventArgs e)
        {

            query = "Select distinct a.MASV, b.MaLop, c.TenMH,b.LANTHI,b.NGAYTHI from THONGTINTHI a join" +
                " DANGKYTHi b on a.TENMH = b.MAMH JOIN MONHOC c on b.MAMH = c.MAMH join TAIKHOAN d on a.MASV = d.MANGUOIDUNG join SINHVIEN e on b.MALOP = e.MALOP where d.TENDANGNHAP = '" + tendn+"' and d.Pass = '"+mk+"'";


            //  Select distinct a.MASV, b.MaLop, c.TenMH,b.LANTHI,b.NGAYTHI from THONGTINTHI a join 
            //    DANGKYTHi b on a.TENMH = b.MAMH JOIN
            // MONHOC c on b.MAMH = c.MAMH join TAIKHOAN d on a.MASV = d.MANGUOIDUNG
            // where d.TENDANGNHAP = 'tuanvu'
            DataSet ds = fn.GetData(query);
            txtNTTMaSinhVien.Text = ds.Tables[0].Rows[0][0].ToString();
            ThongTinThi.MSSV = txtNTTMaSinhVien.Text;
            txtNTTLop.Text = ds.Tables[0].Rows[0][1].ToString();
            cmbMonThi.Text = ds.Tables[0].Rows[0][2].ToString();
            cmbLanThi.Text = ds.Tables[0].Rows[0][3].ToString();
            cmbNgayThi.Text = ds.Tables[0].Rows[0][4].ToString();
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    cmbMonThi.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //}




        }
    }
}
