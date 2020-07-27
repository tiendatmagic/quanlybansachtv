namespace QLS
{
    partial class FmQuanLS
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tviewTacgia = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNXB = new System.Windows.Forms.ComboBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 148);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tviewTacgia
            // 
            this.tviewTacgia.BackColor = System.Drawing.SystemColors.Control;
            this.tviewTacgia.Location = new System.Drawing.Point(6, 21);
            this.tviewTacgia.Name = "tviewTacgia";
            this.tviewTacgia.Size = new System.Drawing.Size(180, 268);
            this.tviewTacgia.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tviewTacgia);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 297);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Sách";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản Lý Thư Viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(215, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng Tiền Sách:";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTongTien.Location = new System.Drawing.Point(366, 325);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(280, 29);
            this.textBoxTongTien.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBoxNXB);
            this.groupBox1.Controls.Add(this.buttonThoat);
            this.groupBox1.Controls.Add(this.buttonLuu);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDonGia);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.textBoxTenSach);
            this.groupBox1.Controls.Add(this.textBoxMaSach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(215, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 285);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập sách";
            // 
            // textBoxNXB
            // 
            this.textBoxNXB.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNXB.FormattingEnabled = true;
            this.textBoxNXB.Location = new System.Drawing.Point(151, 201);
            this.textBoxNXB.Name = "textBoxNXB";
            this.textBoxNXB.Size = new System.Drawing.Size(280, 30);
            this.textBoxNXB.TabIndex = 8;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Black;
            this.buttonThoat.Location = new System.Drawing.Point(452, 157);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(87, 48);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonLuu.ForeColor = System.Drawing.Color.Black;
            this.buttonLuu.Location = new System.Drawing.Point(452, 101);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(87, 41);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.SystemColors.Control;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.ForeColor = System.Drawing.Color.Black;
            this.buttonThem.Location = new System.Drawing.Point(452, 41);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(87, 46);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(0, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhà Xuất Bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(10, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đơn Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(10, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sách:";
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDonGia.Location = new System.Drawing.Point(151, 154);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(280, 29);
            this.textBoxDonGia.TabIndex = 3;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSoLuong.Location = new System.Drawing.Point(151, 110);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(280, 29);
            this.textBoxSoLuong.TabIndex = 2;
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTenSach.Location = new System.Drawing.Point(151, 72);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(280, 29);
            this.textBoxTenSach.TabIndex = 1;
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMaSach.Location = new System.Drawing.Point(151, 28);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(280, 29);
            this.textBoxMaSach.TabIndex = 0;
            // 
            // FmQuanLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmQuanLS";
            this.Text = "Quan Ly Sach";
            this.Load += new System.EventHandler(this.FmQuanLS_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView tviewTacgia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxTenSach;
        private System.Windows.Forms.TextBox textBoxMaSach;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox textBoxNXB;
    }
}

