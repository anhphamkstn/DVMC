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
    public partial class f101_cap_nhat_xu_don_hang : Form
    {
        public f101_cap_nhat_xu_don_hang()
        {
            InitializeComponent();
        }
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us;
        internal void Display_for_update(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            load_data_2_form(v_us);
            this.Show();
        }

        private void load_data_2_form(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
            m_txt_user_dat_hang.Text = v_us.strHO_TEN_USER_DAT_HANG;
            m_txt_dien_thoai.Text = v_us.strDIEN_THOAI;
            m_txt_don_vi.Text = v_us.strMA_DON_VI;
            m_txt_chi_nhanh.Text = v_us.strTEN_CHI_NHANH;
            m_txt_dich_vu_yeu_cau.Text = v_us.strTEN_NHOM_DICH_VU_YEU_CAU;
            m_txt_noi_dung_yeu_cau_cu_the.Text = v_us.strNOI_DUNG_DAT_HANG;
            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
        }

        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
            if (m_txt_cap_nhat_xu_ly.Text == "")
            {
                MessageBox.Show("Vui lòng điền nội dung cập nhật!");
                m_txt_cap_nhat_xu_ly.Focus();
            }
            else
            {
                US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
                v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
                v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
                v_us.dcID_LOAI_THAO_TAC = 344;
                v_us.SetID_NGUOI_NHAN_THAO_TACNull();
                v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
                v_us.strTHAO_TAC_HET_HAN_YN = "Y";
                v_us.strGHI_CHU = m_txt_cap_nhat_xu_ly.Text;
                v_us.Insert();
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
