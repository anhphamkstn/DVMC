using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IPCOREUS;
namespace TOSApp.ChucNang
{
    public partial class f105_thay_doi_don_hang_BO : Form
    {
        public f105_thay_doi_don_hang_BO()
        {
            InitializeComponent();
        }

        US_GD_LOG_DAT_HANG m_US;

        internal void displayForRefuse_order(IPCOREUS.US_GD_LOG_DAT_HANG m_us)
        {
            m_US = m_us;
            us_to_form(m_us);

            this.ShowDialog();

        }

        private void us_to_form(IPCOREUS.US_GD_LOG_DAT_HANG m_us)
        {
            m_txt_ma_don_hang.Text = m_us.dcID_GD_DAT_HANG.ToString();

            m_txt_nguoi_nhan_tao_tac.Text = m_us.dcID_NGUOI_TAO_THAO_TAC.ToString();//xem lai doạn này

           m_txt_ghi_chu.Focus();
            
        }

        private void m_cmd_gui_Click(object sender, EventArgs e)
        {
            ghi_log_tu_choi_don_hang();
            ghi_log_cap_nhat_don_hang(m_US);
            this.Close();
        }

        private void ghi_log_cap_nhat_don_hang(US_GD_LOG_DAT_HANG m_US)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID = m_US.dcID;
            v_us.strGHI_CHU = m_txt_ghi_chu.Text;
            v_us.Update();
        }

        private void ghi_log_tu_choi_don_hang()
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            
            v_US.strTHAO_TAC_HET_HAN_YN = "Y";
            v_US.strGHI_CHU = m_txt_ghi_chu.Text;

            v_US.Update();
        }

        
    }
}
