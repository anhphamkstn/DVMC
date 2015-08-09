using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp;
using IPCOREUS;

namespace TOSApp.ChucNang
{
    public partial class f500_cong_viec_FO_chi_tiet : Form
    {
        public f500_cong_viec_FO_chi_tiet()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_DANH_SACH_DAT_HANG_FO");
            m_grc_FO_danh_sach_don_hang.DataSource = v_ds.Tables[0];

        }

        private void m_cmd_them_moi_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForInsert();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
          
        }

        private void m_cmd_chinh_sua_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                 DataRow v_dr = m_grv_FO_danh_sach_don_hang.GetDataRow(m_grv_FO_danh_sach_don_hang.FocusedRowHandle);
          US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
            v_f100.displayForUpdate(v_us);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void v_cmd_dieu_phoi_BO_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_FO_danh_sach_don_hang.GetDataRow(m_grv_FO_danh_sach_don_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void v_cmd_dieu_phoi_pm_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_FO_danh_sach_don_hang.GetDataRow(m_grv_FO_danh_sach_don_hang.FocusedRowHandle);
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

        private void update_trang_thai_don_hang(US_GD_DAT_HANG v_us)
        {
            f112_FO_chuyen_don_hang_cho_PM v_f = new f112_FO_chuyen_don_hang_cho_PM();
            v_f.displayForUpdate(v_us);
          
         
        }

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

     

      

      

       

       
      
       
    }
}
