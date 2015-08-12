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
    public partial class f0000_gd_dat_hang_gd_log_dat_hang : Form
    {
        public f0000_gd_dat_hang_gd_log_dat_hang()
        {
            InitializeComponent();
            load_data_2_grid();
        }
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_GD_DAT_HANG_GD_LOG_DAT_HANG");
            
            m_grc_gd_dat_hang_gd_log_dat_hang.DataSource = v_ds.Tables[0];
        }
        US_GD_LOG_DAT_HANG m_us_log = new US_GD_LOG_DAT_HANG();
        #region thêm mới đơn hàng
        private void m_cmd_them_moi_don_hang_Click(object sender, EventArgs e)
        {

            try
            {
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForInsert();
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region chỉnh sửa đơn hàng
        private void m_cmd_chinh_sua_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region FO điều phối lại
        private void m_cmd_dieu_phoi_lai_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f114_ds_BO v_f114 = new f114_ds_BO();
                v_f114.display_dieu_huong(v_us);
                load_data_2_grid();
               
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region điều phối cho PM
        private void m_cmd_dieu_phoi_cho_PM_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                update_trang_thai_don_hang(v_us);
                ghi_log_gui_cho_pm(v_us);
                MessageBox.Show("Hoàn thành!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
//hàm được fix cứng 1 vài giá trị cần phải thay đổi khi làm liên quan đến hệ thống
        private void ghi_log_gui_cho_pm(US_GD_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 174;
            v_US.dcID_GD_DAT_HANG = v_us.dcID;
            v_US.dcID_NGUOI_TAO_THAO_TAC = 69763;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = 69762;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng được gửi cho PM";
            v_US.Insert();
        }

        private void update_trang_thai_don_hang(US_GD_DAT_HANG v_us)
        {
            f112_FO_chuyen_don_hang_cho_PM v_f = new f112_FO_chuyen_don_hang_cho_PM();
            v_f.displayForUpdate(v_us);
        }
   

     
//hàm này được fixx cung người tạo thao tác là dành cho FO 
        // FO tự nhận và xử lý đơn hàng đối với các trường hợp nhất định
        private void ghi_log_da_nhan_xu_ly()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 231;
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_TAO_THAO_TAC = 69772;//TuanPA
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();

            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "BO nhận xử lý";
            v_us.Insert();
        }

        private void update_log_tiep_nhan()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID = m_us.dcID_LOG_DAT_HANG;
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_LOAI_THAO_TAC = 296;//BO tiếp nhận xử lý
            v_us.dcID_NGUOI_TAO_THAO_TAC = 69761;//fix cung 1 thanh niên sau này khi phân quyền hệ thống sẽ phải làm lại
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "FO đã tiếp nhận";
            v_us.Update();
        }

        private void fill_data_to_m_us()
        {

            DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
        }
        #endregion

        private void m_cmd_FO_tiep_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_log_tiep_nhan();
                ghi_log_da_nhan_xu_ly();
                load_data_2_grid();
                MessageBox.Show("Hoàn thành!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_FO_tu_choi_Click(object sender, EventArgs e)
        {

            try
            {
                fill_data_to_m_us();

                update_log_trang_thai_don_hang();
                f107_tu_choi_don_hang v_f107 = new f107_tu_choi_don_hang();
                v_f107.displayForRefuse(m_us);
                load_data_2_grid();
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
            v_us.dcID = m_us.dcID_LOG_DAT_HANG;
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_LOAI_THAO_TAC =311 ;//BO từ chối xử lý-FO chờ điều phối lại
            v_us.dcID_NGUOI_TAO_THAO_TAC = 69761;//fix cung 1 thanh niên sau này khi phân quyền hệ thống sẽ phải làm lại
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "FO đã từ chối";
            v_us.Update();


          
        }
    }
}
