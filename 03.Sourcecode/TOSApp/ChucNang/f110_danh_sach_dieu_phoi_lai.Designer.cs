namespace TOSApp.ChucNang
{
    partial class f110_danh_sach_dieu_phoi_lai
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
            this.m_cmd_dieu_phoi_BO = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dieu_phoi_PM = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dieu_phoi_cho_PM = new System.Windows.Forms.Panel();
            this.m_grc_ds_dieu_phoi_lai = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_dieu_phoi_lai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_NHAN_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DICH_VU_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.m_cmd_dieu_phoi_cho_PM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dieu_phoi_lai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dieu_phoi_lai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_dieu_phoi_BO);
            this.panel1.Controls.Add(this.m_cmd_dieu_phoi_PM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 111);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_dieu_phoi_BO
            // 
            this.m_cmd_dieu_phoi_BO.Location = new System.Drawing.Point(732, 32);
            this.m_cmd_dieu_phoi_BO.Name = "m_cmd_dieu_phoi_BO";
            this.m_cmd_dieu_phoi_BO.Size = new System.Drawing.Size(95, 25);
            this.m_cmd_dieu_phoi_BO.TabIndex = 0;
            this.m_cmd_dieu_phoi_BO.Text = "Điều phối cho BO";
            this.m_cmd_dieu_phoi_BO.Click += new System.EventHandler(this.m_cmd_dieu_phoi_BO_Click);
            // 
            // m_cmd_dieu_phoi_PM
            // 
            this.m_cmd_dieu_phoi_PM.Location = new System.Drawing.Point(578, 32);
            this.m_cmd_dieu_phoi_PM.Name = "m_cmd_dieu_phoi_PM";
            this.m_cmd_dieu_phoi_PM.Size = new System.Drawing.Size(95, 25);
            this.m_cmd_dieu_phoi_PM.TabIndex = 0;
            this.m_cmd_dieu_phoi_PM.Text = "Điều phối cho PM";
            this.m_cmd_dieu_phoi_PM.Click += new System.EventHandler(this.m_cmd_dieu_phoi_PM_Click);
            // 
            // m_cmd_dieu_phoi_cho_PM
            // 
            this.m_cmd_dieu_phoi_cho_PM.Controls.Add(this.m_grc_ds_dieu_phoi_lai);
            this.m_cmd_dieu_phoi_cho_PM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_dieu_phoi_cho_PM.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_dieu_phoi_cho_PM.Name = "m_cmd_dieu_phoi_cho_PM";
            this.m_cmd_dieu_phoi_cho_PM.Size = new System.Drawing.Size(905, 340);
            this.m_cmd_dieu_phoi_cho_PM.TabIndex = 1;
            // 
            // m_grc_ds_dieu_phoi_lai
            // 
            this.m_grc_ds_dieu_phoi_lai.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_dieu_phoi_lai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_dieu_phoi_lai.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_dieu_phoi_lai.MainView = this.m_grv_ds_dieu_phoi_lai;
            this.m_grc_ds_dieu_phoi_lai.Name = "m_grc_ds_dieu_phoi_lai";
            this.m_grc_ds_dieu_phoi_lai.Size = new System.Drawing.Size(905, 340);
            this.m_grc_ds_dieu_phoi_lai.TabIndex = 1;
            this.m_grc_ds_dieu_phoi_lai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_dieu_phoi_lai});
            // 
            // m_grv_ds_dieu_phoi_lai
            // 
            this.m_grv_ds_dieu_phoi_lai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_GD_DAT_HANG,
            this.NGUOI_NHAN_THAO_TAC,
            this.NGUOI_DAT_HANG,
            this.THOI_GIAN_DAT_HANG,
            this.NOI_DUNG_DON_HANG,
            this.THOI_GIAN_CAN_HOAN_THANH,
            this.ID,
            this.DICH_VU_YEU_CAU});
            this.m_grv_ds_dieu_phoi_lai.GridControl = this.m_grc_ds_dieu_phoi_lai;
            this.m_grv_ds_dieu_phoi_lai.Name = "m_grv_ds_dieu_phoi_lai";
            this.m_grv_ds_dieu_phoi_lai.OptionsBehavior.Editable = false;
            this.m_grv_ds_dieu_phoi_lai.OptionsBehavior.ReadOnly = true;
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GD ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            this.ID_GD_DAT_HANG.Width = 97;
            // 
            // NGUOI_NHAN_THAO_TAC
            // 
            this.NGUOI_NHAN_THAO_TAC.Caption = "NGƯỜI NHẬN THAO TÁC";
            this.NGUOI_NHAN_THAO_TAC.Name = "NGUOI_NHAN_THAO_TAC";
            this.NGUOI_NHAN_THAO_TAC.Visible = true;
            this.NGUOI_NHAN_THAO_TAC.VisibleIndex = 2;
            this.NGUOI_NHAN_THAO_TAC.Width = 116;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.NGUOI_DAT_HANG.FieldName = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 3;
            this.NGUOI_DAT_HANG.Width = 92;
            // 
            // THOI_GIAN_DAT_HANG
            // 
            this.THOI_GIAN_DAT_HANG.Caption = "THỜI GIAN ĐẶT HÀNG";
            this.THOI_GIAN_DAT_HANG.FieldName = "THOI_GIAN_DAT_HANG";
            this.THOI_GIAN_DAT_HANG.Name = "THOI_GIAN_DAT_HANG";
            this.THOI_GIAN_DAT_HANG.Visible = true;
            this.THOI_GIAN_DAT_HANG.VisibleIndex = 6;
            this.THOI_GIAN_DAT_HANG.Width = 92;
            // 
            // NOI_DUNG_DON_HANG
            // 
            this.NOI_DUNG_DON_HANG.Caption = "NỘI DUNG ĐƠN HÀNG";
            this.NOI_DUNG_DON_HANG.FieldName = "NOI_DUNG_DAT_HANG";
            this.NOI_DUNG_DON_HANG.Name = "NOI_DUNG_DON_HANG";
            this.NOI_DUNG_DON_HANG.Visible = true;
            this.NOI_DUNG_DON_HANG.VisibleIndex = 5;
            this.NOI_DUNG_DON_HANG.Width = 94;
            // 
            // THOI_GIAN_CAN_HOAN_THANH
            // 
            this.THOI_GIAN_CAN_HOAN_THANH.Caption = "THỜI GIAN CẦN HOÀN THÀNH";
            this.THOI_GIAN_CAN_HOAN_THANH.FieldName = "THOI_GIAN_CAN_HOAN_THANH";
            this.THOI_GIAN_CAN_HOAN_THANH.Name = "THOI_GIAN_CAN_HOAN_THANH";
            this.THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            this.THOI_GIAN_CAN_HOAN_THANH.VisibleIndex = 7;
            this.THOI_GIAN_CAN_HOAN_THANH.Width = 92;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 97;
            // 
            // DICH_VU_YEU_CAU
            // 
            this.DICH_VU_YEU_CAU.Caption = "DỊCH VỤ YÊU CẦU ";
            this.DICH_VU_YEU_CAU.FieldName = "TEN_YEU_CAU";
            this.DICH_VU_YEU_CAU.Name = "DICH_VU_YEU_CAU";
            this.DICH_VU_YEU_CAU.Visible = true;
            this.DICH_VU_YEU_CAU.VisibleIndex = 4;
            // 
            // f110_danh_sach_dieu_phoi_lai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 451);
            this.Controls.Add(this.m_cmd_dieu_phoi_cho_PM);
            this.Controls.Add(this.panel1);
            this.Name = "f110_danh_sach_dieu_phoi_lai";
            this.Text = "f110_danh_sach_dieu_phoi_lai";
            this.panel1.ResumeLayout(false);
            this.m_cmd_dieu_phoi_cho_PM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dieu_phoi_lai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dieu_phoi_lai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dieu_phoi_BO;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dieu_phoi_PM;
        private System.Windows.Forms.Panel m_cmd_dieu_phoi_cho_PM;
        private DevExpress.XtraGrid.GridControl m_grc_ds_dieu_phoi_lai;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_dieu_phoi_lai;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_NHAN_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG_DON_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DICH_VU_YEU_CAU;
    }
}