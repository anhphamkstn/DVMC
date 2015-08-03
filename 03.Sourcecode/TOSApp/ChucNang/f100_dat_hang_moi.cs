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
using TOSApp.App_Code;

namespace TOSApp.ChucNang
{
    public partial class f100_dat_hang_moi : Form
    {
        public f100_dat_hang_moi()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interface
        public void display_for_update(US_V_GD_DAT_HANG ip_us_v_gd_dat_hang)
        {
            m_us_v_gd_dat_hang = ip_us_v_gd_dat_hang;
            m_e_fome_mode = e_form_mode.UPDATE_DATA;
            this.ShowDialog();
        }
        public void display_for_update_hoan_thanh_don_hang(US_V_GD_DAT_HANG ip_us_v_gd_dat_hang)
        {
            m_us_v_gd_dat_hang = ip_us_v_gd_dat_hang;
            m_e_fome_mode = e_form_mode.HOAN_THANH_DON_HANG;
            this.ShowDialog();
        }
        public void display_for_insert_form_main()
        {
            m_e_fome_mode = e_form_mode.INSERT_FROM_MAIN_FORM;
            this.ShowDialog();
        }
        public void display_for_insert_form_master()
        {
            m_e_fome_mode = e_form_mode.INSERT_FROM_MASTER;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_form_mode
        {
            INSERT_FROM_MASTER = 0
            , INSERT_FROM_MAIN_FORM=1 
            , UPDATE_DATA = 2
            , HOAN_THANH_DON_HANG = 3
        }
        private enum e_cbo_state
        {
            DANG_FILL_DATA = 0
            , DA_FILL_DATA_XONG = 1
        }
        #endregion

        #region Members
        US_V_GD_DAT_HANG m_us_v_gd_dat_hang = new US_V_GD_DAT_HANG();
        DS_V_GD_DAT_HANG m_ds_v_gd_dat_hang = new DS_V_GD_DAT_HANG();
        US_DM_MAU_EMAIL m_us_dm_mau_mail = new US_DM_MAU_EMAIL();
        DS_DM_MAU_EMAIL m_ds_dm_mau_mail_xac_nhan = new DS_DM_MAU_EMAIL();
        DS_DM_MAU_EMAIL m_ds_dm_mau_mail_hoan_thanh = new DS_DM_MAU_EMAIL();
        DS_DM_MAU_EMAIL m_ds_dm_mau_mail_cap_nhat_don_hang = new DS_DM_MAU_EMAIL();
        e_form_mode m_e_fome_mode;
        e_cbo_state m_e_cbo_trang_thai_don_hang = e_cbo_state.DANG_FILL_DATA;
        e_cbo_state m_e_cbo_trang_thai_loai_dich_vu = e_cbo_state.DANG_FILL_DATA;
        e_cbo_state m_e_clb_nguoi_xu_ly_state = e_cbo_state.DANG_FILL_DATA;
        string m_str_loai_thoi_gian_hoan_thanh = "";

        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);

            this.ShowInTaskbar = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            m_cbo_dich_vu.Visible = false;
            set_define_events();
        }
        private void set_initial_form_load()
        {
            load_data_2_dv_quan_ly();
            load_data_2_nguoi_nhan_dat_hang();
            load_data_2_nguoi_xu_ly_don_hang();
            load_data_2_cbo_loai_dich_vu();
            m_dat_thoi_gian_dat_hang.Value = DateTime.Now;
            m_cbo_nguoi_xu_ly_don_hang.SelectedIndex = 0;
            m_txt_nguoi_dat_hang.AutoCompleteCustomSource = load_thong_tin_nguoi_dat_hang();
            switch (m_e_fome_mode)
            {
                case e_form_mode.INSERT_FROM_MAIN_FORM:
                    load_data_2_trang_thai_don_hang();
                    m_txt_ma_don_hang.Text = get_ma_don_hang_moi();
                    m_e_clb_nguoi_xu_ly_state = e_cbo_state.DA_FILL_DATA_XONG;
                    m_cbo_nguoi_nhan_dat_hang.SelectedValue = f002_main_form.m_dc_id_user;
                    m_lbl_trang_thai_don_hang.Visible = false;
                    m_cbo_trang_thai_don_hang.Visible = false;
                    break;
                case e_form_mode.INSERT_FROM_MASTER:
                    load_data_2_trang_thai_don_hang();
                    m_txt_ma_don_hang.Text = get_ma_don_hang_moi();
                    m_e_clb_nguoi_xu_ly_state = e_cbo_state.DA_FILL_DATA_XONG;
                    m_cbo_nguoi_nhan_dat_hang.SelectedValue = f002_main_form.m_dc_id_user;
                    m_lbl_trang_thai_don_hang.Visible = false;
                    m_cbo_trang_thai_don_hang.Visible = false;
                    break;
                case e_form_mode.UPDATE_DATA:
                    load_data_2_trang_thai_don_hang_de_cap_nhat();
                    m_pnl_nguoi_dat_hang_infor.Enabled = false;
                    m_grb_loai_dich_vu.Enabled = false;
                    m_chk_gui_mail_yn.Visible = true;
                    us_object_2_form();
                    m_cmd_luu.Text = "Cập nhật";
                    m_chk_gui_mail_yn.Visible = false;
                    m_lbl_trang_thai_don_hang.Visible = true;
                    m_cbo_trang_thai_don_hang.Visible = true;
                    break;
                case e_form_mode.HOAN_THANH_DON_HANG:
                    load_data_2_trang_thai_don_hang();
                    m_pnl_nguoi_dat_hang_infor.Enabled = false;
                    m_grb_loai_dich_vu.Enabled = false;
                    m_grb_thoi_gian_hoan_thanh.Enabled = false;
                    us_object_2_form();
                    m_cmd_luu.Text = "Cập nhật";
                    m_chk_gui_mail_yn.Visible = false;
                    m_lbl_trang_thai_don_hang.Visible = true;
                    m_cbo_trang_thai_don_hang.Visible = true;
                    m_cbo_trang_thai_don_hang.SelectedValue = TU_DIEN_TRANG_THAI_DON_HANG.DA_DONG;
                    break;
            }
            // load mẫu mail sẽ gửi cho khách hàng khi nhập mới
            m_us_dm_mau_mail.load_mau_email_by_ma_mau(m_ds_dm_mau_mail_xac_nhan, MAU_EMAIL.XAC_NHAN_YC);
            m_us_dm_mau_mail.load_mau_email_by_ma_mau(m_ds_dm_mau_mail_hoan_thanh, MAU_EMAIL.HOAN_THANH_YC);
            m_us_dm_mau_mail.load_mau_email_by_ma_mau(m_ds_dm_mau_mail_cap_nhat_don_hang, MAU_EMAIL.CAP_NHAT_YC);
        }
        private void load_data_2_dv_quan_ly()
        {
            US_DM_DON_VI v_us_don_vi = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds_don_vi = new DS_DM_DON_VI();
            v_us_don_vi.load_danh_sach_don_vi(v_ds_don_vi);

            DataRow v_dr = v_ds_don_vi.DM_DON_VI.NewDM_DON_VIRow();
            v_dr[DM_DON_VI.ID] = 0;
            v_dr[DM_DON_VI.MA_DON_VI] = "- Chọn một đơn vị -";
            v_ds_don_vi.EnforceConstraints = false;
            v_ds_don_vi.DM_DON_VI.Rows.InsertAt(v_dr, 0);

            m_cbo_dv_don_vi.DataSource = v_ds_don_vi.DM_DON_VI;
            m_cbo_dv_don_vi.DisplayMember = DM_DON_VI.MA_DON_VI;
            m_cbo_dv_don_vi.ValueMember = DM_DON_VI.ID;
        }
        private void load_data_2_trang_thai_don_hang()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_DON_HANG
                                                              , CM_DM_TU_DIEN.TEN
                                                              , v_ds_tu_dien);

            m_cbo_trang_thai_don_hang.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai_don_hang.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_don_hang.ValueMember = CM_DM_TU_DIEN.ID;

            m_e_cbo_trang_thai_don_hang = e_cbo_state.DA_FILL_DATA_XONG;
        }
        private void load_data_2_trang_thai_don_hang_de_cap_nhat()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, " WHERE " + CM_DM_TU_DIEN.ID_LOAI_TU_DIEN + " = " 
                                                             + LOAI_TU_DIEN_ID.TRANG_THAI_GD_YEU_CAU 
                                                             + " AND " + CM_DM_TU_DIEN.ID + " <> " + TU_DIEN_TRANG_THAI_DON_HANG.DA_DONG
                                                             + " ORDER BY " + CM_DM_TU_DIEN.TEN);

            m_cbo_trang_thai_don_hang.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai_don_hang.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_don_hang.ValueMember = CM_DM_TU_DIEN.ID;

            m_e_cbo_trang_thai_don_hang = e_cbo_state.DA_FILL_DATA_XONG;
        }
        private void load_data_2_nguoi_xu_ly_don_hang()
        {
            US_HT_NGUOI_SU_DUNG v_us_nguoi_dung = new US_HT_NGUOI_SU_DUNG();
            DS_HT_NGUOI_SU_DUNG v_ds_nguoi_dung = new DS_HT_NGUOI_SU_DUNG();
            v_us_nguoi_dung.LoadNguoiDungXuLy("", v_ds_nguoi_dung);
            DataRow v_dr = v_ds_nguoi_dung.HT_NGUOI_SU_DUNG.NewHT_NGUOI_SU_DUNGRow();
            v_dr[HT_NGUOI_SU_DUNG.ID] = 0;
            v_dr[HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "- Chọn người xử lý -";
            v_ds_nguoi_dung.EnforceConstraints = false;
            v_ds_nguoi_dung.HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nguoi_xu_ly_don_hang.DataSource = v_ds_nguoi_dung.HT_NGUOI_SU_DUNG;
            m_cbo_nguoi_xu_ly_don_hang.DisplayMember = HT_NGUOI_SU_DUNG.TEN_TRUY_CAP;
            m_cbo_nguoi_xu_ly_don_hang.ValueMember = HT_NGUOI_SU_DUNG.ID;
        }
        private void load_data_2_nguoi_nhan_dat_hang()
        {
            US_HT_NGUOI_SU_DUNG v_us_nguoi_dung = new US_HT_NGUOI_SU_DUNG();
            DS_HT_NGUOI_SU_DUNG v_ds_nguoi_dung = new DS_HT_NGUOI_SU_DUNG();
            v_us_nguoi_dung.LoadNguoiDungTiepNhan("", v_ds_nguoi_dung);

            DataRow v_dr = v_ds_nguoi_dung.HT_NGUOI_SU_DUNG.NewHT_NGUOI_SU_DUNGRow();
            v_dr[HT_NGUOI_SU_DUNG.ID] = 0;
            v_dr[HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "- Chọn người nhận đặt hàng -";
            v_ds_nguoi_dung.EnforceConstraints = false;
            v_ds_nguoi_dung.HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nguoi_nhan_dat_hang.DataSource = v_ds_nguoi_dung.HT_NGUOI_SU_DUNG;
            m_cbo_nguoi_nhan_dat_hang.DisplayMember = HT_NGUOI_SU_DUNG.TEN_TRUY_CAP;
            m_cbo_nguoi_nhan_dat_hang.ValueMember = HT_NGUOI_SU_DUNG.ID;
        }
        private void load_data_2_cbo_loai_dich_vu()
        {
            US_DM_LOAI_YEU_CAU v_us_loai_dich_vu = new US_DM_LOAI_YEU_CAU();
            DS_DM_LOAI_YEU_CAU v_ds_loai_dich_vu = new DS_DM_LOAI_YEU_CAU();
            v_us_loai_dich_vu.load_ds_loai_dich_vu(v_ds_loai_dich_vu);

            DataRow v_dr = v_ds_loai_dich_vu.DM_LOAI_YEU_CAU.NewDM_LOAI_YEU_CAURow();
            v_dr[DM_LOAI_YEU_CAU.ID] = 0;
            v_dr[DM_LOAI_YEU_CAU.TEN_YEU_CAU] = "- Chọn một loại dịch vụ -";
            v_ds_loai_dich_vu.EnforceConstraints = false;
            v_ds_loai_dich_vu.DM_LOAI_YEU_CAU.Rows.InsertAt(v_dr, 0);

            m_cbo_loai_dich_vu.DataSource = v_ds_loai_dich_vu.DM_LOAI_YEU_CAU;
            m_cbo_loai_dich_vu.DisplayMember = DM_LOAI_YEU_CAU.TEN_YEU_CAU;
            m_cbo_loai_dich_vu.ValueMember = DM_LOAI_YEU_CAU.ID;
            
            m_e_cbo_trang_thai_loai_dich_vu = e_cbo_state.DA_FILL_DATA_XONG;
        }
        private void load_data_2_cbo_dich_vu()
        {
            US_DM_LOAI_YEU_CAU v_us_dich_vu = new US_DM_LOAI_YEU_CAU();
            DS_DM_LOAI_YEU_CAU v_ds_dich_vu = new DS_DM_LOAI_YEU_CAU();
            decimal v_dc_id_loai_dich_vu = CIPConvert.ToDecimal(m_cbo_loai_dich_vu.SelectedValue);
            v_us_dich_vu.load_ds_dich_vu_by_loai(v_dc_id_loai_dich_vu, v_ds_dich_vu);

            DataRow v_dr = v_ds_dich_vu.DM_LOAI_YEU_CAU.NewDM_LOAI_YEU_CAURow();
            v_dr[DM_LOAI_YEU_CAU.ID] = 0;
            if (v_ds_dich_vu.DM_LOAI_YEU_CAU.Rows.Count == 0)
            {
                v_dr[DM_LOAI_YEU_CAU.TEN_YEU_CAU] = "- Không có dịch vụ con -";
                m_cbo_dich_vu.Enabled = false;
            }
            else
            {
                v_dr[DM_LOAI_YEU_CAU.TEN_YEU_CAU] = "- Chọn một dịch vụ -";
                m_cbo_dich_vu.Enabled = true;
            }
            v_ds_dich_vu.EnforceConstraints = false;
            v_ds_dich_vu.DM_LOAI_YEU_CAU.Rows.InsertAt(v_dr, 0);

            m_cbo_dich_vu.DataSource = v_ds_dich_vu.DM_LOAI_YEU_CAU;
            m_cbo_dich_vu.DisplayMember = DM_LOAI_YEU_CAU.TEN_YEU_CAU;
            m_cbo_dich_vu.ValueMember = DM_LOAI_YEU_CAU.ID;
        }
        private AutoCompleteStringCollection load_thong_tin_nguoi_dat_hang()
        {
            US_DM_NGUOI_DAT_HANG v_us_dm_nguoi_dat_hang = new US_DM_NGUOI_DAT_HANG();
            DS_DM_NGUOI_DAT_HANG v_ds_dm_nguoi_dat_hang = new DS_DM_NGUOI_DAT_HANG();
            AutoCompleteStringCollection v_auto_complete_string_ten_nguoi_dat_hang = new AutoCompleteStringCollection();
            v_us_dm_nguoi_dat_hang.load_ds_nguoi_dat_hang(v_ds_dm_nguoi_dat_hang);
            if (v_ds_dm_nguoi_dat_hang.DM_NGUOI_DAT_HANG.Rows.Count > 0)
            {
                foreach (DataRow v_dr in v_ds_dm_nguoi_dat_hang.DM_NGUOI_DAT_HANG.Rows)
                {
                    v_auto_complete_string_ten_nguoi_dat_hang.Add(v_dr[DM_NGUOI_DAT_HANG.USER_TOPICA].ToString());
                }
            }
            return v_auto_complete_string_ten_nguoi_dat_hang;
        }
        private string get_ma_don_hang_moi()
        {
            string v_str_ma_don_hang_moi = "";
            v_str_ma_don_hang_moi = m_us_v_gd_dat_hang.get_ma_dat_hang_tiep_theo();
            return v_str_ma_don_hang_moi;
        }
        private decimal get_loai_thoi_gian_hoan_thanh()
        {
            decimal v_dc_id_loai_thoi_gian_hoan_thanh= 0;
            if (m_rdb_loai_time_15phut.Checked)
            {
                v_dc_id_loai_thoi_gian_hoan_thanh = LOAI_THOI_GIAN_HOAN_THANH_ID.MUOI_LAM_PHUT_15;
                m_str_loai_thoi_gian_hoan_thanh = "15 phút";
            }
            else if (m_rdb_loai_time_4h.Checked)
            {
                v_dc_id_loai_thoi_gian_hoan_thanh = LOAI_THOI_GIAN_HOAN_THANH_ID.BON_GIO_4h;
                m_str_loai_thoi_gian_hoan_thanh = "4h";
            }
            else if (m_rdb_loai_time_1ngay.Checked)
            {
                v_dc_id_loai_thoi_gian_hoan_thanh = LOAI_THOI_GIAN_HOAN_THANH_ID.MOT_NGAY_1ngay;
                m_str_loai_thoi_gian_hoan_thanh = "1 ngày";
            }
            else if (m_rdb_loai_time_1tuan.Checked)
            {
                v_dc_id_loai_thoi_gian_hoan_thanh = LOAI_THOI_GIAN_HOAN_THANH_ID.MOT_TUAN_1tuan;
                m_str_loai_thoi_gian_hoan_thanh = "1 tuần";
            }
            else if (m_rdb_loai_time_1thang.Checked)
            {
                v_dc_id_loai_thoi_gian_hoan_thanh = LOAI_THOI_GIAN_HOAN_THANH_ID.MOT_THANG_1thang;
                m_str_loai_thoi_gian_hoan_thanh = "1 tháng";
            }
            return v_dc_id_loai_thoi_gian_hoan_thanh;
        }
        private void get_check_loai_thoi_gian_hoan_thanh(decimal ip_dc_id_loai_thoi_gian_hoan_thanh)
        {
            if (ip_dc_id_loai_thoi_gian_hoan_thanh == LOAI_THOI_GIAN_HOAN_THANH_ID.MUOI_LAM_PHUT_15) m_rdb_loai_time_15phut.Checked= true;
            else if (ip_dc_id_loai_thoi_gian_hoan_thanh == LOAI_THOI_GIAN_HOAN_THANH_ID.BON_GIO_4h) m_rdb_loai_time_4h.Checked = true;
            else if (ip_dc_id_loai_thoi_gian_hoan_thanh == LOAI_THOI_GIAN_HOAN_THANH_ID.MOT_NGAY_1ngay) m_rdb_loai_time_1ngay.Checked =true;
            else if (ip_dc_id_loai_thoi_gian_hoan_thanh == LOAI_THOI_GIAN_HOAN_THANH_ID.MOT_TUAN_1tuan) m_rdb_loai_time_1tuan.Checked=true;
        }
        private void set_thong_tin_dich_vu(decimal ip_dc_id_dich_vu, decimal ip_dc_loai_dich_vu_cha)
        {
            if (ip_dc_loai_dich_vu_cha == 0
                || ip_dc_loai_dich_vu_cha == null)
                m_cbo_loai_dich_vu.SelectedValue = ip_dc_id_dich_vu;
            else
            {
                m_cbo_loai_dich_vu.SelectedValue = ip_dc_loai_dich_vu_cha;
                m_cbo_dich_vu.SelectedValue = ip_dc_id_dich_vu;
            }
        }
        private void form_2_us_object()
        {
            m_us_v_gd_dat_hang.strMA_DON_HANG = m_txt_ma_don_hang.Text;

            // Thông tin ngừời đặt hàng
            m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG = m_txt_nguoi_dat_hang.Text.Trim();
            m_us_v_gd_dat_hang.strDIEN_THOAI = m_txt_dien_thoai.Text.Trim();
            m_us_v_gd_dat_hang.strHO_TEN_USER_DAT_HANG = m_txt_ho_ten.Text.Trim();
            m_us_v_gd_dat_hang.dcID_DON_VI = CIPConvert.ToDecimal(m_cbo_dv_don_vi.SelectedValue);
            m_us_v_gd_dat_hang.datTHOI_GIAN_DAT_HANG = m_dat_thoi_gian_dat_hang.Value;

            // Thông tin về đơn hàng
            if (m_cbo_dich_vu.Items.Count > 1
                && m_cbo_dich_vu.Enabled)
                m_us_v_gd_dat_hang.dcID_LOAI_DV_YEU_CAU = CIPConvert.ToDecimal(m_cbo_dich_vu.SelectedValue);
            else m_us_v_gd_dat_hang.dcID_LOAI_DV_YEU_CAU = CIPConvert.ToDecimal(m_cbo_loai_dich_vu.SelectedValue);
            m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG = m_txt_yeu_cau_cu_the.Text.Trim();
            m_us_v_gd_dat_hang.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH = get_loai_thoi_gian_hoan_thanh();
            m_us_v_gd_dat_hang.strLICH_SU_TRAO_DOI = m_txt_lich_su_trao_doi.Text.Trim();
            // Thông tin từ DVMC
            m_us_v_gd_dat_hang.strPHAN_HOI_TU_DVMC = m_txt_phan_hoi_tu_dvmc.Text.Trim();
            m_us_v_gd_dat_hang.dcID_NGUOI_NHAN_DAT_HANG = CIPConvert.ToDecimal(m_cbo_nguoi_nhan_dat_hang.SelectedValue);
            if (m_chk_nhieu_nguoi_xu_ly_yn.Checked)
            {
                m_us_v_gd_dat_hang.strNGUOI_XU_LY = m_txt_nguoi_xu_ly.Text;
                m_us_v_gd_dat_hang.dcID_NGUOI_XU_LY = 0;
            }
            else
            {
                m_us_v_gd_dat_hang.dcID_NGUOI_XU_LY = CIPConvert.ToDecimal(m_cbo_nguoi_xu_ly_don_hang.SelectedValue);
                m_us_v_gd_dat_hang.strNGUOI_XU_LY = m_cbo_nguoi_xu_ly_don_hang.Text;
            }
            m_us_v_gd_dat_hang.dcID_NGUOI_TAO = f002_main_form.m_dc_id_user;
        }
        private void us_object_2_form()
        {
            m_txt_ma_don_hang.Text = m_us_v_gd_dat_hang.strMA_DON_HANG;

            // Thông tin ngừời đặt hàng
            m_txt_nguoi_dat_hang.Text = m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG;
            m_txt_dien_thoai.Text = m_us_v_gd_dat_hang.strDIEN_THOAI;
            m_txt_ho_ten.Text = m_us_v_gd_dat_hang.strHO_TEN_USER_DAT_HANG;
            m_cbo_dv_don_vi.SelectedValue = m_us_v_gd_dat_hang.dcID_DON_VI;
            m_dat_thoi_gian_dat_hang.Value= m_us_v_gd_dat_hang.datTHOI_GIAN_DAT_HANG;

            // Thông tin về đơn hàng
            set_thong_tin_dich_vu(m_us_v_gd_dat_hang.dcID_LOAI_DV_YEU_CAU, m_us_v_gd_dat_hang.dcID_LOAI_YEU_CAU_CHA);
            get_check_loai_thoi_gian_hoan_thanh(m_us_v_gd_dat_hang.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH);
            m_txt_yeu_cau_cu_the.Text = m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG;
            m_txt_lich_su_trao_doi.Text = m_us_v_gd_dat_hang.strLICH_SU_TRAO_DOI;

            // Thông tin từ DVMC
            m_txt_phan_hoi_tu_dvmc.Text = m_us_v_gd_dat_hang.strPHAN_HOI_TU_DVMC;
            m_cbo_nguoi_nhan_dat_hang.SelectedValue = m_us_v_gd_dat_hang.dcID_NGUOI_NHAN_DAT_HANG;
            if (m_us_v_gd_dat_hang.strNGUOI_XU_LY.IndexOf(",") > 0)  // có nhiều người xử lý đơn hàng
            {
                m_txt_nguoi_xu_ly.Text = m_us_v_gd_dat_hang.strNGUOI_XU_LY;
                m_cbo_nguoi_xu_ly_don_hang.Visible = false;
                m_txt_nguoi_xu_ly.Visible = true;
                m_chk_nhieu_nguoi_xu_ly_yn.Checked = true;
            }
            else
            {
                m_cbo_nguoi_xu_ly_don_hang.Visible = true;
                m_txt_nguoi_xu_ly.Visible = false;
                m_cbo_nguoi_xu_ly_don_hang.SelectedValue = m_us_v_gd_dat_hang.dcID_NGUOI_XU_LY;
            }
            m_e_clb_nguoi_xu_ly_state = e_cbo_state.DA_FILL_DATA_XONG;

            m_cbo_trang_thai_don_hang.SelectedValue = m_us_v_gd_dat_hang.dcID_TRANG_THAI;
            if (m_us_v_gd_dat_hang.dcID_TRANG_THAI == TU_DIEN_TRANG_THAI_DON_HANG.DA_DONG)
            {
                m_cbo_trang_thai_don_hang.Enabled = false;
                m_cmd_luu.Enabled = false;
            }
        }
        private bool is_ma_don_vi_correct(string ip_str_ma_don_vi)
        {
            int v_i_flag = 0;
            for (int v_i = 0; v_i < m_cbo_dv_don_vi.Items.Count; v_i++)
            {
                if (m_cbo_dv_don_vi.Items[v_i].Equals(ip_str_ma_don_vi)) v_i_flag = 1;
            }
            //if (v_i_flag == 1) return true;
            return true;
        }
        private void save_data()
        {
            if (!is_validate_data()) return;
            form_2_us_object();
            switch (m_e_fome_mode)
            {
                case e_form_mode.INSERT_FROM_MAIN_FORM:
                    m_us_v_gd_dat_hang.Insert();
                    if (m_chk_gui_mail_yn.Checked)
                        gui_email_xac_nhan_don_hang();
                    if (BaseMessages.MsgBox_Confirm("Đã thêm mới đơn hàng thành công, bạn có muốn nhập nữa không?"))
                        reset_form();
                    else this.Close();
                    break;
                case e_form_mode.INSERT_FROM_MASTER:
                    m_us_v_gd_dat_hang.Insert();
                    if(m_chk_gui_mail_yn.Checked)
                        gui_email_xac_nhan_don_hang();
                    if (BaseMessages.MsgBox_Confirm("Đã thêm mới đơn hàng thành công, bạn có muốn nhập nữa không?"))
                        reset_form();
                    else this.Close();
                    break;
                case e_form_mode.UPDATE_DATA:
                    m_us_v_gd_dat_hang.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_don_hang.SelectedValue);
                    m_us_v_gd_dat_hang.dcID_NGUOI_SUA_CUOI = f002_main_form.m_dc_id_user;
                    m_us_v_gd_dat_hang.cap_nhat_don_hang();
                    if(m_chk_gui_mail_yn.Checked)
                        gui_email_cap_nhat_don_hang();
                    BaseMessages.MsgBox_Infor("Dữ liệu được cập nhật thành công!");
                    this.Close();
                    break;
                case e_form_mode.HOAN_THANH_DON_HANG:
                    m_us_v_gd_dat_hang.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_don_hang.SelectedValue);
                    m_us_v_gd_dat_hang.dcID_NGUOI_SUA_CUOI = f002_main_form.m_dc_id_user;
                    m_us_v_gd_dat_hang.cap_nhat_don_hang();
                    gui_email_hoan_thanh_don_hang();
                    BaseMessages.MsgBox_Infor("Dữ liệu được cập nhật thành công!");
                    this.Close();
                    break;
            }
        }
        private bool is_validate_data()
        {
            if (!CValidateTextBox.IsValid(m_txt_nguoi_dat_hang, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_yeu_cau_cu_the, DataType.StringType, allowNull.NO, true)) return false;
            if (m_cbo_dv_don_vi.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn đơn vị công tác của Người đặt hàng");
                m_cbo_dv_don_vi.Focus();
                return false;
            }
            /*if (!is_ma_don_vi_correct(m_cbo_dv_don_vi.Text))
            {
                BaseMessages.MsgBox_Infor("Mã đơn vị bạn chọn không nằm trong danh sách!");
                m_cbo_dv_don_vi.Focus();
                return false;
            }*/
            if (m_cbo_loai_dich_vu.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn loại dịch vụ");
                m_cbo_loai_dich_vu.Focus();
                return false;
            }
            if (m_cbo_dich_vu.SelectedIndex == 0
                && m_cbo_dich_vu.Enabled
                && m_cbo_dich_vu.Items.Count > 1)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn dịch vụ");
                m_cbo_dich_vu.Focus();
                return false;
            }
            if (m_cbo_nguoi_nhan_dat_hang.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn người nhận đặt hàng");
                m_cbo_nguoi_nhan_dat_hang.Focus();
                return false;
            }
            if (m_chk_nhieu_nguoi_xu_ly_yn.Checked == false
                && m_cbo_nguoi_xu_ly_don_hang.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn người xử lý đơn hàng!");
                m_cbo_nguoi_xu_ly_don_hang.Focus();
                return false;
            }
            return true;
        }
        private void reset_form()
        {
            m_txt_ma_don_hang.Text = get_ma_don_hang_moi();
            m_txt_nguoi_dat_hang.Text = "";
            m_txt_nguoi_dat_hang.Focus();
            m_txt_ho_ten.Text = "";
            m_cbo_dv_don_vi.SelectedIndex = 0;
            m_txt_dien_thoai.Text = "";
            m_dat_thoi_gian_dat_hang.Value = DateTime.Now;
            m_cbo_loai_dich_vu.SelectedIndex = 0;
            m_txt_yeu_cau_cu_the.Text = "";
            m_rdb_loai_time_4h.Checked = true;
            m_txt_phan_hoi_tu_dvmc.Text = "";
            m_cbo_nguoi_nhan_dat_hang.SelectedIndex = 0;
            m_cbo_nguoi_xu_ly_don_hang.SelectedIndex = 0;
        }
        private void load_thong_tin_nguoi_dat_hang_by_user()
        {
            string v_str_user_nv_dat_hang = m_txt_nguoi_dat_hang.Text.Trim();
            US_DM_NGUOI_DAT_HANG v_us_dm_ng_dat_hang = new US_DM_NGUOI_DAT_HANG();
            DS_DM_NGUOI_DAT_HANG v_ds_dm_ng_dat_hang = new DS_DM_NGUOI_DAT_HANG();
            v_us_dm_ng_dat_hang.FillDataset(v_ds_dm_ng_dat_hang, " WHERE " + DM_NGUOI_DAT_HANG.USER_TOPICA + " = '" + v_str_user_nv_dat_hang + "'");

            if (v_ds_dm_ng_dat_hang.DM_NGUOI_DAT_HANG.Rows.Count == 1)
            {
                if (v_ds_dm_ng_dat_hang.DM_NGUOI_DAT_HANG.Rows[0][DM_NGUOI_DAT_HANG.SO_DIEN_THOAI]!= null)
                    m_txt_dien_thoai.Text = v_ds_dm_ng_dat_hang.DM_NGUOI_DAT_HANG.Rows[0][DM_NGUOI_DAT_HANG.SO_DIEN_THOAI].ToString();
                m_txt_ho_ten.Text = v_ds_dm_ng_dat_hang.DM_NGUOI_DAT_HANG.Rows[0][DM_NGUOI_DAT_HANG.HO_TEN].ToString();
                m_cbo_dv_don_vi.SelectedValue = v_ds_dm_ng_dat_hang.DM_NGUOI_DAT_HANG.Rows[0][DM_NGUOI_DAT_HANG.ID_DON_VI];
            }
        }
        private string get_bcc_mail()
        {
            string v_str_bcc_list = "";
            v_str_bcc_list = m_ds_dm_mau_mail_xac_nhan.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.GUI_CC].ToString();
            string v_str_nguoi_xu_ly = m_us_v_gd_dat_hang.strNGUOI_XU_LY;
            string[] v_str_list_nguoi_xu_ly = v_str_nguoi_xu_ly.Split(',');
            for (int v_i = 0; v_i < v_str_list_nguoi_xu_ly.Length; v_i++)
            {
                v_str_bcc_list = v_str_bcc_list + v_str_list_nguoi_xu_ly[v_i] + "@topica.edu.vn,";
            }
            if(v_str_bcc_list.Substring(v_str_bcc_list.Length-1,1) == ",")
                v_str_bcc_list = v_str_bcc_list.Substring(0, v_str_bcc_list.Length - 1);
            return v_str_bcc_list;
        }
        private void gui_email_xac_nhan_don_hang()
        {
            string v_str_email_dvmc = f002_main_form.m_str_email_dvmc;
            string v_str_password_dvmc = CEncryptKeyString.DecryptString(f002_main_form.m_str_password_dvmc);
            string to = m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG + "@topica.edu.vn";
            string v_str_subject = "";
            string v_str_content = "";
            string v_str_bcc_list = "";
            string v_str_link_portal = f002_main_form.m_str_url_xac_nhan_don_hang;
            v_str_link_portal = v_str_link_portal.Replace("<MA_DON_HANG>", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_subject = m_ds_dm_mau_mail_xac_nhan.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.TIEU_DE_MAIL].ToString();
            v_str_content = m_ds_dm_mau_mail_xac_nhan.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.NOI_DUNG_EMAIL].ToString();

            // Find and replace thông tin trong content mail
            v_str_content = v_str_content.Replace("MA_DON_HANG", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_content = v_str_content.Replace("LINK_VIEW_DON_HANG", v_str_link_portal);
            v_str_content = v_str_content.Replace("NOI_DUNG_DON_HANG", m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG);
            v_str_content = v_str_content.Replace("USER_NHAN_VIEN", m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG);
            v_str_content = v_str_content.Replace("USER_DON_VI", m_cbo_dv_don_vi.Text);
            v_str_content = v_str_content.Replace("USER_DIEN_THOAI", m_us_v_gd_dat_hang.strDIEN_THOAI);
            v_str_content = v_str_content.Replace("USER_THOI_GIAN_DAT_HANG", m_us_v_gd_dat_hang.datTHOI_GIAN_DAT_HANG.ToString());
            v_str_content = v_str_content.Replace("LOAI_DICH_VU_HO_TRO", m_cbo_loai_dich_vu.Text);
            v_str_content = v_str_content.Replace("YEU_CAU_CU_THE", m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG);
            v_str_content = v_str_content.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", m_str_loai_thoi_gian_hoan_thanh);
            v_str_content = v_str_content.Replace("PHAN_HOI_CUA_DVMC", m_us_v_gd_dat_hang.strPHAN_HOI_TU_DVMC);
            v_str_content = v_str_content.Replace("NGUOI_XU_LY_DON_HANG", m_us_v_gd_dat_hang.strNGUOI_XU_LY);
            v_str_content = v_str_content.Replace("NGUOI_NHAN_DAT_HANG", m_cbo_nguoi_nhan_dat_hang.Text);
            v_str_content = v_str_content + f002_main_form.m_str_chu_ky_dvmc;

            v_str_subject = v_str_subject.Replace("<MA_DON_HANG>", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_bcc_list = get_bcc_mail();
            try
            {
               HelpUtils.send_mail("Dịch Vụ Một Cửa", v_str_email_dvmc, v_str_password_dvmc, to, v_str_bcc_list, v_str_subject, v_str_content);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e, "Gửi email thông báo cho khách hàng lỗi.  Hãy xem lại cấu hình email DVMC!");
            }
        }
        private void gui_email_hoan_thanh_don_hang()
        {
            string v_str_email_dvmc = f002_main_form.m_str_email_dvmc;
            string v_str_password_dvmc = CEncryptKeyString.DecryptString(f002_main_form.m_str_password_dvmc);
            string to = m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG + "@topica.edu.vn";
            string v_str_subject = "";
            string v_str_content = "";
            string v_str_link_portal = f002_main_form.m_str_url_hoan_thanh_don_hang;
            v_str_link_portal = v_str_link_portal.Replace("<MA_DON_HANG>", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_subject = m_ds_dm_mau_mail_hoan_thanh.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.TIEU_DE_MAIL].ToString();
            v_str_content = m_ds_dm_mau_mail_hoan_thanh.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.NOI_DUNG_EMAIL].ToString();

            // find and replace thông tin trong content mail
            v_str_content = v_str_content.Replace("MA_DON_HANG", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_content = v_str_content.Replace("LINK_DANH_GIA_DON_HANG", v_str_link_portal);
            v_str_content = v_str_content.Replace("NOI_DUNG_DON_HANG", m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG);
            v_str_content = v_str_content.Replace("USER_NHAN_VIEN", m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG);
            v_str_content = v_str_content.Replace("USER_DON_VI", m_cbo_dv_don_vi.Text);
            v_str_content = v_str_content.Replace("USER_DIEN_THOAI", m_us_v_gd_dat_hang.strDIEN_THOAI);
            v_str_content = v_str_content.Replace("USER_THOI_GIAN_DAT_HANG", m_us_v_gd_dat_hang.datTHOI_GIAN_DAT_HANG.ToString());
            v_str_content = v_str_content.Replace("LOAI_DICH_VU_HO_TRO", m_cbo_loai_dich_vu.Text);
            v_str_content = v_str_content.Replace("YEU_CAU_CU_THE", m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG);
            v_str_content = v_str_content.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", m_str_loai_thoi_gian_hoan_thanh);
            v_str_content = v_str_content.Replace("PHAN_HOI_CUA_DVMC", m_us_v_gd_dat_hang.strPHAN_HOI_TU_DVMC);
            v_str_content = v_str_content.Replace("NGUOI_XU_LY_DON_HANG", m_us_v_gd_dat_hang.strNGUOI_XU_LY);
            v_str_content = v_str_content.Replace("NGUOI_NHAN_DAT_HANG", m_cbo_nguoi_nhan_dat_hang.Text);
            v_str_content = v_str_content.Replace("LICH_SU_TRAO_DOI", m_txt_lich_su_trao_doi.Text);
            v_str_content = v_str_content.Replace("THOI_GIAN_HOAN_THANH_THUC_TE", CIPConvert.ToStr(DateTime.Now,"HH:mm:ss dd/MM/yyyy"));
            
            v_str_content = v_str_content + f002_main_form.m_str_chu_ky_dvmc;
            v_str_subject = v_str_subject.Replace("<MA_DON_HANG>", m_us_v_gd_dat_hang.strMA_DON_HANG);
            try
            {
                HelpUtils.send_mail("Dịch Vụ Một Cửa", v_str_email_dvmc, v_str_password_dvmc, to, "", v_str_subject, v_str_content);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e, "Gửi email thông báo cho khách hàng lỗi.  Hãy xem lại cấu hình email DVMC!");
            }
        }
        private void gui_email_cap_nhat_don_hang()
        {
            string v_str_email_dvmc = f002_main_form.m_str_email_dvmc;
            string v_str_password_dvmc = CEncryptKeyString.DecryptString(f002_main_form.m_str_password_dvmc);
            string to = m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG + "@topica.edu.vn";
            string v_str_subject = "";
            string v_str_content = "";
            string v_str_bcc_list = "";
            string v_str_link_portal = f002_main_form.m_str_url_xac_nhan_don_hang;
            v_str_link_portal = v_str_link_portal.Replace("<MA_DON_HANG>", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_subject = m_ds_dm_mau_mail_cap_nhat_don_hang.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.TIEU_DE_MAIL].ToString();
            v_str_content = m_ds_dm_mau_mail_cap_nhat_don_hang.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.NOI_DUNG_EMAIL].ToString();

            // Find and replace thông tin trong content mail
            v_str_content = v_str_content.Replace("MA_DON_HANG", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_content = v_str_content.Replace("LINK_VIEW_DON_HANG", v_str_link_portal);
            v_str_content = v_str_content.Replace("THONG_TIN_THAY_DOI", m_us_v_gd_dat_hang.strLICH_SU_TRAO_DOI);
            v_str_content = v_str_content.Replace("NOI_DUNG_DON_HANG", m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG);
            v_str_content = v_str_content.Replace("USER_NHAN_VIEN", m_us_v_gd_dat_hang.strUSER_NV_DAT_HANG);
            v_str_content = v_str_content.Replace("USER_DON_VI", m_cbo_dv_don_vi.Text);
            v_str_content = v_str_content.Replace("USER_DIEN_THOAI", m_us_v_gd_dat_hang.strDIEN_THOAI);
            v_str_content = v_str_content.Replace("USER_THOI_GIAN_DAT_HANG", m_us_v_gd_dat_hang.datTHOI_GIAN_DAT_HANG.ToString());
            v_str_content = v_str_content.Replace("LOAI_DICH_VU_HO_TRO", m_cbo_loai_dich_vu.Text);
            v_str_content = v_str_content.Replace("YEU_CAU_CU_THE", m_us_v_gd_dat_hang.strNOI_DUNG_DAT_HANG);
            v_str_content = v_str_content.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", m_str_loai_thoi_gian_hoan_thanh);
            v_str_content = v_str_content.Replace("PHAN_HOI_CUA_DVMC", m_us_v_gd_dat_hang.strPHAN_HOI_TU_DVMC);
            v_str_content = v_str_content.Replace("NGUOI_XU_LY_DON_HANG", m_us_v_gd_dat_hang.strNGUOI_XU_LY);
            v_str_content = v_str_content.Replace("NGUOI_NHAN_DAT_HANG", m_cbo_nguoi_nhan_dat_hang.Text);
            v_str_content = v_str_content.Replace("LICH_SU_TRAO_DOI", m_txt_lich_su_trao_doi.Text);

            v_str_content = v_str_content + f002_main_form.m_str_chu_ky_dvmc;
            v_str_subject = v_str_subject.Replace("<MA_DON_HANG>", m_us_v_gd_dat_hang.strMA_DON_HANG);
            v_str_bcc_list = get_bcc_mail();
            try
            {
                HelpUtils.send_mail("Dịch Vụ Một Cửa", v_str_email_dvmc, v_str_password_dvmc, to, v_str_bcc_list, v_str_subject, v_str_content);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e, "Gửi email thông báo cho khách hàng lỗi.  Hãy xem lại cấu hình email DVMC!");
            }
        }
        private void chon_nhieu_nguoi_xu_ly()
        {
            if (m_e_clb_nguoi_xu_ly_state == e_cbo_state.DANG_FILL_DATA) return;
            
            if (m_chk_nhieu_nguoi_xu_ly_yn.Checked)
            {
                string v_str_user_nguoi_xu_ly = "";
                switch (m_e_fome_mode)
                {
                    case e_form_mode.UPDATE_DATA:
                        v_str_user_nguoi_xu_ly = m_us_v_gd_dat_hang.strNGUOI_XU_LY;
                        break;
                    case e_form_mode.HOAN_THANH_DON_HANG:
                        v_str_user_nguoi_xu_ly = m_us_v_gd_dat_hang.strNGUOI_XU_LY;
                        break;
                }
                m_txt_nguoi_xu_ly.Visible = true;
                m_cbo_nguoi_xu_ly_don_hang.Visible = false;
                f102_chon_danh_sach_nguoi_xu_ly v_f102 = new f102_chon_danh_sach_nguoi_xu_ly();
                v_str_user_nguoi_xu_ly = v_f102.display_to_select(v_str_user_nguoi_xu_ly);
                if (v_str_user_nguoi_xu_ly == "") 
                    m_chk_nhieu_nguoi_xu_ly_yn.Checked = false;
                else
                {
                    v_str_user_nguoi_xu_ly = v_str_user_nguoi_xu_ly.Substring(0, v_str_user_nguoi_xu_ly.Length - 1);
                    m_txt_nguoi_xu_ly.Text = v_str_user_nguoi_xu_ly;
                }
            }
            else
            {
                m_txt_nguoi_xu_ly.Visible = false;
                m_cbo_nguoi_xu_ly_don_hang.Visible = true;
            }
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.m_cmd_exit.Click += new EventHandler(m_cmd_thoat_Click);
            this.Load += new EventHandler(f100_dat_hang_moi_Load);
            this.m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            this.KeyDown += new KeyEventHandler(f100_dat_hang_moi_KeyDown);
            m_txt_nguoi_dat_hang.Leave += new EventHandler(m_txt_nguoi_dat_hang_Leave);
            m_cbo_loai_dich_vu.SelectedIndexChanged += new EventHandler(m_cbo_loai_dich_vu_SelectedIndexChanged);
            m_chk_nhieu_nguoi_xu_ly_yn.CheckedChanged += new EventHandler(m_chk_nhieu_nguoi_xu_ly_yn_CheckedChanged);
        }

        void m_chk_nhieu_nguoi_xu_ly_yn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                 chon_nhieu_nguoi_xu_ly();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_cbo_trang_thai_loai_dich_vu == e_cbo_state.DANG_FILL_DATA) return;
                if (m_cbo_loai_dich_vu.SelectedIndex == 0) m_cbo_dich_vu.Visible = false;
                m_cbo_dich_vu.Visible = true;
                load_data_2_cbo_dich_vu();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_txt_nguoi_dat_hang_Leave(object sender, EventArgs e)
        {
            try
            {
                load_thong_tin_nguoi_dat_hang_by_user();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f100_dat_hang_moi_Load(object sender, EventArgs e)
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

        void f100_dat_hang_moi_KeyDown(object sender, KeyEventArgs e)
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
        #endregion

        internal void Insert_form()
        {
            throw new NotImplementedException();
        }
    }
}
