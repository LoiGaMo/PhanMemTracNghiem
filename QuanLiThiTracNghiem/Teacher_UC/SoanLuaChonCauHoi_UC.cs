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
    public partial class SoanLuaChonCauHoi_UC : UserControl
    {
        KetNoi fn = new KetNoi();
        String query;
        public SoanLuaChonCauHoi_UC()
        {
            InitializeComponent();
        }
        private void SoanLuaChonCauHoi_UC_Load(object sender, EventArgs e)
        {
            cmbMaCauHoi.Items.Add("All Questions");
            query = "select distinct mach from cauhoi ";
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbMaCauHoi.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
        String id;
        private void cmbMaCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMaCauHoi.SelectedIndex != 0)
            {
                query = "select machonlua, cau , noidung from CHONLUA where chonlua.MACH = '" + cmbMaCauHoi.Text + "'";

                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select machonlua, cau , noidung from CHONLUA ";

                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        public void resettt()
        {
            txtDapan.Clear();
            txtMachonlua.Clear();
        }
        private void brnreset_Click(object sender, EventArgs e)
        {
            resettt();
        }

        private void txtDapan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String dapan = txtDapan.Text;
            String machonlua = txtMachonlua.Text;
            String cau = cmbCau.Text;

            query = "update chonlua set cau ='" + cau + "',noidung ='" + dapan + "' where machonlua = '" + machonlua + "'";
            fn.setData(query, "Cập Nhật Câu hỏi: " + cmbMaCauHoi.Text);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                query = "select machonlua, cau , noidung,chonlua.MACH  from CHONLUA where machonlua= '" + id + "'";
                DataSet ds = fn.GetData(query);
                txtMachonlua.Text = ds.Tables[0].Rows[0][0].ToString();
                cmbCau.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDapan.Text = ds.Tables[0].Rows[0][2].ToString();
                cmbMaCauHoi.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String dapan = txtDapan.Text;
            String machonlua = txtMachonlua.Text;
            String cau = cmbCau.Text;

            query = "insert into chonlua (machonlua,cau,noidung,mach) values ('" + machonlua + "','" + cau   + "','" + dapan + "','" + cmbMaCauHoi.Text + "')";

            fn.setData(query, "Question Added.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from chonlua where machonlua = '" + id + "' ";
                fn.setData(query, "Đã xóa thành công");
                
            }
        }
    }
}
