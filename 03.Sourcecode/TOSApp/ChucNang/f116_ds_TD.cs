﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;
using IP.Core.IPCommon;
namespace TOSApp.ChucNang
{
    public partial class f116_ds_TD : Form
    {
        public f116_ds_TD()
        {
            
            InitializeComponent();
        }
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                insert_log_gui_cho_pm(m_us);
                update_log_gui_cho_pm(m_us);

                MessageBox.Show("Hoàn thành!");
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
       
        }

        private void update_log_gui_cho_pm(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(m_us.dcID);
            v_US.strTHAO_TAC_HET_HAN_YN = "Y";
            v_US.strGHI_CHU = "đơn hàng đã được gửi cho TD";
            v_US.Update();
        }

        private void insert_log_gui_cho_pm(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 305;//đã chuyển cho TD
            v_US.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_US.dcID_NGUOI_TAO_THAO_TAC = 15;//Quản lý có id 15
            v_US.dcID_NGUOI_NHAN_THAO_TAC = 21;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng đã được gửi cho TD \n" + m_txt_gui_kem.Text;
            v_US.Insert();

        }

        internal void displayForUpdate(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            load_data_to_form(v_us);

            this.ShowDialog();
        }

        private void load_data_to_form(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
            WinFormControls.load_data_to_combobox("HT_NGUOI_SU_DUNG", "ID", "TEN", "", WinFormControls.eTAT_CA.NO, m_cbo_ds_TD);
            m_txt_gui_kem.Focus();
          
        }
    }
}
