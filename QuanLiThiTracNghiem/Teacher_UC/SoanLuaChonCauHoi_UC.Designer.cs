
namespace QuanLiThiTracNghiem.Teacher_UC
{
    partial class SoanLuaChonCauHoi_UC
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
            this.MaLuaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCau = new System.Windows.Forms.ComboBox();
            this.txtDapan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.brnreset = new System.Windows.Forms.Button();
            this.cmbMaCauHoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMachonlua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuaChon,
            this.Cau,
            this.Noidung});
            this.dataGridView1.Location = new System.Drawing.Point(20, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 410);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaLuaChon
            // 
            this.MaLuaChon.DataPropertyName = "MaChonlua";
            this.MaLuaChon.HeaderText = "Mã Chọn Lựa";
            this.MaLuaChon.MinimumWidth = 6;
            this.MaLuaChon.Name = "MaLuaChon";
            this.MaLuaChon.Width = 125;
            // 
            // Cau
            // 
            this.Cau.DataPropertyName = "Cau";
            this.Cau.HeaderText = "Câu";
            this.Cau.MinimumWidth = 6;
            this.Cau.Name = "Cau";
            this.Cau.Width = 125;
            // 
            // Noidung
            // 
            this.Noidung.DataPropertyName = "Noidung";
            this.Noidung.HeaderText = "Nội Dung";
            this.Noidung.MinimumWidth = 6;
            this.Noidung.Name = "Noidung";
            this.Noidung.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "Câu:";
            // 
            // cmbCau
            // 
            this.cmbCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCau.FormattingEnabled = true;
            this.cmbCau.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.cmbCau.Location = new System.Drawing.Point(194, 131);
            this.cmbCau.Name = "cmbCau";
            this.cmbCau.Size = new System.Drawing.Size(226, 33);
            this.cmbCau.TabIndex = 58;
            // 
            // txtDapan
            // 
            this.txtDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDapan.Location = new System.Drawing.Point(194, 190);
            this.txtDapan.Name = "txtDapan";
            this.txtDapan.Size = new System.Drawing.Size(806, 30);
            this.txtDapan.TabIndex = 59;
            this.txtDapan.TextChanged += new System.EventHandler(this.txtDapan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(67, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "Đáp án:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(67, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "Câu Hỏi:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(600, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 44);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(397, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 44);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(194, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 44);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Sữa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // brnreset
            // 
            this.brnreset.BackColor = System.Drawing.Color.Aqua;
            this.brnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.brnreset.ForeColor = System.Drawing.Color.Black;
            this.brnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnreset.Location = new System.Drawing.Point(803, 241);
            this.brnreset.Name = "brnreset";
            this.brnreset.Size = new System.Drawing.Size(197, 44);
            this.brnreset.TabIndex = 66;
            this.brnreset.Text = "Reset";
            this.brnreset.UseVisualStyleBackColor = false;
            this.brnreset.Click += new System.EventHandler(this.brnreset_Click);
            // 
            // cmbMaCauHoi
            // 
            this.cmbMaCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaCauHoi.FormattingEnabled = true;
            this.cmbMaCauHoi.Location = new System.Drawing.Point(194, 35);
            this.cmbMaCauHoi.Name = "cmbMaCauHoi";
            this.cmbMaCauHoi.Size = new System.Drawing.Size(226, 33);
            this.cmbMaCauHoi.TabIndex = 67;
            this.cmbMaCauHoi.SelectedIndexChanged += new System.EventHandler(this.cmbMaCauHoi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(67, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mã:";
            // 
            // txtMachonlua
            // 
            this.txtMachonlua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMachonlua.Location = new System.Drawing.Point(194, 84);
            this.txtMachonlua.Name = "txtMachonlua";
            this.txtMachonlua.Size = new System.Drawing.Size(226, 30);
            this.txtMachonlua.TabIndex = 68;
            // 
            // SoanLuaChonCauHoi_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMachonlua);
            this.Controls.Add(this.cmbMaCauHoi);
            this.Controls.Add(this.brnreset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDapan);
            this.Controls.Add(this.cmbCau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoanLuaChonCauHoi_UC";
            this.Size = new System.Drawing.Size(1100, 768);
            this.Load += new System.EventHandler(this.SoanLuaChonCauHoi_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCau;
        private System.Windows.Forms.TextBox txtDapan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button brnreset;
        private System.Windows.Forms.ComboBox cmbMaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noidung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMachonlua;
    }
}
