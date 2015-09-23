namespace TOSApp.DanhMuc
{
    partial class f102_dm_loai_yeu_cau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f102_dm_loai_yeu_cau));
            this.m_grc_dm_loai_yeu_cau = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_yeu_cau = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ten_yeu_cau_cha_cha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_yeu_cau_cha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_diem_khoi_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_thoi_gian_xu_ly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_pan_button = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_yeu_cau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_yeu_cau)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.m_pan_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_loai_yeu_cau
            // 
            this.m_grc_dm_loai_yeu_cau.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_yeu_cau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_loai_yeu_cau.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_loai_yeu_cau.MainView = this.m_grv_dm_loai_yeu_cau;
            this.m_grc_dm_loai_yeu_cau.Name = "m_grc_dm_loai_yeu_cau";
            this.m_grc_dm_loai_yeu_cau.Size = new System.Drawing.Size(800, 383);
            this.m_grc_dm_loai_yeu_cau.TabIndex = 0;
            this.m_grc_dm_loai_yeu_cau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_loai_yeu_cau});
            // 
            // m_grv_dm_loai_yeu_cau
            // 
            this.m_grv_dm_loai_yeu_cau.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ten_yeu_cau_cha_cha,
            this.c_ten_yeu_cau_cha,
            this.c_dich_vu,
            this.c_diem_khoi_luong,
            this.c_thoi_gian_xu_ly});
            this.m_grv_dm_loai_yeu_cau.GridControl = this.m_grc_dm_loai_yeu_cau;
            this.m_grv_dm_loai_yeu_cau.Name = "m_grv_dm_loai_yeu_cau";
            this.m_grv_dm_loai_yeu_cau.NewItemRowText = "Thêm mới dịch vụ";
            this.m_grv_dm_loai_yeu_cau.OptionsBehavior.Editable = false;
            this.m_grv_dm_loai_yeu_cau.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.m_grv_dm_loai_yeu_cau.OptionsBehavior.ReadOnly = true;
            this.m_grv_dm_loai_yeu_cau.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.m_grv_dm_loai_yeu_cau.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_dm_loai_yeu_cau.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.m_grv_dm_loai_yeu_cau_RowStyle);
            this.m_grv_dm_loai_yeu_cau.DoubleClick += new System.EventHandler(this.m_grv_dm_loai_yeu_cau_DoubleClick);
            // 
            // c_ten_yeu_cau_cha_cha
            // 
            this.c_ten_yeu_cau_cha_cha.Caption = "Loại dịch vụ";
            this.c_ten_yeu_cau_cha_cha.FieldName = "TEN_YEU_CAU_CHA_CHA";
            this.c_ten_yeu_cau_cha_cha.Name = "c_ten_yeu_cau_cha_cha";
            this.c_ten_yeu_cau_cha_cha.Visible = true;
            this.c_ten_yeu_cau_cha_cha.VisibleIndex = 1;
            // 
            // c_ten_yeu_cau_cha
            // 
            this.c_ten_yeu_cau_cha.Caption = "Nhóm dịch vụ";
            this.c_ten_yeu_cau_cha.FieldName = "TEN_YEU_CAU_CHA";
            this.c_ten_yeu_cau_cha.Name = "c_ten_yeu_cau_cha";
            this.c_ten_yeu_cau_cha.OptionsEditForm.ColumnSpan = 3;
            this.c_ten_yeu_cau_cha.Visible = true;
            this.c_ten_yeu_cau_cha.VisibleIndex = 2;
            // 
            // c_dich_vu
            // 
            this.c_dich_vu.Caption = "Dịch vụ";
            this.c_dich_vu.FieldName = "TEN_YEU_CAU";
            this.c_dich_vu.Name = "c_dich_vu";
            this.c_dich_vu.Visible = true;
            this.c_dich_vu.VisibleIndex = 0;
            // 
            // c_diem_khoi_luong
            // 
            this.c_diem_khoi_luong.Caption = "Điểm khối lượng";
            this.c_diem_khoi_luong.FieldName = "DIEM_KHOI_LUONG";
            this.c_diem_khoi_luong.Name = "c_diem_khoi_luong";
            this.c_diem_khoi_luong.Visible = true;
            this.c_diem_khoi_luong.VisibleIndex = 3;
            this.c_diem_khoi_luong.Width = 83;
            // 
            // c_thoi_gian_xu_ly
            // 
            this.c_thoi_gian_xu_ly.Caption = "Thời gian xử lý";
            this.c_thoi_gian_xu_ly.FieldName = "THOI_GIAN_XU_LY";
            this.c_thoi_gian_xu_ly.Name = "c_thoi_gian_xu_ly";
            this.c_thoi_gian_xu_ly.Visible = true;
            this.c_thoi_gian_xu_ly.VisibleIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_dm_loai_yeu_cau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 383);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_cmd_xoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(610, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 53);
            this.panel4.TabIndex = 1;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xoa.Appearance.Options.UseFont = true;
            this.m_cmd_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(190, 53);
            this.m_cmd_xoa.TabIndex = 5;
            this.m_cmd_xoa.Text = "&Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.simpbtn_xoa_Click);
            // 
            // m_pan_button
            // 
            this.m_pan_button.Controls.Add(this.panel4);
            this.m_pan_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pan_button.Location = new System.Drawing.Point(0, 383);
            this.m_pan_button.Name = "m_pan_button";
            this.m_pan_button.Size = new System.Drawing.Size(800, 53);
            this.m_pan_button.TabIndex = 1;
            // 
            // f102_dm_loai_yeu_cau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.m_pan_button);
            this.Name = "f102_dm_loai_yeu_cau";
            this.Text = "Danh mục dịch vụ";
            this.Load += new System.EventHandler(this.f102_dm_loai_yeu_cau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_yeu_cau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_yeu_cau)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.m_pan_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_loai_yeu_cau;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_loai_yeu_cau;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_yeu_cau_cha_cha;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_yeu_cau_cha;
        private DevExpress.XtraGrid.Columns.GridColumn c_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_diem_khoi_luong;
        private DevExpress.XtraGrid.Columns.GridColumn c_thoi_gian_xu_ly;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private System.Windows.Forms.Panel m_pan_button;
    }
}