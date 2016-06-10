﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiBanVang.Model;
using BUL;
using DTO;

namespace QuanLiBanVang.Form
{
    public partial class DanhSachPhieuNhapHang_Form : DevExpress.XtraEditors.XtraForm
    {
        private BUL_PhieuNhapHang bulImportReceipt;
        public DanhSachPhieuNhapHang_Form()
        {
            InitializeComponent();
            this.bulImportReceipt = new BUL_PhieuNhapHang();
            this.gridControl1.DataSource = this.bulImportReceipt.getAll(); // binding data for gridview
            // some columns that is not informative will be invisible 
            this.gridView1.Columns[5].Visible = false;
            this.gridView1.Columns[6].Visible = false;
            this.gridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check the gridview is valid 
            if (this.gridView1.SelectedRowsCount < 0 || this.gridView1.SelectedRowsCount > 1 || this.gridView1.DataRowCount == 0) { return; }
            PHIEUNHAPHANG selectedImportReceipt = (PHIEUNHAPHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            // start the form
            PhieuNhapHang_Form viewImportDetailForm = new PhieuNhapHang_Form(ActionType.ACTION_VIEW, selectedImportReceipt);
            // show form 
            viewImportDetailForm.ShowDialog();
        }

        private void DanhSachPhieuNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuNhapHang_Form newImportReceipt = new PhieuNhapHang_Form(ActionType.ACTION_CREATE_NEW, null);
            newImportReceipt.ShowDialog();
        }

        /// <summary>
        /// Refreshes gridview when user click refresh menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bulImportReceipt = new BUL_PhieuNhapHang();
            this.gridControl1.DataSource = this.bulImportReceipt.getAll();
        }


    }
}