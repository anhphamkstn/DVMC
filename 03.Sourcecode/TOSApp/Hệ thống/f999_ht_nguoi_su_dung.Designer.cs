namespace TOSApp.Hệ_thống
{
    partial class f999_ht_nguoi_su_dung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f999_ht_nguoi_su_dung));
            this.m_grc_ht_nguoi_su_dung = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ht_nguoi_su_dung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ten_truy_cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_mat_khau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ngay_tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nguoi_tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_built_in_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_mat_khau_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpbtn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpbtn_them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_ht_nguoi_su_dung
            // 
            this.m_grc_ht_nguoi_su_dung.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ht_nguoi_su_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ht_nguoi_su_dung.Location = new System.Drawing.Point(3, 3);
            this.m_grc_ht_nguoi_su_dung.MainView = this.m_grv_ht_nguoi_su_dung;
            this.m_grc_ht_nguoi_su_dung.Name = "m_grc_ht_nguoi_su_dung";
            this.m_grc_ht_nguoi_su_dung.Size = new System.Drawing.Size(755, 317);
            this.m_grc_ht_nguoi_su_dung.TabIndex = 0;
            this.m_grc_ht_nguoi_su_dung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ht_nguoi_su_dung});
            // 
            // m_grv_ht_nguoi_su_dung
            // 
            this.m_grv_ht_nguoi_su_dung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ten_truy_cap,
            this.c_mat_khau,
            this.c_ten,
            this.c_ngay_tao,
            this.c_nguoi_tao,
            this.c_trang_thai,
            this.c_built_in_yn,
            this.c_email,
            this.c_mat_khau_email});
            this.m_grv_ht_nguoi_su_dung.GridControl = this.m_grc_ht_nguoi_su_dung;
            this.m_grv_ht_nguoi_su_dung.Name = "m_grv_ht_nguoi_su_dung";
            // 
            // c_ten_truy_cap
            // 
            this.c_ten_truy_cap.Caption = "Tên truy cập";
            this.c_ten_truy_cap.FieldName = "TEN_TRUY_CAP";
            this.c_ten_truy_cap.Name = "c_ten_truy_cap";
            this.c_ten_truy_cap.Visible = true;
            this.c_ten_truy_cap.VisibleIndex = 0;
            // 
            // c_mat_khau
            // 
            this.c_mat_khau.Caption = "Mật khẩu";
            this.c_mat_khau.FieldName = "MAT_KHAU";
            this.c_mat_khau.Name = "c_mat_khau";
            this.c_mat_khau.Visible = true;
            this.c_mat_khau.VisibleIndex = 1;
            // 
            // c_ten
            // 
            this.c_ten.Caption = "Tên";
            this.c_ten.FieldName = "TEN";
            this.c_ten.Name = "c_ten";
            this.c_ten.Visible = true;
            this.c_ten.VisibleIndex = 2;
            // 
            // c_ngay_tao
            // 
            this.c_ngay_tao.Caption = "Ngày tạo";
            this.c_ngay_tao.FieldName = "NGAY_TAO";
            this.c_ngay_tao.Name = "c_ngay_tao";
            this.c_ngay_tao.Visible = true;
            this.c_ngay_tao.VisibleIndex = 3;
            // 
            // c_nguoi_tao
            // 
            this.c_nguoi_tao.Caption = "Người tạo";
            this.c_nguoi_tao.FieldName = "NGUOI_TAO";
            this.c_nguoi_tao.Name = "c_nguoi_tao";
            this.c_nguoi_tao.Visible = true;
            this.c_nguoi_tao.VisibleIndex = 4;
            // 
            // c_trang_thai
            // 
            this.c_trang_thai.Caption = "Trạng thái";
            this.c_trang_thai.FieldName = "TRANG_THAI";
            this.c_trang_thai.Name = "c_trang_thai";
            this.c_trang_thai.Visible = true;
            this.c_trang_thai.VisibleIndex = 5;
            // 
            // c_built_in_yn
            // 
            this.c_built_in_yn.Caption = "Built in YN";
            this.c_built_in_yn.FieldName = "BUILT_IN_YN";
            this.c_built_in_yn.Name = "c_built_in_yn";
            this.c_built_in_yn.Visible = true;
            this.c_built_in_yn.VisibleIndex = 6;
            // 
            // c_email
            // 
            this.c_email.Caption = "Email";
            this.c_email.FieldName = "EMAIL";
            this.c_email.Name = "c_email";
            this.c_email.Visible = true;
            this.c_email.VisibleIndex = 7;
            // 
            // c_mat_khau_email
            // 
            this.c_mat_khau_email.Caption = "Mật khẩu email";
            this.c_mat_khau_email.FieldName = "MAT_KHAU_EMAIL";
            this.c_mat_khau_email.Name = "c_mat_khau_email";
            this.c_mat_khau_email.Visible = true;
            this.c_mat_khau_email.VisibleIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_grc_ht_nguoi_su_dung, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 404);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(448, 326);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 75);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpbtn_sua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(158, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 69);
            this.panel2.TabIndex = 5;
            // 
            // simpbtn_sua
            // 
            this.simpbtn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpbtn_sua.Appearance.Options.UseFont = true;
            this.simpbtn_sua.Image = ((System.Drawing.Image)(resources.GetObject("simpbtn_sua.Image")));
            this.simpbtn_sua.Location = new System.Drawing.Point(22, 7);
            this.simpbtn_sua.Name = "simpbtn_sua";
            this.simpbtn_sua.Size = new System.Drawing.Size(106, 55);
            this.simpbtn_sua.TabIndex = 1;
            this.simpbtn_sua.Text = "&Sửa";
            this.simpbtn_sua.Click += new System.EventHandler(this.simpbtn_sua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpbtn_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 69);
            this.panel1.TabIndex = 4;
            // 
            // simpbtn_them
            // 
            this.simpbtn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpbtn_them.Appearance.Options.UseFont = true;
            this.simpbtn_them.Image = ((System.Drawing.Image)(resources.GetObject("simpbtn_them.Image")));
            this.simpbtn_them.Location = new System.Drawing.Point(24, 7);
            this.simpbtn_them.Name = "simpbtn_them";
            this.simpbtn_them.Size = new System.Drawing.Size(106, 55);
            this.simpbtn_them.TabIndex = 0;
            this.simpbtn_them.Text = "&Thêm";
            this.simpbtn_them.Click += new System.EventHandler(this.simpbtn_them_Click);
            // 
            // f999_ht_nguoi_su_dung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 404);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f999_ht_nguoi_su_dung";
            this.Text = "f999_ht_nguoi_su_dung";
            this.Load += new System.EventHandler(this.f999_ht_nguoi_su_dung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_truy_cap;
        private DevExpress.XtraGrid.Columns.GridColumn c_mat_khau;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten;
        private DevExpress.XtraGrid.Columns.GridColumn c_ngay_tao;
        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_tao;
        private DevExpress.XtraGrid.Columns.GridColumn c_trang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn c_built_in_yn;
        private DevExpress.XtraGrid.Columns.GridColumn c_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_mat_khau_email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpbtn_sua;
        private DevExpress.XtraEditors.SimpleButton simpbtn_them;
    }
}