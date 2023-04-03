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
using System.Xml.Linq;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmDangKy : Form
    {
        public object Messagebox { get; private set; }
        public frmDangKy()
        {
            InitializeComponent();
        }
       
       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string connection = @"Server=DESKTOP-BRSAPG5\SQLEXPRESS; Database=PMQLKS;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "Insert into MatKhau(cccd,username,password) Values('" +txtCccd.Text + "','" + txtTenDangNhap.Text + "','" + txtMatKhau.Text +  "')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công");
                ClearData();

            }
            catch
            {
                MessageBox.Show("Đăng ký thất bại!Thông tin đã tồn tại hoặc nhập không đúng");
                ClearData();
            }
            finally
            {
                con.Close();
            }

        }
        private void ClearData()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtCccd.Text = "";
        }


        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }
      


    }
}
