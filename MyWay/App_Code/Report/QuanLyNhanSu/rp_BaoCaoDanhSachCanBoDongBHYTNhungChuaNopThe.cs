﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DataController;

/// <summary>
/// Summary description for rp_BaoCaoDanhSachCanBoChuaCoSoBHYT
/// </summary>
public class rp_BaoCaoDanhSachCanBoDongBHYTNhungChuaNopThe : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrtstt;
    private XRTableCell xrtmanhanvien;
    private XRTableCell xrthoten;
    private XRTableCell xrt_ngaysinh;
    private XRTableCell xrtgioitinh;
    private XRTableCell xrtdiachi;
    private XRTableCell xrtdienthoai;
    private XRTableCell xrtngayvaocongty;
    private XRTableCell xrtchucvu;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrl_TitleBC;
    private XRLabel xrl_TenThanhPho;
    private XRLabel xrl_TenCongTy;
    private PageHeaderBand PageHeader;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell15;
    private ReportFooterBand ReportFooter;
    private XRLabel xrl_ten1;
    private XRLabel xrl_ten2;
    private XRLabel xrl_ten3;
    private XRLabel xrtngayketxuat;
    private XRLabel xrl_footer1;
    private XRLabel xrl_footer3;
    private XRLabel xrl_footer2;
    private GroupHeaderBand GroupHeader1;
    private PageFooterBand PageFooter;
    private XRPageInfo xrPageInfo1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    /// <summary>
    /// Nguyễn Văn Khởi
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rp_BaoCaoDanhSachCanBoDongBHYTNhungChuaNopThe()
    {
        InitializeComponent();
    }
    int STT = 1;
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrtstt.Text = STT.ToString();
        STT++;
    }
    public void BindData(ReportFilter filter)
    {
        try
        {
            ReportController rpCtr = new ReportController();
            xrtngayketxuat.Text = rpCtr.GetFooterReport(filter.SessionDepartment, filter.ReportedDate);
            xrl_TenCongTy.Text = rpCtr.GetCompanyName(filter.SessionDepartment);
            xrl_TenThanhPho.Text = rpCtr.GetCityName(filter.SessionDepartment);
            DataTable table = DataHandler.GetInstance().ExecuteDataTable("rp_htc_NhanSu_DanhSachCanBoDongBHYTNhungChuaNopThe", "@MaDonVi", "@WhereClause", filter.SelectedDepartment, filter.WhereClause);
            DataSource = table;
            xrtmanhanvien.DataBindings.Add("Text", DataSource, "MA_CB");
            xrthoten.DataBindings.Add("Text", DataSource, "HO_TEN");
            xrt_ngaysinh.DataBindings.Add("Text", DataSource, "NGAY_SINH", "{0:dd/MM/yyyy}");
            xrtgioitinh.DataBindings.Add("Text", DataSource, "GioiTinh");
            xrtdiachi.DataBindings.Add("Text", DataSource, "DIA_CHI_LH");
            xrtdienthoai.DataBindings.Add("Text", DataSource, "DI_DONG");
            xrtngayvaocongty.DataBindings.Add("Text", DataSource, "NGAY_TUYEN_CHINHTHUC", "{0:dd/MM/yyyy}");
            xrtchucvu.DataBindings.Add("Text", DataSource, "TEN_CHUCVU");
            xrTableCell11.DataBindings.Add("Text", DataSource, "SoTheBHYT");
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("MA_DONVI", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            xrTableCell9.DataBindings.Add("Text", DataSource, "TEN_DONVI").ToString().ToUpper();
            if (!string.IsNullOrEmpty(filter.ReportTitle))
            {
                xrl_TitleBC.Text = filter.ReportTitle;
            }
            if (!string.IsNullOrEmpty(filter.Name1))
            {
                xrl_ten1.Text = filter.Name1;
            }
            else
            {
                xrl_ten1.Text = rpCtr.GetCreatedReporterName(filter.SessionDepartment, filter.Reporter);
            }
            xrl_ten2.Text = rpCtr.GetHeadOfHRroom(filter.SessionDepartment, filter.Name2);
            xrl_ten3.Text = rpCtr.GetDirectorName(filter.SessionDepartment, filter.Name3);
            if (!string.IsNullOrEmpty(filter.Title1))
            {
                xrl_footer1.Text = filter.Title1;
            }
            if (!string.IsNullOrEmpty(filter.Title2))
            {
                xrl_footer2.Text = filter.Title2;
            }
            if (!string.IsNullOrEmpty(filter.Title3))
            {
                xrl_footer3.Text = filter.Title3;
            }
        }
        catch (Exception ex)
        {
            ExtMessage.Dialog.Alert("Có lỗi xảy ra: " + ex.Message);
        }

    }
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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "rp_BaoCaoDanhSachCanBoDongBHYTNhungChuaNopThe.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtstt = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtmanhanvien = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrthoten = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_ngaysinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtgioitinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtdiachi = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtdienthoai = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtngayvaocongty = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtchucvu = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrl_TitleBC = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_TenThanhPho = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_TenCongTy = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrl_ten1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_ten2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_ten3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrtngayketxuat = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_footer1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_footer3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_footer2 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25.41666F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1155F, 25.41666F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UsePadding = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtstt,
            this.xrtmanhanvien,
            this.xrthoten,
            this.xrt_ngaysinh,
            this.xrtgioitinh,
            this.xrtdiachi,
            this.xrtdienthoai,
            this.xrtngayvaocongty,
            this.xrtchucvu,
            this.xrTableCell11});
            this.xrTableRow2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseFont = false;
            this.xrTableRow2.StylePriority.UseTextAlignment = false;
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow2.Weight = 1D;
            // 
            // xrtstt
            // 
            this.xrtstt.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtstt.Name = "xrtstt";
            this.xrtstt.StylePriority.UseFont = false;
            this.xrtstt.StylePriority.UseTextAlignment = false;
            this.xrtstt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtstt.Weight = 0.35416665980020634D;
            // 
            // xrtmanhanvien
            // 
            this.xrtmanhanvien.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtmanhanvien.Name = "xrtmanhanvien";
            this.xrtmanhanvien.StylePriority.UseFont = false;
            this.xrtmanhanvien.StylePriority.UseTextAlignment = false;
            this.xrtmanhanvien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtmanhanvien.Weight = 0.75000018386839962D;
            // 
            // xrthoten
            // 
            this.xrthoten.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrthoten.Name = "xrthoten";
            this.xrthoten.StylePriority.UseFont = false;
            this.xrthoten.StylePriority.UseTextAlignment = false;
            this.xrthoten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrthoten.Weight = 1.3333235636586465D;
            // 
            // xrt_ngaysinh
            // 
            this.xrt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_ngaysinh.Name = "xrt_ngaysinh";
            this.xrt_ngaysinh.StylePriority.UseFont = false;
            this.xrt_ngaysinh.StylePriority.UseTextAlignment = false;
            this.xrt_ngaysinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrt_ngaysinh.Weight = 0.83855090915021291D;
            // 
            // xrtgioitinh
            // 
            this.xrtgioitinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtgioitinh.Name = "xrtgioitinh";
            this.xrtgioitinh.StylePriority.UseFont = false;
            this.xrtgioitinh.StylePriority.UseTextAlignment = false;
            this.xrtgioitinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtgioitinh.Weight = 0.63802091000874361D;
            // 
            // xrtdiachi
            // 
            this.xrtdiachi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtdiachi.Name = "xrtdiachi";
            this.xrtdiachi.StylePriority.UseFont = false;
            this.xrtdiachi.StylePriority.UseTextAlignment = false;
            this.xrtdiachi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtdiachi.Weight = 1.99609264030604D;
            // 
            // xrtdienthoai
            // 
            this.xrtdienthoai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtdienthoai.Name = "xrtdienthoai";
            this.xrtdienthoai.StylePriority.UseFont = false;
            this.xrtdienthoai.StylePriority.UseTextAlignment = false;
            this.xrtdienthoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtdienthoai.Weight = 1.0397113824010129D;
            // 
            // xrtngayvaocongty
            // 
            this.xrtngayvaocongty.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtngayvaocongty.Name = "xrtngayvaocongty";
            this.xrtngayvaocongty.StylePriority.UseFont = false;
            this.xrtngayvaocongty.StylePriority.UseTextAlignment = false;
            this.xrtngayvaocongty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtngayvaocongty.Weight = 1.1761104498251884D;
            // 
            // xrtchucvu
            // 
            this.xrtchucvu.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrtchucvu.Name = "xrtchucvu";
            this.xrtchucvu.StylePriority.UseFont = false;
            this.xrtchucvu.StylePriority.UseTextAlignment = false;
            this.xrtchucvu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtchucvu.Weight = 1.8161808732126783D;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1155F, 25.41666F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UsePadding = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9});
            this.xrTableRow3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.StylePriority.UseFont = false;
            this.xrTableRow3.StylePriority.UseTextAlignment = false;
            this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 3, 3, 3, 100F);
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 10.829994588379142D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 48F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_TitleBC,
            this.xrl_TenThanhPho,
            this.xrl_TenCongTy});
            this.ReportHeader.HeightF = 96F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrl_TitleBC
            // 
            this.xrl_TitleBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrl_TitleBC.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 67.08333F);
            this.xrl_TitleBC.Name = "xrl_TitleBC";
            this.xrl_TitleBC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_TitleBC.SizeF = new System.Drawing.SizeF(1155F, 23F);
            this.xrl_TitleBC.StylePriority.UseFont = false;
            this.xrl_TitleBC.StylePriority.UseTextAlignment = false;
            this.xrl_TitleBC.Text = "BÁO CÁO DANH SÁCH CÁN BỘ ĐANG ĐÓNG BHYT NHƯNG CHƯA NỘP THẺ";
            this.xrl_TitleBC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_TenThanhPho
            // 
            this.xrl_TenThanhPho.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrl_TenThanhPho.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrl_TenThanhPho.Name = "xrl_TenThanhPho";
            this.xrl_TenThanhPho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_TenThanhPho.SizeF = new System.Drawing.SizeF(451.0416F, 23F);
            this.xrl_TenThanhPho.StylePriority.UseFont = false;
            this.xrl_TenThanhPho.StylePriority.UseTextAlignment = false;
            this.xrl_TenThanhPho.Text = "THÀNH PHỐ HÀ NỘI";
            this.xrl_TenThanhPho.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrl_TenCongTy
            // 
            this.xrl_TenCongTy.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_TenCongTy.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.xrl_TenCongTy.Name = "xrl_TenCongTy";
            this.xrl_TenCongTy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_TenCongTy.SizeF = new System.Drawing.SizeF(451.0417F, 23F);
            this.xrl_TenCongTy.StylePriority.UseFont = false;
            this.xrl_TenCongTy.StylePriority.UseTextAlignment = false;
            this.xrl_TenCongTy.Text = "HANOI TELECOM";
            this.xrl_TenCongTy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 38.49998F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1155F, 38.49998F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell15,
            this.xrTableCell10});
            this.xrTableRow1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseFont = false;
            this.xrTableRow1.StylePriority.UseTextAlignment = false;
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "STT";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.35416665980020634D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Mã nhân viên";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.75000018386839962D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Họ tên";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 1.3333326202163578D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Ngày sinh";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.83854185259250169D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Giới tính";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.63802091000874361D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Địa chỉ";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 1.9960942659377745D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Điện thoại";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 1.039712475172728D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Ngày vào công ty";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 1.1761077314217387D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "Chức vụ";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell15.Weight = 1.8161752721786757D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_ten1,
            this.xrl_ten2,
            this.xrl_ten3,
            this.xrtngayketxuat,
            this.xrl_footer1,
            this.xrl_footer3,
            this.xrl_footer2});
            this.ReportFooter.HeightF = 159.0416F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrl_ten1
            // 
            this.xrl_ten1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrl_ten1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 136.0416F);
            this.xrl_ten1.Name = "xrl_ten1";
            this.xrl_ten1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ten1.SizeF = new System.Drawing.SizeF(302.1819F, 23F);
            this.xrl_ten1.StylePriority.UseFont = false;
            this.xrl_ten1.StylePriority.UseTextAlignment = false;
            this.xrl_ten1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_ten2
            // 
            this.xrl_ten2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrl_ten2.LocationFloat = new DevExpress.Utils.PointFloat(373.9583F, 136.0416F);
            this.xrl_ten2.Name = "xrl_ten2";
            this.xrl_ten2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ten2.SizeF = new System.Drawing.SizeF(302.1819F, 23F);
            this.xrl_ten2.StylePriority.UseFont = false;
            this.xrl_ten2.StylePriority.UseTextAlignment = false;
            this.xrl_ten2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_ten3
            // 
            this.xrl_ten3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrl_ten3.LocationFloat = new DevExpress.Utils.PointFloat(811.5565F, 136.0416F);
            this.xrl_ten3.Name = "xrl_ten3";
            this.xrl_ten3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ten3.SizeF = new System.Drawing.SizeF(294.4176F, 23F);
            this.xrl_ten3.StylePriority.UseFont = false;
            this.xrl_ten3.StylePriority.UseTextAlignment = false;
            this.xrl_ten3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrtngayketxuat
            // 
            this.xrtngayketxuat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.xrtngayketxuat.LocationFloat = new DevExpress.Utils.PointFloat(789.6815F, 10.00001F);
            this.xrtngayketxuat.Name = "xrtngayketxuat";
            this.xrtngayketxuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrtngayketxuat.SizeF = new System.Drawing.SizeF(334.0406F, 23F);
            this.xrtngayketxuat.StylePriority.UseFont = false;
            this.xrtngayketxuat.StylePriority.UseTextAlignment = false;
            this.xrtngayketxuat.Text = "Hà Nội, ngày 15 tháng 4 năm 2013";
            this.xrtngayketxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_footer1
            // 
            this.xrl_footer1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_footer1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 35.00001F);
            this.xrl_footer1.Name = "xrl_footer1";
            this.xrl_footer1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_footer1.SizeF = new System.Drawing.SizeF(304.1828F, 23F);
            this.xrl_footer1.StylePriority.UseFont = false;
            this.xrl_footer1.StylePriority.UseTextAlignment = false;
            this.xrl_footer1.Text = "NGƯỜI LẬP";
            this.xrl_footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_footer3
            // 
            this.xrl_footer3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_footer3.LocationFloat = new DevExpress.Utils.PointFloat(811.5565F, 35.00001F);
            this.xrl_footer3.Name = "xrl_footer3";
            this.xrl_footer3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_footer3.SizeF = new System.Drawing.SizeF(295.4991F, 23F);
            this.xrl_footer3.StylePriority.UseFont = false;
            this.xrl_footer3.StylePriority.UseTextAlignment = false;
            this.xrl_footer3.Text = "TỔNG GIÁM ĐỐC";
            this.xrl_footer3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_footer2
            // 
            this.xrl_footer2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_footer2.LocationFloat = new DevExpress.Utils.PointFloat(373.9583F, 35.00001F);
            this.xrl_footer2.Name = "xrl_footer2";
            this.xrl_footer2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_footer2.SizeF = new System.Drawing.SizeF(304.1828F, 23F);
            this.xrl_footer2.StylePriority.UseFont = false;
            this.xrl_footer2.StylePriority.UseTextAlignment = false;
            this.xrl_footer2.Text = "PHÒNG HCNS";
            this.xrl_footer2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.GroupHeader1.HeightF = 25.41666F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.PageFooter.HeightF = 47.91666F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrPageInfo1.Format = "Trang {0} của {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1028.958F, 24.91665F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(126.0417F, 23.00001F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Sổ thẻ BHYT";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 1.6078416470554104D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 1.6078458505364637D;
            // 
            // rp_BaoCaoDanhSachCanBoDongBHYTNhungChuaNopThe
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.GroupHeader1,
            this.PageFooter});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(7, 7, 50, 48);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
