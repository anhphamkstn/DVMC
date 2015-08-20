namespace TOSApp.DanhMuc
{
    partial class f100_dm_cau_hoi
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
            this.m_grc_dm_cau_hoi = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dm_cau_hoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_noi_dung_cau_hoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ngay_tao_cau_hoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nguoi_tao_hoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ngay_cap_nhat_cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nguoi_cap_nhat_cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_to_chuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nhom_cau_hoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_cau_tra_loi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nguoi_tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ngay_tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_link_tl_tham_khao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_cau_hoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_cau_hoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dm_cau_hoi
            // 
            this.m_grc_dm_cau_hoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_cau_hoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_cau_hoi.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_cau_hoi.MainView = this.m_grv_dm_cau_hoi;
            this.m_grc_dm_cau_hoi.Name = "m_grc_dm_cau_hoi";
            this.m_grc_dm_cau_hoi.Size = new System.Drawing.Size(838, 506);
            this.m_grc_dm_cau_hoi.TabIndex = 2;
            this.m_grc_dm_cau_hoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_cau_hoi});
            // 
            // m_grv_dm_cau_hoi
            // 
            this.m_grv_dm_cau_hoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_noi_dung_cau_hoi,
            this.c_ngay_tao_cau_hoi,
            this.c_nguoi_tao_hoi,
            this.c_ngay_cap_nhat_cuoi,
            this.c_nguoi_cap_nhat_cuoi,
            this.c_to_chuc,
            this.c_nhom_cau_hoi,
            this.c_cau_tra_loi,
            this.c_nguoi_tao,
            this.c_ngay_tao,
            this.c_link_tl_tham_khao,
            this.c_trang_thai});
            this.m_grv_dm_cau_hoi.GridControl = this.m_grc_dm_cau_hoi;
            this.m_grv_dm_cau_hoi.Name = "m_grv_dm_cau_hoi";
            // 
            // c_noi_dung_cau_hoi
            // 
            this.c_noi_dung_cau_hoi.Caption = "Nội dung câu hỏi";
            this.c_noi_dung_cau_hoi.FieldName = "NOI_DUNG_CAU_HOI";
            this.c_noi_dung_cau_hoi.Name = "c_noi_dung_cau_hoi";
            this.c_noi_dung_cau_hoi.Visible = true;
            this.c_noi_dung_cau_hoi.VisibleIndex = 0;
            // 
            // c_ngay_tao_cau_hoi
            // 
            this.c_ngay_tao_cau_hoi.Caption = "Ngày tạo câu hỏi";
            this.c_ngay_tao_cau_hoi.FieldName = "NGAY_TAO_CAU_HOI";
            this.c_ngay_tao_cau_hoi.Name = "c_ngay_tao_cau_hoi";
            this.c_ngay_tao_cau_hoi.Visible = true;
            this.c_ngay_tao_cau_hoi.VisibleIndex = 1;
            // 
            // c_nguoi_tao_hoi
            // 
            this.c_nguoi_tao_hoi.Caption = "Người tạo câu hỏi";
            this.c_nguoi_tao_hoi.FieldName = "TEN_NGUOI_TAO_CAU_HOI";
            this.c_nguoi_tao_hoi.Name = "c_nguoi_tao_hoi";
            this.c_nguoi_tao_hoi.Visible = true;
            this.c_nguoi_tao_hoi.VisibleIndex = 2;
            // 
            // c_ngay_cap_nhat_cuoi
            // 
            this.c_ngay_cap_nhat_cuoi.Caption = "Ngày cập nhật cuối";
            this.c_ngay_cap_nhat_cuoi.FieldName = "NGAY_CAP_NHAP_CUOI";
            this.c_ngay_cap_nhat_cuoi.Name = "c_ngay_cap_nhat_cuoi";
            this.c_ngay_cap_nhat_cuoi.Visible = true;
            this.c_ngay_cap_nhat_cuoi.VisibleIndex = 3;
            // 
            // c_nguoi_cap_nhat_cuoi
            // 
            this.c_nguoi_cap_nhat_cuoi.Caption = "Người cập nhật cuối";
            this.c_nguoi_cap_nhat_cuoi.FieldName = "TEN_NGUOI_CAP_NHAT_CUOI";
            this.c_nguoi_cap_nhat_cuoi.Name = "c_nguoi_cap_nhat_cuoi";
            this.c_nguoi_cap_nhat_cuoi.Visible = true;
            this.c_nguoi_cap_nhat_cuoi.VisibleIndex = 4;
            // 
            // c_to_chuc
            // 
            this.c_to_chuc.Caption = "Tổ chức";
            this.c_to_chuc.FieldName = "TO_CHUC";
            this.c_to_chuc.Name = "c_to_chuc";
            this.c_to_chuc.Visible = true;
            this.c_to_chuc.VisibleIndex = 5;
            // 
            // c_nhom_cau_hoi
            // 
            this.c_nhom_cau_hoi.Caption = "Nhóm câu hỏi";
            this.c_nhom_cau_hoi.FieldName = "NHOM_CAU_HOI";
            this.c_nhom_cau_hoi.Name = "c_nhom_cau_hoi";
            this.c_nhom_cau_hoi.Visible = true;
            this.c_nhom_cau_hoi.VisibleIndex = 6;
            // 
            // c_cau_tra_loi
            // 
            this.c_cau_tra_loi.Caption = "Câu trả lời";
            this.c_cau_tra_loi.FieldName = "CAU_TRA_LOI";
            this.c_cau_tra_loi.Name = "c_cau_tra_loi";
            this.c_cau_tra_loi.Visible = true;
            this.c_cau_tra_loi.VisibleIndex = 7;
            // 
            // c_nguoi_tao
            // 
            this.c_nguoi_tao.Caption = "Người tạo";
            this.c_nguoi_tao.FieldName = "TEN_NGUOI_TAO_CAU_TRA_LOI";
            this.c_nguoi_tao.Name = "c_nguoi_tao";
            this.c_nguoi_tao.Visible = true;
            this.c_nguoi_tao.VisibleIndex = 8;
            // 
            // c_ngay_tao
            // 
            this.c_ngay_tao.Caption = "Ngày tạo";
            this.c_ngay_tao.FieldName = "NGAY_TAO_CAU_TRA_LOI";
            this.c_ngay_tao.Name = "c_ngay_tao";
            this.c_ngay_tao.Visible = true;
            this.c_ngay_tao.VisibleIndex = 9;
            // 
            // c_link_tl_tham_khao
            // 
            this.c_link_tl_tham_khao.Caption = "Link tham khảo";
            this.c_link_tl_tham_khao.FieldName = "LINK_TL_THAM_KHAO";
            this.c_link_tl_tham_khao.Name = "c_link_tl_tham_khao";
            this.c_link_tl_tham_khao.Visible = true;
            this.c_link_tl_tham_khao.VisibleIndex = 10;
            // 
            // c_trang_thai
            // 
            this.c_trang_thai.Caption = "Trạng thái";
            this.c_trang_thai.FieldName = "TEN";
            this.c_trang_thai.Name = "c_trang_thai";
            this.c_trang_thai.Visible = true;
            this.c_trang_thai.VisibleIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 75);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(487, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 75);
            this.panel2.TabIndex = 4;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(138, 20);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(82, 34);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "&Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(257, 20);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 34);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "&Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(19, 20);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 34);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "&Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // f100_dm_cau_hoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grc_dm_cau_hoi);
            this.Name = "f100_dm_cau_hoi";
            this.Text = "f100_dm_cau_hoi";
            this.Load += new System.EventHandler(this.f100_dm_cau_hoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_cau_hoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_cau_hoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_cau_hoi;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_cau_hoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_noi_dung_cau_hoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ngay_tao_cau_hoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_tao_hoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_ngay_cap_nhat_cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_cap_nhat_cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_to_chuc;
        private DevExpress.XtraGrid.Columns.GridColumn c_nhom_cau_hoi;
        private DevExpress.XtraGrid.Columns.GridColumn c_cau_tra_loi;
        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_tao;
        private DevExpress.XtraGrid.Columns.GridColumn c_ngay_tao;
        private DevExpress.XtraGrid.Columns.GridColumn c_link_tl_tham_khao;
        private DevExpress.XtraGrid.Columns.GridColumn c_trang_thai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
    }
}