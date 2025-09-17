namespace WinFormsApp2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMaHD = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            txtThanhTien = new TextBox();
            txtThuoc = new TextBox();
            dgvHoaDon = new DataGridView();
            txtGhiChu = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Lượng ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 267);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Thành  Tiền";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 300);
            label.Name = "label";
            label.Size = new Size(60, 20);
            label.TabIndex = 5;
            label.Text = "Ghi Chú";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(160, 482);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(486, 482);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(844, 482);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(160, 95);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(778, 27);
            txtMaHD.TabIndex = 10;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(162, 182);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(778, 27);
            txtSoLuong.TabIndex = 12;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(162, 224);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(778, 27);
            txtDonGia.TabIndex = 14;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(161, 264);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(778, 27);
            txtThanhTien.TabIndex = 15;
            // 
            // txtThuoc
            // 
            txtThuoc.Location = new Point(163, 140);
            txtThuoc.Name = "txtThuoc";
            txtThuoc.Size = new Size(777, 27);
            txtThuoc.TabIndex = 17;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(12, 353);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(926, 111);
            dgvHoaDon.TabIndex = 18;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(162, 300);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(777, 27);
            txtGhiChu.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 9);
            label6.Name = "label6";
            label6.Size = new Size(485, 68);
            label6.TabIndex = 20;
            label6.Text = "Chi Tiết Hóa Đơn";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 564);
            Controls.Add(label6);
            Controls.Add(txtGhiChu);
            Controls.Add(dgvHoaDon);
            Controls.Add(txtThuoc);
            Controls.Add(txtThanhTien);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaHD);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMaHD;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private TextBox txtThuoc;
        private DataGridView dgvHoaDon;
        private TextBox txtGhiChu;
        private Label label6;
    }
}