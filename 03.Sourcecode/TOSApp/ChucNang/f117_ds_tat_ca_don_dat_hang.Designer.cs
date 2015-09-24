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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f117_ds_tat_ca_don_dat_hang));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_chinh_sua_don_hang = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_grc_ds_don_dat_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_dat_hang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_dat_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_dat_hang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tất cả các đơn hàng đang xử lý";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 53);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_chinh_sua_don_hang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1013, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 53);
            this.panel3.TabIndex = 0;
            // 
            // m_cmd_chinh_sua_don_hang
            // 
            this.m_cmd_chinh_sua_don_hang.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_chinh_sua_don_hang.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_cmd_chinh_sua_don_hang.Appearance.Options.UseFont = true;
            this.m_cmd_chinh_sua_don_hang.Appearance.Options.UseForeColor = true;
            this.m_cmd_chinh_sua_don_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_chinh_sua_don_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_chinh_sua_don_hang.Image")));
            this.m_cmd_chinh_sua_don_hang.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_chinh_sua_don_hang.Name = "m_cmd_chinh_sua_don_hang";
            this.m_cmd_chinh_sua_don_hang.Size = new System.Drawing.Size(200, 53);
            this.m_cmd_chinh_sua_don_hang.TabIndex = 2;
            this.m_cmd_chinh_sua_don_hang.Text = "Cập nhật ";
            this.m_cmd_chinh_sua_don_hang.Click += new System.EventHandler(this.m_cmd_chinh_sua_don_hang_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1213, 344);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_grc_ds_don_dat_hang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1213, 238);
            this.panel5.TabIndex = 2;
            // 
            // m_grc_ds_don_dat_hang
            // 
            this.m_grc_ds_don_dat_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_dat_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_dat_hang.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_dat_hang.MainView = this.m_grv_ds_don_dat_hang;
            this.m_grc_ds_don_dat_hang.Name = "m_grc_ds_don_dat_hang";
            this.m_grc_ds_don_dat_hang.Size = new System.Drawing.Size(1213, 238);
            this.m_grc_ds_don_dat_hang.TabIndex = 0;
            this.m_grc_ds_don_dat_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_dat_hang});
            // 
            // m_grv_ds_don_dat_hang
            // 
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.EvenRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_don_dat_hang.Appearance.EvenRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_dat_hang.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_dat_hang.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FilterPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FixedLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_dat_hang.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_ds_don_dat_hang.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FooterPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_dat_hang.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_dat_hang.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupButton.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupFooter.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_don_dat_hang.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_don_dat_hang.Appearance.GroupRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.Options.UseImage = true;
            this.m_grv_ds_don_dat_hang.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv_ds_don_dat_hang.Appearance.HideSelectionRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HorzLine.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.HorzLine.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.HorzLine.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.OddRow.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_don_dat_hang.Appearance.OddRow.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_don_dat_hang.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_don_dat_hang.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_don_dat_hang.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(90)))));
            this.m_grv_ds_don_dat_hang.Appearance.Preview.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.Preview.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_don_dat_hang.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.Row.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.Row.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.RowSeparator.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.RowSeparator.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_don_dat_hang.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.VertLine.BackColor = System.Drawing.SystemColors.Control;
            this.m_grv_ds_don_dat_hang.Appearance.VertLine.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.VertLine.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang.Appearance.ViewCaption.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_dat_hang.Appearance.ViewCaption.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_grv_ds_don_dat_hang.AppearancePrint.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_grv_ds_don_dat_hang.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_grv_ds_don_dat_hang.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang.AppearancePrint.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DON_HANG,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.gridColumn9,
            this.gridColumn1,
            this.gridColumn10,
            this.gridColumn11});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[THOI_DIEM_CAN_HOAN_THANH] <= GetDate(AddHours(Today(),12) )   And  [THOI_DIEM_CA" +
    "N_HOAN_THANH] >=GetDate( AddDays(Today(),-1 ) )";
            this.m_grv_ds_don_dat_hang.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.m_grv_ds_don_dat_hang.GridControl = this.m_grc_ds_don_dat_hang;
            this.m_grv_ds_don_dat_hang.Name = "m_grv_ds_don_dat_hang";
            this.m_grv_ds_don_dat_hang.OptionsBehavior.Editable = false;
            this.m_grv_ds_don_dat_hang.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.m_grv_ds_don_dat_hang.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_don_dat_hang.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_don_dat_hang.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_don_dat_hang.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_don_dat_hang.PaintStyleName = "MixedXP";
            this.m_grv_ds_don_dat_hang.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Descending)});
            this.m_grv_ds_don_dat_hang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.m_grv_ds_don_dat_hang_RowCellClick);
            this.m_grv_ds_don_dat_hang.DoubleClick += new System.EventHandler(this.m_grv_ds_don_dat_hang_DoubleClick);
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "Mã đơn hàng";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 0;
            this.MA_DON_HANG.Width = 110;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ tên User đặt hàng";
            this.gridColumn2.FieldName = "HO_TEN_USER_DAT_HANG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 139;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điện thoại";
            this.gridColumn3.FieldName = "DIEN_THOAI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 106;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Dịch vụ yêu cầu";
            this.gridColumn5.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 108;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nội dung đặt hàng";
            this.gridColumn6.FieldName = "NOI_DUNG_DAT_HANG";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 108;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đơn vị";
            this.gridColumn7.FieldName = "MA_DON_VI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 61;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "thời điểm cần hoàn thành";
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 6;
            this.THOI_DIEM_CAN_HOAN_THANH.Width = 139;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Thời gian tạo";
            this.gridColumn9.FieldName = "THOI_GIAN_TAO";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 103;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Phương thức đặt hàng";
            this.gridColumn1.FieldName = "TEN_PHUONG_THUC_DAT_HANG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 164;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Người tạo";
            this.gridColumn10.FieldName = "NGUOI_TAO_THAO_TAC";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 74;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Chi nhánh";
            this.gridColumn11.FieldName = "TEN_CHI_NHANH";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 86;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // f117_ds_tat_ca_don_dat_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 344);
            this.Controls.Add(this.panel4);
            this.Name = "f117_ds_tat_ca_don_dat_hang";
            this.Text = "f117_Danh sách tất cả đơn hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_dat_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_dat_hang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chinh_sua_don_hang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_dat_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_dat_hang;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}