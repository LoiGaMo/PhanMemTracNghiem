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
    public partial class SoanCauHoi_UC : UserControl
    {
        public SoanCauHoi_UC()
        {
            InitializeComponent();
        }

        KetNoi fn = new KetNoi();
        String query;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoanCauHoi_UC_Load(object sender, EventArgs e)
        {
            
            query = "select  a.MACH, a.noidung,dapan,trinhdo,tenmh,c.TENLOAI from cauhoi a join LOAICAUHOI c on a.MALOAI = c.MALOAI ";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        String id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                query = " select  a.noidung, dapan,b.NOIDUNG, trinhdo, tenmh,c.TENLOAI,a.mach from cauhoi a join chonlua b on a.mach = b.MACH  join LOAICAUHOI c on a.MALOAI = c.MALOAI where a.MACH = '"+id+"' and b.cau = a.DAPAN ";
                DataSet ds = fn.GetData(query);
                txtNoiDung.Text = ds.Tables[0].Rows[0][0].ToString();
                txtDapan.Text = ds.Tables[0].Rows[0][1].ToString();
                txtNoidungDapan.Text = ds.Tables[0].Rows[0][2].ToString();
                txtTrinhDo.Text = ds.Tables[0].Rows[0][3].ToString();
                txtTenMh.Text = ds.Tables[0].Rows[0][4].ToString();
                txtTenLoai.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMaCH.Text = ds.Tables[0].Rows[0][6].ToString();

            }
            catch { }
        }
        public void resettt()
        {
            txtNoiDung.Clear();
            txtDapan.Clear();
            txtTrinhDo.Clear();
            txtMaCH.Clear();
            txtTenMh.Clear();
            txtTenLoai.Clear();
        }

        public static String mach = "";
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String noidung = txtNoiDung.Text;
            String dapan = txtDapan.Text;
            String trinhdo = txtTrinhDo.Text;
            String tenmh = txtTenMh.Text;
            String maloai = "0";
            SoanCauHoi_UC.mach = txtMaCH.Text;

            query = "update cauhoi set noidung ='" + noidung + "',dapan ='" + dapan + "',trinhdo ='" + trinhdo + "',tenmh ='" + tenmh + "',maloai ='" + maloai + "' where mach = '" + mach + "'";
            fn.setData(query, "Cập Nhật Câu hỏi: " + mach );

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String noidung = txtNoiDung.Text;
            String dapan = txtDapan.Text;
            String trinhdo = txtTrinhDo.Text;
            String tenmh = txtTenMh.Text;
            String maloai = "0";
            String gv = "gv01";
            String mach = txtMaCH.Text;

            query = "insert into cauhoi (mach,noidung,dapan,trinhdo,tenmh,magv,maloai) values ('" + mach + "','" + noidung + "','" + dapan + "','" + trinhdo + "','" + tenmh + "','" + gv + "','" + maloai + "')";

            fn.setData(query, "Question Added.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu chưa được lưu sẽ bị mất", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                resettt();
            }
        }

        private void btnLuaChon_Click(object sender, EventArgs e)
        {
           
        }
    }
}
