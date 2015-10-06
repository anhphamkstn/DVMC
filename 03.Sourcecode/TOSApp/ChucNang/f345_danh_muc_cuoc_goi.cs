using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.ChucNang
{
    public partial class f345_danh_muc_cuoc_goi : Form
    {
        public f345_danh_muc_cuoc_goi()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CUOC_GOI_YEU_CAU");
            m_grc_cuoc_goi.DataSource = v_ds.Tables[0];
        }

        private void m_grv_cuoc_goi_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

       

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)

        {
            if (m_grv_cuoc_goi.GetFocusedRowCellValue("link_ghi_am") != null)
            {
                System.Diagnostics.Process.Start(m_grv_cuoc_goi.GetFocusedRowCellValue("link_ghi_am").ToString());
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            
        }

        private void m_grv_cuoc_goi_DoubleClick(object sender, EventArgs e)
        {
           
        }

           


        
    }
}
