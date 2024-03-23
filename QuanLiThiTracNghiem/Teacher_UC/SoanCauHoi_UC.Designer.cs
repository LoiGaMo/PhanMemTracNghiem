
namespace QuanLiThiTracNghiem.Teacher_UC
{
    partial class SoanCauHoi_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDapan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoidungDapan = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtTenMh = new System.Windows.Forms.TextBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.NoiDung,
            this.dapan,
            this.Trinhdo,
            this.tenmh,
            this.TenLoai});
            this.dataGridView1.Location = new System.Drawing.Point(25, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 410);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã CH";
            this.MaCH.MinimumWidth = 6;
            this.MaCH.Name = "MaCH";
            this.MaCH.Width = 50;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "Noidung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 300;
            // 
            // dapan
            // 
            this.dapan.DataPropertyName = "Dapan";
            this.dapan.HeaderText = "Đáp Án";
            this.dapan.MinimumWidth = 6;
            this.dapan.Name = "dapan";
            this.dapan.Width = 50;
            // 
            // Trinhdo
            // 
            this.Trinhdo.DataPropertyName = "Trinhdo";
            this.Trinhdo.HeaderText = "Trình Độ";
            this.Trinhdo.MinimumWidth = 6;
            this.Trinhdo.Name = "Trinhdo";
            this.Trinhdo.Width = 75;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "Tenmh";
            this.tenmh.HeaderText = "Tên Môn Học";
            this.tenmh.MinimumWidth = 6;
            this.tenmh.Name = "tenmh";
            this.tenmh.Width = 120;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TENLOAI";
            this.TenLoai.HeaderText = "Tên Loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Width = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(20, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nội Dung:";
            // 
            // txtDapan
            // 
            this.txtDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDapan.Location = new System.Drawing.Point(412, 124);
            this.txtDapan.Name = "txtDapan";
            this.txtDapan.Size = new System.Drawing.Size(88, 30);
            this.txtDapan.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(20, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 29);
            this.label10.TabIndex = 45;
            this.label10.Text = "Mã:";
            // 
            // txtNoidungDapan
            // 
            this.txtNoidungDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoidungDapan.Location = new System.Drawing.Point(513, 125);
            this.txtNoidungDapan.Name = "txtNoidungDapan";
            this.txtNoidungDapan.ReadOnly = true;
            this.txtNoidungDapan.Size = new System.Drawing.Size(568, 30);
            this.txtNoidungDapan.TabIndex = 47;
            this.txtNoidungDapan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoai.Location = new System.Drawing.Point(769, 191);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(312, 30);
            this.txtTenLoai.TabIndex = 6;
            // 
            // txtTenMh
            // 
            this.txtTenMh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMh.Location = new System.Drawing.Point(412, 190);
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.Size = new System.Drawing.Size(236, 30);
            this.txtTenMh.TabIndex = 5;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrinhDo.Location = new System.Drawing.Point(153, 191);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(127, 30);
            this.txtTrinhDo.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(153, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 44);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Sữa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(356, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 44);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMaCH
            // 
            this.txtMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaCH.Location = new System.Drawing.Point(153, 125);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(99, 30);
            this.txtMaCH.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(560, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 44);
            this.button1.TabIndex = 54;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(295, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Đáp án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "Trình Độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(295, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "Môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(652, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Loại CH:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiDung.Location = new System.Drawing.Point(153, 46);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(928, 57);
            this.txtNoiDung.TabIndex = 1;
            // 
            // SoanCauHoi_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtTenMh);
            this.Controls.Add(this.txtTrinhDo);
            this.Controls.Add(this.txtNoidungDapan);
            this.Controls.Add(this.txtDapan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoanCauHoi_UC";
            this.Size = new System.Drawing.Size(1100, 768);
            this.Load += new System.EventHandler(this.SoanCauHoi_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trinhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDapan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoidungDapan;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtTenMh;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}
