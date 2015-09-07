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
    public partial class f120_ds_don_hang_khach_hang : Form
    {
        public f120_ds_don_hang_khach_hang()
        {
            InitializeComponent();
            load_data_2_grid();
        }
        string query = "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where THAO_TAC_HET_HAN_YN='N'";
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, query);
            m_grc_ds_don_hang_nguoi_xu_ly.DataSource = v_ds.Tables[0];



        }

       

      
    }
}
