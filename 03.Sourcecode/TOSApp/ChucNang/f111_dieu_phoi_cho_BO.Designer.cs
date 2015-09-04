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
            this.m_txt_noi_dung_dat_hang = new System.Windows.Forms.TextBox();
            this.m_txt_dich_vu_yeu_cau = new System.Windows.Forms.TextBox();
            this.m_txt_ID_don_hang = new System.Windows.Forms.TextBox();
            this.m_cbo_danh_sach_PM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 56);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Location = new System.Drawing.Point(533, 21);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Cancel";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Location = new System.Drawing.Point(406, 21);
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
            this.panel2.Size = new System.Drawing.Size(666, 260);
            this.panel2.TabIndex = 1;
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.m_txt_noi_dung_dat_hang);
            this.GroupControl1.Controls.Add(this.m_txt_dich_vu_yeu_cau);
            this.GroupControl1.Controls.Add(this.m_txt_ID_don_hang);
            this.GroupControl1.Controls.Add(this.m_cbo_danh_sach_PM);
            this.GroupControl1.Controls.Add(this.label4);
            this.GroupControl1.Controls.Add(this.label3);
            this.GroupControl1.Controls.Add(this.label2);
            this.GroupControl1.Controls.Add(this.label1);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl1.Location = new System.Drawing.Point(0, 0);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(666, 260);
            this.GroupControl1.TabIndex = 6;
            this.GroupControl1.Text = "Danh sách người xử lý";
            // 
            // m_txt_noi_dung_dat_hang
            // 
            this.m_txt_noi_dung_dat_hang.Location = new System.Drawing.Point(259, 148);
            this.m_txt_noi_dung_dat_hang.Multiline = true;
            this.m_txt_noi_dung_dat_hang.Name = "m_txt_noi_dung_dat_hang";
            this.m_txt_noi_dung_dat_hang.ReadOnly = true;
            this.m_txt_noi_dung_dat_hang.Size = new System.Drawing.Size(350, 50);
            this.m_txt_noi_dung_dat_hang.TabIndex = 2;
            // 
            // m_txt_dich_vu_yeu_cau
            // 
            this.m_txt_dich_vu_yeu_cau.Location = new System.Drawing.Point(259, 104);
            this.m_txt_dich_vu_yeu_cau.Name = "m_txt_dich_vu_yeu_cau";
            this.m_txt_dich_vu_yeu_cau.ReadOnly = true;
            this.m_txt_dich_vu_yeu_cau.Size = new System.Drawing.Size(350, 20);
            this.m_txt_dich_vu_yeu_cau.TabIndex = 2;
            // 
            // m_txt_ID_don_hang
            // 
            this.m_txt_ID_don_hang.Location = new System.Drawing.Point(259, 51);
            this.m_txt_ID_don_hang.Name = "m_txt_ID_don_hang";
            this.m_txt_ID_don_hang.ReadOnly = true;
            this.m_txt_ID_don_hang.Size = new System.Drawing.Size(350, 20);
            this.m_txt_ID_don_hang.TabIndex = 2;
            // 
            // m_cbo_danh_sach_PM
            // 
            this.m_cbo_danh_sach_PM.FormattingEnabled = true;
            this.m_cbo_danh_sach_PM.Location = new System.Drawing.Point(259, 213);
            this.m_cbo_danh_sach_PM.Name = "m_cbo_danh_sach_PM";
            this.m_cbo_danh_sach_PM.Size = new System.Drawing.Size(350, 21);
            this.m_cbo_danh_sach_PM.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nội dung đặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dịch vụ yêu cầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách PM";
            // 
            // f111_dieu_phoi_cho_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f111_dieu_phoi_cho_BO";
            this.Text = "Điều phối";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private System.Windows.Forms.TextBox m_txt_noi_dung_dat_hang;
        private System.Windows.Forms.TextBox m_txt_dich_vu_yeu_cau;
        private System.Windows.Forms.TextBox m_txt_ID_don_hang;
        private System.Windows.Forms.ComboBox m_cbo_danh_sach_PM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}