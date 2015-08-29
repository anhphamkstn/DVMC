namespace TOSApp.ChucNang
{
    partial class f119_ds_don_hang_hoan_thanh
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
            this.m_grc_ds_dh_hoan_thanh = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_dh_hoan_thanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dh_hoan_thanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dh_hoan_thanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_dh_hoan_thanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 262);
            this.panel1.TabIndex = 0;
            // 
            // m_grc_ds_dh_hoan_thanh
            // 
            this.m_grc_ds_dh_hoan_thanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_dh_hoan_thanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_dh_hoan_thanh.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_dh_hoan_thanh.MainView = this.m_grv_ds_dh_hoan_thanh;
            this.m_grc_ds_dh_hoan_thanh.Name = "m_grc_ds_dh_hoan_thanh";
            this.m_grc_ds_dh_hoan_thanh.Size = new System.Drawing.Size(850, 262);
            this.m_grc_ds_dh_hoan_thanh.TabIndex = 0;
            this.m_grc_ds_dh_hoan_thanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_dh_hoan_thanh});
            // 
            // m_grv_ds_dh_hoan_thanh
            // 
            this.m_grv_ds_dh_hoan_thanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.m_grv_ds_dh_hoan_thanh.GridControl = this.m_grc_ds_dh_hoan_thanh;
            this.m_grv_ds_dh_hoan_thanh.Name = "m_grv_ds_dh_hoan_thanh";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ ĐƠN HÀNG";
            this.gridColumn1.FieldName = "MA_DON_HANG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "USER ĐẶT HÀNG";
            this.gridColumn2.FieldName = "HO_TEN_USER_DAT_HANG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MÃ ĐƠN VỊ";
            this.gridColumn3.FieldName = "MA_DON_VI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ĐIỆN THOẠI";
            this.gridColumn4.FieldName = "DIEN_THOAI";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "THỜI GIAN ĐẶT HÀNG";
            this.gridColumn5.FieldName = "THOI_GIAN_DAT_HANG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "DỊCH VỤ YÊU CẦU";
            this.gridColumn6.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "NỘI DUNG ĐẶT HÀNG";
            this.gridColumn7.FieldName = "NOI_DUNG_DAT_HANG";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "THỜI GIAN HOÀN THÀNH";
            this.gridColumn8.FieldName = "THOI_GIAN_HOAN_THANH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "GHI CHÚ";
            this.gridColumn9.FieldName = "GHI_CHU";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // f119_ds_don_hang_hoan_thanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 262);
            this.Controls.Add(this.panel1);
            this.Name = "f119_ds_don_hang_hoan_thanh";
            this.Text = "f119_ds_don_hang_hoan_thanh";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dh_hoan_thanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dh_hoan_thanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_dh_hoan_thanh;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_dh_hoan_thanh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}