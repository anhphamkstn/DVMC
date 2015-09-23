namespace TOSApp.ChucNang
{
    partial class f106_danh_sach_don_hang_can_tiep_nhan_BO
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_tu_choi = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_tiep_nhan = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ds_don_hang_can_tiep_nhan = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_hang_can_tiep_nhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_TAO_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_XU_LY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_can_tiep_nhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_can_tiep_nhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_tu_choi);
            this.panel2.Controls.Add(this.m_cmd_tiep_nhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 58);
            this.panel2.TabIndex = 0;
            // 
            // m_cmd_tu_choi
            // 
            this.m_cmd_tu_choi.Location = new System.Drawing.Point(542, 23);
            this.m_cmd_tu_choi.Name = "m_cmd_tu_choi";
            this.m_cmd_tu_choi.Size = new System.Drawing.Size(89, 23);
            this.m_cmd_tu_choi.TabIndex = 0;
            this.m_cmd_tu_choi.Text = "Từ chối";
            this.m_cmd_tu_choi.Click += new System.EventHandler(this.m_cmd_tu_choi_Click);
            // 
            // m_cmd_tiep_nhan
            // 
            this.m_cmd_tiep_nhan.Location = new System.Drawing.Point(413, 23);
            this.m_cmd_tiep_nhan.Name = "m_cmd_tiep_nhan";
            this.m_cmd_tiep_nhan.Size = new System.Drawing.Size(89, 23);
            this.m_cmd_tiep_nhan.TabIndex = 0;
            this.m_cmd_tiep_nhan.Text = "Tiếp nhận";
            this.m_cmd_tiep_nhan.Click += new System.EventHandler(this.m_cmd_tiep_nhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_don_hang_can_tiep_nhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 289);
            this.panel1.TabIndex = 1;
            // 
            // m_grc_ds_don_hang_can_tiep_nhan
            // 
            this.m_grc_ds_don_hang_can_tiep_nhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_hang_can_tiep_nhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_don_hang_can_tiep_nhan.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_hang_can_tiep_nhan.MainView = this.m_grv_ds_don_hang_can_tiep_nhan;
            this.m_grc_ds_don_hang_can_tiep_nhan.Name = "m_grc_ds_don_hang_can_tiep_nhan";
            this.m_grc_ds_don_hang_can_tiep_nhan.Size = new System.Drawing.Size(654, 289);
            this.m_grc_ds_don_hang_can_tiep_nhan.TabIndex = 0;
            this.m_grc_ds_don_hang_can_tiep_nhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_hang_can_tiep_nhan});
            // 
            // m_grv_ds_don_hang_can_tiep_nhan
            // 
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Empty.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Empty.BackColor2 = System.Drawing.Color.Wheat;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FixedLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupButton.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupFooter.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupPanel.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupRow.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.Options.UseImage = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HorzLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.OddRow.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(90)))));
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.Options.UseBorderColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Row.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.RowSeparator.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.VertLine.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ViewCaption.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_don_hang_can_tiep_nhan.Appearance.ViewCaption.Options.UseBackColor = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_GD_DAT_HANG,
            this.NGUOI_TAO_THAO_TAC,
            this.NGUOI_DAT_HANG,
            this.NOI_DUNG_DON_HANG,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.NGUOI_XU_LY});
            this.m_grv_ds_don_hang_can_tiep_nhan.GridControl = this.m_grc_ds_don_hang_can_tiep_nhan;
            this.m_grv_ds_don_hang_can_tiep_nhan.Name = "m_grv_ds_don_hang_can_tiep_nhan";
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsBehavior.Editable = false;
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_don_hang_can_tiep_nhan.PaintStyleName = "MixedXP";
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GD ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            // 
            // NGUOI_TAO_THAO_TAC
            // 
            this.NGUOI_TAO_THAO_TAC.Caption = "TÊN TRUY CẬP";
            this.NGUOI_TAO_THAO_TAC.FieldName = "TEN_TRUY_CAP";
            this.NGUOI_TAO_THAO_TAC.Name = "NGUOI_TAO_THAO_TAC";
            this.NGUOI_TAO_THAO_TAC.Visible = true;
            this.NGUOI_TAO_THAO_TAC.VisibleIndex = 2;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.NGUOI_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 3;
            // 
            // NOI_DUNG_DON_HANG
            // 
            this.NOI_DUNG_DON_HANG.Caption = "NỘI DUNG ĐƠN HÀNG";
            this.NOI_DUNG_DON_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DON_HANG.Name = "NOI_DUNG_DON_HANG";
            this.NOI_DUNG_DON_HANG.Visible = true;
            this.NOI_DUNG_DON_HANG.VisibleIndex = 5;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "THỜI ĐIỂM CẦN HOÀN THÀNH";
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 4;
            // 
            // NGUOI_XU_LY
            // 
            this.NGUOI_XU_LY.Caption = "NGƯỜI XỬ LÝ";
            this.NGUOI_XU_LY.FieldName = "ID_NGUOI_NHAN_THAO_TAC";
            this.NGUOI_XU_LY.Name = "NGUOI_XU_LY";
            this.NGUOI_XU_LY.Visible = true;
            this.NGUOI_XU_LY.VisibleIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // f106_danh_sach_don_hang_can_tiep_nhan_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f106_danh_sach_don_hang_can_tiep_nhan_BO";
            this.Text = "f106_Đơn hàng cần tiếp nhận";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_hang_can_tiep_nhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_can_tiep_nhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tiep_nhan;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_tu_choi;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_hang_can_tiep_nhan;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_hang_can_tiep_nhan;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_TAO_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_XU_LY;
        private System.Windows.Forms.Timer timer1;
    }
}