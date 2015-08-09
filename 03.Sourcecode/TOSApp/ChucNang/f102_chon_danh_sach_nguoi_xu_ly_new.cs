﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace TOSApp.ChucNang
{
    public partial class f102_chon_danh_sach_nguoi_xu_ly_new : Form
    {
        public f102_chon_danh_sach_nguoi_xu_ly_new()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
          
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

          //  v_us.FillDatasetWithTableName(v_ds, "V_HT_NGUOI_SU_DUNG");
            v_us.FillDatasetWithQuery(v_ds," select * from V_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH WHERE ID_NHOM = 2");
            m_grc_ht_nguoi_su_dung.DataSource = v_ds.Tables[0];

        
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }





        internal void Display(ref List<decimal> v_lst_id_nguoi_xu_ly)
        {
            this.ShowDialog();
            if (DialogResult== System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < m_grv_ht_nguoi_su_dung.SelectedRowsCount; i++)
                {
                    v_lst_id_nguoi_xu_ly.Add(CIPConvert.ToDecimal(m_grv_ht_nguoi_su_dung.GetDataRow(m_grv_ht_nguoi_su_dung.GetSelectedRows()[i])["ID_NGUOI_SU_DUNG"].ToString()));
                }
            }
           

        }

        private void m_cmd_oke_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

       
    }
}
