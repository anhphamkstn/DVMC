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
    public partial class f104_danh_sach_don_hang_tiep_nhan_BO : Form
    {
        public f104_danh_sach_don_hang_tiep_nhan_BO()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CAN_XU_LY");
            m_grc_danh_sach_don_hang_tiep_nhan_BO.DataSource = 

        }
    }
}
