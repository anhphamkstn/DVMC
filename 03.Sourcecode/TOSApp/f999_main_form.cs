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
using TOSApp.DanhMuc;
using TOSApp.Hệ_thống;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using System.Collections;
using TOSApp.HT;
using TOSApp.App_Code;
using IPCOREDS.CDBNames;
using IPCOREUS;

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

            if(us_user.dcIDNhom != 3 && us_user.dcIDNhom != 5)
            {
                m_barsubitem_tao_moi_user.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (us_user.dcID != 134 && us_user.dcID != 141)
            {
                m_rib_dm_email.Visible = false;
                m_rib_blacklist.Visible = false;
            }
            if (us_user.dcIDNhom != 5)
            {
                m_rib_bo_pm_td_dich_vu.Visible = false;
            }
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
                    v_don_hang_can_tiep_nhan_BO.Text = "Đơn hàng cần tiếp nhận";
                    v_don_hang_can_tiep_nhan_BO.m_lab_tieu_de.Text = "Danh sách đơn hàng cần tiếp nhận";
                    v_don_hang_can_tiep_nhan_BO.m_panel_BO_hoan_thanh.Visible = false;
                    v_don_hang_can_tiep_nhan_BO.m_cmd_cap_nhat_BO.Visible = false;
                    v_don_hang_can_tiep_nhan_BO.m_cmd_BO_cap_nhat_xu_ly.Visible = false;
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
                    v_don_hang_dang_xu_ly_BO.Text = "Đơn hàng đang xử lý";
                    v_don_hang_dang_xu_ly_BO.m_lab_tieu_de.Text = "Danh sách đơn hàng đang xử lý";
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
                   // v_don_hang_can_xu_ly_PM = new f0000_gd_dat_hang_gd_log_dat_hang(2);
                    v_don_hang_can_xu_ly_PM = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                    v_don_hang_can_xu_ly_PM.MdiParent = this;
                    v_don_hang_can_xu_ly_PM.Text = "Đơn hàng cần xử lý";
                    v_don_hang_can_xu_ly_PM.m_lab_tieu_de.Text = "Danh sách đơn hàng cần xử lý";
                    v_don_hang_can_xu_ly_PM.m_panel_PM_hoan_thanh.Visible = false;
                    v_don_hang_can_xu_ly_PM.m_cmd_cap_nhat_PM.Visible = false;
                    v_don_hang_can_xu_ly_PM.m_cmd_PM_cap_nhat_xu_ly.Visible = false;
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
                    v_don_hang_dang_xu_ly_PM.Text = "Đơn hàng đang xử lý";
                    v_don_hang_dang_xu_ly_PM.m_lab_tieu_de.Text = "Danh sách đơn hàng đang xử lý";
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
                    v_don_hang_can_xu_ly_TD = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                    v_don_hang_can_xu_ly_TD.MdiParent = this;
                    v_don_hang_can_xu_ly_TD.Text = "Đơn hàng cần xử lý";
                    v_don_hang_can_xu_ly_TD.m_lab_tieu_de.Text = "Danh sách đơn hàng cần xử lý";
                    v_don_hang_can_xu_ly_TD.m_panel_TD_hoan_thanh.Visible = false;
                    v_don_hang_can_xu_ly_TD.m_cmd_cap_nhat_TD.Visible = false;
                    v_don_hang_can_xu_ly_TD.m_cmd_TD_cap_nhat_xu_ly.Visible = false;
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
                    v_don_hang_dang_xu_ly_TD.Text = "Đơn hàng đang xử lý";
                    v_don_hang_dang_xu_ly_TD.m_lab_tieu_de.Text = "Danh sách đơn hàng đang xử lý";
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
                    v_don_hang_can_danh_gia_TM.Text = "Đơn hàng cần đánh giá";
                    v_don_hang_can_danh_gia_TM.m_lab_tieu_de.Text = "Danh sách đơn hàng cần đánh giá";
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
                    v_don_hang_dieu_phoi_lai_FO.Text = "f000_Đơn hàng điều phối lại";
                    v_don_hang_dieu_phoi_lai_FO.m_lab_tieu_de.Text = "Danh sách đơn hàng cần điều phối lại";
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
                v_bao_cao_xu_ly.Focus();
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
                f120_ds_don_hang_khach_hang v_f = new f120_ds_don_hang_khach_hang();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bo_pm_td_dich_vu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f999_ht_bo_pm_td_dich_vu v_f = new f999_ht_bo_pm_td_dich_vu();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForInsert();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_barsubitem_tao_moi_user_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f121_tao_user_moi v_f = new f121_tao_user_moi();
            v_f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_don_hang_dang_xu_ly_TD == null || !IsFormOpen(v_don_hang_dang_xu_ly_TD))
                {
                    v_don_hang_dang_xu_ly_TD = new f0000_gd_dat_hang_gd_log_dat_hang(1);
                    v_don_hang_dang_xu_ly_TD.MdiParent = this;
                    v_don_hang_dang_xu_ly_TD.Text = "Đơn hàng đang xử lý";
                    v_don_hang_dang_xu_ly_TD.m_lab_tieu_de.Text = "Danh sách đơn hàng đang xử lý";
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

        private void m_baritem_dang_xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void m_cmd_pm_don_hang_dang_xu_ly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f122_ds_don_hang_dang_xu_ly v_f = new f122_ds_don_hang_dang_xu_ly();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_pm_don_hang_can_xu_ly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f123_ds_don_hang_can_xu_ly v_f = new f123_ds_don_hang_can_xu_ly();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_td_don_hang_dang_xu_ly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f122_ds_don_hang_dang_xu_ly v_f = new f122_ds_don_hang_dang_xu_ly();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_td_don_hang_can_xu_ly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f123_ds_don_hang_can_xu_ly v_f = new f123_ds_don_hang_can_xu_ly();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_blacklist_FO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f122_blacklist v_f = new f122_blacklist();
            v_f.MdiParent = this;
            v_f.Show();

        }

     

        private void m_cmd_blacklist_TD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f122_blacklist v_f = new f122_blacklist();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void dang_xuat(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            us_user.trang_thai_dang_nhap = false;
            this.Close();

        }

        private void m_cmd_blacklist_pm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f122_blacklist v_f = new f122_blacklist();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_ds_can_danh_gia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f125_ds_don_hang_can_danh_gia v_f = new f125_ds_don_hang_can_danh_gia(0);
            v_f.MdiParent = this;
            v_f.Text = "f125 - danh sách đơn hàng cần đánh giá";
            v_f.Show();
        }

        private void m_cmd_ds_da_danh_gia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f125_ds_don_hang_can_danh_gia v_f = new f125_ds_don_hang_can_danh_gia(1);
            v_f.MdiParent = this;
            v_f.Text = "f125 - danh sách đơn hàng đã đánh giá";
            v_f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

               // check_incoming_call();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }  
        }

        //private void check_incoming_call()
        //{
        //    string m_str_stationId = "2300"; //ip-phone
        //    string v_str_result_api = "", v_str_link_services = "";

        //    v_str_link_services = "http://203.162.121.70:8080/TPCServer/tpc/DoAction.jsp?event=" + WEB_URL_CALL_CENTER.GET_INCOMING_CALL(m_str_stationId);

        //    string v_str_output = CallCenterUtils.get_incoming_call(v_str_link_services).Data;
        //    US_GD_CUOC_GOI_YEU_CAU m_us_gd_cuoc_goi_yc = new US_GD_CUOC_GOI_YEU_CAU();
        //    if (v_str_output == "") return;
        //    CallInfor v_obj_callinfo = HelpUtils.get_start_callinfo_from_client_string_call(v_str_output);
        //    if (v_obj_callinfo.mobile_phone == "Anonymous") return;
        //   // if (m_us_gd_cuoc_goi_yc.is_call_id_exist(v_obj_callinfo.call_id)) return; phải có check đấy nhé
        //    if (v_obj_callinfo.call_id == ""
        //        || v_obj_callinfo.call_id == null) return;

        //    //HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.CALL_API, "SV_GOI_DEN", v_str_link_services, v_str_result_api);
        //    // ghi log gọi điện

        //    m_timer_imcoming_call.Enabled = false;
        //    f100_don_dat_hang_new v_f = new f100_don_dat_hang_new();
        //    v_f.display_for_ipphone(v_obj_callinfo);

        //   // HelpUtils.open_form_sinh_vien_call(v_obj_callinfo);
        //    m_timer_imcoming_call.Enabled = true;
       // }



       
    }
}

