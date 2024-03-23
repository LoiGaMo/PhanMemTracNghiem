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
    public partial class UC_UpdateQuestion : UserControl
    {
        public UC_UpdateQuestion()
        {
            InitializeComponent();
        }
        KetNoi fn = new KetNoi();
        String query;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboQuestionNo.Items.Clear();
            query = "select qNo from questions where qset  = '" + comboSet.Text + "'";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestionNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
            
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_UpdateQuestion_Load(this, null);
        }

        private void UC_UpdateQuestion_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            query = "select distinct qset from questions";
            DataSet ds = fn.GetData(query);


            for(int i=0;i< ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
//        select a.MACH, a.noidung, dapan, trinhdo, tenmh from cauhoi a
//join chonlua b on a.mach = b.MACH where a.MACH = '01' and b.cau = a.DAPAN
        private void comboQuestionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select question,optionA,optionB,optionC,optionD,ans from questions where qset = '" + comboSet.Text + "'and qNo = '" + comboQuestionNo.Text + "'";

            DataSet ds = fn.GetData(query);
            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            txtOption4.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ALLClear();
        }
        public void ALLClear()
        {
            txtAnswer.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtQuestion.Clear();
            comboSet.SelectedIndex = -1;
            comboQuestionNo.SelectedIndex = -1;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(comboQuestionNo.SelectedIndex != -1)
            {
                String qset = comboSet.Text;
                String qNo = comboQuestionNo.Text;
                String question = txtQuestion.Text;
                String ans = txtAnswer.Text;
                String option1 = txtOption1.Text;
                String option2 = txtOption2.Text;
                String option3 = txtOption3.Text;
                String option4 = txtOption4.Text;

                query = "update questions set question ='" + question + "',optionA ='" + option1 + "',optionB ='" + option2 + "',optionC ='" + option3 + "',optionD ='" + option4 + "',ans ='"+ans+"' where qset = '"+qset+"'and qNo='"+qNo+"'";
                fn.setData(query, "Question No: " + qNo + "\n Question Set: " + qset + "\n is Updated. ");
            }
            else
            {
                MessageBox.Show("Chọn câu hỏi đầu tiên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
