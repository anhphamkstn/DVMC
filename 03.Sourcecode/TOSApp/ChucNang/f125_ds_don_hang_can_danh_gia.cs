using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
            tu_dong_danh_gia();
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
                m_pan_button.Visible = false;
            }
            else if (m_trang_thai == 1)
            {
                v_str_query = "SELECT * FROM V_BO_PM_TD_DICH_VU_GD_DAT_HANG_GD_LOG_DAT_HANG bptdvgdhgldh WHERE     (bptdvgdhgldh.ID_NGUOI_SU_DUNG = " + us_user.dcID.ToString() + ")  AND (bptdvgdhgldh.CAP_SU_DUNG ="+us_user.dcIDNhom.ToString() + ")" + "AND thoi_gian_hoan_thanh is not null AND THAO_TAC_HET_HAN_YN = 'N' AND ID_DANH_GIA_TU_USER_DAT_HANG IS NOT NULL";
                m_pan_button.Visible = false;
            }
            else
            {
                v_str_query = "SELECT * FROM V_GD_DAT_HANG_GD_LOG_DAT_HANG  WHERE    thoi_gian_hoan_thanh is not null AND THAO_TAC_HET_HAN_YN = 'N' AND ID_DANH_GIA_TU_USER_DAT_HANG IS NOT NULL";
                c_dich_vu_yeu_cau.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
                m_pan_button.Visible = false;
            }
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_ds_dh_hoan_thanh.DataSource = v_ds.Tables[0];
        }
        private void tu_dong_danh_gia()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query = "SELECT * FROM GD_DAT_HANG WHERE  THOI_GIAN_HOAN_THANH is not null AND ID_DANH_GIA_TU_USER_DAT_HANG IS NULL";
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                US_GD_DAT_HANG v_us_gd_dat_hang = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i][0].ToString()));
                DateTime v_thoi_gian_hoan_thanh = v_us_gd_dat_hang.datTHOI_GIAN_HOAN_THANH.AddDays(3);
                if (System.DateTime.Compare(v_thoi_gian_hoan_thanh, System.DateTime.Now) == -1)
                {
                    v_us_gd_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG = 124;
                    v_us_gd_dat_hang.Update();
                }
            }
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

        private void m_grv_ds_dh_hoan_thanh_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr = m_grv_ds_dh_hoan_thanh.GetDataRow(m_grv_ds_dh_hoan_thanh.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }

        private void m_grv_ds_dh_hoan_thanh_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

       
        private void m_grv_ds_dh_hoan_thanh_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            // Check whether a row is right-clicked.
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                // Add a submenu with a single menu item.
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }
    }
}
