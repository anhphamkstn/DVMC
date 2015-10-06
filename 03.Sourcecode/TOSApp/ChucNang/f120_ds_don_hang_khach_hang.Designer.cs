namespace TOSApp.ChucNang
{
    partial class f120_ds_don_hang_khach_hang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ds_don_hang_nguoi_xu_ly = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_hang_nguoi_xu_ly = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN_USER_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DON_VI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEN_THOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANG_THAI_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_XU_LY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_nguoi_xu_ly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_nguoi_xu_ly)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 51);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách tất cả các đơn hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_don_hang_nguoi_xu_ly);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 262);
            this.panel1.TabIndex = 1;
            // 
            // m_grc_ds_don_hang_nguoi_xu_ly
            // 
            this.m_grc_ds_don_hang_nguoi_xu_ly.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_hang_nguoi_xu_ly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_hang_nguoi_xu_ly.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_hang_nguoi_xu_ly.MainView = this.m_grv_ds_don_hang_nguoi_xu_ly;
            this.m_grc_ds_don_hang_nguoi_xu_ly.Name = "m_grc_ds_don_hang_nguoi_xu_ly";
            this.m_grc_ds_don_hang_nguoi_xu_ly.Size = new System.Drawing.Size(913, 262);
            this.m_grc_ds_don_hang_nguoi_xu_ly.TabIndex = 0;
            this.m_grc_ds_don_hang_nguoi_xu_ly.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_hang_nguoi_xu_ly});
            // 
            // m_grv_ds_don_hang_nguoi_xu_ly
            // 
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_hang_nguoi_xu_ly.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DON_HANG,
            this.HO_TEN_USER_DAT_HANG,
            this.MA_DON_VI,
            this.DIEN_THOAI,
            this.TEN_YEU_CAU,
            this.NOI_DUNG_DAT_HANG,
            this.TRANG_THAI_DON_HANG,
            this.NGUOI_XU_LY,
            this.GHI_CHU});
            this.m_grv_ds_don_hang_nguoi_xu_ly.GridControl = this.m_grc_ds_don_hang_nguoi_xu_ly;
            this.m_grv_ds_don_hang_nguoi_xu_ly.IndicatorWidth = 50;
            this.m_grv_ds_don_hang_nguoi_xu_ly.Name = "m_grv_ds_don_hang_nguoi_xu_ly";
            this.m_grv_ds_don_hang_nguoi_xu_ly.OptionsBehavior.Editable = false;
            this.m_grv_ds_don_hang_nguoi_xu_ly.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.OptionsView.ShowFooter = true;
            this.m_grv_ds_don_hang_nguoi_xu_ly.PaintStyleName = "Flat";
            this.m_grv_ds_don_hang_nguoi_xu_ly.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_ds_don_hang_nguoi_xu_ly_CustomDrawRowIndicator);
            this.m_grv_ds_don_hang_nguoi_xu_ly.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_ds_don_hang_nguoi_xu_ly_PopupMenuShowing);
            this.m_grv_ds_don_hang_nguoi_xu_ly.DoubleClick += new System.EventHandler(this.view_thong_tin_don_hang);
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "MÃ ĐƠN HÀNG";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 0;
            this.MA_DON_HANG.Width = 99;
            // 
            // HO_TEN_USER_DAT_HANG
            // 
            this.HO_TEN_USER_DAT_HANG.Caption = "USER ĐẶT HÀNG";
            this.HO_TEN_USER_DAT_HANG.FieldName = "USER_NAME";
            this.HO_TEN_USER_DAT_HANG.Name = "HO_TEN_USER_DAT_HANG";
            this.HO_TEN_USER_DAT_HANG.Visible = true;
            this.HO_TEN_USER_DAT_HANG.VisibleIndex = 1;
            this.HO_TEN_USER_DAT_HANG.Width = 99;
            // 
            // MA_DON_VI
            // 
            this.MA_DON_VI.Caption = "MÃ ĐƠN VỊ";
            this.MA_DON_VI.FieldName = "MA_DON_VI";
            this.MA_DON_VI.Name = "MA_DON_VI";
            this.MA_DON_VI.Visible = true;
            this.MA_DON_VI.VisibleIndex = 3;
            this.MA_DON_VI.Width = 99;
            // 
            // DIEN_THOAI
            // 
            this.DIEN_THOAI.Caption = "ĐIỆN THOẠI";
            this.DIEN_THOAI.FieldName = "DIEN_THOAI";
            this.DIEN_THOAI.Name = "DIEN_THOAI";
            this.DIEN_THOAI.Visible = true;
            this.DIEN_THOAI.VisibleIndex = 2;
            this.DIEN_THOAI.Width = 99;
            // 
            // TEN_YEU_CAU
            // 
            this.TEN_YEU_CAU.Caption = "TÊN YÊU CẦU";
            this.TEN_YEU_CAU.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
            this.TEN_YEU_CAU.Name = "TEN_YEU_CAU";
            this.TEN_YEU_CAU.Visible = true;
            this.TEN_YEU_CAU.VisibleIndex = 4;
            this.TEN_YEU_CAU.Width = 99;
            // 
            // NOI_DUNG_DAT_HANG
            // 
            this.NOI_DUNG_DAT_HANG.Caption = "NỘI DUNG ĐẶT HÀNG";
            this.NOI_DUNG_DAT_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Name = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DAT_HANG.Visible = true;
            this.NOI_DUNG_DAT_HANG.VisibleIndex = 5;
            this.NOI_DUNG_DAT_HANG.Width = 117;
            // 
            // TRANG_THAI_DON_HANG
            // 
            this.TRANG_THAI_DON_HANG.Caption = "TRẠNG THÁI ĐƠN HÀNG";
            this.TRANG_THAI_DON_HANG.FieldName = "TRANG_THAI_DON_HANG";
            this.TRANG_THAI_DON_HANG.Name = "TRANG_THAI_DON_HANG";
            this.TRANG_THAI_DON_HANG.Visible = true;
            this.TRANG_THAI_DON_HANG.VisibleIndex = 7;
            this.TRANG_THAI_DON_HANG.Width = 121;
            // 
            // NGUOI_XU_LY
            // 
            this.NGUOI_XU_LY.Caption = "NGƯỜI XỬ LÝ";
            this.NGUOI_XU_LY.FieldName = "TEN_NGUOI_TAO_THAO_TAC_LOG";
            this.NGUOI_XU_LY.Name = "NGUOI_XU_LY";
            this.NGUOI_XU_LY.Visible = true;
            this.NGUOI_XU_LY.VisibleIndex = 6;
            this.NGUOI_XU_LY.Width = 91;
            // 
            // GHI_CHU
            // 
            this.GHI_CHU.Caption = "GHI CHÚ";
            this.GHI_CHU.FieldName = "GHI_CHU";
            this.GHI_CHU.Name = "GHI_CHU";
            this.GHI_CHU.Visible = true;
            this.GHI_CHU.VisibleIndex = 8;
            this.GHI_CHU.Width = 74;
            // 
            // f120_ds_don_hang_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f120_ds_don_hang_khach_hang";
            this.Text = "Tất cả các đơn hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_nguoi_xu_ly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_nguoi_xu_ly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_hang_nguoi_xu_ly;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_hang_nguoi_xu_ly;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN_USER_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_VI;
        private DevExpress.XtraGrid.Columns.GridColumn DIEN_THOAI;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANG_THAI_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_XU_LY;
        private DevExpress.XtraGrid.Columns.GridColumn GHI_CHU;
        private System.Windows.Forms.Label label1;
    }
}