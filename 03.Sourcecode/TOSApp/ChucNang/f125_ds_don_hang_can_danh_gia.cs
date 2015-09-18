using IP.Core.IPCommon;
using IPCOREUS;
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
    public partial class f125_ds_don_hang_can_danh_gia : Form
    {
        public int m_trang_thai;
        public f125_ds_don_hang_can_danh_gia(int v_trang_thai)
        {
            InitializeComponent();
            m_trang_thai = v_trang_thai;
        }

        private void f125_ds_don_hang_can_danh_gia_Load(object sender, EventArgs e)
        {
            load_data();
        }
        private void load_data()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query = "";
            if (m_trang_thai == 0)
            {
                v_str_query = "SELECT * FROM V_BO_PM_TD_DICH_VU_GD_DAT_HANG_GD_LOG_DAT_HANG bptdvgdhgldh WHERE     (bptdvgdhgldh.ID_NGUOI_SU_DUNG = " + us_user.dcID.ToString() + ")  AND (bptdvgdhgldh.CAP_SU_DUNG ="+us_user.dcIDNhom.ToString() + ")" + "AND thoi_gian_hoan_thanh is not null AND THAO_TAC_HET_HAN_YN = 'N' AND ID_DANH_GIA_TU_USER_DAT_HANG IS NULL";
                
            }
            else
            {
                v_str_query = "SELECT * FROM V_BO_PM_TD_DICH_VU_GD_DAT_HANG_GD_LOG_DAT_HANG bptdvgdhgldh WHERE     (bptdvgdhgldh.ID_NGUOI_SU_DUNG = " + us_user.dcID.ToString() + ")  AND (bptdvgdhgldh.CAP_SU_DUNG ="+us_user.dcIDNhom.ToString() + ")" + "AND thoi_gian_hoan_thanh is not null AND THAO_TAC_HET_HAN_YN = 'N' AND ID_DANH_GIA_TU_USER_DAT_HANG IS NOT NULL";
                m_pan_button.Visible = false;
            }
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_ds_dh_hoan_thanh.DataSource = v_ds.Tables[0];
        }
        private void m_cmd_danh_gia_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_dh_hoan_thanh.GetDataRow(m_grv_ds_dh_hoan_thanh.FocusedRowHandle);
                decimal v_id_giao_dich = CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString());
                decimal v_id_log_giao_dich = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(v_id_giao_dich);
                US_GD_LOG_DAT_HANG v_us_log = new US_GD_LOG_DAT_HANG();
                f124_danh_gia_cua_khach_hang v_f = new f124_danh_gia_cua_khach_hang();
                v_f.display(v_us, v_us_log);
                load_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
