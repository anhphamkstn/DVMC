using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.ChucNang;
using IPCOREUS;
using IP.Core.IPCommon;

namespace TOSApp.ChucNang
{
    public partial class f110_danh_sach_dieu_phoi_lai : Form
    {
        public f110_danh_sach_dieu_phoi_lai()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        
        private void fill_data_to_m_us()
        {
            DataRow v_dr = m_grv_ds_dieu_phoi_lai.GetDataRow(m_grv_ds_dieu_phoi_lai.FocusedRowHandle);
            
        }
        private void load_data_2_grid()
        {
       
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_GD_DIEU_PHOI_LAI");
            m_grc_ds_dieu_phoi_lai.DataSource = v_ds.Tables[0];
      
        }

      
        private void m_cmd_dieu_phoi_BO_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_log_dieu_phoi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void update_log_dieu_phoi()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.Update();  
            
        }

        private void m_cmd_dieu_phoi_PM_Click(object sender, EventArgs e)
        {
            try
            {
                f111_dieu_phoi_cho_BO v_f111 = new f111_dieu_phoi_cho_BO();
            fill_data_to_m_us();
           
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     

      
    }
}
