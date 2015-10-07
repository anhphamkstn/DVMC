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
            v_str_query = "SELECT * FROM V_BO_PM_TD_DICH_VU_GD_DAT_HANG_GD_LOG_DAT_HANG bptdvgdhgldh WHERE   (bptdvgdhgldh.ID_NGUOI_SU_DUNG = " + us_user.dcID.ToString() + ") AND (bptdvgdhgldh.ID_LOAI_THAO_TAC = 296) AND (bptdvgdhgldh.THAO_TAC_HET_HAN_YN = 'N') AND (bptdvgdhgldh.CAP_SU_DUNG ="+us_user.dcIDNhom.ToString() + ")";
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_ds_don_hang_dang_xu_ly.DataSource = v_ds.Tables[0];
        }

        private void m_grv_ds_don_hang_dang_xu_ly_DoubleClick(object sender, EventArgs e)
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
                DataRow v_dr = m_grv_ds_don_hang_dang_xu_ly.GetDataRow(m_grv_ds_don_hang_dang_xu_ly.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }

        private void m_grv_ds_don_hang_dang_xu_ly_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

        }

      
        private void m_grv_ds_don_hang_dang_xu_ly_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
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
