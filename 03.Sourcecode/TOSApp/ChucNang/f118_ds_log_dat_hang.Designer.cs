namespace TOSApp.ChucNang
{
    partial class f118_ds_log_dat_hang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lab_tieu_de = new System.Windows.Forms.Label();
            this.m_grc_ds_log_gd_dat_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_log_dat_hang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_NGUOI_TAO_THAO_TAC_LOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_TAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_CHI_NHANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LOAI_THAO_TAC_LOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THAO_THAC_HET_HAN_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_NHAN_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_log_gd_dat_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_log_dat_hang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lab_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 44);
            this.panel1.TabIndex = 0;
            // 
            // m_lab_tieu_de
            // 
            this.m_lab_tieu_de.AutoSize = true;
            this.m_lab_tieu_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lab_tieu_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_lab_tieu_de.Location = new System.Drawing.Point(3, 21);
            this.m_lab_tieu_de.Name = "m_lab_tieu_de";
            this.m_lab_tieu_de.Size = new System.Drawing.Size(201, 20);
            this.m_lab_tieu_de.TabIndex = 1;
            this.m_lab_tieu_de.Text = "Danh sách log giao dịch";
            // 
            // m_grc_ds_log_gd_dat_hang
            // 
            this.m_grc_ds_log_gd_dat_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_log_gd_dat_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_log_gd_dat_hang.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_log_gd_dat_hang.MainView = this.m_grv_ds_log_dat_hang;
            this.m_grc_ds_log_gd_dat_hang.Name = "m_grc_ds_log_gd_dat_hang";
            this.m_grc_ds_log_gd_dat_hang.Size = new System.Drawing.Size(993, 218);
            this.m_grc_ds_log_gd_dat_hang.TabIndex = 0;
            this.m_grc_ds_log_gd_dat_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_log_dat_hang});
            // 
            // m_grv_ds_log_dat_hang
            // 
            this.m_grv_ds_log_dat_hang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN_NGUOI_TAO_THAO_TAC_LOG,
            this.THOI_GIAN_TAO,
            this.TEN_CHI_NHANH,
            this.TEN_LOAI_THAO_TAC_LOG,
            this.THAO_THAC_HET_HAN_YN,
            this.NGUOI_NHAN_THAO_TAC,
            this.GHI_CHU,
            this.MA_DON_HANG});
            this.m_grv_ds_log_dat_hang.GridControl = this.m_grc_ds_log_gd_dat_hang;
            this.m_grv_ds_log_dat_hang.Name = "m_grv_ds_log_dat_hang";
            // 
            // TEN_NGUOI_TAO_THAO_TAC_LOG
            // 
            this.TEN_NGUOI_TAO_THAO_TAC_LOG.Caption = "NGƯỜI TẠO THAO TÁC";
            this.TEN_NGUOI_TAO_THAO_TAC_LOG.FieldName = "TEN_NGUOI_TAO_THAO_TAC_LOG";
            this.TEN_NGUOI_TAO_THAO_TAC_LOG.Name = "TEN_NGUOI_TAO_THAO_TAC_LOG";
            this.TEN_NGUOI_TAO_THAO_TAC_LOG.Visible = true;
            this.TEN_NGUOI_TAO_THAO_TAC_LOG.VisibleIndex = 1;
            // 
            // THOI_GIAN_TAO
            // 
            this.THOI_GIAN_TAO.Caption = "THỜI GIAN LẬP THAO TÁC";
            this.THOI_GIAN_TAO.FieldName = "NGAY_LAP_THAO_TAC";
            this.THOI_GIAN_TAO.Name = "THOI_GIAN_TAO";
            this.THOI_GIAN_TAO.Visible = true;
            this.THOI_GIAN_TAO.VisibleIndex = 3;
            // 
            // TEN_CHI_NHANH
            // 
            this.TEN_CHI_NHANH.Caption = "TÊN CHI NHÁNH";
            this.TEN_CHI_NHANH.FieldName = "TEN_CHI_NHANH";
            this.TEN_CHI_NHANH.Name = "TEN_CHI_NHANH";
            this.TEN_CHI_NHANH.Visible = true;
            this.TEN_CHI_NHANH.VisibleIndex = 4;
            // 
            // TEN_LOAI_THAO_TAC_LOG
            // 
            this.TEN_LOAI_THAO_TAC_LOG.Caption = "TÊN THAO TÁC LOG";
            this.TEN_LOAI_THAO_TAC_LOG.FieldName = "TEN_LOAI_THAO_TAC_LOG";
            this.TEN_LOAI_THAO_TAC_LOG.Name = "TEN_LOAI_THAO_TAC_LOG";
            this.TEN_LOAI_THAO_TAC_LOG.Visible = true;
            this.TEN_LOAI_THAO_TAC_LOG.VisibleIndex = 5;
            // 
            // THAO_THAC_HET_HAN_YN
            // 
            this.THAO_THAC_HET_HAN_YN.Caption = "HẾT HẠN Y/N";
            this.THAO_THAC_HET_HAN_YN.FieldName = "THAO_TAC_HET_HAN_YN";
            this.THAO_THAC_HET_HAN_YN.Name = "THAO_THAC_HET_HAN_YN";
            this.THAO_THAC_HET_HAN_YN.Visible = true;
            this.THAO_THAC_HET_HAN_YN.VisibleIndex = 6;
            // 
            // NGUOI_NHAN_THAO_TAC
            // 
            this.NGUOI_NHAN_THAO_TAC.Caption = "NGƯỜI NHẬN THAO TÁC";
            this.NGUOI_NHAN_THAO_TAC.FieldName = "TEN_NGUOI_NHAN_THAO_TAC";
            this.NGUOI_NHAN_THAO_TAC.Name = "NGUOI_NHAN_THAO_TAC";
            this.NGUOI_NHAN_THAO_TAC.Visible = true;
            this.NGUOI_NHAN_THAO_TAC.VisibleIndex = 2;
            // 
            // GHI_CHU
            // 
            this.GHI_CHU.Caption = "CHI CHÚ";
            this.GHI_CHU.FieldName = "GHI_CHU";
            this.GHI_CHU.Name = "GHI_CHU";
            this.GHI_CHU.Visible = true;
            this.GHI_CHU.VisibleIndex = 7;
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "MÃ ĐƠN HÀNG";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_log_gd_dat_hang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 218);
            this.panel2.TabIndex = 1;
            // 
            // f118_ds_log_dat_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f118_ds_log_dat_hang";
            this.Text = "LOG đặt hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_log_gd_dat_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_log_dat_hang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_log_gd_dat_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_log_dat_hang;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGUOI_TAO_THAO_TAC_LOG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_TAO;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_CHI_NHANH;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_LOAI_THAO_TAC_LOG;
        private DevExpress.XtraGrid.Columns.GridColumn THAO_THAC_HET_HAN_YN;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_NHAN_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn GHI_CHU;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lab_tieu_de;
    }
}