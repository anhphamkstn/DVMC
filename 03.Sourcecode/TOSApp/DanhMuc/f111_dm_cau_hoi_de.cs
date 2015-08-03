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

namespace TOSApp.DanhMuc
{
    public partial class f111_dm_cau_hoi_de : Form
    {
        public f111_dm_cau_hoi_de()
        {
            InitializeComponent();

            format_controls();
        }

        #region Members
        US_V_DM_CAU_HOI m_us_dm_cau_hoi = new US_V_DM_CAU_HOI();
        DS_V_DM_CAU_HOI m_ds_dm_cau_hoi = new DS_V_DM_CAU_HOI();
        US_V_DM_CAU_HOI_KO_TRA_LOI m_us_all_cau_hoi = new US_V_DM_CAU_HOI_KO_TRA_LOI();
        US_V_DM_CAU_TRA_LOI m_us_dm_cau_tra_loi = new US_V_DM_CAU_TRA_LOI();
        e_form_mode m_e_form_mode = e_form_mode.THEM_CAU_HOI;
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
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
        #endregion

        #region Public Interface
        public void display_for_insert_cau_hoi()
        {
            m_e_form_mode = e_form_mode.THEM_CAU_HOI;
            this.ShowDialog();
        }
        public void display_for_update_cau_hoi(US_V_DM_CAU_HOI ip_us_dm_cau_hoi)
        {
            m_e_form_mode = e_form_mode.SUA_CAU_HOI;
            m_us_dm_cau_hoi = ip_us_dm_cau_hoi;
            m_us_dm_cau_tra_loi.get_obj_by_id_cau_hoi();
            this.ShowDialog();
        }
        public void display_for_duyet_cau_tra_loi(US_V_DM_CAU_TRA_LOI ip_us_dm_cau_tra_loi)
        {
            m_e_form_mode = e_form_mode.DUYET_CAU_TRA_LOI;
            m_us_dm_cau_tra_loi = ip_us_dm_cau_tra_loi;
            m_us_all_cau_hoi = new US_V_DM_CAU_HOI_KO_TRA_LOI(m_us_dm_cau_tra_loi.dcID_CAU_HOI);
            this.ShowDialog();
        }
        public void display_for_them_cau_tra_loi(US_V_DM_CAU_HOI ip_us_dm_cau_hoi)
        {
            m_e_form_mode = e_form_mode.THEM_CAU_TRA_LOI;
            m_us_dm_cau_hoi = ip_us_dm_cau_hoi;
            this.ShowDialog();
        }
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
            m_cbo_don_vi_truong.Focus();
            set_define_events();
        }
        private void set_inital_form_load()
        {
            load_data_2_cbo_don_vi_truong();
            load_data_2_cbo_nhom_cau_hoi();
            load_data_2_cbo_trang_thai_cau_tra_loi();
            us_object_2_form();

            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_CAU_HOI:
                    m_cmd_luu.Text = "Lưu";
                    m_cbo_trang_thai_cau_tra_loi.SelectedIndex = 0;
                    m_cbo_trang_thai_cau_tra_loi.Enabled = false;
                    break;
                case e_form_mode.SUA_CAU_HOI:
                    m_lbl_username.Text = "Người cập nhật";
                    m_cmd_luu.Text = "Lưu";
                    break;
                case e_form_mode.DUYET_CAU_TRA_LOI:
                    m_lbl_username.Text = "Người cập nhật";
                    m_cmd_luu.Text = "Duyệt";
                    m_txt_noi_dung_cau_hoi.Enabled = false;
                    m_cbo_don_vi_truong.Enabled = false;
                    m_cbo_nhom_cau_hoi.Enabled = false;
                    break;
                case e_form_mode.THEM_CAU_TRA_LOI:
                    m_lbl_username.Text = "Người cập nhật";
                    m_cmd_luu.Text = "Lưu";
                    m_txt_noi_dung_cau_hoi.Enabled = false;
                    m_cbo_don_vi_truong.Enabled = false;
                    m_cbo_nhom_cau_hoi.Enabled = false;
                    break;
            }
            m_txt_nguoi_tao.Text = CAppContext_201.getCurrentUserName();
            m_dat_ngay_tao.Enabled = false;
        }
        private void load_data_2_cbo_trang_thai_cau_tra_loi()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_DM_CAU_TRA_LOI, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);
            m_cbo_trang_thai_cau_tra_loi.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_trang_thai_cau_tra_loi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_cau_tra_loi.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_cbo_don_vi_truong()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TO_CHUC_TRUONG, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);
            m_cbo_don_vi_truong.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_don_vi_truong.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_truong.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_cbo_nhom_cau_hoi()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.NHOM_CAU_HOI, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);
            m_cbo_nhom_cau_hoi.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_nhom_cau_hoi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_nhom_cau_hoi.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void us_object_2_form()
        {
            m_dat_ngay_tao.Value = m_us_dm_cau_hoi.datNGAY_TAO;
            m_txt_nguoi_tao.Text = m_us_dm_cau_hoi.strTEN_NGUOI_TAO;
            m_txt_noi_dung_cau_hoi.Text = m_us_dm_cau_hoi.strNOI_DUNG_CAU_HOI;
            m_cbo_don_vi_truong.SelectedValue = CIPConvert.ToStr(m_us_dm_cau_hoi.dcID_TO_CHUC);
            m_cbo_nhom_cau_hoi.SelectedValue = CIPConvert.ToStr(m_us_dm_cau_hoi.dcID_NHOM_CAU_HOI);
            if (!m_us_dm_cau_hoi.IsLINK_TL_THAM_KHAONull())
                m_txt_link_tai_lieu.Text = m_us_dm_cau_hoi.strLINK_TL_THAM_KHAO;


            switch (m_e_form_mode)
            {
                case e_form_mode.SUA_CAU_HOI:
                    if (m_us_dm_cau_tra_loi.dcID > 0)
                    {
                        m_txt_cau_tra_loi.Text = m_us_dm_cau_tra_loi.strCAU_TRA_LOI;
                        m_cbo_trang_thai_cau_tra_loi.SelectedValue = m_us_dm_cau_tra_loi.dcID_TRANG_THAI;
                        m_txt_link_tai_lieu.Text = m_us_dm_cau_tra_loi.strLINK_TL_THAM_KHAO;
                    }
                    m_txt_cau_tra_loi.Enabled = false;
                    m_txt_link_tai_lieu.Enabled = false;
                    m_cbo_trang_thai_cau_tra_loi.Enabled = false;
                    break;
                case e_form_mode.DUYET_CAU_TRA_LOI:

                    m_dat_ngay_tao.Value = m_us_all_cau_hoi.datNGAY_TAO;
                    m_txt_nguoi_tao.Text = m_us_all_cau_hoi.strTEN_NGUOI_TAO;
                    m_txt_noi_dung_cau_hoi.Text = m_us_all_cau_hoi.strNOI_DUNG_CAU_HOI;
                    m_cbo_don_vi_truong.SelectedValue = CIPConvert.ToStr(m_us_all_cau_hoi.dcID_TO_CHUC);
                    m_cbo_nhom_cau_hoi.SelectedValue = CIPConvert.ToStr(m_us_all_cau_hoi.dcID_NHOM_CAU_HOI);

                    m_txt_link_tai_lieu.Text = m_us_dm_cau_tra_loi.strLINK_TL_THAM_KHAO;
                    m_txt_cau_tra_loi.Text = m_us_dm_cau_tra_loi.strCAU_TRA_LOI;
                    m_cbo_trang_thai_cau_tra_loi.SelectedValue = m_us_dm_cau_tra_loi.dcID_TRANG_THAI;
                    break;
            }

        }
        private void form_2_usobject()
        {
            switch (m_e_form_mode)
            {
                // thêm câu hỏi bắt buộc phải thêm câu trả lời
                case e_form_mode.THEM_CAU_HOI:
                    m_us_dm_cau_hoi.dcID_TO_CHUC = CIPConvert.ToDecimal(m_cbo_don_vi_truong.SelectedValue);
                    m_us_dm_cau_hoi.dcID_NHOM_CAU_HOI = CIPConvert.ToDecimal(m_cbo_nhom_cau_hoi.SelectedValue);
                    m_us_dm_cau_hoi.strNOI_DUNG_CAU_HOI = m_txt_noi_dung_cau_hoi.Text.Trim();
                    m_us_dm_cau_hoi.strCAU_TRA_LOI = m_txt_cau_tra_loi.Text;
                    m_us_dm_cau_hoi.datNGAY_TAO = m_dat_ngay_tao.Value;
                    m_us_dm_cau_hoi.dcNGUOI_TAO = CAppContext_201.getCurrentUserID();
                    m_us_dm_cau_hoi.dcID_TRANG_THAI_CAU_TRA_LOI = CIPConvert.ToDecimal(m_cbo_trang_thai_cau_tra_loi.SelectedValue);
                    if (m_txt_link_tai_lieu.Text.Trim() != "")
                        m_us_dm_cau_hoi.strLINK_TL_THAM_KHAO = m_txt_link_tai_lieu.Text.Trim();
                    else m_us_dm_cau_hoi.SetLINK_TL_THAM_KHAONull();
                    break;
                // Sửa câu hỏi, ko cho sửa câu trả lời
                case e_form_mode.SUA_CAU_HOI:
                    m_us_dm_cau_hoi.dcID_TO_CHUC = CIPConvert.ToDecimal(m_cbo_don_vi_truong.SelectedValue);
                    m_us_dm_cau_hoi.dcID_NHOM_CAU_HOI = CIPConvert.ToDecimal(m_cbo_nhom_cau_hoi.SelectedValue);
                    m_us_dm_cau_hoi.strNOI_DUNG_CAU_HOI = m_txt_noi_dung_cau_hoi.Text.Trim();
                    m_us_dm_cau_hoi.dcNGUOI_CAP_NHAT_CUOI = CAppContext_201.getCurrentUserID();
                    m_us_dm_cau_hoi.datNGAY_CAP_NHAP_CUOI = DateTime.Today;
                    break;
                // ko thay đổi câu hỏi
                case e_form_mode.DUYET_CAU_TRA_LOI:
                    m_us_dm_cau_tra_loi.strCAU_TRA_LOI = m_txt_cau_tra_loi.Text.Trim();
                    m_us_dm_cau_tra_loi.strLINK_TL_THAM_KHAO = m_txt_link_tai_lieu.Text.Trim();
                    m_us_dm_cau_tra_loi.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_cau_tra_loi.SelectedValue);
                    break;
                // ko thay đổi câu hỏi; dùng  procedure riêng để thêm câu trả lời cho câu hỏi
                case e_form_mode.THEM_CAU_TRA_LOI:
                    m_us_dm_cau_hoi.strCAU_TRA_LOI = m_txt_cau_tra_loi.Text.Trim();
                    m_us_dm_cau_hoi.datNGAY_TAO = DateTime.Now;
                    m_us_dm_cau_hoi.dcNGUOI_TAO = CAppContext_201.getCurrentUserID();
                    m_us_dm_cau_hoi.strLINK_TL_THAM_KHAO = m_txt_link_tai_lieu.Text.Trim();
                    break;
            }


        }
        private bool check_validate_data_is_ok()
        {
            if (m_e_form_mode == e_form_mode.THEM_CAU_HOI
                || m_e_form_mode == e_form_mode.SUA_CAU_HOI)
            {
                if (!CValidateTextBox.IsValid(m_txt_noi_dung_cau_hoi, DataType.StringType, allowNull.NO)) return false;
            }
            else if (m_e_form_mode == e_form_mode.THEM_CAU_TRA_LOI
                || m_e_form_mode == e_form_mode.DUYET_CAU_TRA_LOI)
            {
                if (!CValidateTextBox.IsValid(m_txt_cau_tra_loi, DataType.StringType, allowNull.NO)) return false;
            }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_usobject();
            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_CAU_HOI:
                    m_us_dm_cau_hoi.Insert();
                    BaseMessages.MsgBox_Infor(THONG_BAO.SC_THEM_CAU_HOI);
                    this.Close();
                    break;

                case e_form_mode.SUA_CAU_HOI:
                    m_us_dm_cau_hoi.Update();
                    BaseMessages.MsgBox_Infor(THONG_BAO.SC_SUA_CAU_HOI);
                    break;

                case e_form_mode.DUYET_CAU_TRA_LOI:
                    m_us_dm_cau_tra_loi.Update();
                    BaseMessages.MsgBox_Infor(THONG_BAO.SC_DUYET_CAU_TRA_LOI);
                    break;

                case e_form_mode.THEM_CAU_TRA_LOI:
                    m_us_dm_cau_hoi.them_cau_tra_loi();
                    BaseMessages.MsgBox_Infor(THONG_BAO.SC_THEM_CAU_TRA_LOI);
                    break;
            }
            this.Close();
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f111_dm_cau_hoi_de_Load);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(f111_dm_cau_hoi_de_KeyDown);
        }
        void f111_dm_cau_hoi_de_Load(object sender, EventArgs e)
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

        void f111_dm_cau_hoi_de_KeyDown(object sender, KeyEventArgs e)
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
        void m_cmd_exit_Click(object sender, EventArgs e)
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
    }
}
