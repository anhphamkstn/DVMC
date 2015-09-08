namespace TOSApp.ChucNang
{
    partial class f122_ds_don_hang_dang_xu_ly
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
            this.m_grc_ds_don_hang_dang_xu_ly = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_hang_dang_xu_ly = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_loai_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nhom_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_don_hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nguoi_xu_ly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nhan_vien_dat_hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_thoi_gian_tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_loai_thoi_gian_can_hoan_thanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_dang_xu_ly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_dang_xu_ly)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_ds_don_hang_dang_xu_ly
            // 
            this.m_grc_ds_don_hang_dang_xu_ly.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_hang_dang_xu_ly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_hang_dang_xu_ly.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_hang_dang_xu_ly.MainView = this.m_grv_ds_don_hang_dang_xu_ly;
            this.m_grc_ds_don_hang_dang_xu_ly.Name = "m_grc_ds_don_hang_dang_xu_ly";
            this.m_grc_ds_don_hang_dang_xu_ly.Size = new System.Drawing.Size(774, 202);
            this.m_grc_ds_don_hang_dang_xu_ly.TabIndex = 0;
            this.m_grc_ds_don_hang_dang_xu_ly.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_hang_dang_xu_ly});
            // 
            // m_grv_ds_don_hang_dang_xu_ly
            // 
            this.m_grv_ds_don_hang_dang_xu_ly.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_loai_dich_vu,
            this.c_nhom_dich_vu,
            this.c_dich_vu,
            this.c_ma_don_hang,
            this.c_nguoi_xu_ly,
            this.c_nhan_vien_dat_hang,
            this.c_thoi_gian_tao,
            this.c_loai_thoi_gian_can_hoan_thanh});
            this.m_grv_ds_don_hang_dang_xu_ly.GridControl = this.m_grc_ds_don_hang_dang_xu_ly;
            this.m_grv_ds_don_hang_dang_xu_ly.Name = "m_grv_ds_don_hang_dang_xu_ly";
            this.m_grv_ds_don_hang_dang_xu_ly.OptionsBehavior.Editable = false;
            // 
            // c_loai_dich_vu
            // 
            this.c_loai_dich_vu.Caption = "Loại dịch vụ";
            this.c_loai_dich_vu.FieldName = "TEN_YEU_CAU_CHA_CHA";
            this.c_loai_dich_vu.Name = "c_loai_dich_vu";
            this.c_loai_dich_vu.Visible = true;
            this.c_loai_dich_vu.VisibleIndex = 0;
            // 
            // c_nhom_dich_vu
            // 
            this.c_nhom_dich_vu.Caption = "Nhóm dịch vụ";
            this.c_nhom_dich_vu.FieldName = "TEN_YEU_CAU_CHA";
            this.c_nhom_dich_vu.Name = "c_nhom_dich_vu";
            this.c_nhom_dich_vu.Visible = true;
            this.c_nhom_dich_vu.VisibleIndex = 1;
            // 
            // c_dich_vu
            // 
            this.c_dich_vu.Caption = "Dịch vụ";
            this.c_dich_vu.FieldName = "TEN_YEU_CAU";
            this.c_dich_vu.Name = "c_dich_vu";
            this.c_dich_vu.Visible = true;
            this.c_dich_vu.VisibleIndex = 2;
            // 
            // c_ma_don_hang
            // 
            this.c_ma_don_hang.Caption = "Mã đơn hàng";
            this.c_ma_don_hang.FieldName = "MA_DON_HANG";
            this.c_ma_don_hang.Name = "c_ma_don_hang";
            this.c_ma_don_hang.Visible = true;
            this.c_ma_don_hang.VisibleIndex = 3;
            // 
            // c_nguoi_xu_ly
            // 
            this.c_nguoi_xu_ly.Caption = "Người xử lý";
            this.c_nguoi_xu_ly.FieldName = "TEN_NGUOI_TAO_THAO_TAC_LOG";
            this.c_nguoi_xu_ly.Name = "c_nguoi_xu_ly";
            this.c_nguoi_xu_ly.Visible = true;
            this.c_nguoi_xu_ly.VisibleIndex = 5;
            // 
            // c_nhan_vien_dat_hang
            // 
            this.c_nhan_vien_dat_hang.Caption = "Nhân viên đặt hàng";
            this.c_nhan_vien_dat_hang.FieldName = "HO_TEN_USER_DAT_HANG";
            this.c_nhan_vien_dat_hang.Name = "c_nhan_vien_dat_hang";
            this.c_nhan_vien_dat_hang.Visible = true;
            this.c_nhan_vien_dat_hang.VisibleIndex = 4;
            // 
            // c_thoi_gian_tao
            // 
            this.c_thoi_gian_tao.Caption = "Thời gian tạo";
            this.c_thoi_gian_tao.FieldName = "THOI_GIAN_TAO";
            this.c_thoi_gian_tao.Name = "c_thoi_gian_tao";
            this.c_thoi_gian_tao.Visible = true;
            this.c_thoi_gian_tao.VisibleIndex = 6;
            // 
            // c_loai_thoi_gian_can_hoan_thanh
            // 
            this.c_loai_thoi_gian_can_hoan_thanh.Caption = "Thời gian hoàn thành";
            this.c_loai_thoi_gian_can_hoan_thanh.FieldName = "LOAI_THOI_GIAN_CAN_HOAN_THANH";
            this.c_loai_thoi_gian_can_hoan_thanh.Name = "c_loai_thoi_gian_can_hoan_thanh";
            this.c_loai_thoi_gian_can_hoan_thanh.Visible = true;
            this.c_loai_thoi_gian_can_hoan_thanh.VisibleIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 59);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_don_hang_dang_xu_ly);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 202);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tất cả đơn hàng đang được xử lý";
            // 
            // f122_ds_don_hang_dang_xu_ly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f122_ds_don_hang_dang_xu_ly";
            this.Text = "f122_Tất cả đơn hàng đang xử lý";
            this.Load += new System.EventHandler(this.f122_ds_don_hang_dang_xu_ly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_dang_xu_ly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_dang_xu_ly)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_ds_don_hang_dang_xu_ly;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_hang_dang_xu_ly;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_nhom_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_don_hang;
        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_xu_ly;
        private DevExpress.XtraGrid.Columns.GridColumn c_nhan_vien_dat_hang;
        private DevExpress.XtraGrid.Columns.GridColumn c_thoi_gian_tao;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_thoi_gian_can_hoan_thanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}