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
    public partial class f119_ds_don_hang_hoan_thanh : Form
    {
        public f119_ds_don_hang_hoan_thanh()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
      //      string m_str_filed =" MA_DON_HANG,HO_TEN_USER_DAT_HANG,MA_DON_VI,DIEN_THOAI,TEN_YEU_CAU,NOI_DUNG_DAT_HANG,THOI_GIAN_HOAN_THANH,GHI_CHU ";
            //v_us.FillDatasetWithTableName(v_ds, "V_GD_DAT_HANG_GD_LOG_DAT_HANG");
            v_us.FillDatasetWithQuery(v_ds, " select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where thoi_gian_hoan_thanh is not null AND THAO_TAC_HET_HAN_YN = 'N'");

            m_grc_ds_dh_hoan_thanh.DataSource = v_ds.Tables[0];
        }

       
    }
}
