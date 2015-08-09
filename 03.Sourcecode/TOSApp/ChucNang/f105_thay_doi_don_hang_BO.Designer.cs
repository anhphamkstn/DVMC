namespace TOSApp.ChucNang
{
    partial class f105_thay_doi_don_hang_BO
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
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ma_don_hang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_cmd_gui = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_nguoi_nhan_tao_tac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(179, 43);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(188, 20);
            this.m_txt_ma_don_hang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghi chú";
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(179, 113);
            this.m_txt_ghi_chu.Multiline = true;
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(316, 76);
            this.m_txt_ghi_chu.TabIndex = 1;
            // 
            // m_cmd_gui
            // 
            this.m_cmd_gui.Location = new System.Drawing.Point(263, 227);
            this.m_cmd_gui.Name = "m_cmd_gui";
            this.m_cmd_gui.Size = new System.Drawing.Size(88, 23);
            this.m_cmd_gui.TabIndex = 2;
            this.m_cmd_gui.Text = "Gửi";
            this.m_cmd_gui.Click += new System.EventHandler(this.m_cmd_gui_Click);
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Location = new System.Drawing.Point(415, 227);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(80, 23);
            this.m_cmd_cancel.TabIndex = 2;
            this.m_cmd_cancel.Text = "Cancel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người nhận tao tác";
            // 
            // m_txt_nguoi_nhan_tao_tac
            // 
            this.m_txt_nguoi_nhan_tao_tac.Location = new System.Drawing.Point(179, 76);
            this.m_txt_nguoi_nhan_tao_tac.Name = "m_txt_nguoi_nhan_tao_tac";
            this.m_txt_nguoi_nhan_tao_tac.Size = new System.Drawing.Size(188, 20);
            this.m_txt_nguoi_nhan_tao_tac.TabIndex = 1;
            // 
            // f105_thay_doi_don_hang_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 262);
            this.Controls.Add(this.m_cmd_cancel);
            this.Controls.Add(this.m_cmd_gui);
            this.Controls.Add(this.m_txt_ghi_chu);
            this.Controls.Add(this.m_txt_nguoi_nhan_tao_tac);
            this.Controls.Add(this.m_txt_ma_don_hang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "f105_thay_doi_don_hang_BO";
            this.Text = "f105_thay_doi_don_hang_BO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ma_don_hang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ghi_chu;
        private DevExpress.XtraEditors.SimpleButton m_cmd_gui;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_nguoi_nhan_tao_tac;
    }
}