﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using BUS;

namespace PharmacyManagement
{
    public partial class UC_Index : UserControl
    {
        //SqlConnection con = new SqlConnection("Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True");
        SqlConnection con = new SqlConnection();
        //SqlCommand cmd;
        DataTable dt, dt1;
        SqlDataAdapter da, da1;
        DataSet ds, ds1;
        SqlCommand com = new SqlCommand();
        SqlCommandBuilder db, db1;
        SqlDataReader dr1;

        public void get_data()
        {
            con.ConnectionString = @"Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True";
        }

        public void load_data()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from CUSTOMER";


            da = new SqlDataAdapter

                /****** Script for SelectTopNRows command from SSMS  ******/
                (   "SELECT [PRODUCT].[ProductID] as [Mã Thuốc]"
                 + ",[PRODUCT].[ProductName] as [Tên Thuốc]"
                 + ",[PRODUCT_TYPE].[ProductTypeName] as [Loại Thuốc]"
                 + ",[PRODUCT].[SellingPrice] as [Giá bán] "
                 + ",[UNIT].[UnitName] as [Quy cách đóng gói]"
                 + "FROM[PRODUCT], [PRODUCT_TYPE], [NON_SERVICES], [UNIT]"
                 + "WHERE[PRODUCT].[ProductTypeID] = [PRODUCT_TYPE].[ProductTypeID]"
                 + "and[PRODUCT].[ProductID] = [NON_SERVICES].[ProductID]"
                 + "and[NON_SERVICES].[UnitID] = [UNIT].[UnitID]"

                  , con
                );

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "PRODUCT");
            dt = ds.Tables["PRODUCT"];
            dgv_DanhMuc.DataSource = dt;

            con.Close();
        }
        void load_combo()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select ProductTypeName from PRODUCT_TYPE";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            comboBox3.ValueMember = "ProductTypeName";
            comboBox3.DataSource = dt;
            con.Close();
        }

        public UC_Index()
        {
            InitializeComponent();
            get_data();
            load_data();
            load_combo();
        }
        private int row = -1;
        private void UC_Index_Load(object sender, EventArgs e)
        {

        }

        private void pn_ThongTinThuoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void txt_MaHang_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("[Mã Thuốc] LIKE '%{0}%'", txt_MaHang.Text);


            dgv_DanhMuc.DataSource = dv;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("[Loại Thuốc] LIKE '%{0}%'", comboBox3.Text);


            dgv_DanhMuc.DataSource = dv;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form form = new FrmIndexAdd();
            form.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hàng hóa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Xoa hang

                row = -1;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để sửa");
                return;
            }
            //Form frm = new FrmEditIndex(dgv_DanhMuc.Rows[row].Cells[0].Value.ToString());
            dgv_DanhMuc.Refresh();
            row = -1;
        }

        private void dgv_DanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new FrmIndexInfo();
            form.Show();
        }
    }
}