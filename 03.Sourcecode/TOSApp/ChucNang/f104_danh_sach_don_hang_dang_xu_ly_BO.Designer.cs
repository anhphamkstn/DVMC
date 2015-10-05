namespace TOSApp.ChucNang
{
    partial class f104_danh_sach_don_hang_dang_xu_ly_BO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f104_danh_sach_don_hang_dang_xu_ly_BO));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_grc_xac_nhan_don_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_TAO_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DICH_VU_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_bao_cao_da_xu_ly = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tu_choi_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cap_nhat_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_xac_nhan_don_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_don_hang_tiep_nhan_BO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_grc_xac_nhan_don_hang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(948, 391);
            this.panelControl1.TabIndex = 0;
            // 
            // m_grc_xac_nhan_don_hang
            // 
            this.m_grc_xac_nhan_don_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_xac_nhan_don_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_xac_nhan_don_hang.Location = new System.Drawing.Point(2, 2);
            this.m_grc_xac_nhan_don_hang.MainView = this.m_grv_danh_sach_don_hang_tiep_nhan_BO;
            this.m_grc_xac_nhan_don_hang.Name = "m_grc_xac_nhan_don_hang";
            this.m_grc_xac_nhan_don_hang.Size = new System.Drawing.Size(944, 387);
            this.m_grc_xac_nhan_don_hang.TabIndex = 0;
            this.m_grc_xac_nhan_don_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO});
            // 
            // m_grv_danh_sach_don_hang_tiep_nhan_BO
            // 
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Beige;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.EvenRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FixedLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FooterPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupButton.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupFooter.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.Options.UseImage = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HideSelectionRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HorzLine.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HorzLine.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.HorzLine.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.OddRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.OddRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(90)))));
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.Options.UseBorderColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.Options.UseFont = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Row.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Row.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.RowSeparator.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.RowSeparator.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.VertLine.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.VertLine.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.VertLine.Options.UseForeColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ViewCaption.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Appearance.ViewCaption.Options.UseBackColor = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_GD_DAT_HANG,
            this.NGUOI_TAO_THAO_TAC,
            this.DICH_VU_YEU_CAU,
            this.NOI_DUNG_DAT_HANG,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.NGUOI_DAT_HANG,
            this.STT});
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.GridControl = this.m_grc_xac_nhan_don_hang;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.IndicatorWidth = 20;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.Name = "m_grv_danh_sach_don_hang_tiep_nhan_BO";
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.OptionsBehavior.Editable = false;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.OptionsBehavior.ReadOnly = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.OptionsView.ShowFooter = true;
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.PaintStyleName = "MixedXP";
            this.m_grv_danh_sach_don_hang_tiep_nhan_BO.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.m_grv_danh_sach_don_hang_tiep_nhan_BO_CustomDrawCell);
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GIAO DỊCH ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            this.ID_GD_DAT_HANG.Width = 144;
            // 
            // NGUOI_TAO_THAO_TAC
            // 
            this.NGUOI_TAO_THAO_TAC.Caption = "NGƯỜI TẠO THAO TÁC";
            this.NGUOI_TAO_THAO_TAC.FieldName = "ID_NGUOI_TAO_THAO_TAC";
            this.NGUOI_TAO_THAO_TAC.Name = "NGUOI_TAO_THAO_TAC";
            this.NGUOI_TAO_THAO_TAC.Visible = true;
            this.NGUOI_TAO_THAO_TAC.VisibleIndex = 2;
            this.NGUOI_TAO_THAO_TAC.Width = 144;
            // 
            // DICH_VU_YEU_CAU
            // 
            this.DICH_VU_YEU_CAU.Caption = "DỊCH VỤ YÊU CẦU";
            this.DICH_VU_YEU_CAU.FieldName = "TEN_YEU_CAU";
            this.DICH_VU_YEU_CAU.Name = "DICH_VU_YEU_CAU";
            this.DICH_VU_YEU_CAU.Visible = true;
            this.DICH_VU_YEU_CAU.VisibleIndex = 4;
            this.DICH_VU_YEU_CAU.Width = 144;
            // 
            // NOI_DUNG_DAT_HANG
            // 
            this.NOI_DUNG_DAT_HANG.Caption = "NỘI DUNG";
            this.NOI_DUNG_DAT_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Name = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Visible = true;
            this.NOI_DUNG_DAT_HANG.VisibleIndex = 5;
            this.NOI_DUNG_DAT_HANG.Width = 144;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "THỜI ĐIỂM CẦN HOÀN THÀNH";
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 6;
            this.THOI_DIEM_CAN_HOAN_THANH.Width = 156;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.NGUOI_DAT_HANG.FieldName = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 3;
            this.NGUOI_DAT_HANG.Width = 144;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_cmd_bao_cao_da_xu_ly);
            this.panelControl2.Controls.Add(this.m_cmd_tu_choi_don_hang);
            this.panelControl2.Controls.Add(this.m_cmd_cap_nhat_don_hang);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 391);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(948, 49);
            this.panelControl2.TabIndex = 0;
            // 
            // m_cmd_bao_cao_da_xu_ly
            // 
            this.m_cmd_bao_cao_da_xu_ly.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_bao_cao_da_xu_ly.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_bao_cao_da_xu_ly.Image")));
            this.m_cmd_bao_cao_da_xu_ly.Location = new System.Drawing.Point(578, 2);
            this.m_cmd_bao_cao_da_xu_ly.Name = "m_cmd_bao_cao_da_xu_ly";
            this.m_cmd_bao_cao_da_xu_ly.Size = new System.Drawing.Size(124, 45);
            this.m_cmd_bao_cao_da_xu_ly.TabIndex = 1;
            this.m_cmd_bao_cao_da_xu_ly.Text = "Đã xử lý";
            this.m_cmd_bao_cao_da_xu_ly.Click += new System.EventHandler(this.m_cmd_bao_cao_da_xu_ly_Click);
            // 
            // m_cmd_tu_choi_don_hang
            // 
            this.m_cmd_tu_choi_don_hang.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_tu_choi_don_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_tu_choi_don_hang.Image")));
            this.m_cmd_tu_choi_don_hang.Location = new System.Drawing.Point(702, 2);
            this.m_cmd_tu_choi_don_hang.Name = "m_cmd_tu_choi_don_hang";
            this.m_cmd_tu_choi_don_hang.Size = new System.Drawing.Size(132, 45);
            this.m_cmd_tu_choi_don_hang.TabIndex = 0;
            this.m_cmd_tu_choi_don_hang.Text = "Từ chối xử lý";
            this.m_cmd_tu_choi_don_hang.Click += new System.EventHandler(this.m_cmd_tu_choi_don_hang_Click);
            // 
            // m_cmd_cap_nhat_don_hang
            // 
            this.m_cmd_cap_nhat_don_hang.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_cap_nhat_don_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_cap_nhat_don_hang.Image")));
            this.m_cmd_cap_nhat_don_hang.Location = new System.Drawing.Point(834, 2);
            this.m_cmd_cap_nhat_don_hang.Name = "m_cmd_cap_nhat_don_hang";
            this.m_cmd_cap_nhat_don_hang.Size = new System.Drawing.Size(112, 45);
            this.m_cmd_cap_nhat_don_hang.TabIndex = 0;
            this.m_cmd_cap_nhat_don_hang.Text = "Cập nhật";
            this.m_cmd_cap_nhat_don_hang.Click += new System.EventHandler(this.m_cmd_cap_nhat_don_hang_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 46;
            // 
            // f104_danh_sach_don_hang_dang_xu_ly_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 440);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "f104_danh_sach_don_hang_dang_xu_ly_BO";
            this.Text = "f104_Đơn hàng đang xử lý";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_xac_nhan_don_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_don_hang_tiep_nhan_BO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl m_grc_xac_nhan_don_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_danh_sach_don_hang_tiep_nhan_BO;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cap_nhat_don_hang;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tu_choi_don_hang;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_TAO_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn DICH_VU_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraEditors.SimpleButton m_cmd_bao_cao_da_xu_ly;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}