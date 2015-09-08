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
    public partial class f122_ds_don_hang_dang_xu_ly: Form
    {
        public f122_ds_don_hang_dang_xu_ly()
        {
            InitializeComponent();
        }

        private void f122_ds_don_hang_dang_xu_ly_Load(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query = "";
            v_str_query = "SELECT * FROM V_BO_PM_TD_DICH_VU_GD_DAT_HANG_GD_LOG_DAT_HANG bptdvgdhgldh WHERE     (bptdvgdhgldh.ID_NGUOI_SU_DUNG = " + us_user.dcID.ToString() + ") AND (bptdvgdhgldh.ID_LOAI_THAO_TAC = 296) AND (bptdvgdhgldh.THAO_TAC_HET_HAN_YN = 'N') AND (bptdvgdhgldh.CAP_SU_DUNG ="+us_user.dcIDNhom.ToString() + ")";
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_ds_don_hang_dang_xu_ly.DataSource = v_ds.Tables[0];
        }
    }
}
