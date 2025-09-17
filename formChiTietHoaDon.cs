using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "UPDATE ChiTietHoaDon " +
                       "SET SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien, GhiChu = @GhiChu " +
                       "WHERE MaHD = @MaHD AND IdThuoc = @IdThuoc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    command.Parameters.AddWithValue("@IdThuoc", txtThuoc.Text);
                    command.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                    command.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text));
                    command.Parameters.AddWithValue("@ThanhTien", decimal.Parse(txtThanhTien.Text));
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        claerform();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void claerform()
        {
            throw new NotImplementedException();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO ChiTietHoaDon (MaHD, IdThuoc, SoLuong, DonGia, ThanhTien, GhiChu) " +
                      "VALUES (@MaHD, @IdThuoc, @SoLuong, @DonGia, @ThanhTien, @GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    command.Parameters.AddWithValue("@IdThuoc", txtThuoc.Text);
                    command.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                    command.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text));
                    command.Parameters.AddWithValue("@ThanhTien", decimal.Parse(txtThanhTien.Text));
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void clearform()
        {
            throw new NotImplementedException();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND IdThuoc = @IdThuoc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    command.Parameters.AddWithValue("@IdThuoc", txtIdThuoc.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value?.ToString();
                txtThuoc.Text = row.Cells[1].Value?.ToString();
                txtSoLuong.Text = row.Cells[2].Value?.ToString();
                txtDonGia.Text = row.Cells[3].Value?.ToString();
                txtThanhTien.Text = row.Cells[4].Value?.ToString();
                txtGhiChu.Text = row.Cells[5].Value?.ToString();
            }
        }

        // Hàm xóa trắng textbox sau khi thêm
        private void CClearSelection()
        {
            txtMaHD.Clear();
            txtThuoc.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtGhiChu.Clear();

        }
    }
}
