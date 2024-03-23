
namespace QuanLiThiTracNghiem.Teacher_UC
{
    partial class UC_ViewDeleteQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewDeleteQuestion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboSet
            // 
            this.comboSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboSet.FormattingEnabled = true;
            this.comboSet.Location = new System.Drawing.Point(338, 184);
            this.comboSet.Name = "comboSet";
            this.comboSet.Size = new System.Drawing.Size(489, 33);
            this.comboSet.TabIndex = 39;
            this.comboSet.SelectedIndexChanged += new System.EventHandler(this.comboSet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(333, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Delete Questions";
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
            this.dataGridView1.Location = new System.Drawing.Point(22, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 410);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(891, 681);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 48);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UC_ViewDeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_ViewDeleteQuestion";
            this.Size = new System.Drawing.Size(1100, 768);
            this.Load += new System.EventHandler(this.UC_ViewDeleteQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trinhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
    }
}
