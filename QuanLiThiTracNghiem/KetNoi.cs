using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace QuanLiThiTracNghiem
{
    class KetNoi
    {
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=ThiTracNghiem;Integrated Security=True");
            return con;
        }
        public void ThemUserControl(Panel nen, UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            nen.Controls.Clear();
            nen.Controls.Add(uc);
        }
        public DataSet GetData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query,String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
