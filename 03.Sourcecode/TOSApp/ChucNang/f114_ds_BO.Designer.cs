namespace TOSApp.ChucNang
{
    partial class f114_ds_BO
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_txt_ma_don_hang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc_ds_BO = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_BO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_BO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_BO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_BO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 83);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Location = new System.Drawing.Point(467, 38);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Cancel";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Location = new System.Drawing.Point(341, 38);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_txt_ma_don_hang);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 59);
            this.panel3.TabIndex = 0;
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.AutoSize = true;
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(256, 28);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(70, 13);
            this.m_txt_ma_don_hang.TabIndex = 0;
            this.m_txt_ma_don_hang.Text = "mã đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_BO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 283);
            this.panel2.TabIndex = 1;
            // 
            // m_grc_ds_BO
            // 
            this.m_grc_ds_BO.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_BO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_BO.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_BO.MainView = this.m_grv_ds_BO;
            this.m_grc_ds_BO.Name = "m_grc_ds_BO";
            this.m_grc_ds_BO.Size = new System.Drawing.Size(608, 283);
            this.m_grc_ds_BO.TabIndex = 0;
            this.m_grc_ds_BO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_BO});
            // 
            // m_grv_ds_BO
            // 
            this.m_grv_ds_BO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN_BO});
            this.m_grv_ds_BO.GridControl = this.m_grc_ds_BO;
            this.m_grv_ds_BO.Name = "m_grv_ds_BO";
            this.m_grv_ds_BO.OptionsSelection.MultiSelect = true;
            this.m_grv_ds_BO.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // TEN_BO
            // 
            this.TEN_BO.Caption = "TÊN BO";
            this.TEN_BO.FieldName = "TEN_TRUY_CAP";
            this.TEN_BO.Name = "TEN_BO";
            this.TEN_BO.Visible = true;
            this.TEN_BO.VisibleIndex = 1;
            // 
            // f114_ds_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "f114_ds_BO";
            this.Text = "f114_ds_BO";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_BO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_BO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_txt_ma_don_hang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private DevExpress.XtraGrid.GridControl m_grc_ds_BO;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_BO;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_BO;
    }
}