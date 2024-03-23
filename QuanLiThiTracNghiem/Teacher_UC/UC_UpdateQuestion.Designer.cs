
namespace QuanLiThiTracNghiem.Teacher_UC
{
    partial class UC_UpdateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UpdateQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSet = new System.Windows.Forms.ComboBox();
            this.comboQuestionNo = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Questions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(670, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Question No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(133, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "set";
            // 
            // comboSet
            // 
            this.comboSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboSet.FormattingEnabled = true;
            this.comboSet.Location = new System.Drawing.Point(138, 185);
            this.comboSet.Name = "comboSet";
            this.comboSet.Size = new System.Drawing.Size(274, 33);
            this.comboSet.TabIndex = 7;
            this.comboSet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboQuestionNo
            // 
            this.comboQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboQuestionNo.FormattingEnabled = true;
            this.comboQuestionNo.Location = new System.Drawing.Point(675, 185);
            this.comboQuestionNo.Name = "comboQuestionNo";
            this.comboQuestionNo.Size = new System.Drawing.Size(262, 33);
            this.comboQuestionNo.TabIndex = 8;
            this.comboQuestionNo.SelectedIndexChanged += new System.EventHandler(this.comboQuestionNo_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Aqua;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(878, 665);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(197, 44);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(675, 665);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 44);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAnswer.Location = new System.Drawing.Point(138, 603);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(904, 30);
            this.txtAnswer.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(507, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "Answer";
            // 
            // txtOption4
            // 
            this.txtOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOption4.Location = new System.Drawing.Point(619, 485);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(423, 30);
            this.txtOption4.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(614, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Option 4:";
            // 
            // txtOption3
            // 
            this.txtOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOption3.Location = new System.Drawing.Point(619, 395);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(423, 30);
            this.txtOption3.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(614, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Option 3:";
            // 
            // txtOption2
            // 
            this.txtOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOption2.Location = new System.Drawing.Point(138, 488);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(423, 30);
            this.txtOption2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(133, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Option 2:";
            // 
            // txtOption1
            // 
            this.txtOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOption1.Location = new System.Drawing.Point(138, 395);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(423, 30);
            this.txtOption1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(133, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Option 1:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuestion.Location = new System.Drawing.Point(138, 299);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(904, 30);
            this.txtQuestion.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(507, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quesiton";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOption4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOption3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOption2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOption1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboQuestionNo);
            this.Controls.Add(this.comboSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_UpdateQuestion";
            this.Size = new System.Drawing.Size(1100, 768);
            this.Load += new System.EventHandler(this.UC_UpdateQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSet;
        private System.Windows.Forms.ComboBox comboQuestionNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
