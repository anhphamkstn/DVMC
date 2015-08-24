﻿using System;
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
    public partial class f114_ds_BO : Form
    {
        public f114_ds_BO()
        {
            InitializeComponent();
            load_data_2_form();
        }

        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();
        List<decimal> m_lst_ds_BO = new List<decimal>();
        List<decimal> m_lst_id_log_dat_hang = new List<decimal>();

        decimal m_id_gd_dat_hang;
        private void load_data_2_form()
        {
            
            
        }

      

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            //  v_us.FillDatasetWithTableName(v_ds, "V_HT_NGUOI_SU_DUNG");
            v_us.FillDatasetWithQuery(v_ds, " select * from V_BO_DICH_VU where ID_DICH_VU = " + m_us.dcID_NHOM_DV_YEU_CAU);
            m_grc_ds_BO.DataSource = v_ds.Tables[0];

        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        internal void display_dieu_huong(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            load_data_2_ma_don_hang(v_us);
            load_data_2_grid();
            this.ShowDialog();
        }
        US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();

        private void load_data_2_ma_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
            m_id_gd_dat_hang = v_us.dcID_DON_HANG;
           // m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
           
        }

      
        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
           try
           {
               for (int i = 0; i < m_grv_ds_BO.SelectedRowsCount; i++)
               {
                   m_lst_ds_BO.Add(CIPConvert.ToDecimal(m_grv_ds_BO.GetDataRow(m_grv_ds_BO.GetSelectedRows()[i])["ID_NGUOI_SU_DUNG"].ToString()));
               }

	               update_don_hang(m_us);
                   for (int i = 0; i < m_lst_ds_BO.Count; i++)
                   {
                       ghi_log_dieu_phoi_lai(m_lst_ds_BO[i],m_us);
                   }
                    
      
                //for (int i = 0; i < m_lst_ds_BO.Count; i++)
                //{
                //    update_don_hang(m_lst_ds_BO[i]);
                //    ghi_log_dieu_phoi_lai();
                //}
                
                MessageBox.Show("thành công !");
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void ghi_log_dieu_phoi_lai(decimal p,US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 311;//fo đã điều phối lại
            v_US.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;//fo có id 1
            v_US.dcID_NGUOI_NHAN_THAO_TAC = p;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng đã được điều phối lại cho BO" +p ;
            v_US.Insert();
        }

     

        private void update_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(m_us.dcID);
            v_US.strTHAO_TAC_HET_HAN_YN = "Y";
            v_US.strGHI_CHU = "đơn hàng đã được gửi cho BO";
            v_US.Update();
        }

  
        private void ghi_log_dieu_phoi_cho_nguoi_xu_ly(decimal p, US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {

            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 311;//fix cung cho tao tac dieu huong--> bi ngu
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = p;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "FO đã điều phối lại cho BO";
            v_us.Insert();
        }

        private void update_don_hang(decimal p)
        {
            for (int i = 0; i < m_lst_ds_BO.Count; i++)
            {
                US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_lst_ds_BO[i]);
   
                v_us.strTHAO_TAC_HET_HAN_YN = "Y";
                v_us.strGHI_CHU = "đã điều phối lại";
                v_us.Update();
            }
 	      
        }
    }
}
