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

namespace PhanMemQuanLyKhachSan
{
    public partial class frmForgot : Form
    {
        public frmForgot()
        {
            InitializeComponent();
        }
        private void txtCccd_Enter(object sender, EventArgs e)
        {
            if (txtCccd.Text == "Cccd")
            {
                txtCccd.Text = " ";
                txtCccd.ForeColor = Color.Black;
            }
        }

        private void txtCccd_Leave(object sender, EventArgs e)
        {
            if (txtCccd.Text == " ")
            {
                txtCccd.Text = "Tên đăng nhập";
                txtCccd.ForeColor = Color.Silver;
            }
        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string connection = @"Server=DESKTOP-BRSAPG5\SQLEXPRESS; Database=PMQLKS;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from MatKhau where cccd='"+txtCccd.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               txtMatKhau.Text = dr.GetValue(1).ToString();
                MessageBox.Show("Mật khẩu tìm được là:" + " " + dr.GetValue(1).ToString());
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không tồn tại");
                ClearData();
            }
        }
        private void ClearData()
        {
            txtMatKhau.Text = "";
            txtCccd.Text = "";
        }

        private void frmForgot_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap fnd = new frmDangNhap();
            fnd.Show();
            this.Close();
        }
    }
}
