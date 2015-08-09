using System;
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
    public partial class f107_tu_choi_don_hang : Form
    {
        public f107_tu_choi_don_hang()
        {
            InitializeComponent();
           
        }

        US_GD_LOG_DAT_HANG m_US = new US_GD_LOG_DAT_HANG();
        internal void displayForRefuse(IPCOREUS.US_GD_LOG_DAT_HANG m_us)
        {
            us_to_form(m_us);
            this.ShowDialog();
        }

        private void us_to_form(US_GD_LOG_DAT_HANG m_us)
        {
            m_US = m_us;
            m_txt_ma_don_hang.Text = m_us.dcID_GD_DAT_HANG.ToString();
            m_txt_nguoi_nhan_tao_tac.Text = m_us.dcID_NGUOI_TAO_THAO_TAC.ToString();
            m_txt_ly_do_tu_choi.Focus();

        }

        private void m_cmd_gui_Click(object sender, EventArgs e)
        {
            try
            {
                ghi_log_tu_choi();
                this.Close();
                MessageBox.Show("Hoàn thành!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void ghi_log_tu_choi()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 228;//CHỜ FO điều phối lại
            v_us.dcID_GD_DAT_HANG = m_US.dcID_GD_DAT_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = 69763;
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = m_txt_ly_do_tu_choi.Text;
            v_us.Insert();
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
