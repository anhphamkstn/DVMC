namespace TOSApp
{
    partial class f999_main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f999_main_form));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m_cmd_FO_cong_viec = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_BO = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_PM = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_bao_cao_tiep_nhan = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_bao_cao_xu_ly = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_bao_cao_danh_gia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.m_cmd_FO_cong_viec,
            this.m_cmd_BO,
            this.m_cmd_PM,
            this.barButtonItem4,
            this.barButtonItem5,
            this.m_cmd_bao_cao_tiep_nhan,
            this.m_cmd_bao_cao_xu_ly,
            this.m_cmd_bao_cao_danh_gia,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1186, 163);
            // 
            // m_cmd_FO_cong_viec
            // 
            this.m_cmd_FO_cong_viec.Caption = "Đơn hàng cần xử lý";
            this.m_cmd_FO_cong_viec.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_FO_cong_viec.Glyph")));
            this.m_cmd_FO_cong_viec.Id = 1;
            this.m_cmd_FO_cong_viec.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_FO_cong_viec.LargeGlyph")));
            this.m_cmd_FO_cong_viec.Name = "m_cmd_FO_cong_viec";
            this.m_cmd_FO_cong_viec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_FO_cong_viec_ItemClick);
            // 
            // m_cmd_BO
            // 
            this.m_cmd_BO.Caption = "Công việc";
            this.m_cmd_BO.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_BO.Glyph")));
            this.m_cmd_BO.Id = 2;
            this.m_cmd_BO.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_BO.LargeGlyph")));
            this.m_cmd_BO.Name = "m_cmd_BO";
            this.m_cmd_BO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_BO_ItemClick);
            // 
            // m_cmd_PM
            // 
            this.m_cmd_PM.Caption = "Công việc";
            this.m_cmd_PM.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_PM.Glyph")));
            this.m_cmd_PM.Id = 3;
            this.m_cmd_PM.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_PM.LargeGlyph")));
            this.m_cmd_PM.Name = "m_cmd_PM";
            this.m_cmd_PM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_PM_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Điều phối đơn hàng";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Công việc";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // m_cmd_bao_cao_tiep_nhan
            // 
            this.m_cmd_bao_cao_tiep_nhan.Caption = "Báo cáo tiếp nhận";
            this.m_cmd_bao_cao_tiep_nhan.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_tiep_nhan.Glyph")));
            this.m_cmd_bao_cao_tiep_nhan.Id = 6;
            this.m_cmd_bao_cao_tiep_nhan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_tiep_nhan.LargeGlyph")));
            this.m_cmd_bao_cao_tiep_nhan.Name = "m_cmd_bao_cao_tiep_nhan";
            this.m_cmd_bao_cao_tiep_nhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_bao_cao_tiep_nhan_ItemClick);
            // 
            // m_cmd_bao_cao_xu_ly
            // 
            this.m_cmd_bao_cao_xu_ly.Caption = "Báo cáo xử lý";
            this.m_cmd_bao_cao_xu_ly.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_xu_ly.Glyph")));
            this.m_cmd_bao_cao_xu_ly.Id = 7;
            this.m_cmd_bao_cao_xu_ly.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_xu_ly.LargeGlyph")));
            this.m_cmd_bao_cao_xu_ly.Name = "m_cmd_bao_cao_xu_ly";
            this.m_cmd_bao_cao_xu_ly.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_bao_cao_xu_ly_ItemClick);
            // 
            // m_cmd_bao_cao_danh_gia
            // 
            this.m_cmd_bao_cao_danh_gia.Caption = "Báo cáo đánh giá";
            this.m_cmd_bao_cao_danh_gia.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_danh_gia.Glyph")));
            this.m_cmd_bao_cao_danh_gia.Id = 8;
            this.m_cmd_bao_cao_danh_gia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_danh_gia.LargeGlyph")));
            this.m_cmd_bao_cao_danh_gia.Name = "m_cmd_bao_cao_danh_gia";
            this.m_cmd_bao_cao_danh_gia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_bao_cao_danh_gia_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_FO_cong_viec);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nghiệp vụ";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.m_cmd_bao_cao_tiep_nhan);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Báo cáo tiếp nhận";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.m_cmd_bao_cao_xu_ly);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Báo cáo xử lý";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.m_cmd_bao_cao_danh_gia);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Báo cáo đánh giá";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đơn hàng đang xử lý";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // f999_main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 439);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "f999_main_form";
            this.Ribbon = this.ribbonControl1;
            this.Text = "f999_main_form";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem m_cmd_FO_cong_viec;
        private DevExpress.XtraBars.BarButtonItem m_cmd_BO;
        private DevExpress.XtraBars.BarButtonItem m_cmd_PM;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem m_cmd_bao_cao_tiep_nhan;
        private DevExpress.XtraBars.BarButtonItem m_cmd_bao_cao_xu_ly;
        private DevExpress.XtraBars.BarButtonItem m_cmd_bao_cao_danh_gia;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;

    }
}