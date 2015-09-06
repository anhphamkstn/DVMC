namespace TOSApp.ChucNang
{
    partial class f106_danh_sach_don_hang_can_tiep_nhan_BO
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_tu_choi = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tiep_nhan = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ds_don_hang_can_tiep_nhan = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_hang_can_tiep_nhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_TAO_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_XU_LY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_can_tiep_nhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_can_tiep_nhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_tu_choi);
            this.panel2.Controls.Add(this.m_cmd_tiep_nhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 58);
            this.panel2.TabIndex = 0;
            // 
            // m_cmd_tu_choi
            // 
            this.m_cmd_tu_choi.Location = new System.Drawing.Point(542, 23);
            this.m_cmd_tu_choi.Name = "m_cmd_tu_choi";
            this.m_cmd_tu_choi.Size = new System.Drawing.Size(89, 23);
            this.m_cmd_tu_choi.TabIndex = 0;
            this.m_cmd_tu_choi.Text = "Từ chối";
            this.m_cmd_tu_choi.Click += new System.EventHandler(this.m_cmd_tu_choi_Click);
            // 
            // m_cmd_tiep_nhan
            // 
            this.m_cmd_tiep_nhan.Location = new System.Drawing.Point(413, 23);
            this.m_cmd_tiep_nhan.Name = "m_cmd_tiep_nhan";
            this.m_cmd_tiep_nhan.Size = new System.Drawing.Size(89, 23);
            this.m_cmd_tiep_nhan.TabIndex = 0;
            this.m_cmd_tiep_nhan.Text = "Tiếp nhận";
            this.m_cmd_tiep_nhan.Click += new System.EventHandler(this.m_cmd_tiep_nhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_don_hang_can_tiep_nhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 289);
            this.panel1.TabIndex = 1;
            // 
            // m_grc_ds_don_hang_can_tiep_nhan
            // 
            this.m_grc_ds_don_hang_can_tiep_nhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_hang_can_tiep_nhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_hang_can_tiep_nhan.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_hang_can_tiep_nhan.MainView = this.m_grv_ds_don_hang_can_tiep_nhan;
            this.m_grc_ds_don_hang_can_tiep_nhan.Name = "m_grc_ds_don_hang_can_tiep_nhan";
            this.m_grc_ds_don_hang_can_tiep_nhan.Size = new System.Drawing.Size(654, 289);
            this.m_grc_ds_don_hang_can_tiep_nhan.TabIndex = 0;
            this.m_grc_ds_don_hang_can_tiep_nhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_hang_can_tiep_nhan});
            // 
            // m_grv_ds_don_hang_can_tiep_nhan
            // 
            this.m_grv_ds_don_hang_can_tiep_nhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_GD_DAT_HANG,
            this.NGUOI_TAO_THAO_TAC,
            this.NGUOI_DAT_HANG,
            this.NOI_DUNG_DON_HANG,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.NGUOI_XU_LY});
            this.m_grv_ds_don_hang_can_tiep_nhan.GridControl = this.m_grc_ds_don_hang_can_tiep_nhan;
            this.m_grv_ds_don_hang_can_tiep_nhan.Name = "m_grv_ds_don_hang_can_tiep_nhan";
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsBehavior.Editable = false;
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsBehavior.ReadOnly = true;
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GD ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            // 
            // NGUOI_TAO_THAO_TAC
            // 
            this.NGUOI_TAO_THAO_TAC.Caption = "TÊN TRUY CẬP";
            this.NGUOI_TAO_THAO_TAC.FieldName = "TEN_TRUY_CAP";
            this.NGUOI_TAO_THAO_TAC.Name = "NGUOI_TAO_THAO_TAC";
            this.NGUOI_TAO_THAO_TAC.Visible = true;
            this.NGUOI_TAO_THAO_TAC.VisibleIndex = 2;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.NGUOI_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 3;
            // 
            // NOI_DUNG_DON_HANG
            // 
            this.NOI_DUNG_DON_HANG.Caption = "NỘI DUNG ĐƠN HÀNG";
            this.NOI_DUNG_DON_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DON_HANG.Name = "NOI_DUNG_DON_HANG";
            this.NOI_DUNG_DON_HANG.Visible = true;
            this.NOI_DUNG_DON_HANG.VisibleIndex = 5;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "THỜI ĐIỂM CẦN HOÀN THÀNH";
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 4;
            // 
            // NGUOI_XU_LY
            // 
            this.NGUOI_XU_LY.Caption = "NGƯỜI XỬ LÝ";
            this.NGUOI_XU_LY.FieldName = "ID_NGUOI_NHAN_THAO_TAC";
            this.NGUOI_XU_LY.Name = "NGUOI_XU_LY";
            this.NGUOI_XU_LY.Visible = true;
            this.NGUOI_XU_LY.VisibleIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // f106_danh_sach_don_hang_can_tiep_nhan_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f106_danh_sach_don_hang_can_tiep_nhan_BO";
            this.Text = "Đơn hàng cần tiếp nhận";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_can_tiep_nhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_can_tiep_nhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tiep_nhan;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tu_choi;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_hang_can_tiep_nhan;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_hang_can_tiep_nhan;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_TAO_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_XU_LY;
        private System.Windows.Forms.Timer timer1;
    }
}