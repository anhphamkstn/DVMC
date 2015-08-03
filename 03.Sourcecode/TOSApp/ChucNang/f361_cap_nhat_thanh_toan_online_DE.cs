using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IPCOREDS;
using IPCOREDS.CDBNames;
using IPCOREUS;
using IP.Core.IPUserService;
using IP.Core.IPData;
using System.IO;
using System.Net;

namespace TOSApp
{
    public partial class f361_cap_nhat_thanh_toan_online_DE : Form
    {
        public f361_cap_nhat_thanh_toan_online_DE()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interface
        public void display_for_update(US_V_GD_THANH_TOAN_LUONG_ONLINE ip_us_v_dm_mau_hop_dong)
        {
            m_us_v_gd_thanh_toan_online = ip_us_v_dm_mau_hop_dong;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_cbo_state_data
        {
            DANG_FILL_DATA = 0,
            DA_FILL_DATA_XONG = 1
        }
        #endregion

        #region Members
        e_cbo_state_data m_e_cbo_trang_thai_tt_state = e_cbo_state_data.DANG_FILL_DATA;
        US_V_GD_THANH_TOAN_LUONG_ONLINE m_us_v_gd_thanh_toan_online = new US_V_GD_THANH_TOAN_LUONG_ONLINE();
        DS_V_GD_THANH_TOAN_LUONG_ONLINE m_ds_v_gd_thanh_toan_online = new DS_V_GD_THANH_TOAN_LUONG_ONLINE();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;

            m_lbl_ngay_thuc_hien.Visible = false;
            m_dat_ngay_thuc_hien.Visible = false;
            m_dat_ngay_thuc_hien.Value = DateTime.Today;

            set_define_events();
        }
        private void set_initial_form_load()
        {
            load_data_2_truong_quan_ly();
            load_data_2_trang_thai_thanh_toan();
            us_object_2_form(m_us_v_gd_thanh_toan_online);
            if (m_us_v_gd_thanh_toan_online.dcID_TRANG_THAI == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_THANH_TOAN)
                m_cbo_trang_thai_thanh_toan.Enabled = false;
        }
        private void load_data_2_truong_quan_ly()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.DON_VI_QUAN_LY_CHINH
                                                              , CM_DM_TU_DIEN.TEN
                                                              , v_ds_tu_dien);

            DataRow v_dr = v_ds_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = 0;
            v_dr[CM_DM_TU_DIEN.TEN] = "- Chọn một trường quản lý -";
            v_ds_tu_dien.EnforceConstraints = false;
            v_ds_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_dv_quan_ly.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_quan_ly.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_quan_ly.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_trang_thai_thanh_toan()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_LUONG_ONL
                                                              , CM_DM_TU_DIEN.TEN
                                                              , v_ds_tu_dien);

            DataRow v_dr = v_ds_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = 0;
            v_dr[CM_DM_TU_DIEN.TEN] = "- Tất cả trạng thái -";
            v_ds_tu_dien.EnforceConstraints = false;
            v_ds_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_trang_thai_thanh_toan.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai_thanh_toan.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_thanh_toan.ValueMember = CM_DM_TU_DIEN.ID;

            m_e_cbo_trang_thai_tt_state = e_cbo_state_data.DA_FILL_DATA_XONG;
        }
        private void us_object_2_form(US_V_GD_THANH_TOAN_LUONG_ONLINE ip_us_gd_thanh_toan_online)
        {
            m_cbo_dv_quan_ly.SelectedValue = ip_us_gd_thanh_toan_online.dcID_DON_VI_QUAN_LY;
            m_txt_ho_ten_gv.Text = ip_us_gd_thanh_toan_online.strHO_TEN_GIANG_VIEN;
            m_txt_noi_dung_thanh_toan.Text = ip_us_gd_thanh_toan_online.strNOI_DUNG_THANH_TOAN;
            m_txt_ten_course.Text = ip_us_gd_thanh_toan_online.strCOURSE_NAME;
            m_txt_don_gia.Text = CIPConvert.ToStr(ip_us_gd_thanh_toan_online.dcDON_GIA, "#,###");

            if (ip_us_gd_thanh_toan_online.dcID_KHOAN_CHI == C_TU_DIEN_LOAI_NOI_DUNG_HD_ONLINE.LUONG_CM_CHINH_TRI
                || ip_us_gd_thanh_toan_online.dcID_KHOAN_CHI == C_TU_DIEN_LOAI_NOI_DUNG_HD_ONLINE.LUONG_CM_KO_CHINH_TRI
                || ip_us_gd_thanh_toan_online.dcID_KHOAN_CHI == C_TU_DIEN_LOAI_NOI_DUNG_HD_ONLINE.LUONG_HD_CHINH_TRI
                || ip_us_gd_thanh_toan_online.dcID_KHOAN_CHI == C_TU_DIEN_LOAI_NOI_DUNG_HD_ONLINE.LUONG_HD_KO_CHINH_TRI)
            {
                m_txt_so_luong.Text = "1";
                m_txt_he_so.Text = CIPConvert.ToStr(ip_us_gd_thanh_toan_online.dcSO_LUONG_HE_SO,"#,###.0");
            }
            else
            {
                if (ip_us_gd_thanh_toan_online.dcSO_LUONG_HE_SO == 0)
                    m_txt_so_luong.Text = "0";
                else m_txt_so_luong.Text = CIPConvert.ToStr(ip_us_gd_thanh_toan_online.dcSO_LUONG_HE_SO, "#,###");
                m_txt_he_so.Text = "1";
            }

            m_txt_he_so.Text = CIPConvert.ToStr(ip_us_gd_thanh_toan_online.dcSO_LUONG_HE_SO, "#,###.0");
            m_cbo_trang_thai_thanh_toan.SelectedValue = ip_us_gd_thanh_toan_online.dcID_TRANG_THAI;
            m_txt_ghi_chu.Text = ip_us_gd_thanh_toan_online.strGHI_CHU;

            // Cho phép sửa thông tin ra đề, chấm bài cuối kỳ
            if (ip_us_gd_thanh_toan_online.dcID_KHOAN_CHI == C_TU_DIEN_LOAI_NOI_DUNG_HD_ONLINE.RA_DE_HET_MON
               || ip_us_gd_thanh_toan_online.dcID_KHOAN_CHI == C_TU_DIEN_LOAI_NOI_DUNG_HD_ONLINE.CHAM_HET_MON)
            {
                m_txt_so_luong.Enabled = true;
                m_txt_so_luong.BackColor = Color.White;
            }
        }
        private bool is_validate_data()
        {
            decimal v_dc_id_trang_thai_chuyen = CIPConvert.ToDecimal(m_cbo_trang_thai_thanh_toan.SelectedValue);
            DateTime v_dat_ngay_thuc_hien = m_dat_ngay_thuc_hien.Value;
            if (!is_chuyen_state_oke(m_us_v_gd_thanh_toan_online.dcID_TRANG_THAI, v_dc_id_trang_thai_chuyen))
            {
                BaseMessages.MsgBox_Infor("Không thể chuyển lùi trạng thái được!");
                m_cbo_trang_thai_thanh_toan.Focus();
                return false;
            }
            if (v_dc_id_trang_thai_chuyen == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_CHUYEN_CT
              && v_dat_ngay_thuc_hien.Date < m_us_v_gd_thanh_toan_online.datNGAY_TAO_CT.Date)
            {
                BaseMessages.MsgBox_Infor("Ngày chuyển chứng từ phải lớn hơn hoặc bằng ngày tạo chứng từ");
                m_dat_ngay_thuc_hien.Focus();
                return false;
            }
            if (v_dc_id_trang_thai_chuyen == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_THANH_TOAN
              && v_dat_ngay_thuc_hien.Date < m_us_v_gd_thanh_toan_online.datNGAY_TAO_CT.Date)
            {
                BaseMessages.MsgBox_Infor("Ngày thanh toán từ phải lớn hơn hoặc bằng ngày tạo chứng từ");
                return false;
            }
              if (v_dc_id_trang_thai_chuyen == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_THANH_TOAN
              && v_dat_ngay_thuc_hien.Date < m_us_v_gd_thanh_toan_online.datNGAY_CHUYEN_CT.Date)
            {
                BaseMessages.MsgBox_Infor("Ngày thanh toán từ phải lớn hơn hoặc bằng ngày chuyển chứng từ");
                return false;
            }
            return true;
        }
        private void form_2_us_object()
        {
            m_us_v_gd_thanh_toan_online.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_thanh_toan.SelectedValue);
            m_us_v_gd_thanh_toan_online.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
            if (m_us_v_gd_thanh_toan_online.dcID_TRANG_THAI == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_CHUYEN_CT)
                m_us_v_gd_thanh_toan_online.datNGAY_CHUYEN_CT = m_dat_ngay_thuc_hien.Value;
            else if(m_us_v_gd_thanh_toan_online.dcID_TRANG_THAI == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_THANH_TOAN)
                m_us_v_gd_thanh_toan_online.datNGAY_THANH_TOAN = m_dat_ngay_thuc_hien.Value;
        }
        private void save_data()
        {
            if (!is_validate_data()) return;
            form_2_us_object();
            m_us_v_gd_thanh_toan_online.Update();
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }
        private bool is_chuyen_state_oke(decimal ip_dc_id_trang_thai_tu
                                        , decimal ip_dc_id_trang_thai_den)
        {
            if (ip_dc_id_trang_thai_den < ip_dc_id_trang_thai_tu) return false;
            return true;
        }
        #endregion

        ///
        ///event handlers
        ///
        private void set_define_events()
        {
            this.m_cmd_exit.Click += new EventHandler(m_cmd_thoat_Click);
            this.Load += new EventHandler(f121_dm_loai_phoi_chung_chi_DE_Load);
            this.m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cbo_trang_thai_thanh_toan.SelectedIndexChanged += new EventHandler(m_cbo_trang_thai_thanh_toan_SelectedIndexChanged);
            this.KeyDown += new KeyEventHandler(f361_cap_nhat_thanh_toan_online_DE_KeyDown);
        }

        void m_cbo_trang_thai_thanh_toan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_cbo_trang_thai_tt_state == e_cbo_state_data.DANG_FILL_DATA) return;
                if (CIPConvert.ToDecimal(m_cbo_trang_thai_thanh_toan.SelectedValue) == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_CHUYEN_CT)
                {
                    m_lbl_ngay_thuc_hien.Visible = true;
                    m_lbl_ngay_thuc_hien.Text = "Ngày chuyển chứng từ";
                    m_dat_ngay_thuc_hien.Visible = true;
                }
                else if (CIPConvert.ToDecimal(m_cbo_trang_thai_thanh_toan.SelectedValue) == C_TU_DIEN_TRANG_THAI_TT_ONLINE.DA_THANH_TOAN)
                {
                    m_lbl_ngay_thuc_hien.Visible = true;
                    m_lbl_ngay_thuc_hien.Text = "Ngày thanh toán";
                    m_dat_ngay_thuc_hien.Visible = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f361_cap_nhat_thanh_toan_online_DE_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void f121_dm_loai_phoi_chung_chi_DE_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
    }
}
