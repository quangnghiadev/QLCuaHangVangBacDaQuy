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

namespace QuanLiBanVang.Report
{
    public partial class NhapPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {
       
        private BUL.BUL_PhieuChi _bulPaymentBill;
        private int _staffId;
        public NhapPhieuChi_Form()
        {
            InitializeComponent();
      
            _bulPaymentBill = new BUL.BUL_PhieuChi();
        }
        public NhapPhieuChi_Form(int staffid)
        {
      
            _bulPaymentBill = new BUL.BUL_PhieuChi();
            _staffId = staffid;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NhapPhieuChi_Form_Load(object sender, EventArgs e)
        {
            
            this.dtpkCreateDate.EditValue = DateTime.Now;
            this.dtpkCreateDate.Properties.MaxValue = DateTime.Now;
            this.dtpkCreateDate.Properties.MinValue = DateTime.Now;
            this.dtpkCreateDate.Enabled = false;
           
        }
        private bool CheckControlValidation()
        {
            if (txtContent.Text == "")
                return false;
            if (txtCost.Text == "")
                return false;
            if (dtpkCreateDate.EditValue.ToString() == "")
                return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckControlValidation())
            {
                MessageBox.Show("Vui lòng nhập chính xác và đầy đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DTO.PHIEUCHI newBill = new DTO.PHIEUCHI();
            newBill.NoiDungChi = this.txtContent.Text;
            newBill.NgayLap = (DateTime)this.dtpkCreateDate.EditValue;
            newBill.SoTien = decimal.Parse(this.txtCost.Text);
            this._bulPaymentBill.addNewPaymentBill(newBill);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}