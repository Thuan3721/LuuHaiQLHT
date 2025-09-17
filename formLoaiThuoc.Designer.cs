namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtLoaiThuoc = new TextBox();
            label2 = new Label();
            txtMaLoai = new TextBox();
            label4 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label3 = new Label();
            label = new Label();
            txtTenLoai = new TextBox();
            dataGridView = new DataGridView();
            txtGhiChu = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "ID loại thuốc";
            // 
            // txtLoaiThuoc
            // 
            txtLoaiThuoc.Location = new Point(152, 109);
            txtLoaiThuoc.Name = "txtLoaiThuoc";
            txtLoaiThuoc.Size = new Size(801, 27);
            txtLoaiThuoc.TabIndex = 1;
            txtLoaiThuoc.TextChanged += txtLoaiThuoc_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã loại thuốc";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(152, 181);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(801, 27);
            txtMaLoai.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 305);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 19;
            label4.Text = "Ghi Chú";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(152, 507);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(496, 507);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(859, 507);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 26;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 240);
            label.Name = "label";
            label.Size = new Size(102, 20);
            label.TabIndex = 27;
            label.Text = "Tên loại thuốc";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(152, 240);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(801, 27);
            txtTenLoai.TabIndex = 28;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 348);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(941, 153);
            dataGridView.TabIndex = 29;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(152, 305);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(801, 27);
            txtGhiChu.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 9);
            label5.Name = "label5";
            label5.Size = new Size(321, 68);
            label5.TabIndex = 31;
            label5.Text = "Loại Thuốc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 581);
            Controls.Add(label5);
            Controls.Add(txtGhiChu);
            Controls.Add(dataGridView);
            Controls.Add(txtTenLoai);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(txtMaLoai);
            Controls.Add(label2);
            Controls.Add(txtLoaiThuoc);
            Controls.Add(label1);
            Name = "Form1";
            Text = "`";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoaiThuoc;
        private Label label2;
        private TextBox txtMaLoai;
        private Label label4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label3;
        private Label label;
        private TextBox txtTenLoai;
        private DataGridView dataGridView;
        private TextBox txtGhiChu;
        private Label label5;
    }
}
