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
    public partial class f115_TM_danh_gia : Form
    {
        public f115_TM_danh_gia()
        {
            InitializeComponent();
        }

        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();
        
        internal void displayForTM(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            load_data_2_form(m_us);
            this.ShowDialog();
        }

        private void load_data_2_form(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            m_txt_ma_don_hang.Text = m_us.strMA_DON_HANG;
            v_us = m_us;
        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_rdb_hoan_thanh.Checked == true)
                {
                    ghi_log_nghiem_thu_don_hang(v_us);
                    update_trang_thai_don_hang(v_us);
                    MessageBox.Show("Hoàn thành");
                    this.Close();
                }
                else
                {
                    if (m_txt_nhan_xet.Text == "")
                    {
                        MessageBox.Show("Nhập lý do không nghiệm thu!");
                        m_txt_nhan_xet.Focus();
                    }
                    else
                    {
                        ghi_log_nghiem_thu_don_hang_chua_hoan_thanh(v_us);
                        update_trang_thai_don_hang_chua_hoan_thanh(v_us);
                        this.Close();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ghi_log_nghiem_thu_don_hang_chua_hoan_thanh(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();

            v_US.dcID_GD_DAT_HANG = v_us.dcID_DON_HANG;
            v_US.dcID_LOAI_THAO_TAC = 313;//cần xử lý lại
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = v_us.dcID_NGUOI_TAO_THAO_TAC;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng cần được thực hiện lại! TM chưa chấp nhận nghiệm thu!";
            v_US.Insert();
        }

        private void update_trang_thai_don_hang_chua_hoan_thanh(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(v_us.dcID);
            
            v_US.strTHAO_TAC_HET_HAN_YN = "Y";
            v_US.strGHI_CHU = "đơn hàng chưa hoàn thành! TM không chấp nhận nghiệm thu";
            v_US.Update();
        }

        private void ghi_log_nghiem_thu_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
           
            v_US.dcID_GD_DAT_HANG = v_us.dcID_DON_HANG;
            v_US.dcID_LOAI_THAO_TAC = 309;//TM đã nghiệm thu
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_US.SetID_NGUOI_NHAN_THAO_TACNull();
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng được TM nghiệm thu hoàn thành";
            v_US.Insert();
        }

        private void update_trang_thai_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(v_us.dcID);        
            v_US.strTHAO_TAC_HET_HAN_YN = "Y";
            v_US.strGHI_CHU = "TM đã nghiệm thu hoàn thành";
            v_US.Update();
            //cập nhật thời gian hoàn thành cho đơn hàng
            US_GD_DAT_HANG v_us1 = new US_GD_DAT_HANG(v_us.dcID_DON_HANG);
            v_us1.datTHOI_GIAN_HOAN_THANH = System.DateTime.Now;
            v_us1.Update();
        }
    }
}
