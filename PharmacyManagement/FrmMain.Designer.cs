﻿using System.Drawing;

namespace PharmacyManagement
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Pnl_Sidemenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Btn_Customers = new System.Windows.Forms.Button();
            this.Btn_Storage = new System.Windows.Forms.Button();
            this.Btn_Sale = new System.Windows.Forms.Button();
            this.Btn_Employee = new System.Windows.Forms.Button();
            this.Btn_Overview = new System.Windows.Forms.Button();
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.uC_Customers1 = new PharmacyManagement.UC_Customers();
            this.uC_Storage1 = new PharmacyManagement.UC_Storage();
            this.uC_Sale1 = new PharmacyManagement.UC_Sale();
            this.uC_employee1 = new PharmacyManagement.UC_Employee();
            this.uC_overview1 = new PharmacyManagement.UC_Overview();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_Sidemenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Sidemenu
            // 
            this.Pnl_Sidemenu.BackColor = System.Drawing.Color.SteelBlue;
            this.Pnl_Sidemenu.Controls.Add(this.panel3);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Customers);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Storage);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Sale);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Employee);
            this.Pnl_Sidemenu.Controls.Add(this.Btn_Overview);
            this.Pnl_Sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Sidemenu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Sidemenu.Name = "Pnl_Sidemenu";
            this.Pnl_Sidemenu.Size = new System.Drawing.Size(172, 638);
            this.Pnl_Sidemenu.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.Lb_Name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 74);
            this.panel3.TabIndex = 1;
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.BackColor = System.Drawing.Color.Orange;
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lb_Name.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.Location = new System.Drawing.Point(0, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(153, 64);
            this.Lb_Name.TabIndex = 0;
            this.Lb_Name.Text = "G7 Ph";
            this.Lb_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Customers
            // 
            this.Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Customers.FlatAppearance.BorderSize = 0;
            this.Btn_Customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customers.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Customers.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Customers.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Customers.Image")));
            this.Btn_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customers.Location = new System.Drawing.Point(0, 367);
            this.Btn_Customers.Name = "Btn_Customers";
            this.Btn_Customers.Size = new System.Drawing.Size(180, 67);
            this.Btn_Customers.TabIndex = 4;
            this.Btn_Customers.Text = "Khách Hàng";
            this.Btn_Customers.UseVisualStyleBackColor = false;
            this.Btn_Customers.Click += new System.EventHandler(this.Btn_Customers_Click);
            // 
            // Btn_Storage
            // 
            this.Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Storage.FlatAppearance.BorderSize = 0;
            this.Btn_Storage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Storage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Storage.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Storage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Storage.Image")));
            this.Btn_Storage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Storage.Location = new System.Drawing.Point(0, 294);
            this.Btn_Storage.Name = "Btn_Storage";
            this.Btn_Storage.Size = new System.Drawing.Size(180, 67);
            this.Btn_Storage.TabIndex = 3;
            this.Btn_Storage.Text = "Quản lý kho";
            this.Btn_Storage.UseVisualStyleBackColor = false;
            this.Btn_Storage.Click += new System.EventHandler(this.Btn_Storage_Click);
            // 
            // Btn_Sale
            // 
            this.Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Sale.FlatAppearance.BorderSize = 0;
            this.Btn_Sale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sale.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sale.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Sale.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sale.Image")));
            this.Btn_Sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sale.Location = new System.Drawing.Point(0, 221);
            this.Btn_Sale.Name = "Btn_Sale";
            this.Btn_Sale.Size = new System.Drawing.Size(180, 67);
            this.Btn_Sale.TabIndex = 2;
            this.Btn_Sale.Text = "Bán Hàng";
            this.Btn_Sale.UseVisualStyleBackColor = false;
            this.Btn_Sale.Click += new System.EventHandler(this.Btn_Sale_Click);
            // 
            // Btn_Employee
            // 
            this.Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Employee.FlatAppearance.BorderSize = 0;
            this.Btn_Employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Employee.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Employee.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Employee.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Employee.Image")));
            this.Btn_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Employee.Location = new System.Drawing.Point(-3, 148);
            this.Btn_Employee.Name = "Btn_Employee";
            this.Btn_Employee.Size = new System.Drawing.Size(180, 67);
            this.Btn_Employee.TabIndex = 1;
            this.Btn_Employee.Text = "Nhân Sự";
            this.Btn_Employee.UseVisualStyleBackColor = false;
            this.Btn_Employee.Click += new System.EventHandler(this.Btn_Employee_Click);
            // 
            // Btn_Overview
            // 
            this.Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Overview.FlatAppearance.BorderSize = 0;
            this.Btn_Overview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Overview.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Overview.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Overview.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Overview.Image")));
            this.Btn_Overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Overview.Location = new System.Drawing.Point(0, 75);
            this.Btn_Overview.Name = "Btn_Overview";
            this.Btn_Overview.Size = new System.Drawing.Size(180, 67);
            this.Btn_Overview.TabIndex = 0;
            this.Btn_Overview.Text = "Tổng Quan";
            this.Btn_Overview.UseVisualStyleBackColor = false;
            this.Btn_Overview.Click += new System.EventHandler(this.Btn_Overview_Click);
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.Controls.Add(this.uC_Customers1);
            this.Pnl_Main.Controls.Add(this.uC_Storage1);
            this.Pnl_Main.Controls.Add(this.uC_Sale1);
            this.Pnl_Main.Controls.Add(this.uC_employee1);
            this.Pnl_Main.Controls.Add(this.uC_overview1);
            this.Pnl_Main.Location = new System.Drawing.Point(178, 72);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(839, 566);
            this.Pnl_Main.TabIndex = 2;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customers1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(839, 566);
            this.uC_Customers1.TabIndex = 4;
            // 
            // uC_Storage1
            // 
            this.uC_Storage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Storage1.Location = new System.Drawing.Point(0, 0);
            this.uC_Storage1.Name = "uC_Storage1";
            this.uC_Storage1.Size = new System.Drawing.Size(839, 566);
            this.uC_Storage1.TabIndex = 3;
            // 
            // uC_Sale1
            // 
            this.uC_Sale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sale1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sale1.Name = "uC_Sale1";
            this.uC_Sale1.Size = new System.Drawing.Size(839, 566);
            this.uC_Sale1.TabIndex = 2;
            // 
            // uC_employee1
            // 
            this.uC_employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_employee1.Name = "uC_employee1";
            this.uC_employee1.Size = new System.Drawing.Size(839, 566);
            this.uC_employee1.TabIndex = 1;
            // 
            // uC_overview1
            // 
            this.uC_overview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_overview1.Location = new System.Drawing.Point(0, 0);
            this.uC_overview1.Name = "uC_overview1";
            this.uC_overview1.Size = new System.Drawing.Size(839, 566);
            this.uC_overview1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(172, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 74);
            this.panel1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_Main);
            this.Controls.Add(this.Pnl_Sidemenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Pnl_Sidemenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Sidemenu;
        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.Button Btn_Overview;
        private System.Windows.Forms.Button Btn_Customers;
        private System.Windows.Forms.Button Btn_Storage;
        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Button Btn_Employee;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UC_Customers uC_Customers1;
        private UC_Storage uC_Storage1;
        private UC_Sale uC_Sale1;
        private PharmacyManagement.UC_Employee uC_employee1;
        private PharmacyManagement.UC_Overview uC_overview1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}

