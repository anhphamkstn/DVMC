namespace TOSApp.ChucNang
{
    partial class f127_ds_don_hang_hoan_thanh_chua_danh_gia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc_ds_dh_ht_chua_danh_gia = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_don_hang_ht_chua_danh_gia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dh_ht_chua_danh_gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_ht_chua_danh_gia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_dh_ht_chua_danh_gia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 184);
            this.panel2.TabIndex = 1;
            // 
            // m_grc_ds_dh_ht_chua_danh_gia
            // 
            this.m_grc_ds_dh_ht_chua_danh_gia.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_dh_ht_chua_danh_gia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_dh_ht_chua_danh_gia.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_dh_ht_chua_danh_gia.MainView = this.m_grv_ds_don_hang_ht_chua_danh_gia;
            this.m_grc_ds_dh_ht_chua_danh_gia.Name = "m_grc_ds_dh_ht_chua_danh_gia";
            this.m_grc_ds_dh_ht_chua_danh_gia.Size = new System.Drawing.Size(1106, 184);
            this.m_grc_ds_dh_ht_chua_danh_gia.TabIndex = 0;
            this.m_grc_ds_dh_ht_chua_danh_gia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_hang_ht_chua_danh_gia});
            // 
            // m_grv_ds_don_hang_ht_chua_danh_gia
            // 
            this.m_grv_ds_don_hang_ht_chua_danh_gia.GridControl = this.m_grc_ds_dh_ht_chua_danh_gia;
            this.m_grv_ds_don_hang_ht_chua_danh_gia.Name = "m_grv_ds_don_hang_ht_chua_danh_gia";
            // 
            // f127_ds_don_hang_hoan_thanh_chua_danh_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f127_ds_don_hang_hoan_thanh_chua_danh_gia";
            this.Text = "f127_ds_don_hang_hoan_thanh_chua_danh_gia";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dh_ht_chua_danh_gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_hang_ht_chua_danh_gia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl m_grc_ds_dh_ht_chua_danh_gia;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_hang_ht_chua_danh_gia;
    }
}