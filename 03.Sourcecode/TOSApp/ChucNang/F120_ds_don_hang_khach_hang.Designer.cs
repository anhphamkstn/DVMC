namespace TOSApp.ChucNang
{
    partial class F120_ds_don_hang_khach_hang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ds_don_hang_nguoi_xu_ly = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_hang_nguoi_xu_ly = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN_USER_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEN_THOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANG_THAI_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_XU_LY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_nguoi_xu_ly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_nguoi_xu_ly)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 65);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_don_hang_nguoi_xu_ly);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 226);
            this.panel1.TabIndex = 1;
            // 
            // m_grc_ds_don_hang_nguoi_xu_ly
            // 
            this.m_grc_ds_don_hang_nguoi_xu_ly.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_hang_nguoi_xu_ly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_hang_nguoi_xu_ly.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_hang_nguoi_xu_ly.MainView = this.m_grv_ds_don_hang_nguoi_xu_ly;
            this.m_grc_ds_don_hang_nguoi_xu_ly.Name = "m_grc_ds_don_hang_nguoi_xu_ly";
            this.m_grc_ds_don_hang_nguoi_xu_ly.Size = new System.Drawing.Size(913, 226);
            this.m_grc_ds_don_hang_nguoi_xu_ly.TabIndex = 0;
            this.m_grc_ds_don_hang_nguoi_xu_ly.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_hang_nguoi_xu_ly});
            // 
            // m_grv_ds_don_hang_nguoi_xu_ly
            // 
            this.m_grv_ds_don_hang_nguoi_xu_ly.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DON_HANG,
            this.HO_TEN_USER_DAT_HANG,
            this.MA_DON_VI,
            this.DIEN_THOAI,
            this.TEN_YEU_CAU,
            this.NOI_DUNG_DAT_HANG,
            this.TRANG_THAI_DON_HANG,
            this.NGUOI_XU_LY,
            this.GHI_CHU});
            this.m_grv_ds_don_hang_nguoi_xu_ly.GridControl = this.m_grc_ds_don_hang_nguoi_xu_ly;
            this.m_grv_ds_don_hang_nguoi_xu_ly.GroupCount = 2;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Name = "m_grv_ds_don_hang_nguoi_xu_ly";
            this.m_grv_ds_don_hang_nguoi_xu_ly.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DIEN_THOAI, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.HO_TEN_USER_DAT_HANG, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "MÃ ĐƠN HÀNG";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 0;
            // 
            // HO_TEN_USER_DAT_HANG
            // 
            this.HO_TEN_USER_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.HO_TEN_USER_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.HO_TEN_USER_DAT_HANG.Name = "HO_TEN_USER_DAT_HANG";
            this.HO_TEN_USER_DAT_HANG.Visible = true;
            this.HO_TEN_USER_DAT_HANG.VisibleIndex = 1;
            // 
            // MA_DON_VI
            // 
            this.MA_DON_VI.Caption = "MÃ ĐƠN VỊ";
            this.MA_DON_VI.FieldName = "MA_DON_VI";
            this.MA_DON_VI.Name = "MA_DON_VI";
            this.MA_DON_VI.Visible = true;
            this.MA_DON_VI.VisibleIndex = 1;
            // 
            // DIEN_THOAI
            // 
            this.DIEN_THOAI.Caption = "ĐIỆN THOẠI";
            this.DIEN_THOAI.FieldName = "DIEN_THOAI";
            this.DIEN_THOAI.Name = "DIEN_THOAI";
            this.DIEN_THOAI.Visible = true;
            this.DIEN_THOAI.VisibleIndex = 3;
            // 
            // TEN_YEU_CAU
            // 
            this.TEN_YEU_CAU.Caption = "TÊN YÊU CẦU";
            this.TEN_YEU_CAU.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
            this.TEN_YEU_CAU.Name = "TEN_YEU_CAU";
            this.TEN_YEU_CAU.Visible = true;
            this.TEN_YEU_CAU.VisibleIndex = 2;
            // 
            // NOI_DUNG_DAT_HANG
            // 
            this.NOI_DUNG_DAT_HANG.Caption = "NỘI DUNG ĐẶT HÀNG";
            this.NOI_DUNG_DAT_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Name = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Visible = true;
            this.NOI_DUNG_DAT_HANG.VisibleIndex = 3;
            // 
            // TRANG_THAI_DON_HANG
            // 
            this.TRANG_THAI_DON_HANG.Caption = "TRẠNG THÁI ĐƠN HÀNG";
            this.TRANG_THAI_DON_HANG.FieldName = "TEN_LOAI_THAO_TAC_LOG";
            this.TRANG_THAI_DON_HANG.Name = "TRANG_THAI_DON_HANG";
            this.TRANG_THAI_DON_HANG.Visible = true;
            this.TRANG_THAI_DON_HANG.VisibleIndex = 4;
            // 
            // NGUOI_XU_LY
            // 
            this.NGUOI_XU_LY.Caption = "NGƯỜI XỬ LÝ";
            this.NGUOI_XU_LY.FieldName = "TEN_NGUOI_TAO_THAO_TAC_LOG";
            this.NGUOI_XU_LY.Name = "NGUOI_XU_LY";
            this.NGUOI_XU_LY.Visible = true;
            this.NGUOI_XU_LY.VisibleIndex = 5;
            // 
            // GHI_CHU
            // 
            this.GHI_CHU.Caption = "GHI CHÚ";
            this.GHI_CHU.FieldName = "GHI_CHU";
            this.GHI_CHU.Name = "GHI_CHU";
            this.GHI_CHU.Visible = true;
            this.GHI_CHU.VisibleIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "F120_TAT_CA_CAC_DON_HANG";
            // 
            // F120_ds_don_hang_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "F120_ds_don_hang_khach_hang";
            this.Text = "F120_ds_don_hang_khach_hang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_nguoi_xu_ly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_nguoi_xu_ly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_hang_nguoi_xu_ly;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_hang_nguoi_xu_ly;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN_USER_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn DIEN_THOAI;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANG_THAI_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_XU_LY;
        private DevExpress.XtraGrid.Columns.GridColumn GHI_CHU;
        private System.Windows.Forms.Label label1;
    }
}