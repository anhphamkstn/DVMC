using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp.ChucNang
{
    public partial class f000_gd_dat_hang_gd_log_dat_hang : Form
    {
        public f000_gd_dat_hang_gd_log_dat_hang()
        {
            InitializeComponent();
            load_data_2_grid();
            m_str_input = "FO";
            format_control();
        }

        string m_str_input;
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_GD_DAT_HANG_GD_LOG_DAT_HANG");
       
            m_grc_gd_dat_hang_gd_log_dat_hang.DataSource = v_ds.Tables[0];

        }
        private void format_control()
        {
            if (m_str_input == "FO")
            {
                format_ctl_FO();
                format_grv_FO();
            }
            else if (m_str_input == "BO")
            {
                format_ctl_BO();
            }
            else if (m_str_input == "PM")
            {
                format_ctl_PM();
              
            }
            else if (m_str_input == "TM")
            {
                format_ctl_TM();
          
            }
            else if (m_str_input == "ADMIN")
            {
                format_ctl_admin();
             
            }
            else m_panel_button.Visible = false;
               
        }

        private void format_grv_FO()
        {
            MA_DON_HANG.Visible = true;
            TEN_KHACH_HANG.Visible = true;
            DIEN_THOAI.Visible = true;
            MA_DON_VI.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            THOI_GIAN_DAT_HANG.Visible = true;
            LOAI_THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            TEN_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            PHAN_HOI_TU_DVMC.Visible = true;
            TEN_DANH_GIA_TU_USER_DAT_HANG.Visible = true;
            Y_KIEN_DANH_GIA_KHAC_TU_USER_DAT_HANG.Visible = true;
            THOI_GIAN_HOAN_THANH.Visible = true;
            TEN_PHUONG_THUC_DAT_HANG.Visible = true;




        }
        #region format control for each persion
        private void format_ctl_admin()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = false;
            m_panel_TM.Visible = false;
            m_panel_PM.Visible = false;
            m_panel_admin.Visible = true;
        }

        private void format_ctl_TM()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = false;
            m_panel_TM.Visible = true;
            m_panel_PM.Visible = false;
            m_panel_admin.Visible = false;
        }

        private void format_ctl_PM()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = false;
            m_panel_TM.Visible = false;
            m_panel_PM.Visible = true;
            m_panel_admin.Visible = false;
        }

        private void format_ctl_BO()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = true;
            m_panel_TM.Visible = false;
            m_panel_PM.Visible = false;
            m_panel_admin.Visible = false;
        }

        private void format_ctl_FO()
        {
            m_panel_FO.Visible = true;
            m_panel_BO.Visible = false;
            m_panel_TM.Visible = false;
            m_panel_PM.Visible = false;
            m_panel_admin.Visible = false;
        }
        #endregion
        #region format gridview for each person
        #endregion
    }
}
