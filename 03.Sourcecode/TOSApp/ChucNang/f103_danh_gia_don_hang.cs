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

using IPCOREDS;
using IPCOREUS;
using IPCOREDS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;
using TOSApp.ChucNang;

namespace TOSApp.ChucNang
{
    public partial class f103_danh_gia_don_hang : Form
    {
        public f103_danh_gia_don_hang()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interfaces
        public void display_to_danh_gia(US_V_GD_DAT_HANG ip_us_dat_hang)
        {
            m_us_dat_hang = ip_us_dat_hang;
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_V_GD_DAT_HANG m_us_dat_hang = new US_V_GD_DAT_HANG();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            set_define_events();
        }
        private void set_initial_form_load()
        {
            us_object_2_form();
        }
        private void gui_danh_gia_cua_khach_hang()
        {
            if (!is_validate_data()) return;
            form_2_us_object();
            m_us_dat_hang.danh_gia_don_hang(m_us_dat_hang.dcID
                                            , m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG
                                            , m_us_dat_hang.strY_KIEN_KHAC_TU_USER_DAT_HANG);
            BaseMessages.MsgBox_Infor("Đánh giá đơn hàng thành công!");
            this.Close();
        }
        private void us_object_2_form()
        {
            m_txt_ma_don_hang.Text = m_us_dat_hang.strMA_DON_HANG;
            m_txt_yeu_cau_cu_the.Text = m_us_dat_hang.strNOI_DUNG_DAT_HANG;
            m_txt_y_kien_khac.Text = m_us_dat_hang.strY_KIEN_KHAC_TU_USER_DAT_HANG;
            if (m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG == null) 
                m_lbl_state_danh_gia.Visible = false;
            else
            {
                m_lbl_state_danh_gia.Visible = true;
                if (m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG == ID_HANG_DANH_GIA.RAT_HAI_LONG)
                    m_rdb_kh_danh_gia_rat_hai_long.Checked = true;
                else if (m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG == ID_HANG_DANH_GIA.HAI_LONG)
                    m_rdb_kh_danh_gia_hai_long.Checked = true;
                else if (m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG == ID_HANG_DANH_GIA.XONG_VIEC)
                    m_rdb_kh_danh_gia_xong_viec.Checked = true;
                else if (m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG == ID_HANG_DANH_GIA.HOI_DUOI)
                    m_rdb_kh_danh_gia_hoi_duoi.Checked = true;
                else if (m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG == ID_HANG_DANH_GIA.KHONG_DAT)
                    m_rdb_kh_danh_gia_khong_dat.Checked = true;
            }
        }
        private void form_2_us_object()
        {
            if (m_rdb_kh_danh_gia_rat_hai_long.Checked)
                m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG = ID_HANG_DANH_GIA.RAT_HAI_LONG;
            else if (m_rdb_kh_danh_gia_hai_long.Checked)
                m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG = ID_HANG_DANH_GIA.HAI_LONG;
            else if (m_rdb_kh_danh_gia_xong_viec.Checked)
                m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG = ID_HANG_DANH_GIA.XONG_VIEC;
            else if (m_rdb_kh_danh_gia_hoi_duoi.Checked)
                m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG = ID_HANG_DANH_GIA.HOI_DUOI;
            else if (m_rdb_kh_danh_gia_khong_dat.Checked)
                m_us_dat_hang.dcID_DANH_GIA_TU_USER_DAT_HANG = ID_HANG_DANH_GIA.KHONG_DAT;

            m_us_dat_hang.strY_KIEN_KHAC_TU_USER_DAT_HANG = m_txt_y_kien_khac.Text.Trim();
        }
        private bool is_validate_data()
        {
            return true;
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f103_danh_gia_don_hang_Load);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(f103_danh_gia_don_hang_KeyDown);
        }

        void f103_danh_gia_don_hang_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                gui_danh_gia_cua_khach_hang();
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

        void f103_danh_gia_don_hang_Load(object sender, EventArgs e)
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
        #endregion
    }
}
