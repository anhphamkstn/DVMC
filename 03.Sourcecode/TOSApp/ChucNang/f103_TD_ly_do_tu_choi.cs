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
    public partial class f103_TD_ly_do_tu_choi : Form
    {
        public f103_TD_ly_do_tu_choi()
        {
            InitializeComponent();
        }
        US_GD_DAT_HANG v_us;

        internal void Display(IPCOREUS.US_GD_DAT_HANG m_us)
        {
            v_us = new US_GD_DAT_HANG(m_us.dcID);
            this.Show();
        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            if (m_txt_ly_do.Text == "")
            {
                MessageBox.Show("Nhập lý do từ chối!");
                m_txt_ly_do.Focus();
            }
            else
            {

                us_user.TD_tu_choi = m_txt_ly_do.Text;

                update_log_admin_huy_don_hang();
                ghi_log_admin_da_huy_don_hang();
                MessageBox.Show("Đã hủy đơn hàng!");
                this.Close();
            }
        }
        private void ghi_log_admin_da_huy_don_hang()
        {
            US_GD_LOG_DAT_HANG V_us = new US_GD_LOG_DAT_HANG();
            V_us.dcID_LOAI_THAO_TAC = 300;//đã hủy 
            V_us.dcID_GD_DAT_HANG = v_us.dcID;
            V_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            V_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            V_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            V_us.strTHAO_TAC_HET_HAN_YN = "N";
            V_us.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đã hủy đơn hàng với lý do " + m_txt_ly_do.Text;
            V_us.Insert();
        }

        private void update_log_admin_huy_don_hang()
        {
            US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_DAT_HANG_GD_LOG_DAT_HANG WHERE [ID_DON_HANG] = " + v_us.dcID.ToString());
            for(int i= 0;i< v_ds.Tables[0].Rows.Count;i++)
            {
                US_GD_LOG_DAT_HANG V_us = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                V_us.strTHAO_TAC_HET_HAN_YN = "Y";
                V_us.Update();
            }
           
        }
    }
}
