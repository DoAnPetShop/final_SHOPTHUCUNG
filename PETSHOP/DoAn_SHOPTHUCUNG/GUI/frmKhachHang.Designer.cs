namespace GUI
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbo_phanloai = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.txt_dth = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_khachhang = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.dataGridView_khachhang);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 651);
            this.panel1.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.cbo_phanloai);
            this.panel3.Controls.Add(this.bt_xoa);
            this.panel3.Controls.Add(this.bt_them);
            this.panel3.Controls.Add(this.bt_sua);
            this.panel3.Controls.Add(this.bt_reset);
            this.panel3.Controls.Add(this.txt_dth);
            this.panel3.Controls.Add(this.txt_diachi);
            this.panel3.Controls.Add(this.txt_makh);
            this.panel3.Controls.Add(this.txt_tenkh);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(59, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 228);
            this.panel3.TabIndex = 0;
            // 
            // cbo_phanloai
            // 
            this.cbo_phanloai.FormattingEnabled = true;
            this.cbo_phanloai.Location = new System.Drawing.Point(614, 16);
            this.cbo_phanloai.Name = "cbo_phanloai";
            this.cbo_phanloai.Size = new System.Drawing.Size(104, 24);
            this.cbo_phanloai.TabIndex = 57;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Transparent;
            this.bt_xoa.BackgroundImage = global::GUI.Properties.Resources.delete;
            this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Location = new System.Drawing.Point(271, 159);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(57, 47);
            this.bt_xoa.TabIndex = 55;
            this.bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Transparent;
            this.bt_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_them.BackgroundImage")));
            this.bt_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Location = new System.Drawing.Point(125, 158);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(59, 48);
            this.bt_them.TabIndex = 56;
            this.bt_them.UseVisualStyleBackColor = false;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Transparent;
            this.bt_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sua.BackgroundImage")));
            this.bt_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Location = new System.Drawing.Point(385, 158);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(59, 46);
            this.bt_sua.TabIndex = 54;
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.Transparent;
            this.bt_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_reset.BackgroundImage")));
            this.bt_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_reset.FlatAppearance.BorderSize = 0;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Location = new System.Drawing.Point(519, 158);
            this.bt_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(57, 46);
            this.bt_reset.TabIndex = 53;
            this.bt_reset.UseVisualStyleBackColor = false;
            // 
            // txt_dth
            // 
            this.txt_dth.Location = new System.Drawing.Point(394, 57);
            this.txt_dth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dth.Name = "txt_dth";
            this.txt_dth.Size = new System.Drawing.Size(141, 22);
            this.txt_dth.TabIndex = 1;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(139, 57);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(133, 22);
            this.txt_diachi.TabIndex = 1;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(139, 16);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(133, 22);
            this.txt_makh.TabIndex = 1;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(394, 15);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(141, 22);
            this.txt_tenkh.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ngày Sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phân Loại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Khách Hàng:";
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(59, 249);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.RowTemplate.Height = 24;
            this.dataGridView_khachhang.Size = new System.Drawing.Size(718, 348);
            this.dataGridView_khachhang.TabIndex = 1;
            this.dataGridView_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khachhang_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 652);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbo_phanloai;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.TextBox txt_dth;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_khachhang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}