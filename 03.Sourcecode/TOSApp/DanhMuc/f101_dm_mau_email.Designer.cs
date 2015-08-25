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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_btn_xoa = new System.Windows.Forms.Button();
            this.m_btn_them = new System.Windows.Forms.Button();
            this.m_btn_sua = new System.Windows.Forms.Button();
            this.m_grc_dm_mau_email = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_mau_email = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_tieu_de_mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_noi_dung_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_gui_cc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_email = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.Controls.Add(this.m_btn_xoa);
            this.panel1.Controls.Add(this.m_btn_them);
            this.panel1.Controls.Add(this.m_btn_sua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(333, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 100);
            this.panel1.TabIndex = 4;
            // 
            // m_btn_xoa
            // 
            this.m_btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xoa.Location = new System.Drawing.Point(308, 33);
            this.m_btn_xoa.Name = "m_btn_xoa";
            this.m_btn_xoa.Size = new System.Drawing.Size(99, 45);
            this.m_btn_xoa.TabIndex = 3;
            this.m_btn_xoa.Text = "&Xóa";
            this.m_btn_xoa.UseVisualStyleBackColor = true;
            this.m_btn_xoa.Click += new System.EventHandler(this.m_btn_xoa_Click);
            // 
            // m_btn_them
            // 
            this.m_btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_them.Location = new System.Drawing.Point(10, 33);
            this.m_btn_them.Name = "m_btn_them";
            this.m_btn_them.Size = new System.Drawing.Size(99, 45);
            this.m_btn_them.TabIndex = 1;
            this.m_btn_them.Text = "&Thêm";
            this.m_btn_them.UseVisualStyleBackColor = true;
            this.m_btn_them.Click += new System.EventHandler(this.m_btn_them_Click);
            // 
            // m_btn_sua
            // 
            this.m_btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_sua.Location = new System.Drawing.Point(160, 33);
            this.m_btn_sua.Name = "m_btn_sua";
            this.m_btn_sua.Size = new System.Drawing.Size(99, 45);
            this.m_btn_sua.TabIndex = 2;
            this.m_btn_sua.Text = "&Sửa";
            this.m_btn_sua.UseVisualStyleBackColor = true;
            this.m_btn_sua.Click += new System.EventHandler(this.m_btn_sua_Click);
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
        private System.Windows.Forms.Button m_btn_xoa;
        private System.Windows.Forms.Button m_btn_them;
        private System.Windows.Forms.Button m_btn_sua;
        private DevExpress.XtraGrid.GridControl m_grc_dm_mau_email;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_mau_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_tieu_de_mail;
        private DevExpress.XtraGrid.Columns.GridColumn c_noi_dung_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_gui_cc;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_email;
    }
}