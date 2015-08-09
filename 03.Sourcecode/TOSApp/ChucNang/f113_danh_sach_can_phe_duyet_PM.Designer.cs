namespace TOSApp.ChucNang
{
    partial class f113_danh_sach_can_phe_duyet_PM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_khong_duyet = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_duyet = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc_danh_sach_can_phe_duyet_PM = new DevExpress.XtraGrid.GridControl();
            this.m_grv_danh_sach_can_phe_duyet_PM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANG_THAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_danh_sach_can_phe_duyet_PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_can_phe_duyet_PM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_khong_duyet);
            this.panel1.Controls.Add(this.m_cmd_duyet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 59);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_khong_duyet
            // 
            this.m_cmd_khong_duyet.Location = new System.Drawing.Point(611, 15);
            this.m_cmd_khong_duyet.Name = "m_cmd_khong_duyet";
            this.m_cmd_khong_duyet.Size = new System.Drawing.Size(108, 23);
            this.m_cmd_khong_duyet.TabIndex = 0;
            this.m_cmd_khong_duyet.Text = "Không phê duyệt";
            // 
            // m_cmd_duyet
            // 
            this.m_cmd_duyet.Location = new System.Drawing.Point(476, 15);
            this.m_cmd_duyet.Name = "m_cmd_duyet";
            this.m_cmd_duyet.Size = new System.Drawing.Size(103, 23);
            this.m_cmd_duyet.TabIndex = 0;
            this.m_cmd_duyet.Text = "Duyệt";
            this.m_cmd_duyet.Click += new System.EventHandler(this.m_cmd_duyet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_danh_sach_can_phe_duyet_PM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 354);
            this.panel2.TabIndex = 1;
            // 
            // m_grc_danh_sach_can_phe_duyet_PM
            // 
            this.m_grc_danh_sach_can_phe_duyet_PM.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_danh_sach_can_phe_duyet_PM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_danh_sach_can_phe_duyet_PM.Location = new System.Drawing.Point(0, 0);
            this.m_grc_danh_sach_can_phe_duyet_PM.MainView = this.m_grv_danh_sach_can_phe_duyet_PM;
            this.m_grc_danh_sach_can_phe_duyet_PM.Name = "m_grc_danh_sach_can_phe_duyet_PM";
            this.m_grc_danh_sach_can_phe_duyet_PM.Size = new System.Drawing.Size(750, 354);
            this.m_grc_danh_sach_can_phe_duyet_PM.TabIndex = 0;
            this.m_grc_danh_sach_can_phe_duyet_PM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_danh_sach_can_phe_duyet_PM});
            // 
            // m_grv_danh_sach_can_phe_duyet_PM
            // 
            this.m_grv_danh_sach_can_phe_duyet_PM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ID_GD_DAT_HANG,
            this.NGUOI_DAT_HANG,
            this.TEN_YEU_CAU,
            this.BO,
            this.TRANG_THAI});
            this.m_grv_danh_sach_can_phe_duyet_PM.GridControl = this.m_grc_danh_sach_can_phe_duyet_PM;
            this.m_grv_danh_sach_can_phe_duyet_PM.Name = "m_grv_danh_sach_can_phe_duyet_PM";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GD ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 2;
            // 
            // TEN_YEU_CAU
            // 
            this.TEN_YEU_CAU.Caption = "TÊN YÊU CẦU";
            this.TEN_YEU_CAU.FieldName = "TEN_YEU_CAU";
            this.TEN_YEU_CAU.Name = "TEN_YEU_CAU";
            this.TEN_YEU_CAU.Visible = true;
            this.TEN_YEU_CAU.VisibleIndex = 3;
            // 
            // BO
            // 
            this.BO.Caption = "BO";
            this.BO.FieldName = "BO";
            this.BO.Name = "BO";
            this.BO.Visible = true;
            this.BO.VisibleIndex = 4;
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.Caption = "TRẠNG THÁI";
            this.TRANG_THAI.FieldName = "TRANG_THAI";
            this.TRANG_THAI.Name = "TRANG_THAI";
            this.TRANG_THAI.Visible = true;
            this.TRANG_THAI.VisibleIndex = 5;
            // 
            // f113_danh_sach_can_phe_duyet_PM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 413);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f113_danh_sach_can_phe_duyet_PM";
            this.Text = "f113_danh_sach_can_phe_duyet_PM";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_danh_sach_can_phe_duyet_PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_can_phe_duyet_PM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_duyet;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_khong_duyet;
        private DevExpress.XtraGrid.GridControl m_grc_danh_sach_can_phe_duyet_PM;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_danh_sach_can_phe_duyet_PM;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn BO;
        private DevExpress.XtraGrid.Columns.GridColumn TRANG_THAI;
    }
}