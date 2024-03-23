
namespace QuanLiThiTracNghiem
{
    partial class Thi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtCauA = new System.Windows.Forms.TextBox();
            this.txtCauB = new System.Windows.Forms.TextBox();
            this.txtCauC = new System.Windows.Forms.TextBox();
            this.txtCauD = new System.Windows.Forms.TextBox();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnTiepTheo = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCauD = new System.Windows.Forms.RadioButton();
            this.rdCauC = new System.Windows.Forms.RadioButton();
            this.rdCauB = new System.Windows.Forms.RadioButton();
            this.rdCauA = new System.Windows.Forms.RadioButton();
            this.lbCau = new System.Windows.Forms.Label();
            this.txtPhut = new System.Windows.Forms.Label();
            this.txtGiay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiDung.Location = new System.Drawing.Point(76, 127);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(805, 57);
            this.txtNoiDung.TabIndex = 2;
            // 
            // txtCauA
            // 
            this.txtCauA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCauA.Location = new System.Drawing.Point(178, 237);
            this.txtCauA.Name = "txtCauA";
            this.txtCauA.Size = new System.Drawing.Size(703, 27);
            this.txtCauA.TabIndex = 3;
            // 
            // txtCauB
            // 
            this.txtCauB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCauB.Location = new System.Drawing.Point(178, 295);
            this.txtCauB.Name = "txtCauB";
            this.txtCauB.Size = new System.Drawing.Size(703, 27);
            this.txtCauB.TabIndex = 4;
            // 
            // txtCauC
            // 
            this.txtCauC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCauC.Location = new System.Drawing.Point(178, 352);
            this.txtCauC.Name = "txtCauC";
            this.txtCauC.Size = new System.Drawing.Size(703, 27);
            this.txtCauC.TabIndex = 5;
            // 
            // txtCauD
            // 
            this.txtCauD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCauD.Location = new System.Drawing.Point(178, 409);
            this.txtCauD.Name = "txtCauD";
            this.txtCauD.Size = new System.Drawing.Size(703, 27);
            this.txtCauD.TabIndex = 6;
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.Location = new System.Drawing.Point(178, 573);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(119, 47);
            this.btnCauTruoc.TabIndex = 11;
            this.btnCauTruoc.Text = "Câu Trước";
            this.btnCauTruoc.UseVisualStyleBackColor = true;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.Location = new System.Drawing.Point(316, 573);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(119, 47);
            this.btnTiepTheo.TabIndex = 12;
            this.btnTiepTheo.Text = "Câu Tiếp Theo";
            this.btnTiepTheo.UseVisualStyleBackColor = true;
            this.btnTiepTheo.Click += new System.EventHandler(this.btnTiepTheo_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(788, 573);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(93, 47);
            this.btnKetThuc.TabIndex = 13;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cau,
            this.DapAn});
            this.dataGridView1.Location = new System.Drawing.Point(922, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(291, 383);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Cau
            // 
            this.Cau.DataPropertyName = "MaBT";
            this.Cau.HeaderText = "Câu";
            this.Cau.MinimumWidth = 6;
            this.Cau.Name = "Cau";
            this.Cau.Width = 50;
            // 
            // DapAn
            // 
            this.DapAn.DataPropertyName = "Dapan";
            this.DapAn.HeaderText = "Đáp Án";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Câu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thời gian: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng số câu: 10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCauD);
            this.groupBox1.Controls.Add(this.rdCauC);
            this.groupBox1.Controls.Add(this.rdCauB);
            this.groupBox1.Controls.Add(this.rdCauA);
            this.groupBox1.Location = new System.Drawing.Point(40, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 242);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // rdCauD
            // 
            this.rdCauD.AutoSize = true;
            this.rdCauD.Location = new System.Drawing.Point(48, 203);
            this.rdCauD.Name = "rdCauD";
            this.rdCauD.Size = new System.Drawing.Size(72, 21);
            this.rdCauD.TabIndex = 3;
            this.rdCauD.TabStop = true;
            this.rdCauD.Text = "Câu D:";
            this.rdCauD.UseVisualStyleBackColor = true;
            // 
            // rdCauC
            // 
            this.rdCauC.AutoSize = true;
            this.rdCauC.Location = new System.Drawing.Point(48, 146);
            this.rdCauC.Name = "rdCauC";
            this.rdCauC.Size = new System.Drawing.Size(71, 21);
            this.rdCauC.TabIndex = 2;
            this.rdCauC.TabStop = true;
            this.rdCauC.Text = "Câu C:";
            this.rdCauC.UseVisualStyleBackColor = true;
            // 
            // rdCauB
            // 
            this.rdCauB.AutoSize = true;
            this.rdCauB.Location = new System.Drawing.Point(51, 89);
            this.rdCauB.Name = "rdCauB";
            this.rdCauB.Size = new System.Drawing.Size(71, 21);
            this.rdCauB.TabIndex = 1;
            this.rdCauB.TabStop = true;
            this.rdCauB.Text = "Câu B:";
            this.rdCauB.UseVisualStyleBackColor = true;
            // 
            // rdCauA
            // 
            this.rdCauA.AutoSize = true;
            this.rdCauA.Location = new System.Drawing.Point(51, 31);
            this.rdCauA.Name = "rdCauA";
            this.rdCauA.Size = new System.Drawing.Size(71, 21);
            this.rdCauA.TabIndex = 0;
            this.rdCauA.TabStop = true;
            this.rdCauA.Text = "Câu A:";
            this.rdCauA.UseVisualStyleBackColor = true;
            this.rdCauA.CheckedChanged += new System.EventHandler(this.rdCauA_CheckedChanged);
            // 
            // lbCau
            // 
            this.lbCau.AutoSize = true;
            this.lbCau.Location = new System.Drawing.Point(123, 69);
            this.lbCau.Name = "lbCau";
            this.lbCau.Size = new System.Drawing.Size(16, 17);
            this.lbCau.TabIndex = 19;
            this.lbCau.Text = "1";
            // 
            // txtPhut
            // 
            this.txtPhut.AutoSize = true;
            this.txtPhut.Location = new System.Drawing.Point(733, 69);
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(24, 17);
            this.txtPhut.TabIndex = 20;
            this.txtPhut.Text = "00";
            // 
            // txtGiay
            // 
            this.txtGiay.AutoSize = true;
            this.txtGiay.Location = new System.Drawing.Point(763, 69);
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(24, 17);
            this.txtGiay.TabIndex = 21;
            this.txtGiay.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = ":";
            // 
            // tmStart
            // 
            this.tmStart.Interval = 1000;
            this.tmStart.Tick += new System.EventHandler(this.tmStart_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(922, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1225, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.lbCau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnTiepTheo);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.txtCauD);
            this.Controls.Add(this.txtCauC);
            this.Controls.Add(this.txtCauB);
            this.Controls.Add(this.txtCauA);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "Thi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.Thi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtCauA;
        private System.Windows.Forms.TextBox txtCauB;
        private System.Windows.Forms.TextBox txtCauC;
        private System.Windows.Forms.TextBox txtCauD;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnTiepTheo;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCauD;
        private System.Windows.Forms.RadioButton rdCauC;
        private System.Windows.Forms.RadioButton rdCauB;
        private System.Windows.Forms.RadioButton rdCauA;
        private System.Windows.Forms.Label lbCau;
        private System.Windows.Forms.Label txtPhut;
        private System.Windows.Forms.Label txtGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
    }
}