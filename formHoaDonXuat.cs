
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
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
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
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        ClearForm();
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

        private void ClearForm()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e) // Sửa
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
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
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }

        }
        private void button3_Click(object sender, EventArgs e) // Xóa
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "DELETE FROM HoaDonXuat WHERE MaHD = @MaHD";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
        

     

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}