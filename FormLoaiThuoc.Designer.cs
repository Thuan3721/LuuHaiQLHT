namespace WinFormsApp2
{
    partial class FormLoaiThuoc
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
            txtIDLoaiThuoc = new TextBox();
            txtMaLoaiThuoc = new TextBox();
            txtTenLoaiThuoc = new TextBox();
            txtGhiChu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtIDLoaiThuoc
            // 
            txtIDLoaiThuoc.Location = new Point(132, 134);
            txtIDLoaiThuoc.Name = "txtIDLoaiThuoc";
            txtIDLoaiThuoc.Size = new Size(916, 27);
            txtIDLoaiThuoc.TabIndex = 0;
            // 
            // txtMaLoaiThuoc
            // 
            txtMaLoaiThuoc.Location = new Point(132, 182);
            txtMaLoaiThuoc.Name = "txtMaLoaiThuoc";
            txtMaLoaiThuoc.Size = new Size(916, 27);
            txtMaLoaiThuoc.TabIndex = 1;
            // 
            // txtTenLoaiThuoc
            // 
            txtTenLoaiThuoc.Location = new Point(132, 227);
            txtTenLoaiThuoc.Name = "txtTenLoaiThuoc";
            txtTenLoaiThuoc.Size = new Size(916, 27);
            txtTenLoaiThuoc.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(132, 275);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(916, 27);
            txtGhiChu.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "ID Loại Thuoc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 182);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã Loại Thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 227);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên Loại Thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 275);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 7;
            label4.Text = "Ghi Chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(366, 0);
            label5.Name = "label5";
            label5.Size = new Size(321, 68);
            label5.TabIndex = 8;
            label5.Text = "Loại Thuốc";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(916, 124);
            dataGridView1.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(132, 495);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(531, 495);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(954, 495);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // FormLoaiThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 536);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGhiChu);
            Controls.Add(txtTenLoaiThuoc);
            Controls.Add(txtMaLoaiThuoc);
            Controls.Add(txtIDLoaiThuoc);
            Name = "FormLoaiThuoc";
            Text = "FormLoaiThuoc";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDLoaiThuoc;
        private TextBox txtMaLoaiThuoc;
        private TextBox txtTenLoaiThuoc;
        private TextBox txtGhiChu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}