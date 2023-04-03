using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmCapNhatLoaiPhong : Form
    {
        public frmCapNhatLoaiPhong()
        {
            InitializeComponent();
        }

        private void BtnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong qlp = new frmQuanLyPhong();
            qlp.Show();
            this.Close();
        }

        private void btnHuyCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void rdoStandard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbChonSoPhong.SelectedValue.ToString());
            

            QLKSModel context = new QLKSModel();
            Phong phongcur = Phong.GetPhong(id);
            if (rdoStandard.Checked == true)
                phongcur.LoaiPhongID = 1;
            else if (rdoSuperior.Checked == true)
                phongcur.LoaiPhongID = 2;
            else phongcur.LoaiPhongID = 3;


            phongcur.InsertUpdate();
            MessageBox.Show("Cập nhật loại đã thành công!");

        }

        private void rdoSuperior_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbChonSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblChonLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void frmCapNhatLoaiPhong_Load(object sender, EventArgs e)
        {
            List<Phong> lstphong = Phong.GetAll();
            cmbChonSoPhong.DataSource = lstphong;
            cmbChonSoPhong.ValueMember = "PhongID";
            cmbChonSoPhong.DisplayMember = "PhongID";

        }
    }
}
