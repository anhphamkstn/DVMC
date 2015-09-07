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
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_BO.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_BO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(159)))), ((int)(((byte)(69)))));
            this.m_grv_ds_BO.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(49)))));
            this.m_grv_ds_BO.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_ds_BO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.GroupButton.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.m_grv_ds_BO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.m_grv_ds_BO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(176)))), ((int)(((byte)(84)))));
            this.m_grv_ds_BO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_BO.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(163)))));
            this.m_grv_ds_BO.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_BO.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.m_grv_ds_BO.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_BO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(90)))));
            this.m_grv_ds_BO.Appearance.Preview.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.Preview.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_BO.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(173)))));
            this.m_grv_ds_BO.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.m_grv_ds_BO.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(167)))), ((int)(((byte)(62)))));
            this.m_grv_ds_BO.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(194)))), ((int)(((byte)(102)))));
            this.m_grv_ds_BO.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_BO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN_BO});
            this.m_grv_ds_BO.GridControl = this.m_grc_ds_BO;
            this.m_grv_ds_BO.Name = "m_grv_ds_BO";
            this.m_grv_ds_BO.OptionsBehavior.Editable = false;
            this.m_grv_ds_BO.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_BO.OptionsSelection.MultiSelect = true;
            this.m_grv_ds_BO.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.m_grv_ds_BO.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_BO.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_BO.PaintStyleName = "Office2003";
            // 
            // TEN_BO
            // 
            this.TEN_BO.Caption = "TÊN BO";
            this.TEN_BO.FieldName = "BO";
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
            this.Text = "f114_Danh sách BO";
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