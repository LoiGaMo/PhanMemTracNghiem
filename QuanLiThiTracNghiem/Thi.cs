using System;
using System.Collections;
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
    public partial class Thi : Form
    {

        KetNoi fn = new KetNoi();
        String query;
        DataSet ds_CauTraLoi = new DataSet();
        DataSet ds_CauHoi = new DataSet();
        DataSet ds_Diem = new DataSet();
        DataSet ds_DapAn = new DataSet();
        DataSet ds_Chitietbaithi = new DataSet();
        public String iddkt = SinhVien_UC.DangKyThi_UC.IDDKT;
        public String MSSV = SinhVien_UC.ThongTinThi.MSSV;
        int _CauHoiHienTai = 0;
        String MaBT = "";
        int b = 0;
        int a = 0;
        int d = 0;
        int c;
        int count = 0;
        int min = 0;
        int Diem = 0;
        String diem;
        public Thi()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void Thi_Load(object sender, EventArgs e)
        {
            query = "Select NoiDung from cauhoi ";
            ds_CauHoi = fn.GetData(query);
            query = "select NoiDung from chonlua ";
            ds_CauTraLoi = fn.GetData(query);
            query = "Select Dapan from cauhoi";
            ds_DapAn = fn.GetData(query);
            query = "select mabt from thi order by MaBT desc";
            ds_Diem = fn.GetData(query);
            query = "select a.mach,CAUDACHON from cauhoi a join chitietbt b on a.MACH= b.MACH";
            ds_Chitietbaithi = fn.GetData(query);
            btnCauTruoc.Enabled = false;
            btnTiepTheo.Enabled = false;


            if (ds_CauTraLoi != null && ds_CauTraLoi.Tables.Count > _CauHoiHienTai)
            {
                XuatCauTraLoi(_CauHoiHienTai, b);
            }
            else
            {
                MessageBox.Show("Không thể truy xuất dữ liệu câu trả lời cho câu hỏi hiện tại.");
            }

            // Tương tự cho phương thức XuatCauHoi
            if (ds_CauHoi != null && ds_CauHoi.Tables.Count > _CauHoiHienTai)
            {
                XuatCauHoi(_CauHoiHienTai, a);
            }
            else
            {
                MessageBox.Show("Không thể truy xuất dữ liệu câu hỏi cho câu hỏi hiện tại.");
            }


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = false;
            }

            if (dataGridView1.Columns.Contains("MABT"))
            {
                dataGridView1.Columns["MABT"].ReadOnly = false;
            }

            // Gắn sự kiện CellEndEdit

            // Trong sự kiện Thi_Load
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);

        }
        public void XuatCauTraLoi(int CauHienTai, int b)
        {

            txtCauA.Text = ds_CauTraLoi.Tables[CauHienTai].Rows[b][0].ToString();
            txtCauB.Text = ds_CauTraLoi.Tables[CauHienTai].Rows[b + 1][0].ToString();
            txtCauC.Text = ds_CauTraLoi.Tables[CauHienTai].Rows[b + 2][0].ToString();
            txtCauD.Text = ds_CauTraLoi.Tables[CauHienTai].Rows[b + 3][0].ToString();

        }

        public void XuatCauHoi(int CauHienTai, int a)
        {
            if (a == 10)
            {
                // btnCauTruoc.Enabled = false;
                btnTiepTheo.Enabled = false;
                btnCauTruoc.Enabled = true;
                a = 9;
                b = b - 4;
            }
            else if (a == 0)
            {
                btnCauTruoc.Enabled = false;
                btnTiepTheo.Enabled = false;
            }

            txtNoiDung.Text = ds_CauHoi.Tables[CauHienTai].Rows[a][0].ToString();
          
        }
        void resettt()
        {
            rdCauA.Checked = false;
            rdCauB.Checked = false;
            rdCauC.Checked = false;
            rdCauD.Checked = false;
        }
        private string CauHoi()
        {
            string d = "";
            if (rdCauA.Checked)
                d = "a";
            if (rdCauB.Checked)
                d = "b";
            if (rdCauC.Checked) 
                d = "c";
            if (rdCauD.Checked) 
                d = "d";
            return d;
        }
        private void DanhSachDapAn(int dapan,int d)
        {

            if (ds_DapAn != null && ds_DapAn.Tables.Count > dapan && ds_DapAn.Tables[dapan] != null)
            {
                // Kiểm tra xem có đủ số lượng dòng không
                if (d < ds_DapAn.Tables[dapan].Rows.Count)
                {
                    // Lấy giá trị từ dòng tại vị trí d
                    string giaTriDong = ds_DapAn.Tables[dapan].Rows[d][0].ToString();

                    // Kiểm tra và thực hiện các thao tác với giá trị
                    if ((String)dataGridView1.Rows[0].Cells["Dapan"].Value == giaTriDong)
                    {
                        Diem++;
                    }

                    // Cập nhật điểm
                    diem = Diem.ToString();
                }
                else
                {
                    MessageBox.Show("Không có đủ dòng để truy cập.");
                }
            }
            else
            {
                MessageBox.Show("DataTable không tồn tại hoặc không có dữ liệu.");
            }
        }

        
        private void LuuDanhSachDapAn()
        {
            int mabt = int.Parse(ds_Diem.Tables[0].Rows[0][0].ToString());
            MaBT = (mabt + 1).ToString();
            String mach;
            String caudachon ="";
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i <= dataGridView1.Rows.Count; i++)
            {
                mach = ds_Chitietbaithi.Tables[0].Rows[i][0].ToString();
                caudachon = dataGridView1.Rows[i].Cells["dapan"].Value.ToString();
                query = "insert into chitietbt (mabt,mach,caudachon) values ('" + MaBT + "','" + mach + "','" + caudachon + "')";
                fn.setData(query, "Loading Câu: "+i);
            }
        }
        private void SuaDapAn()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                // Lấy chỉ mục của hàng hiện tại (hoặc chỉ mục của hàng cuối cùng nếu không có hàng được chọn)
                int currentIndex = dataGridView1.CurrentRow != null ? dataGridView1.CurrentRow.Index : dataGridView1.Rows.Count - 1;

                // Xóa hàng hiện tại khỏi DataGridView
                dataGridView1.Rows.RemoveAt(currentIndex);
            }
            else
            {
                MessageBox.Show("Không có hàng để xóa.");
            }

        }

        private void LuuDiem()
        {
            int mabt =int.Parse(ds_Diem.Tables[0].Rows[0][0].ToString());
           MaBT = (mabt+1).ToString();
            diem = diem + ".0";
            query = "insert into thi (mabt,masv,diem,iddkt) values ('" + MaBT + "','" + MSSV + "','" + diem + "','" + iddkt + "')";

            fn.setData(query, "Lưu Điểm Thi");
        }
        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
          
            dataGridView1.Rows.Add(lbCau.Text, CauHoi());

            btnCauTruoc.Enabled = true;
            _CauHoiHienTai++;
            a = a + 1;
            b = b + 4;
            if (ds_CauTraLoi.Tables.Count == _CauHoiHienTai)
            {
                _CauHoiHienTai = ds_CauTraLoi.Tables.Count - 1;
            }
            c = a + 1;
            lbCau.Text = c.ToString();
            resettt();


            DanhSachDapAn(_CauHoiHienTai,d);
            XuatCauHoi(_CauHoiHienTai, a);
            XuatCauTraLoi(_CauHoiHienTai, b);
            d++;
      
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            btnTiepTheo.Enabled = true;
            _CauHoiHienTai--;
            a = a - 1;
            b = b - 4;
            if (_CauHoiHienTai < 0)
            {
                _CauHoiHienTai = 0;
            }

            lbCau.Text = (a + 1).ToString();
            resettt();
            XuatCauHoi(_CauHoiHienTai, a);
            XuatCauTraLoi(_CauHoiHienTai, b);

            SuaDapAn();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
          
           
            tmStart.Stop();
            SuaDapAn();
            LuuDanhSachDapAn();

            LuuDiem();
            SinhVien sv = new SinhVien();
            sv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnTiepTheo.Enabled = true;
            tmStart.Start();
        }

        private void tmStart_Tick(object sender, EventArgs e)
        {

            count++;
            if (count >= 60)
            {
                min++;
                if (min.ToString().Length == 1)
                {
                    txtPhut.Text = "0" + min.ToString();
                }
                else
                {
                    txtPhut.Text = min.ToString();
                }
                count = 0;
            }
            if (count.ToString().Length == 1)
            {
                txtGiay.Text = "0" + count.ToString();
            }
            else
            {
                txtGiay.Text = count.ToString();
            }
            if (min >= 10)
            {
                tmStart.Stop();
                MessageBox.Show("Hết Giờ làm bài!", "Thông Báo!");

            }


        }
        private void rdCauA_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void UpdateCauTraLoi(int rowIndex, object newValue)
        {
            try
            {
                if (ds_CauTraLoi != null && ds_CauTraLoi.Tables.Count > _CauHoiHienTai)
                {
                    int cauTraLoiIndex = rowIndex % 4; // Vị trí của câu trả lời trong nhóm 4 câu trả lời
                    int groupIndex = rowIndex / 4; // Nhóm câu trả lời

                    // Kiểm tra số lượng nhóm câu trả lời
                    if (groupIndex < ds_CauTraLoi.Tables[_CauHoiHienTai].Rows.Count)
                    {
                        ds_CauTraLoi.Tables[_CauHoiHienTai].Rows[groupIndex][cauTraLoiIndex] = newValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không có đủ dòng để cập nhật.");
                    }
                }
                else
                {
                    MessageBox.Show("DataTable ds_CauTraLoi không tồn tại hoặc không có dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật giá trị trong ds_CauTraLoi: {ex.Message}");
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           

        }

     

       
    }
}
