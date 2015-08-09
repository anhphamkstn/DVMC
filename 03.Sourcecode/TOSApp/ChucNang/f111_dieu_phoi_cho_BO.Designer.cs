namespace TOSApp.ChucNang
{
    partial class f111_dieu_phoi_cho_BO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_grc_ht_nguoi_su_dung = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ht_nguoi_su_dung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HO_VA_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 63);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Location = new System.Drawing.Point(724, 19);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Cancel";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Location = new System.Drawing.Point(597, 19);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GroupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 345);
            this.panel2.TabIndex = 1;
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.m_grc_ht_nguoi_su_dung);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(826, 345);
            this.GroupControl1.TabIndex = 6;
            this.GroupControl1.Text = "Danh sách người xử lý";
            // 
            // m_grc_ht_nguoi_su_dung
            // 
            this.m_grc_ht_nguoi_su_dung.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ht_nguoi_su_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ht_nguoi_su_dung.Location = new System.Drawing.Point(2, 21);
            this.m_grc_ht_nguoi_su_dung.MainView = this.m_grv_ht_nguoi_su_dung;
            this.m_grc_ht_nguoi_su_dung.Name = "m_grc_ht_nguoi_su_dung";
            this.m_grc_ht_nguoi_su_dung.Size = new System.Drawing.Size(822, 322);
            this.m_grc_ht_nguoi_su_dung.TabIndex = 0;
            this.m_grc_ht_nguoi_su_dung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ht_nguoi_su_dung});
            // 
            // m_grv_ht_nguoi_su_dung
            // 
            this.m_grv_ht_nguoi_su_dung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HO_VA_TEN,
            this.EMAIL,
            this.ID});
            this.m_grv_ht_nguoi_su_dung.GridControl = this.m_grc_ht_nguoi_su_dung;
            this.m_grv_ht_nguoi_su_dung.Name = "m_grv_ht_nguoi_su_dung";
            this.m_grv_ht_nguoi_su_dung.OptionsSelection.MultiSelect = true;
            this.m_grv_ht_nguoi_su_dung.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // HO_VA_TEN
            // 
            this.HO_VA_TEN.Caption = "HỌ VÀ TÊN";
            this.HO_VA_TEN.FieldName = "TEN";
            this.HO_VA_TEN.Name = "HO_VA_TEN";
            this.HO_VA_TEN.Visible = true;
            this.HO_VA_TEN.VisibleIndex = 2;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "EMAIL";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 3;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            // 
            // f111_dieu_phoi_cho_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f111_dieu_phoi_cho_BO";
            this.Text = "f111_ds_chon_BO";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ht_nguoi_su_dung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ht_nguoi_su_dung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraGrid.GridControl m_grc_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ht_nguoi_su_dung;
        private DevExpress.XtraGrid.Columns.GridColumn HO_VA_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}