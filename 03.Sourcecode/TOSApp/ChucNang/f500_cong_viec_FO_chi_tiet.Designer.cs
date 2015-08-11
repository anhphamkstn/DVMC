namespace TOSApp.ChucNang
{
    partial class f500_cong_viec_FO_chi_tiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f500_cong_viec_FO_chi_tiet));
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_them_moi_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.v_cmd_dieu_phoi_pm = new DevExpress.XtraEditors.SimpleButton();
            this.v_cmd_dieu_phoi_BO = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_chinh_sua_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_grc_FO_danh_sach_don_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_FO_danh_sach_don_hang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN_NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEN_THOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DICH_VỤ_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHAN_HOI_TU_DVMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_FO_danh_sach_don_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_FO_danh_sach_don_hang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_them_moi_don_hang);
            this.panel2.Controls.Add(this.v_cmd_dieu_phoi_pm);
            this.panel2.Controls.Add(this.v_cmd_dieu_phoi_BO);
            this.panel2.Controls.Add(this.m_cmd_chinh_sua_don_hang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 72);
            this.panel2.TabIndex = 0;
            // 
            // m_cmd_them_moi_don_hang
            // 
            this.m_cmd_them_moi_don_hang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.m_cmd_them_moi_don_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them_moi_don_hang.Image")));
            this.m_cmd_them_moi_don_hang.Location = new System.Drawing.Point(12, 19);
            this.m_cmd_them_moi_don_hang.Name = "m_cmd_them_moi_don_hang";
            this.m_cmd_them_moi_don_hang.Size = new System.Drawing.Size(152, 33);
            this.m_cmd_them_moi_don_hang.TabIndex = 20;
            this.m_cmd_them_moi_don_hang.Text = "Thêm mới đơn hàng";
            this.m_cmd_them_moi_don_hang.Click += new System.EventHandler(this.m_cmd_them_moi_don_hang_Click);
            // 
            // v_cmd_dieu_phoi_pm
            // 
            this.v_cmd_dieu_phoi_pm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.v_cmd_dieu_phoi_pm.Image = ((System.Drawing.Image)(resources.GetObject("v_cmd_dieu_phoi_pm.Image")));
            this.v_cmd_dieu_phoi_pm.Location = new System.Drawing.Point(491, 19);
            this.v_cmd_dieu_phoi_pm.Name = "v_cmd_dieu_phoi_pm";
            this.v_cmd_dieu_phoi_pm.Size = new System.Drawing.Size(133, 33);
            this.v_cmd_dieu_phoi_pm.TabIndex = 21;
            this.v_cmd_dieu_phoi_pm.Text = "Điều phối cho PM";
            this.v_cmd_dieu_phoi_pm.Click += new System.EventHandler(this.v_cmd_dieu_phoi_pm_Click);
            // 
            // v_cmd_dieu_phoi_BO
            // 
            this.v_cmd_dieu_phoi_BO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.v_cmd_dieu_phoi_BO.Image = ((System.Drawing.Image)(resources.GetObject("v_cmd_dieu_phoi_BO.Image")));
            this.v_cmd_dieu_phoi_BO.Location = new System.Drawing.Point(337, 19);
            this.v_cmd_dieu_phoi_BO.Name = "v_cmd_dieu_phoi_BO";
            this.v_cmd_dieu_phoi_BO.Size = new System.Drawing.Size(133, 33);
            this.v_cmd_dieu_phoi_BO.TabIndex = 21;
            this.v_cmd_dieu_phoi_BO.Text = "Điều phối";
            this.v_cmd_dieu_phoi_BO.Click += new System.EventHandler(this.v_cmd_dieu_phoi_BO_Click);
            // 
            // m_cmd_chinh_sua_don_hang
            // 
            this.m_cmd_chinh_sua_don_hang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.m_cmd_chinh_sua_don_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_chinh_sua_don_hang.Image")));
            this.m_cmd_chinh_sua_don_hang.Location = new System.Drawing.Point(170, 19);
            this.m_cmd_chinh_sua_don_hang.Name = "m_cmd_chinh_sua_don_hang";
            this.m_cmd_chinh_sua_don_hang.Size = new System.Drawing.Size(146, 33);
            this.m_cmd_chinh_sua_don_hang.TabIndex = 18;
            this.m_cmd_chinh_sua_don_hang.Text = "Chỉnh sửa đơn hàng";
            this.m_cmd_chinh_sua_don_hang.Click += new System.EventHandler(this.m_cmd_chinh_sua_don_hang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 373);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_grc_FO_danh_sach_don_hang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1277, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn hàng";
            // 
            // m_grc_FO_danh_sach_don_hang
            // 
            this.m_grc_FO_danh_sach_don_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_FO_danh_sach_don_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_FO_danh_sach_don_hang.Location = new System.Drawing.Point(3, 16);
            this.m_grc_FO_danh_sach_don_hang.MainView = this.m_grv_FO_danh_sach_don_hang;
            this.m_grc_FO_danh_sach_don_hang.Name = "m_grc_FO_danh_sach_don_hang";
            this.m_grc_FO_danh_sach_don_hang.Size = new System.Drawing.Size(1271, 354);
            this.m_grc_FO_danh_sach_don_hang.TabIndex = 1;
            this.m_grc_FO_danh_sach_don_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_FO_danh_sach_don_hang});
            // 
            // m_grv_FO_danh_sach_don_hang
            // 
            this.m_grv_FO_danh_sach_don_hang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DON_HANG,
            this.HO_TEN_NGUOI_DAT_HANG,
            this.DIEN_THOAI,
            this.THOI_GIAN_DAT_HANG,
            this.TEN_DICH_VỤ_YEU_CAU,
            this.NOI_DUNG_DAT_HANG,
            this.PHAN_HOI_TU_DVMC,
            this.ID});
            this.m_grv_FO_danh_sach_don_hang.GridControl = this.m_grc_FO_danh_sach_don_hang;
            this.m_grv_FO_danh_sach_don_hang.Name = "m_grv_FO_danh_sach_don_hang";
            this.m_grv_FO_danh_sach_don_hang.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "MÃ ĐƠN HÀNG";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 1;
            this.MA_DON_HANG.Width = 76;
            // 
            // HO_TEN_NGUOI_DAT_HANG
            // 
            this.HO_TEN_NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.HO_TEN_NGUOI_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.HO_TEN_NGUOI_DAT_HANG.Name = "HO_TEN_NGUOI_DAT_HANG";
            this.HO_TEN_NGUOI_DAT_HANG.Visible = true;
            this.HO_TEN_NGUOI_DAT_HANG.VisibleIndex = 2;
            this.HO_TEN_NGUOI_DAT_HANG.Width = 76;
            // 
            // DIEN_THOAI
            // 
            this.DIEN_THOAI.Caption = "ĐIỆN THOẠI";
            this.DIEN_THOAI.FieldName = "DIEN_THOAI";
            this.DIEN_THOAI.Name = "DIEN_THOAI";
            this.DIEN_THOAI.Visible = true;
            this.DIEN_THOAI.VisibleIndex = 3;
            this.DIEN_THOAI.Width = 76;
            // 
            // THOI_GIAN_DAT_HANG
            // 
            this.THOI_GIAN_DAT_HANG.Caption = "THỜI GIAN ĐẶT HÀNG";
            this.THOI_GIAN_DAT_HANG.FieldName = "THOI_GIAN_DAT_HANG";
            this.THOI_GIAN_DAT_HANG.Name = "THOI_GIAN_DAT_HANG";
            this.THOI_GIAN_DAT_HANG.Visible = true;
            this.THOI_GIAN_DAT_HANG.VisibleIndex = 4;
            this.THOI_GIAN_DAT_HANG.Width = 102;
            // 
            // TEN_DICH_VỤ_YEU_CAU
            // 
            this.TEN_DICH_VỤ_YEU_CAU.Caption = "DỊCH VỤ YÊU CẦU";
            this.TEN_DICH_VỤ_YEU_CAU.FieldName = "TEN_YEU_CAU";
            this.TEN_DICH_VỤ_YEU_CAU.Name = "TEN_DICH_VỤ_YEU_CAU";
            this.TEN_DICH_VỤ_YEU_CAU.Visible = true;
            this.TEN_DICH_VỤ_YEU_CAU.VisibleIndex = 5;
            this.TEN_DICH_VỤ_YEU_CAU.Width = 71;
            // 
            // NOI_DUNG_DAT_HANG
            // 
            this.NOI_DUNG_DAT_HANG.Caption = "NỘI DUNG ĐẶT HÀNG";
            this.NOI_DUNG_DAT_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Name = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Visible = true;
            this.NOI_DUNG_DAT_HANG.VisibleIndex = 6;
            this.NOI_DUNG_DAT_HANG.Width = 71;
            // 
            // PHAN_HOI_TU_DVMC
            // 
            this.PHAN_HOI_TU_DVMC.Caption = "PHẢN HỒI TỪ DVMC";
            this.PHAN_HOI_TU_DVMC.FieldName = "PHAN_HOI_TU_DVMC";
            this.PHAN_HOI_TU_DVMC.Name = "PHAN_HOI_TU_DVMC";
            this.PHAN_HOI_TU_DVMC.Visible = true;
            this.PHAN_HOI_TU_DVMC.VisibleIndex = 7;
            this.PHAN_HOI_TU_DVMC.Width = 88;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // f500_cong_viec_FO_chi_tiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f500_cong_viec_FO_chi_tiet";
            this.Text = "f500_cong_viec_FO_chi_tiet";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_FO_danh_sach_don_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_FO_danh_sach_don_hang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them_moi_don_hang;
        private DevExpress.XtraEditors.SimpleButton v_cmd_dieu_phoi_BO;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chinh_sua_don_hang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl m_grc_FO_danh_sach_don_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_FO_danh_sach_don_hang;
        private DevExpress.XtraEditors.SimpleButton v_cmd_dieu_phoi_pm;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN_NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn DIEN_THOAI;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DICH_VỤ_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn PHAN_HOI_TU_DVMC;
        private DevExpress.XtraGrid.Columns.GridColumn ID;

    }
}