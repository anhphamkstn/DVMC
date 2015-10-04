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
    public partial class F345_danh_sach_cuoc_goi : Form
    {
        public F345_danh_sach_cuoc_goi()
        {
            InitializeComponent();
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CUOC_GOI_YEU_CAU");
            m_grc_danh_sach_cuoc_goi.DataSource = v_ds.Tables[0];
        }

        

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        

    }
}
