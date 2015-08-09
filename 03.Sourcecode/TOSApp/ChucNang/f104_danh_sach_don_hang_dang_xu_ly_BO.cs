using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;



using IP.Core.IPCommon;namespace TOSApp.ChucNang
{
    public partial class f104_danh_sach_don_hang_dang_xu_ly_BO : Form
    {
        public f104_danh_sach_don_hang_dang_xu_ly_BO()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        US_GD_LOG_DAT_HANG m_us;

        decimal m_dc_nguoi_nhan_thao_tac = 69766;

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_DA_NHAN_XU_LY");
            m_grc_xac_nhan_don_hang.DataSource = v_ds.Tables[0];


        }
        private void fill_data_2_m_us()
        {

            DataRow v_dr = m_grv_danh_sach_don_hang_tiep_nhan_BO.GetDataRow(m_grv_danh_sach_don_hang_tiep_nhan_BO.FocusedRowHandle);
            m_us = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_GD_DAT_HANG"].ToString()));
        }
        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_tu_choi_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                //DataRow v_dr = m_grv_danh_sach_don_hang_tiep_nhan_BO.GetDataRow(m_grv_danh_sach_don_hang_tiep_nhan_BO.FocusedRowHandle);
                //m_us  = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_GD_DAT_HANG"].ToString()));
                fill_data_2_m_us();
                f105_thay_doi_don_hang_BO v_f104 = new f105_thay_doi_don_hang_BO();
                v_f104.displayForRefuse_order(m_us);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
          
          

        }
        #region tiep nhan don hang
        private void m_cmd_xac_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                update_log_tiep_nhan_don_hang(m_us);
                ghi_log_xac_nhan(m_us);
                MessageBox.Show("thành công");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }
        //ghi log cho hành động tiếp nhận đơn hàng
        private void ghi_log_xac_nhan(US_GD_LOG_DAT_HANG m_us)
        {

            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC =231 ;
           v_us.dcID_GD_DAT_HANG = m_us.dcID_GD_DAT_HANG;
           v_us.dcID_NGUOI_TAO_THAO_TAC = m_us.dcID_NGUOI_TAO_THAO_TAC;
           v_us.dcID_NGUOI_NHAN_THAO_TAC = m_us.dcID_NGUOI_NHAN_THAO_TAC;
           v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
           v_us.strTHAO_TAC_HET_HAN_YN = "N";
           v_us.strGHI_CHU = m_us.dcID_NGUOI_NHAN_THAO_TAC.ToString()+" đã tiếp nhận đơn hàng";
           v_us.Insert();
        }

    
        //khi tiếp nhận đơn hàng thì trạng thái đơn hàng sẽ được thay đổi từ Y->N
        private void update_log_tiep_nhan_don_hang(US_GD_LOG_DAT_HANG m_us)
        {

            m_us.strTHAO_TAC_HET_HAN_YN = "N";
            m_us.dcID_NGUOI_NHAN_THAO_TAC = m_dc_nguoi_nhan_thao_tac;//fix cung nguoi nhan tao tac
            m_us.Update();

        }
        #endregion
        #region cap nhật đơn hàng
        //cập nhật đơn hàng sẽ cập nhật ghi chú cho đơn hàng
        private void m_cmd_cap_nhat_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_2_m_us();
                f105_thay_doi_don_hang_BO v_f105 = new f105_thay_doi_don_hang_BO();
                v_f105.displayForRefuse_order(m_us);
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
          
            

        }

        #endregion
        #region đã xử lý
        //ghi log đã xử lý đơn hàng xong và chuyển trạng thái đơn hàng thành hết hạn
        private void ghi_log_da_xu_ly(US_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 177;
            v_us.dcID_GD_DAT_HANG = m_us.dcID_GD_DAT_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = m_dc_nguoi_nhan_thao_tac;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = 69765;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "đã chuyển cho PM";
        }
        //được thực hiện khi đơn hàng được hoàn thành
        private void m_cmd_bao_cao_da_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_2_m_us();
                ghi_log_da_xu_ly(m_us);
                update_log_da_xu_ly(m_us);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
          

        }

        private void update_log_da_xu_ly(US_GD_LOG_DAT_HANG m_us)
        {
              US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            // v_us.dcID = m_us.dcID;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.Update();
        }
        #endregion










    }
}
