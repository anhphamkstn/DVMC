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
            this.m_pan_button = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_dm_mau_email = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_mau_email = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_tieu_de_mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_noi_dung_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_gui_cc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pan_button.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_mau_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_mau_email)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pan_button
            // 
            this.m_pan_button.Controls.Add(this.panel1);
            this.m_pan_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pan_button.Location = new System.Drawing.Point(0, 305);
            this.m_pan_button.Name = "m_pan_button";
            this.m_pan_button.Size = new System.Drawing.Size(752, 56);
            this.m_pan_button.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_xoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(562, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 56);
            this.panel1.TabIndex = 4;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xoa.Appearance.Options.UseFont = true;
            this.m_cmd_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(190, 56);
            this.m_cmd_xoa.TabIndex = 7;
            this.m_cmd_xoa.Text = "&Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.simpbtn_xoa_Click);
            // 
            // m_grc_dm_mau_email
            // 
            this.m_grc_dm_mau_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_mau_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_mau_email.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_mau_email.MainView = this.m_grv_dm_mau_email;
            this.m_grc_dm_mau_email.Name = "m_grc_dm_mau_email";
            this.m_grc_dm_mau_email.Size = new System.Drawing.Size(752, 305);
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
            this.m_grv_dm_mau_email.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.m_grv_dm_mau_email.OptionsBehavior.ReadOnly = true;
            this.m_grv_dm_mau_email.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.m_grv_dm_mau_email.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.m_grv_dm_mau_email_RowCellClick);
            this.m_grv_dm_mau_email.DoubleClick += new System.EventHandler(this.m_grv_dm_mau_email_DoubleClick);
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
            this.Controls.Add(this.m_pan_button);
            this.Name = "f101_dm_mau_email";
            this.Text = "f101_dm_mau_email";
            this.Load += new System.EventHandler(this.f101_dm_mau_email_Load);
            this.m_pan_button.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_mau_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_mau_email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_pan_button;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_dm_mau_email;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_mau_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_tieu_de_mail;
        private DevExpress.XtraGrid.Columns.GridColumn c_noi_dung_email;
        private DevExpress.XtraGrid.Columns.GridColumn c_gui_cc;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_email;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
    }
}