﻿using System;
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
using TOSApp.DanhMuc;
using TOSApp.Hệ_thống;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using System.Collections;
using TOSApp.HT;

namespace TOSApp
{
    public partial class f999_main_form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f999_main_form()
        {
            InitializeComponent();
            format_controll_for_each_user(us_user.dcIDNhom);
        //   format_button_controll();
        }

        // forms in tabs
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_can_tiep_nhan_BO;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_dang_xu_ly_BO ;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_can_xu_ly_PM ;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_dang_xu_ly_PM ;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_can_xu_ly_TD ;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_dang_xu_ly_TD ;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_can_danh_gia_TM;
        f0000_gd_dat_hang_gd_log_dat_hang v_don_hang_dieu_phoi_lai_FO;
        f117_ds_tat_ca_don_dat_hang v_tat_ca_don_hang;
        f117_ds_tat_ca_don_dat_hang v_tat_ca_don_hang_TD;
        f118_ds_log_dat_hang v_log_dat_hang;
        f119_ds_don_hang_hoan_thanh v_don_hang_hoan_thanh;
        f101_dm_mau_email v_dm_email;
        f102_dm_loai_yeu_cau v_dm_loai_yeu_cau;


        private void GetAllControl(f999_main_form c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(c, list);
            }
        }
        public void openform( Form form, int i)
        {
            if (form == null || !IsFormOpen(form))
            {
                form = new f0000_gd_dat_hang_gd_log_dat_hang(i);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Focus();
            }
        }
        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }

        private void format_controll_for_each_user(decimal p)
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_HT_PHAN_QUYEN_CHO_NHOM where id_NHOM_NGUOI_SU_DUNG=" + us_user.dcIDNhom);

            //List<Control> list = new List<Control>();

            //GetAllControl(this, list);

            ArrayList visiblePages = ribbonControl1.TotalPageCategory.GetVisiblePages();
  
            foreach (RibbonPage page in visiblePages)
            {
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    if (page.Name == v_ds.Tables[0].Rows[i]["CONTROL_NAME"].ToString())
                    {

                        page.Visible = true;
                        break;
                    }
                    else page.Visible = false;


                }


                //if (page.Text == "Selection")
                //{
                //    page.Visible = false;
                //    break;
                //}
            }
            if (us_user.dcIDNhom == 1 || us_user.dcIDNhom == 5)
            {
                m_rib_dm_cau_hoi.Visible = true;
            }
            else m_rib_dm_cau_hoi.Visible = false;
     
            //foreach (Control control in list)
            //{
            //    if (control.GetType() == typeof(RibbonPage) )
            //    {
            //        for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            //        {
            //            if (control.Name == v_ds.Tables[0].Rows[i]["CONTROL_NAME"].ToString())
            //            {
            //                control.Visible = true;
            //            }

            //        }
            //    }
            //}
        }

        private  void format_button_controll()
        {
            if (user_id == 1)
            {
                m_rbc_FO.Visible = true;
                m_rbc_BO.Visible = false;
                m_rbc_PM.Visible = false;
                m_rbc_TD.Visible = false;
                m_rbc_TM.Visible = false;
                m_rbc_bao_cao.Visible = true;
                m_rib_dm_cau_hoi.Visible = true;
            }
            else if (user_id == 2)
            {
                m_rbc_FO.Visible = false;
                m_rbc_BO.Visible = true;
                m_rbc_PM.Visible = false;
                m_rbc_TD.Visible = false;
                m_rbc_TM.Visible = false;
                m_rbc_bao_cao.Visible = false;
                m_rib_dm_cau_hoi.Visible = false;
            }
            else if (user_id == 3)
            {
                m_rbc_FO.Visible = false;
                m_rbc_BO.Visible = false;
                m_rbc_PM.Visible = true;
                m_rbc_TD.Visible = false;
                m_rbc_TM.Visible = false;
                m_rbc_bao_cao.Visible = false;
                m_rib_dm_cau_hoi.Visible = false;
            }
            else if (user_id == 5)
            {
                m_rbc_FO.Visible = false;
                m_rbc_BO.Visible = false;
                m_rbc_PM.Visible = false;
                m_rbc_TD.Visible = true;
                m_rbc_TM.Visible = false;
                m_rbc_bao_cao.Visible = true;
                m_rib_dm_cau_hoi.Visible = true;
            }
            else
            {
                m_rbc_FO.Visible = false;
                m_rbc_BO.Visible = false;
                m_rbc_PM.Visible = false;
                m_rbc_TD.Visible = false;
                m_rbc_TM.Visible = true;
                m_rbc_bao_cao.Visible = false;
                m_rib_dm_cau_hoi.Visible = false;
            }
        }
        //decimal id_nguoi_dung;
      
        decimal user_id = us_user.dcIDNhom;

        
        
        #region format controll for each user
        private void m_cmd_ds_don_hang_can_tiep_nhan_BO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_don_hang_can_tiep_nhan_BO == null || !IsFormOpen(v_don_hang_can_tiep_nhan_BO))
                {
                    v_don_hang_can_tiep_nhan_BO = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                    v_don_hang_can_tiep_nhan_BO.MdiParent = this;
                    v_don_hang_can_tiep_nhan_BO.m_panel_BO_hoan_thanh.Visible = false;  
                    v_don_hang_can_tiep_nhan_BO.Show();
                }
                else
                {
                    v_don_hang_can_tiep_nhan_BO.Focus();
                }
                         
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
                if (v_don_hang_dang_xu_ly_BO == null || !IsFormOpen(v_don_hang_dang_xu_ly_BO))
                {
                    v_don_hang_dang_xu_ly_BO = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_dang_xu_ly_BO.MdiParent = this;
                    v_don_hang_dang_xu_ly_BO.m_panel_BO_tu_choi.Visible = false;
                    v_don_hang_dang_xu_ly_BO.m_panel_BO_tiep_nhan.Visible = false;
                    v_don_hang_dang_xu_ly_BO.Show();
                }
                else
                {
                    v_don_hang_dang_xu_ly_BO.Focus();
                }
               
    
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
                
                if (v_don_hang_can_xu_ly_PM == null || !IsFormOpen(v_don_hang_can_xu_ly_PM))
                {
                    v_don_hang_can_xu_ly_PM = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_can_xu_ly_PM.MdiParent = this;
                    v_don_hang_can_xu_ly_PM.m_panel_PM_hoan_thanh.Visible = false;
                    v_don_hang_can_xu_ly_PM.Show();
                }
                else
                {
                    v_don_hang_can_xu_ly_PM.Focus();
                }
     
                
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
                if (v_don_hang_dang_xu_ly_PM == null || !IsFormOpen(v_don_hang_can_xu_ly_PM))
                {
                    v_don_hang_dang_xu_ly_PM = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_dang_xu_ly_PM.MdiParent = this;
                    v_don_hang_dang_xu_ly_PM.m_panel_PM_dieu_phoi_lai.Visible = false;
                    v_don_hang_dang_xu_ly_PM.m_panel_PM_gui_TD.Visible = false;
                    v_don_hang_dang_xu_ly_PM.m_panel_PM_tiep_nhan.Visible = false;
                    v_don_hang_dang_xu_ly_PM.Show();
                }
                else
                {
                    v_don_hang_dang_xu_ly_PM.Focus();
                }           
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
                if (v_don_hang_can_xu_ly_TD == null || !IsFormOpen(v_don_hang_can_xu_ly_TD))
                {
                    v_don_hang_can_xu_ly_TD = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_can_xu_ly_TD.MdiParent = this;
                    v_don_hang_can_xu_ly_TD.m_panel_TD_hoan_thanh.Visible = false;
                    v_don_hang_can_xu_ly_TD.Show();
                }
                else
                {
                    v_don_hang_can_xu_ly_TD.Focus();
                }           
               
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
                if (v_don_hang_dang_xu_ly_TD == null || !IsFormOpen(v_don_hang_dang_xu_ly_TD))
                {
                    v_don_hang_dang_xu_ly_TD = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_dang_xu_ly_TD.MdiParent = this;
                    v_don_hang_dang_xu_ly_TD.m_panel_TD_tu_choi.Visible = false;
                    v_don_hang_dang_xu_ly_TD.m_panel_TD_tiep_nhan.Visible = false;
                    v_don_hang_dang_xu_ly_TD.Show();
                }
                else
                {
                    v_don_hang_dang_xu_ly_TD.Focus();
                }           
               
             
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
                if (v_don_hang_can_danh_gia_TM == null || !IsFormOpen(v_don_hang_can_danh_gia_TM))
                {
                    v_don_hang_can_danh_gia_TM = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_can_danh_gia_TM.MdiParent = this;
                    
                    v_don_hang_can_danh_gia_TM.Show();
                }
                else
                {
                    v_don_hang_can_danh_gia_TM.Focus();
                }           
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
                if (v_tat_ca_don_hang == null || !IsFormOpen(v_tat_ca_don_hang))
                {
                    v_tat_ca_don_hang = new f117_ds_tat_ca_don_dat_hang();
                    v_tat_ca_don_hang.MdiParent = this;
                   v_tat_ca_don_hang.Show();
                }
                else
                {
                    v_tat_ca_don_hang.Focus();
                }           

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
                if (v_tat_ca_don_hang_TD == null || !IsFormOpen(v_tat_ca_don_hang_TD))
                {
                    v_tat_ca_don_hang_TD = new f117_ds_tat_ca_don_dat_hang();
                    v_tat_ca_don_hang_TD.MdiParent = this;
                    v_tat_ca_don_hang_TD.Show();
                }
                else
                {
                    v_tat_ca_don_hang_TD.Focus();
                }           
               
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_ds_don_hang_dieu_phoi_lai_FO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_don_hang_dieu_phoi_lai_FO == null || !IsFormOpen(v_don_hang_dieu_phoi_lai_FO))
                {
                    v_don_hang_dieu_phoi_lai_FO = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                    v_don_hang_dieu_phoi_lai_FO.MdiParent = this;
                    v_don_hang_dieu_phoi_lai_FO.Show();
                }
                else
                {
                    v_don_hang_dieu_phoi_lai_FO.Focus();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_show_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (v_log_dat_hang == null || !IsFormOpen(v_log_dat_hang))
            {
                 v_log_dat_hang = new f118_ds_log_dat_hang();
                 v_log_dat_hang.MdiParent = this;
                 v_log_dat_hang.Show();
            }
            else
            {
                v_log_dat_hang.Focus();
            }
           
        }

        private void m_cmd_dm_cau_hoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f100_dm_cau_hoi v_f = new f100_dm_cau_hoi();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_barsubitem_doi_ten_dang_nhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f999_doi_ten_dang_nhap v_f = new f999_doi_ten_dang_nhap();
            v_f.ShowDialog();
        }

        private void m_barsubitem_doi_mat_khau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f999_doi_mat_khau v_f = new f999_doi_mat_khau();
            v_f.ShowDialog();
        }

        private void m_cmd_ds_don_hang_hoan_thanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_don_hang_hoan_thanh == null || !IsFormOpen(v_don_hang_hoan_thanh))
                {
                    v_don_hang_hoan_thanh = new f119_ds_don_hang_hoan_thanh();
                    v_don_hang_hoan_thanh.MdiParent = this;
                    v_don_hang_hoan_thanh.Show();
                }
                else
                {
                    v_don_hang_hoan_thanh.Focus();
                }
              
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        private void m_cmd_dm_email_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (v_dm_email == null || !IsFormOpen(v_dm_email))
            {
                v_dm_email = new f101_dm_mau_email();
                v_dm_email.MdiParent = this;
                v_dm_email.Show();
            }
            else
            {
                v_dm_email.Focus();
            }
            
        }

        private void m_cmd_dm_dich_vu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (v_dm_loai_yeu_cau == null || !IsFormOpen(v_dm_loai_yeu_cau))
            {
                v_dm_loai_yeu_cau = new f102_dm_loai_yeu_cau();
                v_dm_loai_yeu_cau.MdiParent = this;
                v_dm_loai_yeu_cau.Show();
            }
            else
            {
                v_dm_loai_yeu_cau.Focus();
            }
         
        }

        TOSApp.BaoCao.f500_BAO_CAO_DANH_GIA v_bao_cao_danh_gia;
        TOSApp.BaoCao.f510_BAO_CAO_TIEP_NHAN v_bao_cao_tiep_nhan;
        TOSApp.BaoCao.f520_BAO_CAO_XU_LI v_bao_cao_xu_ly;
        private void m_cmd_bao_cao_tiep_nhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (v_bao_cao_tiep_nhan == null || !IsFormOpen(v_bao_cao_tiep_nhan))
            {
                v_bao_cao_tiep_nhan = new TOSApp.BaoCao.f510_BAO_CAO_TIEP_NHAN();
                v_bao_cao_tiep_nhan.MdiParent = this;
                v_bao_cao_tiep_nhan.Show();
            }
            else
            {
                v_bao_cao_tiep_nhan.Focus();
            }
        }

        private void m_cmd_bao_cao_xu_ly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (v_bao_cao_xu_ly == null || !IsFormOpen(v_bao_cao_xu_ly))
            {
                v_bao_cao_xu_ly = new TOSApp.BaoCao.f520_BAO_CAO_XU_LI();
                v_bao_cao_xu_ly.MdiParent = this;
                v_bao_cao_xu_ly.Show();
            }
            else
            {
                v_bao_cao_tiep_nhan.Focus();
            }
        }

        private void m_cmd_bao_cao_danh_gia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (v_bao_cao_danh_gia == null || !IsFormOpen(v_bao_cao_danh_gia))
            {
                v_bao_cao_danh_gia = new TOSApp.BaoCao.f500_BAO_CAO_DANH_GIA();
                v_bao_cao_danh_gia.MdiParent = this;
                v_bao_cao_danh_gia.Show();
            }
            else
            {
                v_bao_cao_tiep_nhan.Focus();
            }
        }

        private void m_cmd_cap_nhat_deadline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            decimal deadline_id = 1;
            try
            {
                f117_ds_tat_ca_don_dat_hang v_f = new f117_ds_tat_ca_don_dat_hang();
                v_f.MdiParent = this;

                v_f.display_for_refurse_dealine(deadline_id);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_PM_cap_nhat_deadline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            decimal deadline_id = 1;
            try
            {
                f117_ds_tat_ca_don_dat_hang v_f = new f117_ds_tat_ca_don_dat_hang();
                v_f.MdiParent = this;

                v_f.display_for_refurse_dealine(deadline_id);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                F120_ds_don_hang_khach_hang v_f = new F120_ds_don_hang_khach_hang();
                v_f.MdiParent = this;

                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     

      




    }
}
