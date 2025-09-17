using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<LoaiThuoc> danhSach = new List<LoaiThuoc>();
        private int indexDangChon = -1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Gán danh sách vào DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = danhSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiThuoc lt = new LoaiThuoc()
            {
                IDLoaiThuoc = int.Parse(txtLoaiThuoc.Text),
                MaLoai = txtMaLoai.Text,
                TenLoai = txtTenLoai.Text,
                GhiChu = dataGridView.Text
            };
            danhSach.Add(lt);
            RefreshGrid();
            ClearForm();

            MessageBox.Show("Thêm thành công!");

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO LoaiThuoc (IDLoaiThuoc,MaLoaiThuoc,TenLoaiThuoc)" +
                    "VALUES (@IDLoaiThuoc,@MaLoaiThuoc,@TenLoaiThuoc,@GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDLoaiThuoc", txtLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@MaLoaithuoc", txtMaLoai.Text);
                    command.Parameters.AddWithValue("@TenLoaiThuoc", txtTenLoai.Text);
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"..."))
                {
                    connection.Open();
                    string query = "UPDATE LoaiThuoc SET MaLoaiThuoc=@MaLoaiThuoc, TenLoaiThuoc=@TenLoaiThuoc, GhiChu=@GhiChu " +
                                   "WHERE IDLoaiThuoc=@IDLoaiThuoc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDLoaiThuoc", txtLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@MaLoaiThuoc", txtMaLoai.Text);
                    command.Parameters.AddWithValue("@TenLoaiThuoc", txtTenLoai.Text);
                    command.Parameters.AddWithValue("@GhiChu", dataGridView.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=TOI-LA-PO;Initial Catalog=QuanLyHT;User ID=sa;Password=***********;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "DELETE FROM LoaiThuoc WHERE IDLoaiThuoc = @IDLoaiThuoc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDLoaiThuoc", txtLoaiThuoc.Text);
                    command.Parameters.AddWithValue("@MaLoaithuoc", txtMaLoai.Text);
                    command.Parameters.AddWithValue("@TenLoaiThuoc", txtTenLoai.Text);


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

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void txtGhiChu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexDangChon = e.RowIndex;
                var lt = danhSach[indexDangChon];

                txtLoaiThuoc.Text = lt.IDLoaiThuoc.ToString();
                txtMaLoai.Text = lt.MaLoai;
                txtTenLoai.Text = lt.TenLoai;
                dataGridView.Text = lt.GhiChu;
            }
        }

        private void RefreshGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = danhSach;
        }

        private void ClearForm()
        {
            txtLoaiThuoc.Clear();
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            dataGridView.ClearSelection();
            indexDangChon = -1;
        }

        private void txtLoaiThuoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


namespace WinFormsApp2
{
    public class LoaiThuoc
    {
        public int IDLoaiThuoc { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }

        public static implicit operator LoaiThuoc(string value)

        {
            throw new NotImplementedException();
        }
    }
}