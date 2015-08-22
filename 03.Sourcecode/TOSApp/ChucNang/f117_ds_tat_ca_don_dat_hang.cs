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
    public partial class f117_ds_tat_ca_don_dat_hang : Form
    {
        public f117_ds_tat_ca_don_dat_hang()
        {
            
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_DS_DON_DAT_HANG_CHI_TIET");
            m_grc_ds_don_dat_hang.DataSource = v_ds.Tables[0];

          
 
        }
    }
}
