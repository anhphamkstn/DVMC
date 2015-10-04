namespace TOSApp.ChucNang
{
    partial class F345_danh_sach_cuoc_goi
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
            this.m_grc_danh_sach_cuoc_goi = new DevExpress.XtraGrid.GridControl();
            this.m_grv_danh_sach_cuoc_goi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.column1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_danh_sach_cuoc_goi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_cuoc_goi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_danh_sach_cuoc_goi
            // 
            this.m_grc_danh_sach_cuoc_goi.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_danh_sach_cuoc_goi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_danh_sach_cuoc_goi.Location = new System.Drawing.Point(0, 66);
            this.m_grc_danh_sach_cuoc_goi.MainView = this.m_grv_danh_sach_cuoc_goi;
            this.m_grc_danh_sach_cuoc_goi.Name = "m_grc_danh_sach_cuoc_goi";
            this.m_grc_danh_sach_cuoc_goi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.m_grc_danh_sach_cuoc_goi.Size = new System.Drawing.Size(915, 331);
            this.m_grc_danh_sach_cuoc_goi.TabIndex = 0;
            this.m_grc_danh_sach_cuoc_goi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_danh_sach_cuoc_goi});
            // 
            // m_grv_danh_sach_cuoc_goi
            // 
            this.m_grv_danh_sach_cuoc_goi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.column1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.m_grv_danh_sach_cuoc_goi.GridControl = this.m_grc_danh_sach_cuoc_goi;
            this.m_grv_danh_sach_cuoc_goi.GroupCount = 1;
            this.m_grv_danh_sach_cuoc_goi.Name = "m_grv_danh_sach_cuoc_goi";
            this.m_grv_danh_sach_cuoc_goi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.column1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // column1
            // 
            this.column1.Caption = "Mã đơn hàng";
            this.column1.FieldName = "MA_DON_HANG";
            this.column1.Name = "column1";
            this.column1.Visible = true;
            this.column1.VisibleIndex = 0;
            this.column1.Width = 157;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nhân viên đặt hàng";
            this.gridColumn2.FieldName = "HO_TEN_USER_DAT_HANG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 141;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Dịch vụ";
            this.gridColumn3.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 172;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thời điểm gọi";
            this.gridColumn4.FieldName = "THOI_DIEM_GOI";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 101;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời gian bắt đầu";
            this.gridColumn1.FieldName = "START_TIME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 95;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thời gian kết thúc";
            this.gridColumn5.FieldName = "END_TIME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 95;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Link ghi âm";
            this.gridColumn6.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn6.FieldName = "VOICE_CALL_LINK";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 121;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.NullText = "Link";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người tiếp nhận";
            this.gridColumn7.FieldName = "NGUOI_TAO_THAO_TAC";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 171;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 66);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách cuộc gọi yêu cầu";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // F345_danh_sach_cuoc_goi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 397);
            this.Controls.Add(this.m_grc_danh_sach_cuoc_goi);
            this.Controls.Add(this.panel1);
            this.Name = "F345_danh_sach_cuoc_goi";
            this.Text = "F345_danh_sach_cuoc_goi";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_danh_sach_cuoc_goi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_cuoc_goi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_danh_sach_cuoc_goi;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_danh_sach_cuoc_goi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn column1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}