using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.ChucNang;
using IP.Core.IPCommon;
using TOSApp.BaoCao;

namespace TOSApp
{
    public partial class f999_main_form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f999_main_form()
        {
            InitializeComponent();
        }
        //decimal id_nguoi_dung;
        #region old format
        private void m_cmd_FO_cong_viec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
         
        }

        private void m_cmd_BO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;

                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_PM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;

                v_f.Show();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;

                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;

                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bao_cao_tiep_nhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f510_BAO_CAO_TIEP_NHAN v_f = new f510_BAO_CAO_TIEP_NHAN();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
         
        }

        private void m_cmd_bao_cao_xu_ly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f520_BAO_CAO_XU_LI v_f = new f520_BAO_CAO_XU_LI();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bao_cao_danh_gia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               f500_BAO_CAO_DANH_GIA v_f = new f500_BAO_CAO_DANH_GIA();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

        #region format controll for each user
        private void m_cmd_ds_don_hang_can_tiep_nhan_BO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_don_hang_dang_xu_ly_BO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_don_hang_can_xu_ly_PM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_don_hang_dang_xu_ly_PM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_don_hang_can_xu_ly_TD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_don_hang_dang_xu_ly_TD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_don_hang_can_danh_gia_TM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f0000_gd_dat_hang_gd_log_dat_hang v_f = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_tat_ca_don_hang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f117_ds_tat_ca_don_dat_hang v_f = new f117_ds_tat_ca_don_dat_hang();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tat_ca_don_hang_TD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f117_ds_tat_ca_don_dat_hang v_f = new f117_ds_tat_ca_don_dat_hang();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion




    }
}
