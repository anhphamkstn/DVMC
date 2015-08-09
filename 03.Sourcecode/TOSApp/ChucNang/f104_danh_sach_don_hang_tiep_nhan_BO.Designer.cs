namespace TOSApp.ChucNang
{
    partial class f104_danh_sach_don_hang_tiep_nhan_BO
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_xac_nhan_don_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_TAO_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DICH_VU_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_bao_cao_hoan_thanh = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cap_nhat_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tu_choi_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xac_nhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_cmd_xac_nhan_don_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_don_hang_tiep_nhan_BO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_xac_nhan_don_hang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(792, 465);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_xac_nhan_don_hang
            // 
            this.m_cmd_xac_nhan_don_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_cmd_xac_nhan_don_hang.Location = new System.Drawing.Point(2, 2);
            this.m_cmd_xac_nhan_don_hang.MainView = this.m_grv_danh_sach_don_hang_tiep_nhan_BO;
            this.m_cmd_xac_nhan_don_hang.Name = "m_cmd_xac_nhan_don_hang";
            this.m_cmd_xac_nhan_don_hang.Size = new System.Drawing.Size(788, 314);
            this.m_cmd_xac_nhan_don_hang.TabIndex = 0;
            this.m_cmd_xac_nhan_don_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO});
            // 
            // m_grv_danh_sach_don_hang_tiep_nhan_BO
            // 
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_GD_DAT_HANG,
            this.NGUOI_TAO_THAO_TAC,
            this.NGUOI_DAT_HANG,
            this.DICH_VU_YEU_CAU,
            this.NOI_DUNG_DAT_HANG,
            this.THOI_GIAN_DAT_HANG,
            this.THOI_GIAN_CAN_HOAN_THANH});
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.GridControl = this.m_cmd_xac_nhan_don_hang;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Name = "m_grv_danh_sach_don_hang_tiep_nhan_BO";
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GIAO DỊCH ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 0;
            // 
            // NGUOI_TAO_THAO_TAC
            // 
            this.NGUOI_TAO_THAO_TAC.Caption = "NGƯỜI TẠO THAO TÁC";
            this.NGUOI_TAO_THAO_TAC.FieldName = "TEN_TRUY_CAP";
            this.NGUOI_TAO_THAO_TAC.Name = "NGUOI_TAO_THAO_TAC";
            this.NGUOI_TAO_THAO_TAC.Visible = true;
            this.NGUOI_TAO_THAO_TAC.VisibleIndex = 1;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.NGUOI_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 2;
            // 
            // DICH_VU_YEU_CAU
            // 
            this.DICH_VU_YEU_CAU.Caption = "DỊCH VỤ YÊU CẦU";
            this.DICH_VU_YEU_CAU.FieldName = "DICH_VU_YEU_CAU";
            this.DICH_VU_YEU_CAU.Name = "DICH_VU_YEU_CAU";
            this.DICH_VU_YEU_CAU.Visible = true;
            this.DICH_VU_YEU_CAU.VisibleIndex = 3;
            // 
            // NOI_DUNG_DAT_HANG
            // 
            this.NOI_DUNG_DAT_HANG.Caption = "NỘI DUNG";
            this.NOI_DUNG_DAT_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Name = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Visible = true;
            this.NOI_DUNG_DAT_HANG.VisibleIndex = 4;
            // 
            // THOI_GIAN_DAT_HANG
            // 
            this.THOI_GIAN_DAT_HANG.Caption = "THỜI GIAN ĐẶT HÀNG";
            this.THOI_GIAN_DAT_HANG.FieldName = "THOI_GIAN_DAT_HANG";
            this.THOI_GIAN_DAT_HANG.Name = "THOI_GIAN_DAT_HANG";
            this.THOI_GIAN_DAT_HANG.Visible = true;
            this.THOI_GIAN_DAT_HANG.VisibleIndex = 5;
            // 
            // THOI_GIAN_CAN_HOAN_THANH
            // 
            this.THOI_GIAN_CAN_HOAN_THANH.Caption = "THỜI GIAN CẦN HOÀN THÀNH";
            this.THOI_GIAN_CAN_HOAN_THANH.FieldName = "THOI_GIAN_CAN_HOAN_THANH";
            this.THOI_GIAN_CAN_HOAN_THANH.Name = "THOI_GIAN_CAN_HOAN_THANH";
            this.THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            this.THOI_GIAN_CAN_HOAN_THANH.VisibleIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_cmd_bao_cao_hoan_thanh);
            this.panelControl2.Controls.Add(this.m_cmd_thoat);
            this.panelControl2.Controls.Add(this.m_cmd_cap_nhat_don_hang);
            this.panelControl2.Controls.Add(this.m_cmd_tu_choi_don_hang);
            this.panelControl2.Controls.Add(this.m_cmd_xac_nhan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 410);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(792, 55);
            this.panelControl2.TabIndex = 0;
            // 
            // m_cmd_bao_cao_hoan_thanh
            // 
            this.m_cmd_bao_cao_hoan_thanh.Location = new System.Drawing.Point(110, 13);
            this.m_cmd_bao_cao_hoan_thanh.Name = "m_cmd_bao_cao_hoan_thanh";
            this.m_cmd_bao_cao_hoan_thanh.Size = new System.Drawing.Size(177, 31);
            this.m_cmd_bao_cao_hoan_thanh.TabIndex = 1;
            this.m_cmd_bao_cao_hoan_thanh.Text = "Báo cáo hoàn thành đơn hàng";
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(692, 13);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 31);
            this.m_cmd_thoat.TabIndex = 0;
            this.m_cmd_thoat.Text = "Thoát(ESC)";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // m_cmd_cap_nhat_don_hang
            // 
            this.m_cmd_cap_nhat_don_hang.Location = new System.Drawing.Point(568, 13);
            this.m_cmd_cap_nhat_don_hang.Name = "m_cmd_cap_nhat_don_hang";
            this.m_cmd_cap_nhat_don_hang.Size = new System.Drawing.Size(108, 31);
            this.m_cmd_cap_nhat_don_hang.TabIndex = 0;
            this.m_cmd_cap_nhat_don_hang.Text = "Cập nhật đơn hàng";
            this.m_cmd_cap_nhat_don_hang.Click += new System.EventHandler(this.m_cmd_cap_nhat_don_hang_Click);
            // 
            // m_cmd_tu_choi_don_hang
            // 
            this.m_cmd_tu_choi_don_hang.Location = new System.Drawing.Point(445, 13);
            this.m_cmd_tu_choi_don_hang.Name = "m_cmd_tu_choi_don_hang";
            this.m_cmd_tu_choi_don_hang.Size = new System.Drawing.Size(108, 31);
            this.m_cmd_tu_choi_don_hang.TabIndex = 0;
            this.m_cmd_tu_choi_don_hang.Text = "Từ chối đơn hàng";
            this.m_cmd_tu_choi_don_hang.Click += new System.EventHandler(this.m_cmd_tu_choi_don_hang_Click);
            // 
            // m_cmd_xac_nhan
            // 
            this.m_cmd_xac_nhan.Location = new System.Drawing.Point(315, 13);
            this.m_cmd_xac_nhan.Name = "m_cmd_xac_nhan";
            this.m_cmd_xac_nhan.Size = new System.Drawing.Size(108, 31);
            this.m_cmd_xac_nhan.TabIndex = 0;
            this.m_cmd_xac_nhan.Text = "Xác nhận đơn hàng";
            this.m_cmd_xac_nhan.Click += new System.EventHandler(this.m_cmd_xac_nhan_Click);
            // 
            // f104_danh_sach_don_hang_tiep_nhan_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "f104_danh_sach_don_hang_tiep_nhan_BO";
            this.Text = "f104_danh_sach_don_hang_tiep_nhan_BO";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_cmd_xac_nhan_don_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_don_hang_tiep_nhan_BO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl m_cmd_xac_nhan_don_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_danh_sach_don_hang_tiep_nhan_BO;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cap_nhat_don_hang;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tu_choi_don_hang;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xac_nhan;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_TAO_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn DICH_VU_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_CAN_HOAN_THANH;
        private DevExpress.XtraEditors.SimpleButton m_cmd_bao_cao_hoan_thanh;
    }
}