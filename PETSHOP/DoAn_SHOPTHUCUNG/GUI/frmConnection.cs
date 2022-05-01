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
    public partial class frmConnection : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public frmConnection()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = CauHinh.GetServerName();
            comboBox1.DisplayMember = "ServerName";
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()) || string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + label2.Text + " và " + label4.Text);
                this.txtTaiKhoan.Focus();
                return;
            }
            comboBox2.DataSource = CauHinh.GetDBName(comboBox1.Text, txtTaiKhoan.Text, txtMatKhau.Text);
            comboBox2.DisplayMember = "name";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(comboBox1.Text, txtTaiKhoan.Text, txtMatKhau.Text, comboBox2.Text);
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("May co muon thoat khong", "thong bao", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                this.Close();
        }

    }
}
