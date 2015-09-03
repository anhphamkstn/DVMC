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

namespace TOSApp.Hệ_thống
{
    public partial class f999_ht_bo_pm_td_dich_vu : Form
    {
        public f999_ht_bo_pm_td_dich_vu()
        {
            InitializeComponent();
        }

        private void f999_ht_bo_dich_vu_Load(object sender, EventArgs e)
        {
            us_user.dcIDNhom = 5;
            if(us_user.dcIDNhom !=5)
            {
                m_grv_ht_bo_pm_td_dich_vu.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            load_data_to_grv();
        }
        private void load_data_to_grv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DICH_VU_BO_PM_TD");
            m_grc_ht_bo_pm_td_dich_vu.DataSource = v_ds.Tables[0];
        }

        private void m_grv_ht_bo_pm_td_dich_vu_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
             us_user.m_lst_id_nguoi_xu_ly.Clear();
             GridHitInfo info = view.CalcHitInfo(pt);
             if (info.InRow || info.InRowCell)
             {
                 DataRow v_dr_grv = m_grv_ht_bo_pm_td_dich_vu.GetDataRow(m_grv_ht_bo_pm_td_dich_vu.FocusedRowHandle);
                 if(v_dr_grv == null)
                 {
                     try
                     {
                         f999_ht_bo_pm_td_dich_vu_de v_f = new f999_ht_bo_pm_td_dich_vu_de();
                         v_f.WindowState = FormWindowState.Maximized;
                         v_f.displayInsert();
                         load_data_to_grv();
                     }
                     catch(Exception v_e)
                     {
                         CSystemLog_100.ExceptionHandle(v_e);
                     }
                 }
                 else
                 {
                     try
                     {
                         decimal v_id = CIPConvert.ToDecimal(v_dr_grv["ID"].ToString());
                         decimal v_id_dich_vu = CIPConvert.ToDecimal(v_dr_grv["ID_DICH_VU"].ToString());
                         US_HT_BO_DICH_VU v_us_bo_dich_vu = new US_HT_BO_DICH_VU(v_id);
                         US_DM_LOAI_YEU_CAU v_us_dich_vu = new US_DM_LOAI_YEU_CAU(v_id_dich_vu);
                         f999_ht_bo_pm_td_dich_vu_de v_f = new f999_ht_bo_pm_td_dich_vu_de();
                         v_f.WindowState = FormWindowState.Maximized;
                         v_f.displayUpdate(v_us_bo_dich_vu,v_us_dich_vu);
                         load_data_to_grv();
                     }
                     catch (Exception v_e)
                     {
                         CSystemLog_100.ExceptionHandle(v_e);
                     }
                    
                 }
             }
        }
    }
}
