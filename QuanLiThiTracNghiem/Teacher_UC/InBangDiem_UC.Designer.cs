
namespace QuanLiThiTracNghiem.Teacher_UC
{
    partial class InBangDiem_UC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbInLop = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInLanThi = new System.Windows.Forms.TextBox();
            this.txtInMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.cmbInLop);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtInLanThi);
            this.panel1.Controls.Add(this.txtInMon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(156, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 330);
            this.panel1.TabIndex = 0;
            // 
            // cmbInLop
            // 
            this.cmbInLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInLop.FormattingEnabled = true;
            this.cmbInLop.Location = new System.Drawing.Point(170, 37);
            this.cmbInLop.Name = "cmbInLop";
            this.cmbInLop.Size = new System.Drawing.Size(408, 30);
            this.cmbInLop.TabIndex = 8;
            this.cmbInLop.SelectedIndexChanged += new System.EventHandler(this.cmbInLop_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(171, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInLanThi
            // 
            this.txtInLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInLanThi.Location = new System.Drawing.Point(170, 109);
            this.txtInLanThi.Name = "txtInLanThi";
            this.txtInLanThi.Size = new System.Drawing.Size(408, 30);
            this.txtInLanThi.TabIndex = 5;
            // 
            // txtInMon
            // 
            this.txtInMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInMon.Location = new System.Drawing.Point(170, 169);
            this.txtInMon.Name = "txtInMon";
            this.txtInMon.Size = new System.Drawing.Size(408, 30);
            this.txtInMon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(60, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lần Thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.HoTenSinhVien,
            this.Diem});
            this.dataGridView1.Location = new System.Drawing.Point(156, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 292);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "masv";
            this.MaSinhVien.HeaderText = "Mã Sinh Viên";
            this.MaSinhVien.MinimumWidth = 6;
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Width = 125;
            // 
            // HoTenSinhVien
            // 
            this.HoTenSinhVien.DataPropertyName = "hoten";
            this.HoTenSinhVien.HeaderText = "Họ Tên Sinh Viên";
            this.HoTenSinhVien.MinimumWidth = 6;
            this.HoTenSinhVien.Name = "HoTenSinhVien";
            this.HoTenSinhVien.Width = 250;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            this.Diem.Width = 125;
            // 
            // InBangDiem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "InBangDiem_UC";
            this.Size = new System.Drawing.Size(1100, 768);
            this.Load += new System.EventHandler(this.InBangDiem_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbInLop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInLanThi;
        private System.Windows.Forms.TextBox txtInMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}
