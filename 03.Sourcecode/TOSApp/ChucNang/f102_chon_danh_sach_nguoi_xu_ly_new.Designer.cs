﻿namespace TOSApp.ChucNang
{
    partial class f102_chon_danh_sach_nguoi_xu_ly_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f102_chon_danh_sach_nguoi_xu_ly_new));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ht_nguoi_su_dung = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ht_nguoi_su_dung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HO_VA_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NGUOI_SU_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.m_sch = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.panel1);
            this.GroupControl1.Controls.Add(this.m_pnl_out_place_dm);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(238, 414);
            this.GroupControl1.TabIndex = 5;
            this.GroupControl1.Text = "Danh sách người xử lý";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ht_nguoi_su_dung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 351);
            this.panel1.TabIndex = 10;
            // 
            // m_grc_ht_nguoi_su_dung
            // 
            this.m_grc_ht_nguoi_su_dung.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ht_nguoi_su_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.m_grc_ht_nguoi_su_dung.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.m_grc_ht_nguoi_su_dung.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ht_nguoi_su_dung.MainView = this.m_grv_ht_nguoi_su_dung;
            this.m_grc_ht_nguoi_su_dung.Name = "m_grc_ht_nguoi_su_dung";
            this.m_grc_ht_nguoi_su_dung.Size = new System.Drawing.Size(234, 351);
            this.m_grc_ht_nguoi_su_dung.TabIndex = 8;
            this.m_grc_ht_nguoi_su_dung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ht_nguoi_su_dung});
            // 
            // m_grv_ht_nguoi_su_dung
            // 
            this.m_grv_ht_nguoi_su_dung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HO_VA_TEN});
            this.m_grv_ht_nguoi_su_dung.GridControl = this.m_grc_ht_nguoi_su_dung;
            this.m_grv_ht_nguoi_su_dung.Name = "m_grv_ht_nguoi_su_dung";
            this.m_grv_ht_nguoi_su_dung.OptionsBehavior.Editable = false;
            this.m_grv_ht_nguoi_su_dung.OptionsBehavior.ReadOnly = true;
            this.m_grv_ht_nguoi_su_dung.OptionsSelection.MultiSelect = true;
            this.m_grv_ht_nguoi_su_dung.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // HO_VA_TEN
            // 
            this.HO_VA_TEN.Caption = "HỌ VÀ TÊN";
            this.HO_VA_TEN.FieldName = "BO";
            this.HO_VA_TEN.Name = "HO_VA_TEN";
            this.HO_VA_TEN.Visible = true;
            this.HO_VA_TEN.VisibleIndex = 1;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.simpleButton2);
            this.m_pnl_out_place_dm.Controls.Add(this.simpleButton1);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(2, 372);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(234, 40);
            this.m_pnl_out_place_dm.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(38, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(102, 32);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Điều phối";
            this.simpleButton2.Click += new System.EventHandler(this.m_cmd_oke_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(140, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 32);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            // 
            // ID_NGUOI_SU_DUNG
            // 
            this.ID_NGUOI_SU_DUNG.Caption = "ID BM";
            this.ID_NGUOI_SU_DUNG.FieldName = "ID_NGUOI_SU_DUNG";
            this.ID_NGUOI_SU_DUNG.Name = "ID_NGUOI_SU_DUNG";
            this.ID_NGUOI_SU_DUNG.Visible = true;
            this.ID_NGUOI_SU_DUNG.VisibleIndex = 2;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("1d65b123-1904-47f3-a6b0-e9c624d10862");
            this.dockPanel1.Location = new System.Drawing.Point(238, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(649, 200);
            this.dockPanel1.Size = new System.Drawing.Size(649, 414);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.m_sch);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(641, 387);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // m_sch
            // 
            this.m_sch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_sch.Location = new System.Drawing.Point(0, 0);
            this.m_sch.Name = "m_sch";
            this.m_sch.Size = new System.Drawing.Size(641, 387);
            this.m_sch.Start = new System.DateTime(2015, 9, 10, 0, 0, 0, 0);
            this.m_sch.Storage = this.schedulerStorage1;
            this.m_sch.TabIndex = 0;
            this.m_sch.Text = "schedulerControl1";
            this.m_sch.Views.DayView.TimeRulers.Add(timeRuler1);
            this.m_sch.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // f102_chon_danh_sach_nguoi_xu_ly_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 414);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "f102_chon_danh_sach_nguoi_xu_ly_new";
            this.Text = "f102_Danh sách nhân viên xử lý";
            this.Load += new System.EventHandler(this.f102_chon_danh_sach_nguoi_xu_ly_new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_sch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraGrid.GridControl m_grc_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Columns.GridColumn HO_VA_TEN;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NGUOI_SU_DUNG;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraScheduler.SchedulerControl m_sch;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
    }
}