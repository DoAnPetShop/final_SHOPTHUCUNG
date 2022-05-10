namespace GUI
{
    partial class frmBaoCaoNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoNgay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_doanhthu = new System.Windows.Forms.DataGridView();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanhthu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.dataGridView_doanhthu);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 649);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView_doanhthu
            // 
            this.dataGridView_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doanhthu.Location = new System.Drawing.Point(54, 258);
            this.dataGridView_doanhthu.Name = "dataGridView_doanhthu";
            this.dataGridView_doanhthu.RowTemplate.Height = 24;
            this.dataGridView_doanhthu.Size = new System.Drawing.Size(730, 202);
            this.dataGridView_doanhthu.TabIndex = 35;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(538, 480);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(246, 37);
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
            this.label8.Size = new System.Drawing.Size(389, 38);
            this.label8.TabIndex = 1;
            this.label8.Text = "BÁO CÁO THEO NGÀY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.bt_thoat);
            this.panel2.Controls.Add(this.bt_in);
            this.panel2.Controls.Add(this.bt_tim);
            this.panel2.Location = new System.Drawing.Point(54, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 174);
            this.panel2.TabIndex = 0;
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_thoat.BackgroundImage")));
            this.bt_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Location = new System.Drawing.Point(585, 116);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(99, 50);
            this.bt_thoat.TabIndex = 2;
            this.bt_thoat.UseVisualStyleBackColor = true;
            // 
            // bt_in
            // 
            this.bt_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_in.BackgroundImage")));
            this.bt_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_in.Location = new System.Drawing.Point(585, 58);
            this.bt_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(99, 52);
            this.bt_in.TabIndex = 2;
            this.bt_in.UseVisualStyleBackColor = true;
            // 
            // bt_tim
            // 
            this.bt_tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_tim.BackgroundImage")));
            this.bt_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tim.Location = new System.Drawing.Point(585, 2);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(99, 44);
            this.bt_tim.TabIndex = 2;
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // frmBaoCaoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 652);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoNgay";
            this.Text = "frmBaoCaoNgay";
            this.Load += new System.EventHandler(this.frmBaoCaoNgay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanhthu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dataGridView_doanhthu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}