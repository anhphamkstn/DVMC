using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.BaoCao
{
    public partial class f510_BAO_CAO_TIEP_NHAN : Form
    {
        public f510_BAO_CAO_TIEP_NHAN()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DANH_GIA_TIEP_NHAN");
            pivotGridControl1.DataSource = v_ds.Tables[0];

        
        }

        
    }
}
