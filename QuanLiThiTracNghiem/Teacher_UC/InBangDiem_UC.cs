using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QuanLiThiTracNghiem.Teacher_UC
{
    public partial class InBangDiem_UC : UserControl
    {
        KetNoi fn = new KetNoi();
        String query;
        public InBangDiem_UC()
        {
            InitializeComponent();
        }

        private void InBangDiem_UC_Load(object sender, EventArgs e)
        {
            cmbInLop.Items.Add("Toàn Bộ Lớp");
            query = "select distinct a.malop,TENMH,lanthi from dangkythi a join thi b on a.IDDKT = b.IDDKT  join sinhvien c on b.MASV = c.MASV join monhoc d on a.MAMH = d.MAMH ";
           
           
            DataSet ds = fn.GetData(query);
            txtInLanThi.Text = ds.Tables[0].Rows[0][1].ToString();
            txtInMon.Text = ds.Tables[0].Rows[0][2].ToString();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbInLop.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cmbInLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInLop.SelectedIndex != 0)
            {
                query = "select c.masv,hoten,diem from dangkythi a join thi b on a.IDDKT = b.IDDKT join sinhvien c on b.MASV = c.MASV join monhoc d on a.MAMH = d.MAMH where a.malop = '" + cmbInLop.Text + "'";

                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void exportexcel(DataGridView g , string duongdan , string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            for(int i = 1; i<g.Columns.Count +  1; i++)
            {
                obj.Cells[1,i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for(int j=0;j < g.Columns.Count; j++)
                {
                    if(g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            exportexcel(dataGridView1, @"E:\", "xuatfileExcel");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
