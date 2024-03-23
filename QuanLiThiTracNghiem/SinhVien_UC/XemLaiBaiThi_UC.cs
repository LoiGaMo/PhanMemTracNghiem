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
    public partial class XemLaiBaiThi_UC : UserControl
    {
        public XemLaiBaiThi_UC()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        String query;
        public string tendn = Login.DangNhap;
        public string mk = Login.MatKhau;
        private void XemLaiBaiThi_UC_Load(object sender, EventArgs e)
        {
            query = "select distinct d.HOTEN,d.MALOP,a.TENMH,f.LANTHI from cauhoi a join CHITIETBT b on a.MACH = b.MACH join thi  c on b.MABT = c.MABT join sinhvien d on c.MASV = d.MASV join taikhoan e on d.PASS = e.PASS join DANGKYTHI f on c.IDDKT = f.IDDKT where e.TENDANGNHAP = '" + tendn + "' ";
            DataSet ds = fn.GetData(query);
            txtXBTTenSinhVien.Text = ds.Tables[0].Rows[0][0].ToString();
            txtXBTLop.Text = ds.Tables[0].Rows[0][1].ToString();
            cmbMonThi.Text = ds.Tables[0].Rows[0][2].ToString();
            cmbLanThi.Text = ds.Tables[0].Rows[0][3].ToString();


            //            select a.noidung, caudachon,a.dapan,d.HOTEN,d.MALOP,a.TENMH,f.LANTHI from cauhoi a
            //join CHITIETBT b on a.MACH = b.MACH join thi  c on b.MABT = c.MABT
            //join sinhvien d on c.MASV = d.MASV
            //join taikhoan e on d.PASS = e.PASS
            //join DANGKYTHI f on c.IDDKT = f.IDDKT
            //where e.TENDANGNHAP = 'tuanvu'
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            query = "select a.noidung, caudachon,a.dapan from cauhoi a join CHITIETBT b on a.MACH = b.MACH join thi  c on b.MABT = c.MABT join sinhvien d on c.MASV = d.MASV join taikhoan e on d.PASS = e.PASS join DANGKYTHI f on c.IDDKT = f.IDDKT where e.TENDANGNHAP = '"+tendn+"'";

            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        public void getSizeColumn()
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }
            catch { }
        }
    }
}
