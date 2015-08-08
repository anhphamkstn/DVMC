namespace TOSApp.BaoCao
{
    partial class f500_BAO_CAO_DANH_GIA
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pivotGridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 516);
            this.panel1.TabIndex = 1;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField6,
            this.pivotGridField5,
            this.pivotGridField7});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(672, 516);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Đánh giá";
            this.pivotGridField1.FieldName = "TEN";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Số lượng order";
            this.pivotGridField2.FieldName = "ID";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Khu vực";
            this.pivotGridField3.FieldName = "TEN_CHI_NHANH";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField6.AreaIndex = 1;
            this.pivotGridField6.Caption = "Trạng thái";
            this.pivotGridField6.FieldName = "TRANG_THAI";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField5.AreaIndex = 2;
            this.pivotGridField5.Caption = "Tỷ lệ tiến độ xử lý";
            this.pivotGridField5.FieldName = "DANH_GIA_TIEN_DO";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField7.AreaIndex = 1;
            this.pivotGridField7.Caption = "Tỉ lệ";
            this.pivotGridField7.FieldName = "ID";
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            this.pivotGridField7.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(672, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 516);
            this.panel2.TabIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.AutoBindingSettingsEnabled = false;
            this.chartControl1.AutoLayoutSettingsEnabled = false;
            this.chartControl1.DataSource = this.pivotGridControl1;
            simpleDiagram1.EqualPieSize = false;
            this.chartControl1.Diagram = simpleDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            this.chartControl1.SeriesTemplate.Label = pieSeriesLabel1;
            this.chartControl1.SeriesTemplate.LegendTextPattern = "{A}";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            this.chartControl1.SeriesTemplate.View = pieSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(336, 516);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField4.AreaIndex = 1;
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // f500_BAO_CAO_DANH_GIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f500_BAO_CAO_DANH_GIA";
            this.Text = "f500_BAO_CAO_DANH_GIA";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
    }
}