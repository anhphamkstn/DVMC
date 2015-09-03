﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.ChucNang
{
    public partial class f118_ds_log_dat_hang : Form
    {
        public f118_ds_log_dat_hang()
        {
            InitializeComponent();
            load_data_to_grid();

        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

             //v_us.FillDatasetWithTableName(v_ds, "V_GD_DAT_HANG_GD_LOG_DAT_HANG");
            v_us.FillDatasetWithQuery(v_ds, " select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG WHERE ID IS NOT NULL");
            m_grc_ds_log_gd_dat_hang.DataSource = v_ds.Tables[0];

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_to_grid();


        }
    }
}
