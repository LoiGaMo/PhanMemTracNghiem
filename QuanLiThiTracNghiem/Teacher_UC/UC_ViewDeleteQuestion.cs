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
    public partial class UC_ViewDeleteQuestion : UserControl
    {

        KetNoi fn = new KetNoi();
        String query ;
        public UC_ViewDeleteQuestion()
        {
            InitializeComponent();
        }

        private void UC_ViewDeleteQuestion_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            comboSet.Items.Add("All Questions");
            query = "select  a.MACH, a.noidung,dapan,trinhdo,tenmh,c.TENLOAI from cauhoi a join LOAICAUHOI c on a.MALOAI = c.MALOAI ";
            DataSet ds =  fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSet.SelectedIndex != 0)
            {
                query = "select  a.MACH, a.noidung,dapan,trinhdo,tenmh,c.TENLOAI from cauhoi a join LOAICAUHOI c on a.MALOAI = c.MALOAI where a.MACH = '" + comboSet.Text + "'";

                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select  a.MACH, a.noidung,dapan,trinhdo,tenmh,c.TENLOAI from cauhoi a join LOAICAUHOI c on a.MALOAI = c.MALOAI";

                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        int id, questionNo;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from cauhoi where MACH = '" + id + "' ";
                fn.setData(query, "Đã xóa thành công");
                UC_ViewDeleteQuestion_Load(this, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_ViewDeleteQuestion_Load(this, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
               // questionNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch { }
        }

    }
     
    }
