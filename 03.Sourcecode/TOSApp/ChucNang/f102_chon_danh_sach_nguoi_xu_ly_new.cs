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
    public partial class f102_chon_danh_sach_nguoi_xu_ly_new : Form
    {
        public f102_chon_danh_sach_nguoi_xu_ly_new()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
          
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_HT_NGUOI_SU_DUNG");
            m_grc_ht_nguoi_su_dung.DataSource = v_ds.Tables[0];

        
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
