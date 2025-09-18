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
    public partial class FormLoaiThuoc : Form
    {
        private object row;

        public FormLoaiThuoc()
        {
            InitializeComponent();
            this.Load += FormLoaiThuoc_Load; // gọi hàm khi form load
        }

        private void FormLoaiThuoc_Load(object? sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHT;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO LoaiThuoc (MaLoaiThuoc, TenLoaiThuoc, GhiChu) " +
               "VALUES (@MaLoaiThuoc, @TenLoaiThuoc, @GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@MaLoaiThuoc", txtMaLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@TenLoaiThuoc", txtTenLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm loại thuốc thành công!");
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại thuốc thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại thuốc: " + ex.Message);
            }
        }


        private void clearform()
        {
            txtIDLoaiThuoc.Clear();
            txtMaLoaiThuoc.Clear();
            txtTenLoaiThuoc.Clear();
            txtGhiChu.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHT;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    string query = "UPDATE LoaiThuoc " +
                                   "SET MaLoaiThuoc = @MaLoaiThuoc, TenLoaiThuoc = @TenLoaiThuoc, GhiChu = @GhiChu " +
                                   "WHERE IDLoaiThuoc = @IDLoaiThuoc";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@MaLoaiThuoc", txtMaLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@TenLoaiThuoc", txtTenLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật loại thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại thuốc thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại thuốc: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHT;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    string query = "DELETE FROM LoaiThuoc WHERE IDLoaiThuoc = @IDLoaiThuoc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDLoaiThuoc", txtIDLoaiThuoc.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa loại thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearform();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại thuốc thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại thuốc: " + ex.Message);
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtIDLoaiThuoc.Text = row.Cells["IDLoaiThuoc"].Value?.ToString() ?? "";
                    txtMaLoaiThuoc.Text = row.Cells["MaLoaiThuoc"].Value?.ToString() ?? "";
                    txtTenLoaiThuoc.Text = row.Cells["TenLoaiThuoc"].Value?.ToString() ?? "";
                    txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
                }
            }
        }


        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHT;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM LoaiThuoc", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

