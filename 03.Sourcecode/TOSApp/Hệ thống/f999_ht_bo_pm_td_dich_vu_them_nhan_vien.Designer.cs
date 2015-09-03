namespace TOSApp.Hệ_thống
{
    partial class f999_ht_bo_pm_td_dich_vu_them_nhan_vien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f999_ht_bo_pm_td_dich_vu_them_nhan_vien));
            this.grc_danh_sach = new DevExpress.XtraGrid.GridControl();
            this.grv_danh_sach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_cmd_ok = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grc_danh_sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danh_sach)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grc_danh_sach
            // 
            this.grc_danh_sach.Cursor = System.Windows.Forms.Cursors.Default;
            this.grc_danh_sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_danh_sach.Location = new System.Drawing.Point(0, 0);
            this.grc_danh_sach.MainView = this.grv_danh_sach;
            this.grc_danh_sach.Name = "grc_danh_sach";
            this.grc_danh_sach.Size = new System.Drawing.Size(563, 209);
            this.grc_danh_sach.TabIndex = 4;
            this.grc_danh_sach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_danh_sach});
            // 
            // grv_danh_sach
            // 
            this.grv_danh_sach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ds});
            this.grv_danh_sach.GridControl = this.grc_danh_sach;
            this.grv_danh_sach.Name = "grv_danh_sach";
            this.grv_danh_sach.OptionsBehavior.Editable = false;
            this.grv_danh_sach.OptionsSelection.MultiSelect = true;
            this.grv_danh_sach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // c_ds
            // 
            this.c_ds.Caption = "Danh sách";
            this.c_ds.FieldName = "TEN";
            this.c_ds.Name = "c_ds";
            this.c_ds.Visible = true;
            this.c_ds.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 52);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grc_danh_sach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 209);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(436, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 52);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_cmd_thoat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 52);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_cmd_ok);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(309, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 52);
            this.panel5.TabIndex = 2;
            // 
            // m_cmd_ok
            // 
            this.m_cmd_ok.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_ok.Appearance.Options.UseFont = true;
            this.m_cmd_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_ok.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_ok.Image")));
            this.m_cmd_ok.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_ok.Name = "m_cmd_ok";
            this.m_cmd_ok.Size = new System.Drawing.Size(127, 52);
            this.m_cmd_ok.TabIndex = 6;
            this.m_cmd_ok.Text = "&OK";
            this.m_cmd_ok.Click += new System.EventHandler(this.m_cmd_ok_Click);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_thoat.Appearance.Options.UseFont = true;
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_thoat.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_thoat.Image")));
            this.m_cmd_thoat.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(127, 52);
            this.m_cmd_thoat.TabIndex = 9;
            this.m_cmd_thoat.Text = "&Thoát";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // f999_ht_bo_pm_td_dich_vu_them_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f999_ht_bo_pm_td_dich_vu_them_nhan_vien";
            this.Text = "f999_ht_bo_pm_td_dich_vu_them_nhan_vien";
            this.Load += new System.EventHandler(this.f999_ht_bo_pm_td_dich_vu_them_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grc_danh_sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danh_sach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grc_danh_sach;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_danh_sach;
        private DevExpress.XtraGrid.Columns.GridColumn c_ds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_ok;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
    }
}