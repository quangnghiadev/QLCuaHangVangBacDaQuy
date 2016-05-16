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
    public partial class SuaPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {

        private BUL.BUL_PhieuChi _bulPaymentBill;
        private DTO.PHIEUCHI _paymentBill;
        public SuaPhieuChi_Form()
        {
            InitializeComponent();
  
            _bulPaymentBill = new BUL.BUL_PhieuChi();
     
        }
        public SuaPhieuChi_Form(int id)
        {
            InitializeComponent();

            _bulPaymentBill = new BUL.BUL_PhieuChi();
            _paymentBill = _bulPaymentBill.getPaymentBillById(id);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void SuaPhieuChi_Form_Load(object sender, EventArgs e)
        {
            this.dtpkCreateDate.Properties.MinValue = DateTime.Now;
            this.dtpkCreateDate.Enabled = false;
            this.dtpkCreateDate.EditValue = _paymentBill.NgayLap;
            this.txtPrice.Text = int.Parse(_paymentBill.SoTien.ToString()).ToString();

        }
        private bool CheckControlValidation()
        {
            if (this.txtPrice.Text == "")
                return false;
            if (this.txtContent.Text.Length == 0)
                return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this._paymentBill.SoTien = decimal.Parse(this.txtPrice.Text);
            this._paymentBill.NgayLap = (DateTime)this.dtpkCreateDate.EditValue;
            this._paymentBill.NoiDungChi = this.txtContent.Text;
            this._bulPaymentBill.updatePaymentBill(_paymentBill);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}