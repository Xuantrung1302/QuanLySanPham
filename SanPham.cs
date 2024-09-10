using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Policy;

namespace QuanLySanPham
{
    public partial class SanPham : Form
    {
        DBConnect dbConnect = new DBConnect();
        bool isThoat = true;
        private static readonly HttpClient client = new HttpClient();
        public SanPham()
        {
            InitializeComponent();
        }
        void Reset()
        {
            txbTenSanPham.Clear();
            txbIdSanPham.Clear();
            txbIdChiTiet.Clear();
            txbKieuSanPham.Clear();
            txbTrangThai.Clear();
            txbSoLuong.Clear();
            txbTimKiem.Clear();
            btnUpdateSP.Enabled = false;
        }
        private bool CheckThemSanPham()
        {
            string tenSP = txbTenSanPham.Text;
            string soluong = txbSoLuong.Text;
            string trangthai = txbTrangThai.Text;
            string kieuSP = txbKieuSanPham.Text;
            long sl;
            if (txbIdSanPham.Text == "")
            {
                errorProvider1.SetError(txbIdSanPham, "Bạn chưa nhập ID sản Phẩm");
                txbIdSanPham.Focus();
                return false;
            }
            else if (txbTenSanPham.Text == "")
            {
                errorProvider1.SetError(txbTenSanPham, "Bạn chưa nhập tên sản phẩm");
                txbTenSanPham.Focus();
                return false;
            }
            else if (txbIdChiTiet.Text == "")
            {
                errorProvider1.SetError(txbIdChiTiet, "Bạn chưa nhập tên sản phẩm");
                txbIdChiTiet.Focus();
                return false;
            }
            else if (txbKieuSanPham.Text == "")
            {
                errorProvider1.SetError(txbKieuSanPham, "Bạn chưa nhập tên sản phẩm");
                txbKieuSanPham.Focus();
                return false;
            }
            else if (txbSoLuong.Text == "")
            {
                errorProvider1.SetError(txbSoLuong, "Bạn chưa nhập tên sản phẩm");
                txbSoLuong.Focus();
                return false;
            }
            else if (txbTrangThai.Text == "")
            {
                errorProvider1.SetError(txbTrangThai, "Bạn chưa nhập tên sản phẩm");
                txbTrangThai.Focus();
                return false;
            }
            if (!(long.TryParse(soluong, out sl)))
            {
                MessageBox.Show("Bạn chưa nhập đúng định dạng số lượng", "Thông Báo");
                txbSoLuong.Focus();
                return false;
            }
            //foreach (char c in tenSP.Trim())
            //{
            //    if (!char.IsLetter(c) || Char.IsWhiteSpace(c)) // Kiểm tra nếu không phải là chữ cái
            //    {
            //            MessageBox.Show("Bạn chỉ được nhập ký tự chữ cái.", "Thông Báo");
            //            txbTenSanPham.Focus();
            //            return false;
            //    }
            //}
            //foreach (char c in trangthai.Trim())
            //{
            //    if (!char.IsLetter(c)) // Kiểm tra nếu không phải là chữ cái
            //    {
            //        MessageBox.Show("Bạn chỉ được nhập ký tự chữ cái.", "Thông Báo");
            //        txbTrangThai.Focus();
            //        return false;
            //    }
            //}
            foreach (char c in kieuSP.Trim())
            {
                if (!char.IsLetter(c)) // Kiểm tra nếu không phải là chữ cái
                {
                    MessageBox.Show("Bạn chỉ được nhập ký tự chữ cái.", "Thông Báo");
                    txbKieuSanPham.Focus();
                    return false;
                }
            }
            return true;
        }


        private void btnThoatDSSP_Click(object sender, EventArgs e)
        {
            if(isThoat)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void SanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }


        private void SanPham_Load(object sender, EventArgs e)
        {
            //dtgvDanhsachSanPham.AllowUserToResizeColumns = false;
            //dtgvDanhsachSanPham.AllowUserToResizeRows = false;
            btnUpdateSP.Enabled = false;
            txbIdChiTiet.Enabled = true;
            txbIdSanPham.Enabled = true;
            //btnThemSP.Enabled = false;
            LoadDataGridView();
        }

        private void dtgvDanhsachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            btnUpdateSP.Enabled=true;
            txbIdChiTiet.ReadOnly = true;
            txbIdSanPham.ReadOnly = true;
            txbIdSanPham.Text = dtgvDanhsachSanPham.Rows[e.RowIndex].Cells["idProduct"].Value.ToString();
            txbTenSanPham.Text = dtgvDanhsachSanPham.Rows[e.RowIndex].Cells["productName"].Value.ToString();
            txbIdChiTiet.Text = dtgvDanhsachSanPham.Rows[e.RowIndex].Cells["idProductDetail"].Value.ToString();
            txbKieuSanPham.Text = dtgvDanhsachSanPham.Rows[e.RowIndex].Cells["productType"].Value.ToString();
            txbSoLuong.Text = dtgvDanhsachSanPham.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            txbTrangThai.Text = dtgvDanhsachSanPham.Rows[e.RowIndex].Cells["productStatus"].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private async void btnThemSP_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (CheckThemSanPham())
            {
                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = connection;

                //con.Open();

                //string sql = $@"INSERT INTO PRODUCT values ('{txbIdSanPham.Text}', N'{txbTenSanPham.Text}')

                //        INSERT INTO PRODUCTDETAIL values ('{txbIdChiTiet.Text}','{txbIdSanPham.Text}', N'{txbKieuSanPham.Text}', {txbSoLuong.Text}, N'{txbTrangThai.Text}')";
                //SqlCommand cmd = new SqlCommand(sql, con);
                //var SoHang = cmd.ExecuteNonQuery();

                //string insertProcedure = "SP_INSERT_PRODUCT"; // Tên stored procedure
                //SqlParameter[] insertParams = {
                //    new SqlParameter("@IdProduct", txbIdSanPham.Text),
                //    new SqlParameter("@ProductName", txbTenSanPham.Text),
                //    new SqlParameter("@IdProductDetail", txbIdChiTiet.Text),
                //    new SqlParameter("@ProductType", txbKieuSanPham.Text),
                //    new SqlParameter("@Quantity", txbSoLuong.Text),
                //    new SqlParameter("@ProductStatus", txbTrangThai.Text)
                //};
                var myData = new
                {
                    IdProduct = txbIdSanPham.Text,
                    ProductName = txbTenSanPham.Text,
                    IdProductDetail = txbIdChiTiet.Text,
                    ProductType = txbKieuSanPham.Text,
                    Quantity = txbSoLuong.Text,
                    ProductStatus = txbTrangThai.Text
                };

                var json = JsonConvert.SerializeObject(myData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://localhost:44318/api/QLSP/themsanpham", content);

                if (response.IsSuccessStatusCode)
                {
                    bool result = bool.Parse(await response.Content.ReadAsStringAsync());

                    if (result)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                        Reset();
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm chưa thành công", "Thông báo");
                }
                else
                {
                    // Xử lý khi phản hồi không thành công
                    string errorMessage = $"Lỗi khi gọi API: {response.ReasonPhrase}";
                    MessageBox.Show(errorMessage, "Thông báo");
                }
                //bool result = dbConnect.ExecuteNonQuery(insertProcedure, insertParams);

                //if (result)
                //{
                //    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                //    Reset();
                //}    
                //else
                //    MessageBox.Show("Thêm sản phẩm chưa thành công", "Thông báo");


                LoadDataGridView();
            }
        }

        private async void btnUpdateSP_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (CheckThemSanPham())
            {

                var myData = new
                {
                    IdProduct = txbIdSanPham.Text,
                    ProductName = txbTenSanPham.Text,
                    IdProductDetail = txbIdChiTiet.Text,
                    ProductType = txbKieuSanPham.Text,
                    Quantity = txbSoLuong.Text,
                    ProductStatus = txbTrangThai.Text
                };

                var json = JsonConvert.SerializeObject(myData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://localhost:44318/api/QLSP/capnhatsanpham", content);
                if (response.IsSuccessStatusCode)
                {
                    bool result = bool.Parse(await response.Content.ReadAsStringAsync());

                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        Reset();
                    }
                    else
                        MessageBox.Show("Cập nhật chưa thành công", "Thông báo");
                }
                else
                {
                    // Xử lý khi phản hồi không thành công
                    string errorMessage = $"Lỗi khi gọi API: {response.ReasonPhrase}";
                    MessageBox.Show(errorMessage, "Thông báo");
                }
                //bool result = dbConnect.ExecuteNonQuery(updateProcedure, updateParams);




                LoadDataGridView();

            }


            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = connection;

            //con.Open();

            ////string sql = "update PRODUCT @set  productName = N'Bút mực'\r\nwhere idProduct = 'A01'" +
            ////    "update PRODUCTDETAIL\r\nset productStatus = N'Không Bền', productType = N'Gỗ', quantity = 100\r\nwhere idProduct = 'A01' and idProductDetail = 'B01'";
            //string sql = $@"update PRODUCT 
            //    set  productName = N'{txbTenSanPham.Text}'
            //    where idProduct = N'{txbIdSanPham.Text}'

            //    update PRODUCTDETAIL
            //    set productStatus = N'{txbTrangThai.Text}', productType = N'{txbKieuSanPham.Text}', quantity = {txbSoLuong.Text}
            //    where idProductDetail = '{txbIdChiTiet.Text}'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //var SoHang = cmd.ExecuteNonQuery();

            //if (SoHang <= 0)
            //    MessageBox.Show("Cập nhật chưa thành công", "Thông báo");
            //else
            //{
            //    MessageBox.Show("Cập nhật thành công", "Thông báo");
            //    Reset();

            //}

            //LoadDataGridView();
            //con.Close();
        }

        private async void btnDeleteSP_Click(object sender, EventArgs e)
        {
            string Id = txbIdSanPham.Text;
            string url = $"https://localhost:44318/api/QLSP/xoaSanPham?Id={Id}";
            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("ID sản phẩm không hợp lệ.", "Thông báo");
                return;
            }
            HttpResponseMessage response = await client.PostAsync(url, null);

            if (response.IsSuccessStatusCode)
            {
                // Đọc nội dung phản hồi từ API
                bool result = bool.Parse(await response.Content.ReadAsStringAsync());

                if (result)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Reset(); // Gọi hàm Reset để làm mới giao diện
                }
                else
                {
                    MessageBox.Show("Xóa chưa thành công", "Thông báo");
                }
            }
            else
            {
                // Xử lý khi phản hồi không thành công
                string errorMessage = $"Lỗi khi gọi API: {response.ReasonPhrase}";
                MessageBox.Show(errorMessage, "Thông báo");
            }


            LoadDataGridView();
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = connection;

            //con.Open();

            //string sql = $@"DELETE FROM PRODUCTDETAIL WHERE idProductDetail = '{txbIdChiTiet.Text}'

            //                DELETE FROM PRODUCT WHERE idProduct = '{txbIdSanPham.Text}'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //var SoHang1 = cmd.ExecuteNonQuery();

            //if (SoHang1 <= 0)
            //    MessageBox.Show("Xóa chưa thành công", "Thông báo");
            //else
            //{
            //    MessageBox.Show("Xóa thành công", "Thông báo");
            //    Reset();

            //}

            //LoadDataGridView();
            //con.Close();
        }



        private async void LoadDataGridView()
        {

            //string selectProcedure = "SP_SELECT_PRODUCT"; // Tên stored procedure

            //DataTable result = dbConnect.ExecuteQuery(selectProcedure);
            // URL of your API endpoint
            string url = "https://localhost:44318/api/QLSP/danhsachsanpham";

            // Fetch data from API
            string response = await client.GetStringAsync(url);

            // Convert the response to DataTable
            DataTable result = JsonConvert.DeserializeObject<DataTable>(response);

            dtgvDanhsachSanPham.DataSource = result;
            foreach (DataGridViewColumn column in dtgvDanhsachSanPham.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dtgvDanhsachSanPham.Columns["idProduct"].HeaderText = "ID";
            dtgvDanhsachSanPham.Columns["productName"].HeaderText = "Tên sản phẩm";
            dtgvDanhsachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDanhsachSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvDanhsachSanPham.Refresh();
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = connection;

            //con.Open();

            //string sql = "select pr.idProduct, productName, idProductDetail, productType, quantity, productStatus from PRODUCT pr join PRODUCTDETAIL pd on pr.idProduct = pd.idProduct ";
            //DataSet ds = new DataSet();
            ////Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            //SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            ////Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            //dap.Fill(ds);
            //dtgvDanhsachSanPham.DataSource = ds.Tables[0];
            //dtgvDanhsachSanPham.Columns["idProduct"].HeaderText = "ID";
            //dtgvDanhsachSanPham.Columns["productName"].HeaderText = "Tên sản phẩm";
            //dtgvDanhsachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dtgvDanhsachSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dtgvDanhsachSanPham.Refresh();
            //con.Close();
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            //string searchProcedure = "SP_SELECT_PRODUCT"; // Tên stored procedure
            //SqlParameter[] searchParams = {
            //            new SqlParameter("@IdProduct", 
            //            string.IsNullOrWhiteSpace(txbTimKiem.Text) ? null : txbTimKiem.Text),
            //};

            //DataTable result = dbConnect.ExecuteQuery(searchProcedure, searchParams);
            string Id = string.IsNullOrWhiteSpace(txbTimKiem.Text) ? null : txbTimKiem.Text;
            string url = $"https://localhost:44318/api/QLSP/danhsachsanpham?Id={Id}";

            // Fetch data from API
            string response = await client.GetStringAsync(url);

            // Convert the response to DataTable
            DataTable result = JsonConvert.DeserializeObject<DataTable>(response);
            dtgvDanhsachSanPham.DataSource = result;
            dtgvDanhsachSanPham.Columns["idProduct"].HeaderText = "ID";
            dtgvDanhsachSanPham.Columns["productName"].HeaderText = "Tên sản phẩm";
            dtgvDanhsachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDanhsachSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvDanhsachSanPham.Refresh();
        }

        private void dtgvDanhsachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in dtgvDanhsachSanPham.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
