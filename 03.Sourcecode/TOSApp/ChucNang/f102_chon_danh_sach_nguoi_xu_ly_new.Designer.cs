namespace TOSApp.ChucNang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f102_chon_danh_sach_nguoi_xu_ly_new));
            this.ImageList = new System.Windows.Forms.ImageList();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_oke = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_grc_ht_nguoi_su_dung = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ht_nguoi_su_dung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HO_VA_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NGUOI_SU_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).BeginInit();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_oke);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 271);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(787, 36);
            this.m_pnl_out_place_dm.TabIndex = 4;
            // 
            // m_cmd_oke
            // 
            this.m_cmd_oke.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_oke.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_oke.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_oke.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_oke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_oke.ImageIndex = 13;
            this.m_cmd_oke.ImageList = this.ImageList;
            this.m_cmd_oke.Location = new System.Drawing.Point(634, 4);
            this.m_cmd_oke.Name = "m_cmd_oke";
            this.m_cmd_oke.Size = new System.Drawing.Size(61, 28);
            this.m_cmd_oke.TabIndex = 2;
            this.m_cmd_oke.Text = "OKE";
            this.m_cmd_oke.Click += new System.EventHandler(this.m_cmd_oke_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(695, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 4;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.m_grc_ht_nguoi_su_dung);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(787, 307);
            this.GroupControl1.TabIndex = 5;
            this.GroupControl1.Text = "Danh sách người xử lý";
            // 
            // m_grc_ht_nguoi_su_dung
            // 
            this.m_grc_ht_nguoi_su_dung.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ht_nguoi_su_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ht_nguoi_su_dung.Location = new System.Drawing.Point(2, 21);
            this.m_grc_ht_nguoi_su_dung.MainView = this.m_grv_ht_nguoi_su_dung;
            this.m_grc_ht_nguoi_su_dung.Name = "m_grc_ht_nguoi_su_dung";
            this.m_grc_ht_nguoi_su_dung.Size = new System.Drawing.Size(783, 284);
            this.m_grc_ht_nguoi_su_dung.TabIndex = 0;
            this.m_grc_ht_nguoi_su_dung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ht_nguoi_su_dung});
            // 
            // m_grv_ht_nguoi_su_dung
            // 
            this.m_grv_ht_nguoi_su_dung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HO_VA_TEN,
            this.ID,
            this.ID_NGUOI_SU_DUNG});
            this.m_grv_ht_nguoi_su_dung.GridControl = this.m_grc_ht_nguoi_su_dung;
            this.m_grv_ht_nguoi_su_dung.Name = "m_grv_ht_nguoi_su_dung";
            this.m_grv_ht_nguoi_su_dung.OptionsSelection.MultiSelect = true;
            this.m_grv_ht_nguoi_su_dung.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // HO_VA_TEN
            // 
            this.HO_VA_TEN.Caption = "HỌ VÀ TÊN";
            this.HO_VA_TEN.FieldName = "TEN";
            this.HO_VA_TEN.Name = "HO_VA_TEN";
            this.HO_VA_TEN.Visible = true;
            this.HO_VA_TEN.VisibleIndex = 3;
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
            // f102_chon_danh_sach_nguoi_xu_ly_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 307);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.GroupControl1);
            this.Name = "f102_chon_danh_sach_nguoi_xu_ly_new";
            this.Text = "f102_chon_danh_sach_nguoi_xu_ly_new";
//            this.Load += new System.EventHandler(this.f102_chon_danh_sach_nguoi_xu_ly_new_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_oke;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraGrid.GridControl m_grc_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Columns.GridColumn HO_VA_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NGUOI_SU_DUNG;
    }
}