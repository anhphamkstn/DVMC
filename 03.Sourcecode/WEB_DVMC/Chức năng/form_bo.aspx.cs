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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, query);
            

        }
    }
}