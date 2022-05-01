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
    public partial class frmDangNhap : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label3.Text);
                this.txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label4.Text);
                this.txtPass.Focus();
                return;
            }
            int kq = CauHinh.check_config();
            if (kq == 0)
            {
                processlogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Cau hinh khong ton tai");
            }
            if (kq == 2)
            {
                MessageBox.Show("Cau hinh khong phu hop");
            }
        }
             public void processlogin()
        {
            int kq = CauHinh.check_user(txtName.Text, txtPass.Text);
            if(kq == 5)
            {
                MessageBox.Show("Sai " + label3.Text + " hoac " + label4.Text + "");
                return;
            }
            else if (kq == 10)
            {
                MessageBox.Show("Tai khoan bi khoa");
                return;
            }
           
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain();
            }
            this.Visible = false;
            Program.mainForm.Show();
        }

             private void frmDangNhap_Load(object sender, EventArgs e)
             {

             }

             private void button1_Click(object sender, EventArgs e)
             {
                 DialogResult h = MessageBox.Show("May co muon thoat khong", "thong bao", MessageBoxButtons.OKCancel);
                 if (h == DialogResult.OK)
                     Application.Exit();
             }
        
    }
}
