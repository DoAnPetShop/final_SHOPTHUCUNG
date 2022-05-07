using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLHoaDon bllbanghoadon = new BLLHoaDon();
        BLLCBHoaDon bllcbhoadon = new BLLCBHoaDon();
        BLLSanPham bllsanpham = new BLLSanPham();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void loadcombo()
        {

            cbo_mahd.DataSource = bllcbhoadon.loadCBHoaDon();
            cbo_mahd.DisplayMember = "MAHD";
            cbo_mahd.ValueMember = "MAHD";
            
        }
        
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadcombo();
            loadDataG();
        }

        private void cbo_mahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
        public void loadDataG()
        {

            int mahd = int.Parse(cbo_mahd.SelectedValue.ToString());
            dataGridView_CTHD.DataSource = bllbanghoadon.loadCTHoaDon(mahd);
            dataGridView_SanPham.DataSource = bllsanpham.loadSanPham();
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sp.Text = dataGridView_SanPham.CurrentRow.Cells[1].Value.ToString();
        
            txt_masp.Text = dataGridView_SanPham.CurrentRow.Cells[0].Value.ToString();
            txt_dongia.Text = dataGridView_SanPham.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_mua_Click(object sender, EventArgs e)
        {
            if (cbo_mahd.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để thanh toán!!!");
            }
            else
            {
                DialogResult h = MessageBox.Show
                   ("Bạn có chắc muốn thanh toán hóa đơn " + cbo_mahd.SelectedValue.ToString() + " không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    if (dataGridView_CTHD.DataSource == null)
                    {
                        MessageBox.Show("Chưa có sản phẩm trong hóa đơn!!!");
                        return;
                    }
                    else
                    {
                      
                    }
                 
                 
                }
            }
           
           
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (txt_sp.Text == "")
            {
                errorProvider1.SetError(txt_sp, "Không được để trống tên hóa đơn");
                txt_sp.Focus();
                return;
            }
            if (txt_dongia.Text == "" || !char.IsDigit(txt_dongia.Text.ToString(), 0))
            {
                errorProvider2.SetError(txt_dongia, "Không được để trống đơn giá");
                txt_dongia.Focus();
                return;
            }
            if (nguoidung.GetSoLuongSanPham(txt_masp.Text) < number.Value)
            {
                MessageBox.Show("Không đủ số lượng!!!");
                return;
            }
            else
            {
                CTHOADON cthd = new CTHOADON();
                cthd.MAHD = int.Parse(cbo_mahd.SelectedValue.ToString());
          
                cthd.MASP = int.Parse(txt_masp.Text);
                cthd.SOLUONG = int.Parse(number.Value.ToString());
                cthd.DONGIA = decimal.Parse(txt_dongia.Text);

                qlthucung.CTHOADONs.InsertOnSubmit(cthd);
                qlthucung.SubmitChanges();
                loadDataG();
            }
        }

       
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                  ("Bạn có chắc muốn xóa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dataGridView_CTHD.CurrentRow.Cells[0].Value.ToString());
                CTHOADON ct = qlthucung.CTHOADONs.Where(t => t.MAHD == cthd).FirstOrDefault();
                qlthucung.CTHOADONs.DeleteOnSubmit(ct);
                qlthucung.SubmitChanges();
                loadDataG();
            }
        }
    }
}
