using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp.ChucNang
{
    public partial class f000_gd_dat_hang_gd_log_dat_hang : Form
    {
        public f000_gd_dat_hang_gd_log_dat_hang()
        {
            InitializeComponent();
            load_data_2_grid();          
        }
     
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_GD_DAT_HANG_GD_LOG_DAT_HANG");
       
            m_grc_gd_dat_hang_gd_log_dat_hang.DataSource = v_ds.Tables[0];

        }
        
        

        #region FO
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            open_form_new_gd();

        }

        private void open_form_new_gd()
        {
            
        }
        #endregion


    }
}
