using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmSanPham : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLLoaiSP bllloaisp = new BLLLoaiSP();
        BLLSanPham bllsanpham = new BLLSanPham();
        String imLocation = "";
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

            loadDataG();
            loadcombo();
        }
        public void loadcombo()
        {
            
            cb_masp.DataSource = bllloaisp.loadLoaiSP();
            cb_masp.DisplayMember = "TENLOAI";
            cb_masp.ValueMember = "MALOAI";
          


        }
        public void loadDataG()
        {

    
                dataGridView_SanPham.DataSource = bllsanpham.loadSanPham();
           

        }

        private void btn_uphinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png) |*.png|jpg files(*.jpg)|*.jpg|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imLocation = dialog.FileName.ToString();
                txt_hinh.Text = imLocation;
            }
            pictureBox5.Image = Image.FromFile(imLocation);
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            txt_ma.Text = dataGridView_SanPham.CurrentRow.Cells[0].Value.ToString();
            txt_tensp.Text = dataGridView_SanPham.CurrentRow.Cells[1].Value.ToString();
            pictureBox5.ImageLocation = dataGridView_SanPham.CurrentRow.Cells[2].Value.ToString();
            txt_hinh.Text = dataGridView_SanPham.CurrentRow.Cells[2].Value.ToString();
            number.Value = decimal.Parse(dataGridView_SanPham.CurrentRow.Cells[3].Value.ToString());
            txt_gia.Text = dataGridView_SanPham.CurrentRow.Cells[4].Value.ToString();
            txt_mota.Text = dataGridView_SanPham.CurrentRow.Cells[6].Value.ToString();
            cb_masp.SelectedItem = dataGridView_SanPham.CurrentRow.Cells[7].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
           
            if (txt_tensp.Text == "")
            {
                errorProvider1.SetError(txt_tensp, "Không được để trống tên sản phẩm");
                txt_tensp.Focus();
                return;
            }
            if (txt_gia.Text == "" || !char.IsDigit(txt_gia.Text.ToString(), 0))
            {
                errorProvider2.SetError(txt_gia, "Không được để trống đơn giá");
                txt_gia.Focus();
                return;
            }
            if (txt_mota.Text == "")
            {
                errorProvider2.SetError(txt_gia, "Không được để trống mô tả");
                txt_gia.Focus();
                return;
            }
          

                SANPHAM cthd = new SANPHAM();
              

                cthd.TenSP = txt_tensp.Text;
                cthd.HinhAnh = txt_hinh.Text;
                cthd.MoTa = txt_mota.Text;
                cthd.Gia = int.Parse(txt_gia.Text);
                cthd.Soluong = int.Parse(number.Value.ToString());
                cthd.MaLoai = int.Parse(cb_masp.SelectedValue.ToString());
                qlthucung.SANPHAMs.InsertOnSubmit(cthd);
                qlthucung.SubmitChanges();
                loadDataG();
            MessageBox.Show("Thêm thành công");
        }
        

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn sửa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dataGridView_SanPham.CurrentRow.Cells[0].Value.ToString());
                SANPHAM ct = qlthucung.SANPHAMs.Where(t => t.MaSP == cthd).FirstOrDefault();
                if(ct != null)
                {
                    ct.HinhAnh = txt_hinh.Text;
                    ct.MoTa = txt_mota.Text;
                    qlthucung.SubmitChanges();
                    loadDataG();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
               
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                  ("Bạn có chắc muốn xóa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dataGridView_SanPham.CurrentRow.Cells[0].Value.ToString());
                SANPHAM ct = qlthucung.SANPHAMs.Where(t => t.MaSP == cthd).FirstOrDefault();
                if (ct != null)
                {
                    qlthucung.SANPHAMs.DeleteOnSubmit(ct);
                    qlthucung.SubmitChanges();
                    loadDataG();
                    MessageBox.Show("Xóa thành công");
                }
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
