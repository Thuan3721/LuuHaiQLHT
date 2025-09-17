
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private DataTable dt = new DataTable();

        public Form3()
        {
            InitializeComponent();         
        }

        private void button1_Click(object sender, EventArgs e) // Thêm
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    @"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO HoaDonXuat (MaHD, NgayLap, MaNV, MaKH, TongTien, GhiChu) " +
                                   "VALUES (@MaHD, @NgayLap, @MaNV, @MaKH, @TongTien, @GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    command.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                    command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    command.Parameters.AddWithValue("@TongTien", decimal.Parse(txtTongTien.Text));
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtMaHD.Clear();
            txtMaNV.Clear();
            txtMaKH.Clear();
            txtTongTien.Clear();
            txtGhiChu.Clear();
            dtpNgayLap.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e) // Sửa
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    @"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "UPDATE HoaDonXuat " +
                                   "SET NgayLap=@NgayLap, MaNV=@MaNV, MaKH=@MaKH, TongTien=@TongTien, GhiChu=@GhiChu " +
                                   "WHERE MaHD=@MaHD";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    command.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                    command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    command.Parameters.AddWithValue("@TongTien", decimal.Parse(txtTongTien.Text));
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa hóa đơn: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Xóa
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    @"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "DELETE FROM HoaDonXuat WHERE MaHD = @MaHD";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
            }
        }




        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}