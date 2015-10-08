using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IPCOREUS;
using IP.Core.IPCommon;
using IPCOREDS;
using System.Data;

namespace WEB_DVMC.Chức_năng
{
    public partial class form_bo : System.Web.UI.Page
    {
        string query = "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where THAO_TAC_HET_HAN_YN = 'N'";
        decimal id_user;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            load_data_2_grid_dp_lai(id_user);
            load_data_2_grid_dang_xu_ly(id_user);
        }

        private void load_data_2_grid_dang_xu_ly(decimal id_user)
        {

            query += "And ID_LOAI_THAO_TAC in (296) And ID_NGUOI_NHAN_THAO_TAC = " + id_user;

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, query);
        }

        private void load_data_2_grid_dp_lai(decimal id_user)
        {
            query += "And ID_LOAI_THAO_TAC in (295,311) And ID_NGUOI_NHAN_THAO_TAC = "+ id_user;

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, query);
        }

    }
}