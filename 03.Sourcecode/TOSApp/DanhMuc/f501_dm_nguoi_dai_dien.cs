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
    public partial class f501_dm_nguoi_dai_dien : Form
    {
        public f501_dm_nguoi_dai_dien()
        {
            InitializeComponent();

            format_controls();
        }

        #region Members
        US_V_DM_NGUOI_DAI_DIEN m_us_dm_nguoi_dai_dien = new US_V_DM_NGUOI_DAI_DIEN();
        DS_V_DM_NGUOI_DAI_DIEN m_ds_dm_nguoi_dai_dien = new DS_V_DM_NGUOI_DAI_DIEN();
        decimal m_dc_id_to_chuc = 0;
        e_form_mode m_e_form_mode = e_form_mode.THEM_NGUOI_DAI_DIEN;
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        #endregion

        #region Data Structure
        public enum e_form_mode
        {
            THEM_NGUOI_DAI_DIEN = 0
            ,
            SUA_NGUOI_DAI_DIEN = 1
        }
        #endregion

        #region Public Interface
        public void display_for_insert_ndd(decimal ip_dc_id_to_chuc)
        {
            m_e_form_mode = e_form_mode.THEM_NGUOI_DAI_DIEN;
            m_dc_id_to_chuc = ip_dc_id_to_chuc;
            this.ShowDialog();
        }
        public void display_for_update_ndd(US_V_DM_NGUOI_DAI_DIEN ip_us_dm_nguoi_dai_dien)
        {
            m_e_form_mode = e_form_mode.SUA_NGUOI_DAI_DIEN;
            m_us_dm_nguoi_dai_dien = ip_us_dm_nguoi_dai_dien;
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
            us_object_2_form();
            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_NGUOI_DAI_DIEN:
                    m_cbo_don_vi_truong.Focus();
                    break;
                case e_form_mode.SUA_NGUOI_DAI_DIEN:
                    m_txt_ho_ten_ndd.Focus();
                    break;
            }
        }
        private void load_data_2_cbo_don_vi_truong()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.PHONG_BAN_NOI_BO, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);
            m_cbo_don_vi_truong.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_don_vi_truong.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_truong.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void us_object_2_form()
        {
            m_cbo_don_vi_truong.SelectedValue = CIPConvert.ToStr(m_us_dm_nguoi_dai_dien.dcID_DON_VI);
            switch (m_e_form_mode)
            {
                case e_form_mode.SUA_NGUOI_DAI_DIEN:
                    m_txt_chuc_vu_ndd.Text = m_us_dm_nguoi_dai_dien.strNDD_CHUC_VU;
                    m_txt_dien_thoai_ndd.Text = m_us_dm_nguoi_dai_dien.strNDD_DIEN_THOAI;
                    m_txt_ho_ten_ndd.Text = m_us_dm_nguoi_dai_dien.strNDD_HO_TEN;
                    m_txt_email_ndd.Text = m_us_dm_nguoi_dai_dien.strNDD_EMAIL;
                    break;
                case e_form_mode.THEM_NGUOI_DAI_DIEN:
                    m_cbo_don_vi_truong.SelectedValue = m_dc_id_to_chuc;
                    break;
            }

        }
        private void form_2_usobject()
        {
            m_us_dm_nguoi_dai_dien.dcID_DON_VI = CIPConvert.ToDecimal(m_cbo_don_vi_truong.SelectedValue);
            m_us_dm_nguoi_dai_dien.strNDD_HO_TEN = m_txt_ho_ten_ndd.Text.Trim();
            m_us_dm_nguoi_dai_dien.strNDD_CHUC_VU = m_txt_chuc_vu_ndd.Text.Trim();
            m_us_dm_nguoi_dai_dien.strNDD_DIEN_THOAI = m_txt_dien_thoai_ndd.Text.Trim();
            m_us_dm_nguoi_dai_dien.strNDD_EMAIL = m_txt_email_ndd.Text.Trim();
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ho_ten_ndd, DataType.StringType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_dien_thoai_ndd, DataType.StringType, allowNull.NO)) return false;
            if (!HelpUtils.ValidatePhoneMask(m_txt_dien_thoai_ndd.Text.Trim()))
            {
                BaseMessages.MsgBox_Error("Số điện thoại không đúng định dạng!");
                return false;
            }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_usobject();
            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_NGUOI_DAI_DIEN:
                    m_us_dm_nguoi_dai_dien.Insert();
                    BaseMessages.MsgBox_Infor(THONG_BAO.SC_THEM_NGUOI_DAI_DIEN);
                    this.Close();
                    break;

                case e_form_mode.SUA_NGUOI_DAI_DIEN:
                    m_us_dm_nguoi_dai_dien.Update();
                    BaseMessages.MsgBox_Infor(THONG_BAO.SC_SUA_NGUOI_DAI_DIEN);
                    break;
            }
            this.Close();
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f501_dm_nguoi_dai_dien_Load);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(f501_dm_nguoi_dai_dien_KeyDown);
        }
        void f501_dm_nguoi_dai_dien_Load(object sender, EventArgs e)
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

        void f501_dm_nguoi_dai_dien_KeyDown(object sender, KeyEventArgs e)
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
