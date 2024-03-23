using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThiTracNghiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            lbthongbao.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSelectUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if(txtSelectUser.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShow.Text = "Hiện thị Mật khẩu";

            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShow.Text = "Hiện thị Mật khẩu";

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text =="1" && txtPassword.Text == "1")
            {
                lbthongbao.Visible = false;
                teacher ts = new teacher();
                ts.Show();
                this.Hide();
            }
            else
            {
                lbthongbao.Visible = true;
            }
        }
    }
}
