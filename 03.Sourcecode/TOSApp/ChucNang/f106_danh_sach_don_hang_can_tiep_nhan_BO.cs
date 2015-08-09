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
    public partial class f106_danh_sach_don_hang_can_tiep_nhan_BO : Form
    {
        public f106_danh_sach_don_hang_can_tiep_nhan_BO()
        {
            InitializeComponent();

            load_data_2_grid();
        }
        US_GD_LOG_DAT_HANG m_us = new US_GD_LOG_DAT_HANG();
        private void fill_data_to_m_us()
        {
            DataRow v_dr = m_grv_ds_don_hang_can_tiep_nhan.GetDataRow(m_grv_ds_don_hang_can_tiep_nhan.FocusedRowHandle);
            m_us = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
        }
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CAN_XU_LY");
            m_grc_ds_don_hang_can_tiep_nhan.DataSource = v_ds.Tables[0];
            m_grv_ds_don_hang_can_tiep_nhan.ActiveFilterString = "[ID_NGUOI_NHAN_THAO_TAC]= 69761";
           
            
        }

        private void m_cmd_tiep_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_log_tiep_nhan();
                ghi_log_da_nhan_xu_ly();
                MessageBox.Show("Hoàn thành!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
       

        }

        private void ghi_log_da_nhan_xu_ly()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 231;
            v_us.dcID_GD_DAT_HANG = m_us.dcID_GD_DAT_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = 69763;
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();
           
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "nhận xử lý";
            v_us.Insert();
        }

        private void update_log_tiep_nhan()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us = m_us;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "đã tiếp nhận";
            v_us.Update();
        }

        private void m_cmd_tu_choi_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
               
                update_log_trang_thai_don_hang();
                f107_tu_choi_don_hang v_f107 = new f107_tu_choi_don_hang();
                v_f107.displayForRefuse(m_us);
                MessageBox.Show("Thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void update_log_trang_thai_don_hang()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us = m_us;
            v_us.dcID_NGUOI_TAO_THAO_TAC = 69761;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.Update();
        }
    }
}
