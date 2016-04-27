﻿namespace QuanLiBanVang.Form
{
    partial class DanhSachPhieuBanHang
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlListReceipts = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoPhieuBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCTPBHs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHACHHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHIEUTHUTIENNOes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListReceipts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlListReceipts);
            this.groupControl1.Location = new System.Drawing.Point(12, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 342);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách";
            // 
            // gridControlListReceipts
            // 
            this.gridControlListReceipts.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlListReceipts.DataSource = this.bindingSource1;
            this.gridControlListReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlListReceipts.Location = new System.Drawing.Point(2, 20);
            this.gridControlListReceipts.MainView = this.gridView1;
            this.gridControlListReceipts.Name = "gridControlListReceipts";
            this.gridControlListReceipts.Size = new System.Drawing.Size(636, 320);
            this.gridControlListReceipts.TabIndex = 0;
            this.gridControlListReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DTO.PHIEUBANHANG);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoPhieuBH,
            this.colMaNV,
            this.colMaKH,
            this.colNgayBan,
            this.colNgayTra,
            this.colTongTien,
            this.colCTPBHs,
            this.colKHACHHANG,
            this.colNHANVIEN,
            this.colPHIEUTHUTIENNOes});
            this.gridView1.GridControl = this.gridControlListReceipts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colSoPhieuBH
            // 
            this.colSoPhieuBH.FieldName = "SoPhieuBH";
            this.colSoPhieuBH.Name = "colSoPhieuBH";
            this.colSoPhieuBH.Visible = true;
            this.colSoPhieuBH.VisibleIndex = 0;
            this.colSoPhieuBH.Width = 86;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 1;
            this.colMaNV.Width = 86;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 2;
            this.colMaKH.Width = 86;
            // 
            // colNgayBan
            // 
            this.colNgayBan.FieldName = "NgayBan";
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.Visible = true;
            this.colNgayBan.VisibleIndex = 3;
            this.colNgayBan.Width = 86;
            // 
            // colNgayTra
            // 
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 4;
            this.colNgayTra.Width = 86;
            // 
            // colTongTien
            // 
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 5;
            this.colTongTien.Width = 117;
            // 
            // colCTPBHs
            // 
            this.colCTPBHs.FieldName = "CTPBHs";
            this.colCTPBHs.Name = "colCTPBHs";
            this.colCTPBHs.Width = 78;
            // 
            // colKHACHHANG
            // 
            this.colKHACHHANG.FieldName = "KHACHHANG";
            this.colKHACHHANG.Name = "colKHACHHANG";
            this.colKHACHHANG.Width = 78;
            // 
            // colNHANVIEN
            // 
            this.colNHANVIEN.FieldName = "NHANVIEN";
            this.colNHANVIEN.Name = "colNHANVIEN";
            this.colNHANVIEN.Width = 78;
            // 
            // colPHIEUTHUTIENNOes
            // 
            this.colPHIEUTHUTIENNOes.FieldName = "PHIEUTHUTIENNOes";
            this.colPHIEUTHUTIENNOes.Name = "colPHIEUTHUTIENNOes";
            this.colPHIEUTHUTIENNOes.Width = 82;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(313, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Danh sách phiếu bán hàng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(567, 395);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 34);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(476, 395);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 34);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DanhSachPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "DanhSachPhieuBanHang";
            this.Text = "DanhSachPhieuBanHang";
            this.Load += new System.EventHandler(this.DanhSachPhieuBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListReceipts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlListReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieuBH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colCTPBHs;
        private DevExpress.XtraGrid.Columns.GridColumn colKHACHHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEUTHUTIENNOes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}