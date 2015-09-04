namespace TOSApp.Hệ_thống
{
    partial class f999_ht_bo_pm_td_dich_vu
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
            this.m_grc_ht_bo_pm_td_dich_vu = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ht_bo_pm_td_dich_vu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ten_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_bo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_pm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_td = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nhom_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_loai_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pan_grv = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_bo_pm_td_dich_vu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_bo_pm_td_dich_vu)).BeginInit();
            this.m_pan_grv.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_ht_bo_pm_td_dich_vu
            // 
            this.m_grc_ht_bo_pm_td_dich_vu.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ht_bo_pm_td_dich_vu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ht_bo_pm_td_dich_vu.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ht_bo_pm_td_dich_vu.MainView = this.m_grv_ht_bo_pm_td_dich_vu;
            this.m_grc_ht_bo_pm_td_dich_vu.Name = "m_grc_ht_bo_pm_td_dich_vu";
            this.m_grc_ht_bo_pm_td_dich_vu.Size = new System.Drawing.Size(784, 313);
            this.m_grc_ht_bo_pm_td_dich_vu.TabIndex = 0;
            this.m_grc_ht_bo_pm_td_dich_vu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ht_bo_pm_td_dich_vu});
            // 
            // m_grv_ht_bo_pm_td_dich_vu
            // 
            this.m_grv_ht_bo_pm_td_dich_vu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ten_dich_vu,
            this.c_bo,
            this.c_pm,
            this.c_td,
            this.c_nhom_dich_vu,
            this.c_loai_dich_vu});
            this.m_grv_ht_bo_pm_td_dich_vu.GridControl = this.m_grc_ht_bo_pm_td_dich_vu;
            this.m_grv_ht_bo_pm_td_dich_vu.GroupCount = 3;
            this.m_grv_ht_bo_pm_td_dich_vu.Name = "m_grv_ht_bo_pm_td_dich_vu";
            this.m_grv_ht_bo_pm_td_dich_vu.OptionsBehavior.Editable = false;
            this.m_grv_ht_bo_pm_td_dich_vu.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.m_grv_ht_bo_pm_td_dich_vu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_loai_dich_vu, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_nhom_dich_vu, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_ten_dich_vu, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.m_grv_ht_bo_pm_td_dich_vu.DoubleClick += new System.EventHandler(this.m_grv_ht_bo_pm_td_dich_vu_DoubleClick);
            // 
            // c_ten_dich_vu
            // 
            this.c_ten_dich_vu.Caption = "Dịch vụ";
            this.c_ten_dich_vu.FieldName = "DICH_VU";
            this.c_ten_dich_vu.Name = "c_ten_dich_vu";
            this.c_ten_dich_vu.Visible = true;
            this.c_ten_dich_vu.VisibleIndex = 0;
            // 
            // c_bo
            // 
            this.c_bo.Caption = "Người xử lý cấp 1";
            this.c_bo.FieldName = "BO";
            this.c_bo.Name = "c_bo";
            this.c_bo.Visible = true;
            this.c_bo.VisibleIndex = 0;
            this.c_bo.Width = 83;
            // 
            // c_pm
            // 
            this.c_pm.Caption = "Người xử lý cấp 2";
            this.c_pm.FieldName = "PM";
            this.c_pm.Name = "c_pm";
            this.c_pm.Visible = true;
            this.c_pm.VisibleIndex = 1;
            // 
            // c_td
            // 
            this.c_td.Caption = "Người xử lý cấp 3";
            this.c_td.FieldName = "TD";
            this.c_td.Name = "c_td";
            this.c_td.Visible = true;
            this.c_td.VisibleIndex = 2;
            // 
            // c_nhom_dich_vu
            // 
            this.c_nhom_dich_vu.Caption = "Nhóm dịch vụ";
            this.c_nhom_dich_vu.FieldName = "NHOM_DICH_VU";
            this.c_nhom_dich_vu.Name = "c_nhom_dich_vu";
            this.c_nhom_dich_vu.Visible = true;
            this.c_nhom_dich_vu.VisibleIndex = 0;
            // 
            // c_loai_dich_vu
            // 
            this.c_loai_dich_vu.Caption = "Loại dịch vụ";
            this.c_loai_dich_vu.FieldName = "LOAI_DICH_VU";
            this.c_loai_dich_vu.Name = "c_loai_dich_vu";
            this.c_loai_dich_vu.Visible = true;
            this.c_loai_dich_vu.VisibleIndex = 0;
            // 
            // m_pan_grv
            // 
            this.m_pan_grv.Controls.Add(this.m_grc_ht_bo_pm_td_dich_vu);
            this.m_pan_grv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pan_grv.Location = new System.Drawing.Point(0, 0);
            this.m_pan_grv.Name = "m_pan_grv";
            this.m_pan_grv.Size = new System.Drawing.Size(784, 313);
            this.m_pan_grv.TabIndex = 2;
            // 
            // f999_ht_bo_pm_td_dich_vu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 313);
            this.Controls.Add(this.m_pan_grv);
            this.Name = "f999_ht_bo_pm_td_dich_vu";
            this.Text = "Dịch vụ - Người xử lý";
            this.Load += new System.EventHandler(this.f999_ht_bo_dich_vu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_bo_pm_td_dich_vu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_bo_pm_td_dich_vu)).EndInit();
            this.m_pan_grv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_ht_bo_pm_td_dich_vu;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ht_bo_pm_td_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_bo;
        private DevExpress.XtraGrid.Columns.GridColumn c_pm;
        private DevExpress.XtraGrid.Columns.GridColumn c_td;
        private DevExpress.XtraGrid.Columns.GridColumn c_nhom_dich_vu;
        private System.Windows.Forms.Panel m_pan_grv;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_dich_vu;
    }
}