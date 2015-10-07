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
    public partial class f127_ds_don_hang_hoan_thanh_chua_danh_gia : Form
    {
        public f127_ds_don_hang_hoan_thanh_chua_danh_gia()
        {
            InitializeComponent();
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            string v_query = "SELECT * FROM V_GD_DAT_HANG  WHERE thoi_gian_hoan_thanh is not null and id_danh_gia_tu_user_dat_hang is null";
            v_us.FillDatasetWithQuery(v_ds, v_query);
            m_grc_ds_dh_ht_chua_danh_gia.DataSource = v_ds.Tables[0];
        }
    }
}
