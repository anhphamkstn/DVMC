namespace TOSApp.ChucNang
{
    partial class f108_danh_sach_don_hang_hoa_thanh
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_cmd_nghiem_thu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xu_ly_lai = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_xu_ly_lai);
            this.panel1.Controls.Add(this.m_cmd_nghiem_thu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 304);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(933, 304);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // m_cmd_nghiem_thu
            // 
            this.m_cmd_nghiem_thu.Location = new System.Drawing.Point(635, 26);
            this.m_cmd_nghiem_thu.Name = "m_cmd_nghiem_thu";
            this.m_cmd_nghiem_thu.Size = new System.Drawing.Size(104, 23);
            this.m_cmd_nghiem_thu.TabIndex = 0;
            this.m_cmd_nghiem_thu.Text = "Nghiệm thu";
            // 
            // m_cmd_xu_ly_lai
            // 
            this.m_cmd_xu_ly_lai.Location = new System.Drawing.Point(791, 26);
            this.m_cmd_xu_ly_lai.Name = "m_cmd_xu_ly_lai";
            this.m_cmd_xu_ly_lai.Size = new System.Drawing.Size(100, 23);
            this.m_cmd_xu_ly_lai.TabIndex = 0;
            this.m_cmd_xu_ly_lai.Text = "Xử lý lại";
            // 
            // f108_danh_sach_don_hang_hoa_thanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f108_danh_sach_don_hang_hoa_thanh";
            this.Text = "f108_danh_sach_don_hang_can_duyet";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xu_ly_lai;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nghiem_thu;
    }
}