using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhapHang : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLNhapHang bllnhaphang = new BLLNhapHang();
        BLLNhaCungCap bllncc = new BLLNhaCungCap();
        BLLCTNHAPHANG bllct = new BLLCTNHAPHANG();
        BLLSanPham bllsp = new BLLSanPham();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            
            loadcombobox();
            loadCT();
        }
        
        public void loadCT()
        {
            if (cboMaNhap.SelectedValue.ToString() != "DTO.NHAPHANG")
            {
                int manhap = int.Parse(cboMaNhap.SelectedValue.ToString());
                dt_ctnhaphang.DataSource = bllct.loadCTnhaphang(manhap);
            }
        }
        public void loadcombobox()
        {
            cboNCC.DataSource = bllncc.loadNhacc();
            cboNCC.DisplayMember = "MACC";
            cboNCC.ValueMember = "MACC";
            cboMaNhap.DataSource = bllnhaphang.loadNhapHang();
            cboMaNhap.DisplayMember = "MANHAP";
            cboMaNhap.ValueMember = "MANHAP";
            cbo_sp.DataSource = bllsp.loadSanPham();
            cbo_sp.DisplayMember = "TENSP";
            cbo_sp.ValueMember = "MASP";
        }


        private void cboMaNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCT();
        }

        private void dt_ctnhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaNhap.Text = dt_ctnhaphang.CurrentRow.Cells[0].Value.ToString();
            cbo_sp.Text = dt_ctnhaphang.CurrentRow.Cells[1].Value.ToString();
            number.Text = dt_ctnhaphang.CurrentRow.Cells[2].Value.ToString();
            txt_dongia.Text = dt_ctnhaphang.CurrentRow.Cells[3].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thêm đơn nhập hàng này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {

                NHAPHANG nh = new NHAPHANG();
                nh.MACC = cboNCC.SelectedValue.ToString();

                
                nh.NGAYNHAP = DateTime.Now;

                qlthucung.NHAPHANGs.InsertOnSubmit(nh);
                qlthucung.SubmitChanges();
                loadCT();
                MessageBox.Show("Thêm đơn nhập hàng thành công !!");
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thêm chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (txt_dongia.Text == "" || !char.IsDigit(txt_dongia.Text.ToString(), 0))
                {
                    errorProvider1.SetError(txt_dongia, "Không được để trống đơn giá");
                    txt_dongia.Focus();
                    return;
                }
                else
                {

                    CTNHAPHANG nhaphangs = qlthucung.CTNHAPHANGs.Where(t => t.MANHAP == int.Parse(cboMaNhap.SelectedValue.ToString())).FirstOrDefault();

                    int sanphams = -1;
                    var sps = from sp in qlthucung.SANPHAMs
                              join
                                cthd in qlthucung.CTNHAPHANGs
                                on sp.MaSP equals cthd.MASP
                              where cthd.MANHAP.Equals(cboMaNhap.SelectedValue)
                              select new
                              {
                                  sp.MaSP
                              };
                    foreach (var product in sps)
                    {
                        sanphams = product.MaSP;
                    }
                    if (sanphams != -1)
                    {

                        if (nhaphangs.MANHAP.Equals(int.Parse(cboMaNhap.SelectedValue.ToString())) && int.Parse(cbo_sp.SelectedValue.ToString()) == sanphams)
                        {

                            CTNHAPHANG ct = qlthucung.CTNHAPHANGs.Where(t => t.MANHAP == int.Parse(cboMaNhap.SelectedValue.ToString()) && t.MASP == sanphams).FirstOrDefault();
                            ct.SOLUONG += int.Parse(number.Value.ToString());
                            ct.DONGIA = decimal.Parse(txt_dongia.Text);
                            qlthucung.SubmitChanges();
                            loadCT();
                        }
                        else
                        {

                            CTNHAPHANG cthd = new CTNHAPHANG();
                            cthd.MANHAP = int.Parse(cboMaNhap.SelectedValue.ToString());

                            cthd.MASP = int.Parse(cbo_sp.SelectedValue.ToString());
                            cthd.SOLUONG = int.Parse(number.Value.ToString());
                            cthd.DONGIA = decimal.Parse(txt_dongia.Text);

                            qlthucung.CTNHAPHANGs.InsertOnSubmit(cthd);
                            qlthucung.SubmitChanges();
                            loadCT();

                        }
                    }

                    else
                    {

                        CTNHAPHANG cthd = new CTNHAPHANG();
                        cthd.MANHAP = int.Parse(cboMaNhap.SelectedValue.ToString());

                        cthd.MASP = int.Parse(cbo_sp.SelectedValue.ToString());
                        cthd.SOLUONG = int.Parse(number.Value.ToString());
                        cthd.DONGIA = decimal.Parse(txt_dongia.Text);

                        qlthucung.CTNHAPHANGs.InsertOnSubmit(cthd);
                        qlthucung.SubmitChanges();
                        loadCT();
                    }

                }
            }
        }

        private void bt_mua_Click(object sender, EventArgs e)
        {
            if (cboMaNhap.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để thanh toán!!!");
            }
            else
            {
                DialogResult h = MessageBox.Show
                   ("Bạn có chắc muốn thanh toán hóa đơn với mã nhập " + cboMaNhap.SelectedValue.ToString() + " không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    if (dt_ctnhaphang.RowCount < 1)
                    {
                        MessageBox.Show("Chưa có sản phẩm trong hóa đơn nhập hàng!!!");
                        return;
                    }
                    else
                    {
                        if (nguoidung.upDateNhapHang(int.Parse(cboMaNhap.SelectedValue.ToString())) != -1)
                        {
                            MessageBox.Show("Đã Thanh toán và cập nhật số lượng cho hóa đơn nhập" + cboMaNhap.SelectedValue + "Vào kho");
                            loadCT();
                        }
                    }


                }

            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (rdoXemTT.Checked)
            {
                new frmXemThongTin().Show();
            }
        }

        private void bt_luu2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
             ("Bạn có chắc muốn sửa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dt_ctnhaphang.CurrentRow.Cells[0].Value.ToString());
                CTNHAPHANG ct = qlthucung.CTNHAPHANGs.Where(t => t.MANHAP == cthd).FirstOrDefault();
                ct.SOLUONG = int.Parse(number.Value.ToString());
                ct.DONGIA = decimal.Parse(txt_dongia.Text);
                if (nguoidung.GetSoLuongSanPham(cboMaNhap.SelectedValue.ToString()) < number.Value)
                {
                    MessageBox.Show("Không đủ số lượng!!!");
                    return;
                }
                qlthucung.SubmitChanges();
                loadCT();
            }
        }

        private void bt_xoa2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn xóa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dt_ctnhaphang.CurrentRow.Cells[0].Value.ToString());
                CTNHAPHANG ct = qlthucung.CTNHAPHANGs.Where(t => t.MANHAP == cthd).FirstOrDefault();
                qlthucung.CTNHAPHANGs.DeleteOnSubmit(ct);
                qlthucung.SubmitChanges();
                loadCT();
            }
        }

        private void rdoTim_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
