using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.ChucNang;
using IPCOREUS;

namespace TOSApp.ChucNang
{
    public partial class f110_danh_sach_dieu_phoi_lai : Form
    {
        public f110_danh_sach_dieu_phoi_lai()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        
        private void load_data_2_grid()
        {
       
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_DIEU_PHOI_LAI");
            m_grc_ds_dieu_phoi_lai.DataSource = v_ds.Tables[0];


        
        }

        private void m_cmd_dieu_phoi_cho_BO_Click(object sender, EventArgs e)
        {
            f111_dieu_phoi_cho_BO v_f111 = new f111_dieu_phoi_cho_BO();
            v_f111.displayListPM();
        }
    }
}
