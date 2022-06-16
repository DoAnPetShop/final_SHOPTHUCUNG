namespace GUI
{
    partial class frmBaoCaoThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoThang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_hienthi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_chucnang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dataGridView_doanhthu = new System.Windows.Forms.DataGridView();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hienthi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.dataGridView_hienthi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView_doanhthu);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-13, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 649);
            this.panel1.TabIndex = 26;
            // 
            // dataGridView_hienthi
            // 
            this.dataGridView_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hienthi.Location = new System.Drawing.Point(482, 72);
            this.dataGridView_hienthi.Name = "dataGridView_hienthi";
            this.dataGridView_hienthi.RowTemplate.Height = 24;
            this.dataGridView_hienthi.Size = new System.Drawing.Size(323, 169);
            this.dataGridView_hienthi.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cb_chucnang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.bt_thoat);
            this.panel2.Controls.Add(this.bt_in);
            this.panel2.Controls.Add(this.bt_tim);
            this.panel2.Location = new System.Drawing.Point(53, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 175);
            this.panel2.TabIndex = 37;
            // 
            // cb_chucnang
            // 
            this.cb_chucnang.FormattingEnabled = true;
            this.cb_chucnang.Items.AddRange(new object[] {
            "San pham duoc ban ra nhieu nhat",
            "San pham co doanh thu cao nhat"});
            this.cb_chucnang.Location = new System.Drawing.Point(203, 64);
            this.cb_chucnang.Name = "cb_chucnang";
            this.cb_chucnang.Size = new System.Drawing.Size(190, 24);
            this.cb_chucnang.TabIndex = 6;
            this.cb_chucnang.SelectedIndexChanged += new System.EventHandler(this.cb_chucnang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn thang báo cáo: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_thoat.BackgroundImage")));
            this.bt_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Location = new System.Drawing.Point(235, 123);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(96, 44);
            this.bt_thoat.TabIndex = 2;
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click_1);
            // 
            // bt_in
            // 
            this.bt_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_in.BackgroundImage")));
            this.bt_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_in.Location = new System.Drawing.Point(121, 123);
            this.bt_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(94, 44);
            this.bt_in.TabIndex = 2;
            this.bt_in.UseVisualStyleBackColor = true;
            // 
            // bt_tim
            // 
            this.bt_tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_tim.BackgroundImage")));
            this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tim.Location = new System.Drawing.Point(16, 123);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(99, 44);
            this.bt_tim.TabIndex = 2;
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click_1);
            // 
            // dataGridView_doanhthu
            // 
            this.dataGridView_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doanhthu.Location = new System.Drawing.Point(54, 258);
            this.dataGridView_doanhthu.Name = "dataGridView_doanhthu";
            this.dataGridView_doanhthu.RowTemplate.Height = 24;
            this.dataGridView_doanhthu.Size = new System.Drawing.Size(751, 202);
            this.dataGridView_doanhthu.TabIndex = 35;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(538, 489);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(246, 28);
            this.txt_tongtien.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(365, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tổng Doanh thu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(412, 38);
            this.label8.TabIndex = 1;
            this.label8.Text = "BÁO CÁO THEO THÁNG";
            // 
            // frmBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 652);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoThang";
            this.Text = "frmBaoCaoThang";
            this.Load += new System.EventHandler(this.frmBaoCaoThang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hienthi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_doanhthu;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_hienthi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_chucnang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_tim;
    }
}