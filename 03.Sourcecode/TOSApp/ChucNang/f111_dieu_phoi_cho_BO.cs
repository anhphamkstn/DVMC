using IP.Core.IPCommon;
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
    public partial class f111_dieu_phoi_cho_BO : Form
    {
        public f111_dieu_phoi_cho_BO()
        {
            InitializeComponent();
          
        }


        US_V_GD_DIEU_PHOI_LAI m_US = new US_V_GD_DIEU_PHOI_LAI();

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                update_log_dieu_phoi();
                MessageBox.Show("Thành công!");
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
         
        }

        private void update_log_dieu_phoi()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID = m_US.dcID;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "đã gửi cho PM";
            v_us.Update();
        }



        internal void displayListPM(IPCOREUS.US_V_GD_DIEU_PHOI_LAI m_us)
        {
            m_US = m_us;
            f111_dieu_phoi_cho_BO v_f111 = new f111_dieu_phoi_cho_BO();
            us_2_form(m_us);
            v_f111.ShowDialog();
        }

        private void us_2_form(IPCOREUS.US_V_GD_DIEU_PHOI_LAI m_us)
        {

            m_txt_ID_don_hang.Text = m_us.dcID_GD_DAT_HANG.ToString();
            m_txt_dich_vu_yeu_cau.Text = m_us.strTEN_YEU_CAU;
            m_txt_noi_dung_dat_hang.Text = m_us.strNOI_DUNG_DAT_HANG;
        }
    }
}
