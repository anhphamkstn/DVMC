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
    public partial class f500_cong_viec_FO_chi_tiet : Form
    {
        public f500_cong_viec_FO_chi_tiet()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_DANH_SACH_DAT_HANG_FO");
            v_grc_FO_danh_sach_don_hang.DataSource = v_ds.Tables[0];

        }

        private void m_cmd_them_moi_don_hang_Click(object sender, EventArgs e)
        {

        }

       
    }
}
