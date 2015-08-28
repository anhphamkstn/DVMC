namespace TOSApp.ChucNang
{
    partial class f117_ds_tat_ca_don_dat_hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f117_ds_tat_ca_don_dat_hang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ds_don_dat_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_dat_hang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_chinh_sua_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_dat_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_dat_hang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_don_dat_hang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 344);
            this.panel1.TabIndex = 0;
            // 
            // m_grc_ds_don_dat_hang
            // 
            this.m_grc_ds_don_dat_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_dat_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_dat_hang.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_dat_hang.MainView = this.m_grv_ds_don_dat_hang;
            this.m_grc_ds_don_dat_hang.Name = "m_grc_ds_don_dat_hang";
            this.m_grc_ds_don_dat_hang.Size = new System.Drawing.Size(1213, 344);
            this.m_grc_ds_don_dat_hang.TabIndex = 0;
            this.m_grc_ds_don_dat_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_dat_hang});
            // 
            // m_grv_ds_don_dat_hang
            // 
            this.m_grv_ds_don_dat_hang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DON_HANG,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn1,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.m_grv_ds_don_dat_hang.GridControl = this.m_grc_ds_don_dat_hang;
            this.m_grv_ds_don_dat_hang.Name = "m_grv_ds_don_dat_hang";
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "Mã đơn hàng";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ tên User đặt hàng";
            this.gridColumn2.FieldName = "HO_TEN_USER_DAT_HANG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điện thoại";
            this.gridColumn3.FieldName = "DIEN_THOAI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thời gian đặt hàng";
            this.gridColumn4.FieldName = "THOI_GIAN_DAT_HANG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Dịch vụ yêu cầu";
            this.gridColumn5.FieldName = "TEN_YEU_CAU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nội dung đặt hàng";
            this.gridColumn6.FieldName = "NOI_DUNG_DAT_HANG";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đơn vị";
            this.gridColumn7.FieldName = "MA_DON_VI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Loại thời gian cần hoàn thành";
            this.gridColumn8.FieldName = "LOAI_TG_CAN_HOAN-THANH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Thời gian tạo";
            this.gridColumn9.FieldName = "THOI_GIAN_TAO";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Phương thức đặt hàng";
            this.gridColumn1.FieldName = "PHUONG_THUC_DAT_HANG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Người tạo";
            this.gridColumn10.FieldName = "NGUOI_TAO";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Chi nhánh";
            this.gridColumn11.FieldName = "TEN_CHI_NHANH";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Trạng thái đơn hàng";
            this.gridColumn12.FieldName = "TRANG_THAI_DON_HANG";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 43);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_chinh_sua_don_hang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1013, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 43);
            this.panel3.TabIndex = 0;
            // 
            // m_cmd_chinh_sua_don_hang
            // 
            this.m_cmd_chinh_sua_don_hang.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_chinh_sua_don_hang.Appearance.ForeColor = System.Drawing.Color.Red;
            this.m_cmd_chinh_sua_don_hang.Appearance.Options.UseFont = true;
            this.m_cmd_chinh_sua_don_hang.Appearance.Options.UseForeColor = true;
            this.m_cmd_chinh_sua_don_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_chinh_sua_don_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_chinh_sua_don_hang.Image")));
            this.m_cmd_chinh_sua_don_hang.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_chinh_sua_don_hang.Name = "m_cmd_chinh_sua_don_hang";
            this.m_cmd_chinh_sua_don_hang.Size = new System.Drawing.Size(200, 43);
            this.m_cmd_chinh_sua_don_hang.TabIndex = 2;
            this.m_cmd_chinh_sua_don_hang.Text = "Cập nhật đơn hàng";
            this.m_cmd_chinh_sua_don_hang.Click += new System.EventHandler(this.m_cmd_chinh_sua_don_hang_Click);
            // 
            // f117_ds_tat_ca_don_dat_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f117_ds_tat_ca_don_dat_hang";
            this.Text = "f117_ds_tat_ca_don_dat_hang";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_dat_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_dat_hang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_dat_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_dat_hang;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chinh_sua_don_hang;
    }
}