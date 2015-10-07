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
    public partial class f126_don_hang_can_nghiem_thu : Form
    {
        public f126_don_hang_can_nghiem_thu()
        {
            InitializeComponent();
           
        }
        US_GD_DAT_HANG m_us = new US_GD_DAT_HANG();
        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            string v_query = "SELECT * FROM V_GD_DAT_HANG  WHERE dbo.[f_get_trang_thai_da_xu_ly_don_hang_YN](ID) ='Y'";
            v_us.FillDatasetWithQuery(v_ds, v_query);
            m_grc_ds_don_dat_hang_can_nghiem_thu.DataSource = v_ds.Tables[0];
        }

        private void f126_don_hang_can_nghiem_thu_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void m_cmd_TM_danh_gia_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
                m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f115_TM_danh_gia v_f115 = new f115_TM_danh_gia();
                v_f115.displayForTM(m_us);
                load_data_to_grid(); ;

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_TM_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
            DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            v_f.Display_for_update(v_us);
            load_data_to_grid();
        }

        private void m_cmd_TM_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
                m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                f103.Display(m_us);
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_to_grid();
        }
    }
}
