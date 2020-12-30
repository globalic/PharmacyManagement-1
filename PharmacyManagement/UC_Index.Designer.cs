﻿namespace PharmacyManagement
{
    partial class UC_Index
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.pn_ThongTinThuoc = new System.Windows.Forms.Panel();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DongGoi = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbl_MaThuoc = new System.Windows.Forms.Label();
            this.lbl_TenThuoc = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.txt_LoaiThuoc = new System.Windows.Forms.TextBox();
            this.dgv_DanhMuc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_ThongTinThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(919, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UC_Index";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(22, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(130, 42);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm sản phẩm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(187, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(130, 42);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Text = "Xóa sản phẩm";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(351, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(130, 42);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.TabStop = false;
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // pn_ThongTinThuoc
            // 
            this.pn_ThongTinThuoc.Controls.Add(this.txt_TenHang);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_MaHang);
            this.pn_ThongTinThuoc.Controls.Add(this.label2);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_DongGoi);
            this.pn_ThongTinThuoc.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_MaThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_TenThuoc);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_GiaBan);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_DonGia);
            this.pn_ThongTinThuoc.Controls.Add(this.lbl_SoLuong);
            this.pn_ThongTinThuoc.Controls.Add(this.txt_LoaiThuoc);
            this.pn_ThongTinThuoc.Location = new System.Drawing.Point(52, 51);
            this.pn_ThongTinThuoc.Name = "pn_ThongTinThuoc";
            this.pn_ThongTinThuoc.Size = new System.Drawing.Size(853, 185);
            this.pn_ThongTinThuoc.TabIndex = 42;
            this.pn_ThongTinThuoc.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_ThongTinThuoc_Paint);
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHang.Location = new System.Drawing.Point(335, 44);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(215, 26);
            this.txt_TenHang.TabIndex = 2;
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(0, 44);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(215, 26);
            this.txt_MaHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Quy cách đóng gói:";
            // 
            // txt_DongGoi
            // 
            this.txt_DongGoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DongGoi.Location = new System.Drawing.Point(614, 44);
            this.txt_DongGoi.Name = "txt_DongGoi";
            this.txt_DongGoi.Size = new System.Drawing.Size(215, 26);
            this.txt_DongGoi.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(634, 120);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(160, 42);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_MaThuoc
            // 
            this.lbl_MaThuoc.AutoSize = true;
            this.lbl_MaThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaThuoc.Location = new System.Drawing.Point(-3, 23);
            this.lbl_MaThuoc.Name = "lbl_MaThuoc";
            this.lbl_MaThuoc.Size = new System.Drawing.Size(75, 18);
            this.lbl_MaThuoc.TabIndex = 16;
            this.lbl_MaThuoc.Text = "Mã thuốc:";
            // 
            // lbl_TenThuoc
            // 
            this.lbl_TenThuoc.AutoSize = true;
            this.lbl_TenThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenThuoc.Location = new System.Drawing.Point(332, 23);
            this.lbl_TenThuoc.Name = "lbl_TenThuoc";
            this.lbl_TenThuoc.Size = new System.Drawing.Size(79, 18);
            this.lbl_TenThuoc.TabIndex = 18;
            this.lbl_TenThuoc.Text = "Tên thuốc:";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaBan.Location = new System.Drawing.Point(335, 120);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(215, 26);
            this.txt_GiaBan.TabIndex = 5;
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(335, 96);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(90, 18);
            this.lbl_DonGia.TabIndex = 31;
            this.lbl_DonGia.Text = "Giá bán (đ):";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(1, 96);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(84, 18);
            this.lbl_SoLuong.TabIndex = 28;
            this.lbl_SoLuong.Text = "Loại thuốc:";
            // 
            // txt_LoaiThuoc
            // 
            this.txt_LoaiThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiThuoc.Location = new System.Drawing.Point(3, 120);
            this.txt_LoaiThuoc.Name = "txt_LoaiThuoc";
            this.txt_LoaiThuoc.Size = new System.Drawing.Size(215, 26);
            this.txt_LoaiThuoc.TabIndex = 4;
            // 
            // dgv_DanhMuc
            // 
            this.dgv_DanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.LoaiThuoc,
            this.GiaBan,
            this.DongGoi});
            this.dgv_DanhMuc.Location = new System.Drawing.Point(52, 243);
            this.dgv_DanhMuc.Name = "dgv_DanhMuc";
            this.dgv_DanhMuc.ReadOnly = true;
            this.dgv_DanhMuc.Size = new System.Drawing.Size(853, 243);
            this.dgv_DanhMuc.TabIndex = 43;
            this.dgv_DanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMuc_CellContentClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Width = 71;
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            this.TenThuoc.Width = 75;
            // 
            // LoaiThuoc
            // 
            this.LoaiThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoaiThuoc.HeaderText = "Loại thuốc";
            this.LoaiThuoc.Name = "LoaiThuoc";
            this.LoaiThuoc.ReadOnly = true;
            this.LoaiThuoc.Width = 76;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 64;
            // 
            // DongGoi
            // 
            this.DongGoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DongGoi.HeaderText = "Quy cách đóng gói";
            this.DongGoi.Name = "DongGoi";
            this.DongGoi.ReadOnly = true;
            // 
            // UC_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhMuc);
            this.Controls.Add(this.pn_ThongTinThuoc);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Name = "UC_Index";
            this.Size = new System.Drawing.Size(976, 514);
            this.Load += new System.EventHandler(this.UC_Index_Load);
            this.pn_ThongTinThuoc.ResumeLayout(false);
            this.pn_ThongTinThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel pn_ThongTinThuoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label lbl_MaThuoc;
        private System.Windows.Forms.Label lbl_TenThuoc;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.TextBox txt_LoaiThuoc;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DongGoi;
        private System.Windows.Forms.DataGridView dgv_DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongGoi;
    }
}
