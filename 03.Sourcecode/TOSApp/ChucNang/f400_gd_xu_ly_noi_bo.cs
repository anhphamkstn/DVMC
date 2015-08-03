using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using IPCOREDS;
using IPCOREDS.CDBNames;
using IPCOREUS;
using System.IO;
using TOSApp.App_Code;
using System.Collections;
using System.Net.Mail;
using System.Net;

namespace TOSApp.ChucNang
{
    public partial class f400_gd_xu_ly_noi_bo : Form
    {
        public f400_gd_xu_ly_noi_bo()
        {
            InitializeComponent();

            format_controls();
        }

        #region Members
        US_DM_NGUOI_DUNG_STATION m_us_dm_user_station = new US_DM_NGUOI_DUNG_STATION();
        US_V_GD_CAU_HOI_YEU_CAU m_gd_cau_hoi_yeu_cau_hoc_vien;
        US_GD_XU_LY_NOI_BO m_us_gd_xu_ly_noi_bo = new US_GD_XU_LY_NOI_BO();
        DS_GD_XU_LY_NOI_BO m_ds_gd_xu_ly_noi_bo = new DS_GD_XU_LY_NOI_BO();

        US_DM_MAU_EMAIL m_us_dm_mau_email = new US_DM_MAU_EMAIL();
        DS_DM_MAU_EMAIL m_ds_dm_mau_email = new DS_DM_MAU_EMAIL();

        ITransferDataRow m_obj_trans;
        ITransferDataRow m_obj_trans_tab1_assign;
        DS_V_GD_LICH_GOI_NOI_BO m_ds = new DS_V_GD_LICH_GOI_NOI_BO();
        US_V_GD_LICH_GOI_NOI_BO m_us = new US_V_GD_LICH_GOI_NOI_BO();

        US_DM_QLHT_SCM m_us_dm_qlht = new US_DM_QLHT_SCM();

        e_form_mode m_e_form_mode = e_form_mode.THEM_CAU_HOI;
        e_trang_thai_cbo_don_vi m_e_trang_thai_cbo_dv = e_trang_thai_cbo_don_vi.DANG_FILL_DATA;
        e_trang_thai_cbo_nguoi_dai_dien m_e_trang_thai_cbo_ndd = e_trang_thai_cbo_nguoi_dai_dien.DANG_FILL_DATA;
        e_form_state m_e_form_state = e_form_state.KHOI_TAO_FORM;

        string m_str_stationcode = "";
        CallInfor m_call_infor = new CallInfor();

        SCMServices.SyncData m_ws_scm;

        decimal m_dc_id_cau_hoi_xu_ly = 0;

        string m_str_tieu_de_mail = "", m_str_noi_dung_email = "", m_str_send_cc = "";
        string m_str_send_mail = "", m_str_password_send_mail = "";
        #endregion

        #region Data Structure
        public enum e_form_mode
        {
            THEM_CAU_HOI = 0
            ,
            SUA_CAU_HOI = 1
                ,
            DUYET_CAU_TRA_LOI = 2
                , THEM_CAU_TRA_LOI = 3
        }

        private enum e_col_Number
        {
            NOI_DUNG_TRAO_DOI = 5
,
            DATETIME_RESPOND = 6
                ,
            NDD_HO_TEN = 3
                ,
            SO_DIEN_THOAI_GOI = 4
                ,
            DON_VI_LIEN_QUAN = 2
                ,
            STT = 1
                , VOICE_CALL_LINK = 7
        }
        private enum e_col_Number_tab1_assign
        {
            STT = 1
            ,
            ACCOUNT_SCM = 2
                ,
            HO_TEN_QLHT = 3
                ,
            NOI_DUNG_TRAO_DOI = 4
                , THOI_GiAN_ASSIGN = 5
        }
        private enum e_form_state
        {
            KHOI_TAO_FORM = 0
            ,
            DA_CALL_NDD = 1
                , DA_LUU_THONG_TIN_CALL = 2
        }
        private enum e_trang_thai_cbo_don_vi
        {
            DANG_FILL_DATA = 0
            , DA_FILL_XONG = 1
        }
        private enum e_trang_thai_cbo_nguoi_dai_dien
        {
            DANG_FILL_DATA = 0
            , DA_FILL_XONG = 1
        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display_xu_ly_cau_hoi(decimal ip_dc_id_cau_hoi)
        {
            m_dc_id_cau_hoi_xu_ly = ip_dc_id_cau_hoi;
            this.ShowDialog();
        }
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            this.KeyPreview = true;
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
            m_txt_ghi_chu_toi_qlht.Focus();
            m_pic_call_ndd.Visible = false;
            m_fg.Cols[(int)e_col_Number.VOICE_CALL_LINK].Visible = false;
            set_define_events();
        }
        private void set_inital_form_load()
        {
            load_cbo_truong();
            load_cbo_truong_sinh_vien();
            load_data_2_cbo_don_vi_noi_bo();
            load_data_2_cbo_nguoi_dai_dien();
            load_thong_tin_cau_hoi();
            m_obj_trans = get_trans_object(m_fg);
            m_obj_trans_tab1_assign = get_trans_object_tab1_assign(m_fg_tab1_assign);
            load_data_2_grid();
            load_data_2_grid_tab1_assign();
            m_str_stationcode = m_us_dm_user_station.get_station_id_by_user(CAppContext_201.getCurrentUserID());
            m_txt_email_qlht.AutoCompleteCustomSource = load_thong_tin_email_qlht_search("");
        }
        private void load_thong_tin_cau_hoi()
        {
            m_gd_cau_hoi_yeu_cau_hoc_vien = new US_V_GD_CAU_HOI_YEU_CAU();
            m_gd_cau_hoi_yeu_cau_hoc_vien.dcID_CAU_HOI = m_dc_id_cau_hoi_xu_ly;
            m_gd_cau_hoi_yeu_cau_hoc_vien.load_gd_cau_hoi_by_id_cau_hoi();

            //Tab 1
            m_txt_sv_ho_ten.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strHO_TEN_SINH_VIEN;
            m_txt_sv_ma_lop.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strLOP;
            m_txt_sv_dien_thoai.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strSO_DIEN_THOAI;
            m_txt_ma_hoc_vien.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strMA_SINH_VIEN;
            m_txt_sv_noi_sinh.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strNOI_SINH;
            m_dat_sv_ngay_sinh.Value = m_gd_cau_hoi_yeu_cau_hoc_vien.datNGAY_SINH;
            m_cbo_sv_truong.SelectedValue = m_gd_cau_hoi_yeu_cau_hoc_vien.strTRUONG; // trường sinh viên

            m_tab1_txt_noi_dung_cau_hoi.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strNOI_DUNG_CAU_HOI;

            load_thong_tin_qlht(m_gd_cau_hoi_yeu_cau_hoc_vien.strMA_SINH_VIEN);
            // Tab 2
            m_tab2_txt_noi_dung_cau_hoi.Text = m_gd_cau_hoi_yeu_cau_hoc_vien.strNOI_DUNG_CAU_HOI;
        }

        #region Xử lý Tab1
        private void load_thong_tin_qlht(string ip_str_ma_sinh_vien)
        {
            string v_str_search_key_qlht = HelpUtils.gen_string_call_scm_get_QLHT_ws(ip_str_ma_sinh_vien, "", "", "", "10");
            DataSet v_ds_qlht = new DataSet();
            m_ws_scm = new SCMServices.SyncData();
            v_ds_qlht = m_ws_scm.TOS_search_qlht_all_T(v_str_search_key_qlht);
            if (v_ds_qlht.Tables[0].Rows.Count > 0)
            {
                m_us_dm_qlht.dcID = CIPConvert.ToDecimal(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.ID]);
                m_us_dm_qlht.strTEN_THAT = CIPConvert.ToStr(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.TEN_THAT]);
                m_us_dm_qlht.strACCOUNT = CIPConvert.ToStr(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.ACCOUNT]);
                m_us_dm_qlht.strMA_TRUONG = CIPConvert.ToStr(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.MA_TRUONG]);

                m_txt_qlht_ho_ten.Text = CIPConvert.ToStr(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.TEN_THAT]);
                m_txt_qlht_acc_scm.Text = CIPConvert.ToStr(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.ACCOUNT]);
                m_cbo_qlht_truong.SelectedValue = CIPConvert.ToStr(v_ds_qlht.Tables[0].Rows[0][DM_QLHT_SCM.MA_TRUONG]);
                if (m_txt_qlht_acc_scm.Text != "")
                    load_thong_tin_email_qlht(m_txt_qlht_acc_scm.Text);
            }
        }
        private void tab1_save_data()
        {
            // Lưu vào GD xử lý nội bộ
            // Thay đổi trạng thái và id người xử lý câu hỏi trong bảng GD câu hỏi học viên hỏi
            if (!check_validate_assign_qlht()) return;
            //form_2_us_assign_cho_qlht();
            //m_us_gd_xu_ly_noi_bo.Insert();
            //load_data_2_grid_tab1_assign();
            //HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.ASSIGN_QLHT, m_txt_qlht_ho_ten.Text, "Assign cho QLHT", "");
            gui_email_assign_cho_qlht();
            reset_form_tab1();
            BaseMessages.MsgBox_Infor("Đã assign và gửi email cho QLHT thành công!");
        }
        private void form_2_us_assign_cho_qlht()
        {
            m_us_gd_xu_ly_noi_bo.dcID_NGUOI_LIEN_QUAN = m_us_dm_qlht.dcID;
            m_us_gd_xu_ly_noi_bo.dcID_USER_GOI = CAppContext_201.getCurrentUserID();
            m_us_gd_xu_ly_noi_bo.dcID_HANH_DONG_NOI_BO = TU_DIEN_XU_LU_NB.ASSIGN;
            m_us_gd_xu_ly_noi_bo.strDUNG_SO_KHAC_YN = "N";
            m_us_gd_xu_ly_noi_bo.strSO_DIEN_THOAI_GOI = "";
            m_us_gd_xu_ly_noi_bo.dcID_CAU_HOI = m_dc_id_cau_hoi_xu_ly;
            m_us_gd_xu_ly_noi_bo.dcID_CUOC_GOI = 0;
            m_us_gd_xu_ly_noi_bo.strGHI_CHU = m_us_dm_qlht.strTEN_THAT;
            m_us_gd_xu_ly_noi_bo.strCALL_ID = "";
            m_us_gd_xu_ly_noi_bo.strVOICE_CALL_LINK = m_us_dm_qlht.strACCOUNT;
            m_us_gd_xu_ly_noi_bo.datEND_TIME = DateTime.Now;
            m_us_gd_xu_ly_noi_bo.datSTART_TIME = DateTime.Now;
            m_us_gd_xu_ly_noi_bo.dcSTATION_ID = 0;
            m_us_gd_xu_ly_noi_bo.dcDURATION = 0;
            m_us_gd_xu_ly_noi_bo.strSTATUS = "Y";
            m_us_gd_xu_ly_noi_bo.strERROR_CODE = "";
            m_us_gd_xu_ly_noi_bo.strERROR_DESC = "";
            m_us_gd_xu_ly_noi_bo.datDATETIME_RESPOND = DateTime.Now;
            m_us_gd_xu_ly_noi_bo.dcRINGTIME = 0;
            m_us_gd_xu_ly_noi_bo.strNOI_DUNG_TRAO_DOI = m_txt_ghi_chu_toi_qlht.Text.Trim();
        }
        private void chon_qlht_khac()
        {
            DataSet v_ds = new DataSet();
            f420_search_chon_qlht v_f420 = new f420_search_chon_qlht();
            US_DM_QLHT_SCM v_us_chon_qlht = new US_DM_QLHT_SCM();
            v_us_chon_qlht = v_f420.display();
            if (v_us_chon_qlht.dcID > 0)
                m_us_dm_qlht = v_us_chon_qlht;
            if (m_us_dm_qlht.dcID > 0)
            {
                m_txt_qlht_ho_ten.Text = m_us_dm_qlht.strTEN_THAT;
                m_txt_qlht_acc_scm.Text = m_us_dm_qlht.strACCOUNT;
                m_cbo_qlht_truong.SelectedValue = m_us_dm_qlht.strMA_TRUONG;
                if (m_us_dm_qlht.strACCOUNT != "")
                    load_thong_tin_email_qlht(m_us_dm_qlht.strACCOUNT);
            }
        }
        private void reset_form_tab1()
        {
            m_txt_ghi_chu_toi_qlht.Text = "";
        }
        private void load_cbo_truong()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            string v_str_loai_tu_dien = LOAI_TU_DIEN_ID.TO_CHUC_TRUONG.ToString();

            v_us_tu_dien.fill_tu_dien_by_procedure("pr_CM_DM_TU_DIEN_Load_tu_dien_by_procedure", v_str_loai_tu_dien, v_ds_tu_dien);

            m_cbo_qlht_truong.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_qlht_truong.ValueMember = CM_DM_TU_DIEN.MA_TU_DIEN;
            m_cbo_qlht_truong.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
        }
        private void load_cbo_truong_sinh_vien()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();

            v_us_tu_dien.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TO_CHUC_TRUONG, CM_DM_TU_DIEN.ID, v_ds_tu_dien);

            m_cbo_sv_truong.DisplayMember = CM_DM_TU_DIEN.MA_TU_DIEN;
            m_cbo_sv_truong.ValueMember = CM_DM_TU_DIEN.TEN;
            m_cbo_sv_truong.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
        }
        private ITransferDataRow get_trans_object_tab1_assign(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_XU_LY_NOI_BO.NOI_DUNG_TRAO_DOI, e_col_Number_tab1_assign.NOI_DUNG_TRAO_DOI);
            v_htb.Add(GD_XU_LY_NOI_BO.START_TIME, e_col_Number_tab1_assign.THOI_GiAN_ASSIGN);
            v_htb.Add(GD_XU_LY_NOI_BO.GHI_CHU, e_col_Number_tab1_assign.HO_TEN_QLHT);
            v_htb.Add(GD_XU_LY_NOI_BO.VOICE_CALL_LINK, e_col_Number_tab1_assign.ACCOUNT_SCM);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_gd_xu_ly_noi_bo.GD_XU_LY_NOI_BO.NewRow());
            return v_obj_trans;
        }
        private void load_thong_tin_email_qlht(string ip_str_acc_scm_qlht)
        {
            US_V_DM_NGUOI_DAI_DIEN v_us_dm_nguoi_dai_dien = new US_V_DM_NGUOI_DAI_DIEN();
            DS_V_DM_NGUOI_DAI_DIEN v_ds_dm_nguoi_dai_dien = new DS_V_DM_NGUOI_DAI_DIEN();
            if (ip_str_acc_scm_qlht != "")
            {
                v_ds_dm_nguoi_dai_dien.EnforceConstraints = false;
                v_us_dm_nguoi_dai_dien.load_nguoi_dai_dien_by_acc_scm(v_ds_dm_nguoi_dai_dien, ip_str_acc_scm_qlht);
                if (v_ds_dm_nguoi_dai_dien.V_DM_NGUOI_DAI_DIEN.Rows.Count > 0)
                    m_txt_email_qlht.Text = v_ds_dm_nguoi_dai_dien.V_DM_NGUOI_DAI_DIEN.Rows[0][V_DM_NGUOI_DAI_DIEN.NDD_EMAIL].ToString();
            }
        }
        private AutoCompleteStringCollection load_thong_tin_email_qlht_search(string ip_str_acc_scm_qlht)
        {
            US_V_DM_NGUOI_DAI_DIEN v_us_dm_nguoi_dai_dien = new US_V_DM_NGUOI_DAI_DIEN();
            DS_V_DM_NGUOI_DAI_DIEN v_ds_dm_nguoi_dai_dien = new DS_V_DM_NGUOI_DAI_DIEN();
            AutoCompleteStringCollection v_auto_complete_string_email = new AutoCompleteStringCollection();
            v_ds_dm_nguoi_dai_dien.EnforceConstraints = false;
            v_us_dm_nguoi_dai_dien.load_nguoi_dai_dien_by_acc_scm(v_ds_dm_nguoi_dai_dien, ip_str_acc_scm_qlht);
            if (v_ds_dm_nguoi_dai_dien.V_DM_NGUOI_DAI_DIEN.Rows.Count > 0)
            {
                foreach (DataRow v_dr in v_ds_dm_nguoi_dai_dien.V_DM_NGUOI_DAI_DIEN.Rows)
                {
                    v_auto_complete_string_email.Add(v_dr[V_DM_NGUOI_DAI_DIEN.NDD_EMAIL].ToString());
                }
            }
            return v_auto_complete_string_email;
        }
        private void gui_email_assign_cho_qlht()
        {
            try
            {
                m_us_dm_mau_email.load_mau_email_by_ma_mau(m_ds_dm_mau_email, MAU_EMAIL.XAC_NHAN_YC);
                string v_str_thong_tin_sv = "<strong>Thông tin sinh viên: </strong><br />";
                if (m_txt_sv_ho_ten.Text.Trim() != "")
                    v_str_thong_tin_sv += "Họ tên: " + m_txt_sv_ho_ten.Text + "; ";
                if (m_txt_sv_dien_thoai.Text.Trim() != "")
                    v_str_thong_tin_sv += "Điện thoại: " + m_txt_sv_dien_thoai.Text + "; ";
                if (m_cbo_sv_truong.SelectedValue != null)
                    v_str_thong_tin_sv += "Trường: " + m_cbo_sv_truong.SelectedValue + "; ";
                if (m_txt_sv_ma_lop.Text != null)
                    v_str_thong_tin_sv += "Lớp: " + m_txt_sv_ma_lop.Text + "; ";
                m_str_noi_dung_email = m_ds_dm_mau_email.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.NOI_DUNG_EMAIL].ToString();

                m_str_noi_dung_email += "<p>" + v_str_thong_tin_sv + "</p>";
                m_str_noi_dung_email += "<p>Ch&uacute;c c&ocirc; một ng&agrave;y l&agrave;m việc hiệu quả!</p>";
                m_str_tieu_de_mail = m_ds_dm_mau_email.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.TIEU_DE_MAIL].ToString();
                
                string v_str_cc_array = m_ds_dm_mau_email.DM_MAU_EMAIL.Rows[0][DM_MAU_EMAIL.GUI_CC].ToString();

                HelpUtils.send_mail(m_txt_email_qlht.Text.Trim(), v_str_cc_array, m_str_tieu_de_mail, m_str_noi_dung_email);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e, "Gửi email không thành công. Xem lại thông tin email, mật khẩu của bạn!");
            }
        }
        private void show_change_password()
        {
            string v_str_ten_truy_cap = CAppContext_201.getCurrentUserName();
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_dung = new US_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_dung.InitByTenTruyCap(v_str_ten_truy_cap);
            f998_ht_nguoi_su_dung_de v_f998_change_password = new f998_ht_nguoi_su_dung_de();
            v_f998_change_password.change_password(v_us_ht_nguoi_dung, "Y","Y");
        }
        private bool check_validate_assign_qlht()
        {
            if (f002_main_form.m_str_email_dvmc == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa cấu hình email cá nhân để gửi email");
                show_change_password();
                return false;
            }
            if (m_txt_email_qlht.Text.Trim() == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập email QLHT");
                return false;
            }
            return true;
        }
        #endregion

        #region Xử lý Tab2
        private bool tab2_check_validate_data_is_ok()
        {
            if (m_e_form_state == e_form_state.KHOI_TAO_FORM)
            {
                BaseMessages.MsgBox_Warning(THONG_BAO.WN_CHUA_THUC_HIEN_CUOC_GOI);
                return false;
            }
            return true;
        }
        private void tab2_save_data()
        {
            if (tab2_check_validate_data_is_ok() == false) return;
            m_us_gd_xu_ly_noi_bo.dcID = 1; // giá trị bất kỳ; update dựa vào call id
            m_call_infor = HelpUtils.get_call_infor(m_call_infor.call_id, m_call_infor.mobile_phone, m_call_infor.station_id, CAppContext_201.getCurrentUserName());
            form_2_usobject_goi_noi_bo();
            m_us_gd_xu_ly_noi_bo.Update();
            load_data_2_grid();
            reset_form_tab2();
            m_e_form_state = e_form_state.DA_LUU_THONG_TIN_CALL;
        }
        private void call_2_nguoi_dai_dien()
        {
            m_e_form_state = e_form_state.DA_CALL_NDD;
            string v_str_so_dien_thoai = "";
            v_str_so_dien_thoai = m_txt_dien_thoai_ndd.Text;
            m_call_infor = HelpUtils.call_2_contact(v_str_so_dien_thoai, m_str_stationcode, CAppContext_201.getCurrentUserName());

            // Insert vào GD xử lý nội bộ
            form_2_usobject_goi_noi_bo();
            m_us_gd_xu_ly_noi_bo.Insert();
            HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.USER_GOI_NOI_BO, m_cbo_nguoi_dai_dien.SelectedItem.ToString(), "Gọi nội bộ", "");
        }
        private void reset_form_tab2()
        {
            m_e_form_state = e_form_state.KHOI_TAO_FORM;
            m_txt_noi_dung_trao_doi.Text = "";
            m_txt_dien_thoai_ndd.Text = "";
            m_cbo_nguoi_dai_dien.SelectedIndex = 0;
            m_cbo_don_vi_noi_bo.SelectedIndex = 0;
            m_chb_dung_so_khac.Checked = false;
        }
        private void form_2_usobject_goi_noi_bo()
        {
            m_us_gd_xu_ly_noi_bo.dcID_NGUOI_LIEN_QUAN = CIPConvert.ToDecimal(m_cbo_nguoi_dai_dien.SelectedValue);
            m_us_gd_xu_ly_noi_bo.dcID_USER_GOI = CAppContext_201.getCurrentUserID();
            m_us_gd_xu_ly_noi_bo.dcID_HANH_DONG_NOI_BO = TU_DIEN_XU_LU_NB.GOI_DIEN;
            if (m_chb_dung_so_khac.Checked)
                m_us_gd_xu_ly_noi_bo.strDUNG_SO_KHAC_YN = "Y";
            else m_us_gd_xu_ly_noi_bo.strDUNG_SO_KHAC_YN = "N";
            m_us_gd_xu_ly_noi_bo.strSO_DIEN_THOAI_GOI = m_txt_dien_thoai_ndd.Text.Trim();
            m_us_gd_xu_ly_noi_bo.dcID_CAU_HOI = m_dc_id_cau_hoi_xu_ly;
            m_us_gd_xu_ly_noi_bo.strCALL_ID = m_call_infor.call_id;
            m_us_gd_xu_ly_noi_bo.strERROR_CODE = m_call_infor.error_code;
            m_us_gd_xu_ly_noi_bo.strERROR_DESC = m_call_infor.error_desc;
            m_us_gd_xu_ly_noi_bo.dcSTATION_ID = CIPConvert.ToDecimal(m_str_stationcode);

            if (m_call_infor.ringtime != null && m_call_infor.ringtime != "")
                m_us_gd_xu_ly_noi_bo.dcRINGTIME = CIPConvert.ToDecimal(m_call_infor.ringtime);
            else m_us_gd_xu_ly_noi_bo.dcRINGTIME = 0;

            if (m_call_infor.duration != null && m_call_infor.duration != "")
                m_us_gd_xu_ly_noi_bo.dcDURATION = CIPConvert.ToDecimal(m_call_infor.duration);
            else m_us_gd_xu_ly_noi_bo.dcDURATION = 0;

            if (m_call_infor.link_down_record != null && m_call_infor.link_down_record != "")
                m_us_gd_xu_ly_noi_bo.strVOICE_CALL_LINK = m_call_infor.link_down_record;
            else m_us_gd_xu_ly_noi_bo.strVOICE_CALL_LINK = "";

            if (m_call_infor.start_time != null && m_call_infor.start_time != "")
                m_us_gd_xu_ly_noi_bo.datSTART_TIME = HelpUtils.string_2_datetime(m_call_infor.start_time);
            else m_us_gd_xu_ly_noi_bo.datSTART_TIME = DateTime.Now;

            if (m_call_infor.end_time != null && m_call_infor.end_time != "")
                m_us_gd_xu_ly_noi_bo.datEND_TIME = HelpUtils.string_2_datetime(m_call_infor.end_time);
            else m_us_gd_xu_ly_noi_bo.SetEND_TIMENull();

            if (m_call_infor.datetime_response != null && m_call_infor.datetime_response != "")
                m_us_gd_xu_ly_noi_bo.datDATETIME_RESPOND = HelpUtils.string_2_datetime(m_call_infor.datetime_response);
            else m_us_gd_xu_ly_noi_bo.datDATETIME_RESPOND = DateTime.Now;

            m_us_gd_xu_ly_noi_bo.strNOI_DUNG_TRAO_DOI = m_txt_noi_dung_trao_doi.Text.Trim();
        }
        private void load_data_2_cbo_don_vi_noi_bo()
        {
            m_e_trang_thai_cbo_dv = e_trang_thai_cbo_don_vi.DANG_FILL_DATA;

            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();

            DataRow v_dr = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.TEN] = "-- Chọn đơn vị liên quan --";

            v_ds_tu_dien_trang_thai.EnforceConstraints = false;

            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.PHONG_BAN_NOI_BO, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);
            v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_don_vi_noi_bo.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_don_vi_noi_bo.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_noi_bo.ValueMember = CM_DM_TU_DIEN.ID;

            m_e_trang_thai_cbo_dv = e_trang_thai_cbo_don_vi.DA_FILL_XONG;
        }
        private void load_data_2_cbo_nguoi_dai_dien()
        {
            m_e_trang_thai_cbo_ndd = e_trang_thai_cbo_nguoi_dai_dien.DANG_FILL_DATA;
            US_V_DM_NGUOI_DAI_DIEN v_us_nguoi_dai_dien = new US_V_DM_NGUOI_DAI_DIEN();
            DS_V_DM_NGUOI_DAI_DIEN v_ds_nguoi_dai_dien = new DS_V_DM_NGUOI_DAI_DIEN();

            v_us_nguoi_dai_dien.dcID_DON_VI = CIPConvert.ToDecimal(m_cbo_don_vi_noi_bo.SelectedValue);
            v_us_nguoi_dai_dien.load_ds_nguoi_dai_dien_by_id_to_chuc(v_ds_nguoi_dai_dien);

            m_cbo_nguoi_dai_dien.DataSource = v_ds_nguoi_dai_dien.V_DM_NGUOI_DAI_DIEN;
            m_cbo_nguoi_dai_dien.DisplayMember = V_DM_NGUOI_DAI_DIEN.NDD_HO_TEN;
            m_cbo_nguoi_dai_dien.ValueMember = V_DM_NGUOI_DAI_DIEN.ID;

            m_e_trang_thai_cbo_ndd = e_trang_thai_cbo_nguoi_dai_dien.DA_FILL_XONG;
            if (m_cbo_nguoi_dai_dien.Items.Count > 0)
                load_thong_tin_nguoi_dai_dien();
            else
            {
                m_txt_dien_thoai_ndd.Text = "";
                m_pic_call_ndd.Visible = false;
            }
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_LICH_GOI_NOI_BO.NOI_DUNG_TRAO_DOI, e_col_Number.NOI_DUNG_TRAO_DOI);
            v_htb.Add(V_GD_LICH_GOI_NOI_BO.DATETIME_RESPOND, e_col_Number.DATETIME_RESPOND);
            v_htb.Add(V_GD_LICH_GOI_NOI_BO.NDD_HO_TEN, e_col_Number.NDD_HO_TEN);
            v_htb.Add(V_GD_LICH_GOI_NOI_BO.SO_DIEN_THOAI_GOI, e_col_Number.SO_DIEN_THOAI_GOI);
            v_htb.Add(V_GD_LICH_GOI_NOI_BO.DON_VI_LIEN_QUAN, e_col_Number.DON_VI_LIEN_QUAN);
            v_htb.Add(V_GD_LICH_GOI_NOI_BO.VOICE_CALL_LINK, e_col_Number.VOICE_CALL_LINK);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_LICH_GOI_NOI_BO.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_GD_LICH_GOI_NOI_BO();
            m_us.load_ds_xu_ly_noi_bo_cau_hoi(m_ds, m_dc_id_cau_hoi_xu_ly);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;
        }
        private void load_data_2_grid_tab1_assign()
        {
            m_ds_gd_xu_ly_noi_bo = new DS_GD_XU_LY_NOI_BO();
            m_us_gd_xu_ly_noi_bo.load_ds_assign_qlht(m_ds_gd_xu_ly_noi_bo, m_dc_id_cau_hoi_xu_ly);
            //m_fg_tab1_assign.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_gd_xu_ly_noi_bo, m_fg_tab1_assign, m_obj_trans_tab1_assign);
            CGridUtils.MakeSoTT((int)e_col_Number_tab1_assign.STT, m_fg_tab1_assign);
            //m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_GD_LICH_GOI_NOI_BO i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void load_thong_tin_nguoi_dai_dien()
        {
            US_V_DM_NGUOI_DAI_DIEN v_us_ndd = new US_V_DM_NGUOI_DAI_DIEN(CIPConvert.ToDecimal(m_cbo_nguoi_dai_dien.SelectedValue));

            m_txt_dien_thoai_ndd.Text = v_us_ndd.strNDD_DIEN_THOAI;
            m_txt_dien_thoai_ndd.Enabled = false;
            if (m_txt_dien_thoai_ndd.Text != "")
                m_pic_call_ndd.Visible = true;
            else m_pic_call_ndd.Visible = false;
        }
        private void change_status_enable_dien_thoai_ndd()
        {
            if (m_chb_dung_so_khac.Checked) m_txt_dien_thoai_ndd.Enabled = true;
            else if (!m_chb_dung_so_khac.Checked) m_txt_dien_thoai_ndd.Enabled = false;
        }
        private void us_object2grid(US_V_GD_LICH_GOI_NOI_BO i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        #endregion
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f400_gd_xu_ly_noi_bo_Load);
            this.KeyDown += new KeyEventHandler(f400_gd_xu_ly_noi_bo_KeyDown);
            m_tab2_thoat.Click += new EventHandler(m_tab2_thoat_Click);
            m_tab1_cmd_exit.Click += new EventHandler(m_tab1_cmd_exit_Click);
            m_cbo_don_vi_noi_bo.SelectedIndexChanged += new EventHandler(m_cbo_don_vi_noi_bo_SelectedIndexChanged);
            m_cbo_nguoi_dai_dien.SelectedIndexChanged += new EventHandler(m_cbo_nguoi_dai_dien_SelectedIndexChanged);
            m_chb_dung_so_khac.CheckedChanged += new EventHandler(m_chb_dung_so_khac_CheckedChanged);
            m_pic_call_ndd.Click += new EventHandler(m_pic_call_ndd_Click);
            m_tab1_cmd_assign_cho_qlht.Click += new EventHandler(m_tab1_cmd_assign_cho_qlht_Click);
            m_tab2_save_data.Click += new EventHandler(m_tab2_save_data_Click);
            this.FormClosing += new FormClosingEventHandler(f400_gd_xu_ly_noi_bo_FormClosing);
            m_cmd_nghe_lai.Click += new EventHandler(m_cmd_nghe_lai_Click);
            m_cmd_chon_qlht_khac.Click += new EventHandler(m_cmd_chon_qlht_khac_Click);
        }

        void m_cmd_nghe_lai_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                grid2us_object(m_us, m_fg.Row);
                HelpUtils.open_link_in_default_browser(HelpUtils.get_file_record(m_us.strVOICE_CALL_LINK));
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void f400_gd_xu_ly_noi_bo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (m_e_form_state == e_form_state.DA_CALL_NDD)
                    if (!BaseMessages.MsgBox_Confirm("Bạn chưa lưu thông tin cuộc gọi.Bạn có chắc chắn muốn thoát không?"))
                    {
                        e.Cancel = true;
                    }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void f400_gd_xu_ly_noi_bo_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void f400_gd_xu_ly_noi_bo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        #region Event Tab1
        void m_tab1_cmd_assign_cho_qlht_Click(object sender, EventArgs e)
        {
            try
            {
                tab1_save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void m_cmd_chon_qlht_khac_Click(object sender, EventArgs e)
        {
            try
            {
                chon_qlht_khac();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void m_tab1_cmd_exit_Click(object sender, EventArgs e)
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
        #endregion

        #region Event Tab2
        void m_tab2_save_data_Click(object sender, EventArgs e)
        {
            try
            {
                tab2_save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_pic_call_ndd_Click(object sender, EventArgs e)
        {
            try
            {
                call_2_nguoi_dai_dien();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_chb_dung_so_khac_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                change_status_enable_dien_thoai_ndd();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cbo_nguoi_dai_dien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_trang_thai_cbo_ndd == e_trang_thai_cbo_nguoi_dai_dien.DANG_FILL_DATA) return;
                load_thong_tin_nguoi_dai_dien();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cbo_don_vi_noi_bo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_trang_thai_cbo_dv == e_trang_thai_cbo_don_vi.DANG_FILL_DATA) return;
                load_data_2_cbo_nguoi_dai_dien();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_tab2_thoat_Click(object sender, EventArgs e)
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
        #endregion

        #endregion
    }
}
