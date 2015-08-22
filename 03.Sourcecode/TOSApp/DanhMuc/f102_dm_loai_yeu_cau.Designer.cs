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
            this.m_grc_dm_loai_yeu_cau = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_loai_yeu_cau = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ten_yeu_cau_cha_cha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_yeu_cau_cha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_diem_khoi_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_thoi_gian_xu_ly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_btn_them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_sua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_btn_xoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_yeu_cau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_yeu_cau)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_loai_yeu_cau
            // 
            this.m_grc_dm_loai_yeu_cau.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_loai_yeu_cau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_loai_yeu_cau.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_loai_yeu_cau.MainView = this.m_grv_dm_loai_yeu_cau;
            this.m_grc_dm_loai_yeu_cau.Name = "m_grc_dm_loai_yeu_cau";
            this.m_grc_dm_loai_yeu_cau.Size = new System.Drawing.Size(800, 346);
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
            this.m_grv_dm_loai_yeu_cau.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv_dm_loai_yeu_cau.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // c_ten_yeu_cau_cha_cha
            // 
            this.c_ten_yeu_cau_cha_cha.Caption = "Loại dịch vụ";
            this.c_ten_yeu_cau_cha_cha.FieldName = "TEN_YEU_CAU_CHA_CHA";
            this.c_ten_yeu_cau_cha_cha.Name = "c_ten_yeu_cau_cha_cha";
            this.c_ten_yeu_cau_cha_cha.Visible = true;
            this.c_ten_yeu_cau_cha_cha.VisibleIndex = 2;
            // 
            // c_ten_yeu_cau_cha
            // 
            this.c_ten_yeu_cau_cha.Caption = "Nhóm dịch vụ";
            this.c_ten_yeu_cau_cha.FieldName = "TEN_YEU_CAU_CHA";
            this.c_ten_yeu_cau_cha.Name = "c_ten_yeu_cau_cha";
            this.c_ten_yeu_cau_cha.OptionsEditForm.ColumnSpan = 3;
            this.c_ten_yeu_cau_cha.Visible = true;
            this.c_ten_yeu_cau_cha.VisibleIndex = 1;
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
            // 
            // c_thoi_gian_xu_ly
            // 
            this.c_thoi_gian_xu_ly.Caption = "Thời gian xử lý";
            this.c_thoi_gian_xu_ly.FieldName = "TEN";
            this.c_thoi_gian_xu_ly.Name = "c_thoi_gian_xu_ly";
            this.c_thoi_gian_xu_ly.Visible = true;
            this.c_thoi_gian_xu_ly.VisibleIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_btn_them);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(383, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 90);
            this.panel5.TabIndex = 2;
            // 
            // m_btn_them
            // 
            this.m_btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_them.Location = new System.Drawing.Point(19, 30);
            this.m_btn_them.Name = "m_btn_them";
            this.m_btn_them.Size = new System.Drawing.Size(105, 48);
            this.m_btn_them.TabIndex = 0;
            this.m_btn_them.Text = "&Thêm";
            this.m_btn_them.UseVisualStyleBackColor = true;
            this.m_btn_them.Click += new System.EventHandler(this.m_btn_them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_btn_sua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(522, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 90);
            this.panel2.TabIndex = 2;
            // 
            // m_btn_sua
            // 
            this.m_btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_sua.Location = new System.Drawing.Point(17, 30);
            this.m_btn_sua.Name = "m_btn_sua";
            this.m_btn_sua.Size = new System.Drawing.Size(105, 48);
            this.m_btn_sua.TabIndex = 1;
            this.m_btn_sua.Text = "&Sửa";
            this.m_btn_sua.UseVisualStyleBackColor = true;
            this.m_btn_sua.Click += new System.EventHandler(this.m_btn_sua_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_btn_xoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(661, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 90);
            this.panel4.TabIndex = 1;
            // 
            // m_btn_xoa
            // 
            this.m_btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xoa.Location = new System.Drawing.Point(22, 30);
            this.m_btn_xoa.Name = "m_btn_xoa";
            this.m_btn_xoa.Size = new System.Drawing.Size(105, 48);
            this.m_btn_xoa.TabIndex = 2;
            this.m_btn_xoa.Text = "&Xóa";
            this.m_btn_xoa.UseVisualStyleBackColor = true;
            this.m_btn_xoa.Click += new System.EventHandler(this.m_btn_xoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_dm_loai_yeu_cau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 346);
            this.panel3.TabIndex = 2;
            // 
            // f102_dm_loai_yeu_cau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "f102_dm_loai_yeu_cau";
            this.Text = "f102_dm_loai_yeu_cau";
            this.Load += new System.EventHandler(this.f102_dm_loai_yeu_cau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_loai_yeu_cau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_loai_yeu_cau)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_btn_xoa;
        private System.Windows.Forms.Button m_btn_sua;
        private System.Windows.Forms.Button m_btn_them;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}