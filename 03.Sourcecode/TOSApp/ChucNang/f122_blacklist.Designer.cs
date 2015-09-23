namespace TOSApp.ChucNang
{
    partial class f122_blacklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f122_blacklist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_cmd_them = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc_ds_backlist = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_blacklist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SO_DIEN_THOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_ADD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHI_CHU_LY_DO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_backlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_blacklist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_cmd_them);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(655, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 40);
            this.panel4.TabIndex = 1;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_them.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them.Image")));
            this.m_cmd_them.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(155, 40);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.Click += new System.EventHandler(this.m_cmd_them_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_xoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(810, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 40);
            this.panel3.TabIndex = 1;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(136, 40);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_backlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 351);
            this.panel2.TabIndex = 0;
            // 
            // m_grc_ds_backlist
            // 
            this.m_grc_ds_backlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_backlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_backlist.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_backlist.MainView = this.m_grv_ds_blacklist;
            this.m_grc_ds_backlist.Name = "m_grc_ds_backlist";
            this.m_grc_ds_backlist.Size = new System.Drawing.Size(946, 351);
            this.m_grc_ds_backlist.TabIndex = 0;
            this.m_grc_ds_backlist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_blacklist});
            // 
            // m_grv_ds_blacklist
            // 
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.Empty.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.Empty.BackColor2 = System.Drawing.Color.Wheat;
            this.m_grv_ds_blacklist.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_blacklist.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_blacklist.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_blacklist.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_blacklist.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_blacklist.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_blacklist.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.FixedLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_blacklist.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_blacklist.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_ds_blacklist.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_blacklist.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_blacklist.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_blacklist.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_blacklist.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupButton.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupFooter.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.m_grv_ds_blacklist.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_blacklist.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupPanel.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupRow.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_blacklist.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.Options.UseImage = true;
            this.m_grv_ds_blacklist.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv_ds_blacklist.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.HorzLine.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.OddRow.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_blacklist.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_blacklist.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_blacklist.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_blacklist.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(90)))));
            this.m_grv_ds_blacklist.Appearance.Preview.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.Preview.Options.UseBorderColor = true;
            this.m_grv_ds_blacklist.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_blacklist.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.Row.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_blacklist.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.RowSeparator.BackColor = System.Drawing.Color.Bisque;
            this.m_grv_ds_blacklist.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aquamarine;
            this.m_grv_ds_blacklist.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_blacklist.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_blacklist.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_blacklist.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.VertLine.BackColor = System.Drawing.Color.Beige;
            this.m_grv_ds_blacklist.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Appearance.ViewCaption.BackColor = System.Drawing.Color.Maroon;
            this.m_grv_ds_blacklist.Appearance.ViewCaption.Options.UseBackColor = true;
            this.m_grv_ds_blacklist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SO_DIEN_THOAI,
            this.HO_TEN,
            this.NGAY_ADD,
            this.GHI_CHU_LY_DO});
            this.m_grv_ds_blacklist.GridControl = this.m_grc_ds_backlist;
            this.m_grv_ds_blacklist.Name = "m_grv_ds_blacklist";
            this.m_grv_ds_blacklist.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_blacklist.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_blacklist.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_blacklist.PaintStyleName = "MixedXP";
            // 
            // SO_DIEN_THOAI
            // 
            this.SO_DIEN_THOAI.Caption = "số điện thoại";
            this.SO_DIEN_THOAI.FieldName = "SO_DIEN_THOAI";
            this.SO_DIEN_THOAI.Name = "SO_DIEN_THOAI";
            this.SO_DIEN_THOAI.Visible = true;
            this.SO_DIEN_THOAI.VisibleIndex = 0;
            // 
            // HO_TEN
            // 
            this.HO_TEN.Caption = "họ tên chủ điện thoại";
            this.HO_TEN.FieldName = "HO_TEN_CHU_DIEN_THOAI";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 1;
            // 
            // NGAY_ADD
            // 
            this.NGAY_ADD.Caption = "ngày add";
            this.NGAY_ADD.FieldName = "NGAY_ADD";
            this.NGAY_ADD.Name = "NGAY_ADD";
            this.NGAY_ADD.Visible = true;
            this.NGAY_ADD.VisibleIndex = 2;
            // 
            // GHI_CHU_LY_DO
            // 
            this.GHI_CHU_LY_DO.Caption = "ghi chú lý do";
            this.GHI_CHU_LY_DO.FieldName = "GHI_CHU_LY_DO";
            this.GHI_CHU_LY_DO.Name = "GHI_CHU_LY_DO";
            this.GHI_CHU_LY_DO.Visible = true;
            this.GHI_CHU_LY_DO.VisibleIndex = 3;
            // 
            // f122_blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f122_blacklist";
            this.Text = "f122_blacklist";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_backlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_blacklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl m_grc_ds_backlist;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_blacklist;
        private DevExpress.XtraGrid.Columns.GridColumn SO_DIEN_THOAI;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_ADD;
        private DevExpress.XtraGrid.Columns.GridColumn GHI_CHU_LY_DO;
    }
}