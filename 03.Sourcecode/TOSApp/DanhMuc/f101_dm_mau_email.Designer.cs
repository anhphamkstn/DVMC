namespace TOSApp.DanhMuc
{
    partial class f101_dm_mau_email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f101_dm_mau_email));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_dm_mau_email = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_mau_email = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_tieu_de_mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_noi_dung_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_gui_cc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpbtn_them = new DevExpress.XtraEditors.SimpleButton();
            this.simpbtn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.simpbtn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_mau_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_mau_email)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpbtn_xoa);
            this.panel1.Controls.Add(this.simpbtn_sua);
            this.panel1.Controls.Add(this.simpbtn_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(333, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 100);
            this.panel1.TabIndex = 4;
            // 
            // m_grc_dm_mau_email
            // 
            this.m_grc_dm_mau_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_mau_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_mau_email.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_mau_email.MainView = this.m_grv_dm_mau_email;
            this.m_grc_dm_mau_email.Name = "m_grc_dm_mau_email";
            this.m_grc_dm_mau_email.Size = new System.Drawing.Size(752, 261);
            this.m_grc_dm_mau_email.TabIndex = 2;
            this.m_grc_dm_mau_email.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_mau_email});
            // 
            // m_grv_dm_mau_email
            // 
            this.m_grv_dm_mau_email.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_tieu_de_mail,
            this.c_noi_dung_email,
            this.c_gui_cc,
            this.c_ma_email});
            this.m_grv_dm_mau_email.GridControl = this.m_grc_dm_mau_email;
            this.m_grv_dm_mau_email.Name = "m_grv_dm_mau_email";
            // 
            // c_tieu_de_mail
            // 
            this.c_tieu_de_mail.Caption = "Tiêu đề mail";
            this.c_tieu_de_mail.FieldName = "TIEU_DE_MAIL";
            this.c_tieu_de_mail.Name = "c_tieu_de_mail";
            this.c_tieu_de_mail.Visible = true;
            this.c_tieu_de_mail.VisibleIndex = 0;
            // 
            // c_noi_dung_email
            // 
            this.c_noi_dung_email.Caption = "Nội dung email";
            this.c_noi_dung_email.FieldName = "NOI_DUNG_EMAIL";
            this.c_noi_dung_email.Name = "c_noi_dung_email";
            this.c_noi_dung_email.Visible = true;
            this.c_noi_dung_email.VisibleIndex = 1;
            // 
            // c_gui_cc
            // 
            this.c_gui_cc.Caption = "Gửi CC";
            this.c_gui_cc.FieldName = "GUI_CC";
            this.c_gui_cc.Name = "c_gui_cc";
            this.c_gui_cc.Visible = true;
            this.c_gui_cc.VisibleIndex = 2;
            // 
            // c_ma_email
            // 
            this.c_ma_email.Caption = "Mã email";
            this.c_ma_email.FieldName = "MA_EMAIL";
            this.c_ma_email.Name = "c_ma_email";
            this.c_ma_email.Visible = true;
            this.c_ma_email.VisibleIndex = 3;
            // 
            // simpbtn_them
            // 
            this.simpbtn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpbtn_them.Appearance.Options.UseFont = true;
            this.simpbtn_them.Image = ((System.Drawing.Image)(resources.GetObject("simpbtn_them.Image")));
            this.simpbtn_them.Location = new System.Drawing.Point(31, 19);
            this.simpbtn_them.Name = "simpbtn_them";
            this.simpbtn_them.Size = new System.Drawing.Size(98, 45);
            this.simpbtn_them.TabIndex = 5;
            this.simpbtn_them.Text = "&Thêm";
            this.simpbtn_them.Click += new System.EventHandler(this.simpbtn_them_Click);
            // 
            // simpbtn_sua
            // 
            this.simpbtn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpbtn_sua.Appearance.Options.UseFont = true;
            this.simpbtn_sua.Image = ((System.Drawing.Image)(resources.GetObject("simpbtn_sua.Image")));
            this.simpbtn_sua.Location = new System.Drawing.Point(167, 19);
            this.simpbtn_sua.Name = "simpbtn_sua";
            this.simpbtn_sua.Size = new System.Drawing.Size(98, 45);
            this.simpbtn_sua.TabIndex = 6;
            this.simpbtn_sua.Text = "&Sửa";
            this.simpbtn_sua.Click += new System.EventHandler(this.simpbtn_sua_Click);
            // 
            // simpbtn_xoa
            // 
            this.simpbtn_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpbtn_xoa.Appearance.Options.UseFont = true;
            this.simpbtn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("simpbtn_xoa.Image")));
            this.simpbtn_xoa.Location = new System.Drawing.Point(295, 19);
            this.simpbtn_xoa.Name = "simpbtn_xoa";
            this.simpbtn_xoa.Size = new System.Drawing.Size(98, 45);
            this.simpbtn_xoa.TabIndex = 7;
            this.simpbtn_xoa.Text = "&Xóa";
            this.simpbtn_xoa.Click += new System.EventHandler(this.simpbtn_xoa_Click);
            // 
            // f101_dm_mau_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 361);
            this.Controls.Add(this.m_grc_dm_mau_email);
            this.Controls.Add(this.panel3);
            this.Name = "f101_dm_mau_email";
            this.Text = "f101_dm_mau_email";
            this.Load += new System.EventHandler(this.f101_dm_mau_email_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_mau_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_mau_email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_dm_mau_email;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_mau_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_tieu_de_mail;
        private DevExpress.XtraGrid.Columns.GridColumn c_noi_dung_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_gui_cc;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_email;
        private DevExpress.XtraEditors.SimpleButton simpbtn_them;
        private DevExpress.XtraEditors.SimpleButton simpbtn_sua;
        private DevExpress.XtraEditors.SimpleButton simpbtn_xoa;
    }
}