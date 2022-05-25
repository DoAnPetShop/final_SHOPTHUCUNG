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
    public partial class frmNhaCungCap : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        BLLNhaCungCap bllncc = new BLLNhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadG();
        }
        public void loadG()
        {
            dt_ncc.DataSource = bllncc.loadNhacc();
        }

        private void dt_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dt_ncc.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dt_ncc.CurrentRow.Cells[1].Value.ToString();
            txtDC.Text = dt_ncc.CurrentRow.Cells[2].Value.ToString();
            txtDT.Text = dt_ncc.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (txtMa.Text == "")
            {
                errorProvider1.SetError(txtMa, "Không được để trống mã nhà cung cấp");
                txtMa.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                errorProvider2.SetError(txtTen, "Không được để trống tên nhà cung cấp");
                txtTen.Focus();
                return;
            }
            else
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.MACC = txtMa.Text;

                ncc.TENCC = txtTen.Text;
                ncc.DIACHI = txtDC.Text;
                ncc.DTHOAI = txtDT.Text;

                qlthucung.NHACUNGCAPs.InsertOnSubmit(ncc);
                qlthucung.SubmitChanges();
                loadG();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                 ("Bạn có chắc muốn xóa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                string ncc = dt_ncc.CurrentRow.Cells[0].Value.ToString();
                NHACUNGCAP ct = qlthucung.NHACUNGCAPs.Where(t => t.MACC == ncc).FirstOrDefault();
                qlthucung.NHACUNGCAPs.DeleteOnSubmit(ct);
                qlthucung.SubmitChanges();
                loadG();
            }
        }
    }
}
