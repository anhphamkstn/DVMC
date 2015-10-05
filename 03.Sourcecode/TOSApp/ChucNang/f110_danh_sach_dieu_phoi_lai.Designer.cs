namespace TOSApp.ChucNang
{
    partial class f110_danh_sach_dieu_phoi_lai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f110_danh_sach_dieu_phoi_lai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_dieu_phoi_PM = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dieu_phoi_BO = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dieu_phoi_cho_PM = new System.Windows.Forms.Panel();
            this.m_grc_ds_dieu_phoi_lai = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_dieu_phoi_lai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_NHAN_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DICH_VU_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.m_cmd_dieu_phoi_cho_PM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dieu_phoi_lai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dieu_phoi_lai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_dieu_phoi_PM);
            this.panel1.Controls.Add(this.m_cmd_dieu_phoi_BO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 40);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_dieu_phoi_PM
            // 
            this.m_cmd_dieu_phoi_PM.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_dieu_phoi_PM.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_dieu_phoi_PM.Image")));
            this.m_cmd_dieu_phoi_PM.Location = new System.Drawing.Point(638, 0);
            this.m_cmd_dieu_phoi_PM.Name = "m_cmd_dieu_phoi_PM";
            this.m_cmd_dieu_phoi_PM.Size = new System.Drawing.Size(133, 40);
            this.m_cmd_dieu_phoi_PM.TabIndex = 0;
            this.m_cmd_dieu_phoi_PM.Text = "Điều phối cho PM";
            this.m_cmd_dieu_phoi_PM.Click += new System.EventHandler(this.m_cmd_dieu_phoi_PM_Click);
            // 
            // m_cmd_dieu_phoi_BO
            // 
            this.m_cmd_dieu_phoi_BO.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_dieu_phoi_BO.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_dieu_phoi_BO.Image")));
            this.m_cmd_dieu_phoi_BO.Location = new System.Drawing.Point(771, 0);
            this.m_cmd_dieu_phoi_BO.Name = "m_cmd_dieu_phoi_BO";
            this.m_cmd_dieu_phoi_BO.Size = new System.Drawing.Size(134, 40);
            this.m_cmd_dieu_phoi_BO.TabIndex = 0;
            this.m_cmd_dieu_phoi_BO.Text = "Điều phối cho BO";
            this.m_cmd_dieu_phoi_BO.Click += new System.EventHandler(this.m_cmd_dieu_phoi_BO_Click);
            // 
            // m_cmd_dieu_phoi_cho_PM
            // 
            this.m_cmd_dieu_phoi_cho_PM.Controls.Add(this.m_grc_ds_dieu_phoi_lai);
            this.m_cmd_dieu_phoi_cho_PM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_dieu_phoi_cho_PM.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_dieu_phoi_cho_PM.Name = "m_cmd_dieu_phoi_cho_PM";
            this.m_cmd_dieu_phoi_cho_PM.Size = new System.Drawing.Size(905, 398);
            this.m_cmd_dieu_phoi_cho_PM.TabIndex = 1;
            // 
            // m_grc_ds_dieu_phoi_lai
            // 
            this.m_grc_ds_dieu_phoi_lai.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_dieu_phoi_lai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_dieu_phoi_lai.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_dieu_phoi_lai.MainView = this.m_grv_ds_dieu_phoi_lai;
            this.m_grc_ds_dieu_phoi_lai.Name = "m_grc_ds_dieu_phoi_lai";
            this.m_grc_ds_dieu_phoi_lai.Size = new System.Drawing.Size(905, 398);
            this.m_grc_ds_dieu_phoi_lai.TabIndex = 1;
            this.m_grc_ds_dieu_phoi_lai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_dieu_phoi_lai});
            // 
            // m_grv_ds_dieu_phoi_lai
            // 
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.EvenRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.EvenRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FixedLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FooterPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupButton.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupFooter.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.Options.UseImage = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HideSelectionRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HorzLine.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HorzLine.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.HorzLine.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.OddRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.OddRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(90)))));
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.Options.UseBorderColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Row.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Row.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.RowSeparator.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.RowSeparator.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_dieu_phoi_lai.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dieu_phoi_lai.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_dieu_phoi_lai.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.VertLine.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_dieu_phoi_lai.Appearance.VertLine.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.VertLine.Options.UseForeColor = true;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ViewCaption.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_dieu_phoi_lai.Appearance.ViewCaption.Options.UseBackColor = true;
            this.m_grv_ds_dieu_phoi_lai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_GD_DAT_HANG,
            this.NGUOI_NHAN_THAO_TAC,
            this.NGUOI_DAT_HANG,
            this.NOI_DUNG_DON_HANG,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.ID,
            this.DICH_VU_YEU_CAU});
            this.m_grv_ds_dieu_phoi_lai.GridControl = this.m_grc_ds_dieu_phoi_lai;
            this.m_grv_ds_dieu_phoi_lai.IndicatorWidth = 20;
            this.m_grv_ds_dieu_phoi_lai.Name = "m_grv_ds_dieu_phoi_lai";
            this.m_grv_ds_dieu_phoi_lai.OptionsBehavior.Editable = false;
            this.m_grv_ds_dieu_phoi_lai.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_dieu_phoi_lai.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_dieu_phoi_lai.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_dieu_phoi_lai.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_dieu_phoi_lai.OptionsView.ShowFooter = true;
            this.m_grv_ds_dieu_phoi_lai.PaintStyleName = "MixedXP";
            this.m_grv_ds_dieu_phoi_lai.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_ds_dieu_phoi_lai_CustomDrawRowIndicator);
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GD ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            this.ID_GD_DAT_HANG.Width = 97;
            // 
            // NGUOI_NHAN_THAO_TAC
            // 
            this.NGUOI_NHAN_THAO_TAC.Caption = "NGƯỜI NHẬN THAO TÁC";
            this.NGUOI_NHAN_THAO_TAC.Name = "NGUOI_NHAN_THAO_TAC";
            this.NGUOI_NHAN_THAO_TAC.Visible = true;
            this.NGUOI_NHAN_THAO_TAC.VisibleIndex = 2;
            this.NGUOI_NHAN_THAO_TAC.Width = 116;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.NGUOI_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 3;
            this.NGUOI_DAT_HANG.Width = 92;
            // 
            // NOI_DUNG_DON_HANG
            // 
            this.NOI_DUNG_DON_HANG.Caption = "NỘI DUNG ĐƠN HÀNG";
            this.NOI_DUNG_DON_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DON_HANG.Name = "NOI_DUNG_DON_HANG";
            this.NOI_DUNG_DON_HANG.Visible = true;
            this.NOI_DUNG_DON_HANG.VisibleIndex = 5;
            this.NOI_DUNG_DON_HANG.Width = 94;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "THỜI ĐIỂM CẦN HOÀN THÀNH";
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 6;
            this.THOI_DIEM_CAN_HOAN_THANH.Width = 92;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 97;
            // 
            // DICH_VU_YEU_CAU
            // 
            this.DICH_VU_YEU_CAU.Caption = "DỊCH VỤ YÊU CẦU ";
            this.DICH_VU_YEU_CAU.FieldName = "TEN_YEU_CAU";
            this.DICH_VU_YEU_CAU.Name = "DICH_VU_YEU_CAU";
            this.DICH_VU_YEU_CAU.Visible = true;
            this.DICH_VU_YEU_CAU.VisibleIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // f110_danh_sach_dieu_phoi_lai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 438);
            this.Controls.Add(this.m_cmd_dieu_phoi_cho_PM);
            this.Controls.Add(this.panel1);
            this.Name = "f110_danh_sach_dieu_phoi_lai";
            this.Text = "f110_Đơn hàng chờ điều phối lại";
            this.panel1.ResumeLayout(false);
            this.m_cmd_dieu_phoi_cho_PM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dieu_phoi_lai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dieu_phoi_lai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dieu_phoi_BO;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dieu_phoi_PM;
        private System.Windows.Forms.Panel m_cmd_dieu_phoi_cho_PM;
        private DevExpress.XtraGrid.GridControl m_grc_ds_dieu_phoi_lai;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_dieu_phoi_lai;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_NHAN_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DICH_VU_YEU_CAU;
        private System.Windows.Forms.Timer timer1;
    }
}