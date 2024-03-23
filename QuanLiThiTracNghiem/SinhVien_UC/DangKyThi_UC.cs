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
    public partial class DangKyThi_UC : UserControl
    {
        public DangKyThi_UC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        KetNoi fn = new KetNoi();
        String query; 
        public string tendn = Login.DangNhap;
        public string mk = Login.MatKhau;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static String IDDKT = "";
        private void DangKyThi_UC_Load(object sender, EventArgs e)
        {
            query = "  select  a.IDDKT, a.MaLop, MaMH,LanThi,NgayThi,TrinhDo,SoCauHoi,ThoiGian from DANGKYTHI a join thi b on a.IDDKT = b.IDDKT join SINHVIEN c on c.MASV = b.MASV join TAIKHOAN d on c.PASS = d.PASS where D.TENDANGNHAP = '" + tendn + "'";
            DataSet ds = fn.GetData(query);
            Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtDKTLop.Text = ds.Tables[0].Rows[0][1].ToString();
            txtDKTMon.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDKTLanThi.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDKTNgayThi.Text = ds.Tables[0].Rows[0][4].ToString();
            txtDKTTrinhDo.Text = ds.Tables[0].Rows[0][5].ToString();
            txtDKTSoCauHoi.Text = ds.Tables[0].Rows[0][6].ToString();
            txtDKTThoiGian.Text = ds.Tables[0].Rows[0][7].ToString();
            
            LabelDKT.Text = (id).ToString();
            DangKyThi_UC.IDDKT = LabelDKT.Text;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            String IDDKT = LabelDKT.Text;
            String Lop = txtDKTLop.Text;
            String Mon = txtDKTMon.Text;
            String LanThi = txtDKTLanThi.Text;
            String NgayThi = txtDKTNgayThi.Text;
            String TrinhDo = txtDKTTrinhDo.Text;
            String SoCauHoi = txtDKTSoCauHoi.Text;
            String ThoiGian = txtDKTThoiGian.Text;
            String MANVPDT = "PDT01";
            query = "insert into DANGKYTHI (IDDKT,MALOP,MAMH,LANTHI,NGAYTHI,TRINHDO,SOCAUHOI,THOIGIAN,MANVPDT) values ( '"+IDDKT+"','" + Lop + "','" + Mon + "','" + LanThi + "','" + NgayThi + "','" + TrinhDo + "','" + SoCauHoi + "','" + ThoiGian + "','" + MANVPDT + "')";
            fn.setData(query, "Đăng Kí Thành Công: " + "\nLớp: " + Lop + "\nNgày Thi: " + NgayThi);


        }
    }
}
