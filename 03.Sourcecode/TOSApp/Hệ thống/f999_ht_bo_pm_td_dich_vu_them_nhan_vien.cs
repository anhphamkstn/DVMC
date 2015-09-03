using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.Hệ_thống
{
    public partial class f999_ht_bo_pm_td_dich_vu_them_nhan_vien : Form
    {
        public f999_ht_bo_pm_td_dich_vu_them_nhan_vien()
        {
            InitializeComponent();
        }
        private void f999_ht_bo_pm_td_dich_vu_them_nhan_vien_Load(object sender, EventArgs e)
        {
           
        }
        internal void load_to_form(decimal v_id_nhom)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT hnsd.ID,hnsd.TEN FROM V_HT_NGUOI_SU_DUNG hnsd WHERE hnsd.ID_NHOM = "+v_id_nhom.ToString());
            grc_danh_sach.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < grv_danh_sach.SelectedRowsCount; i++)
            {
                us_user.m_lst_id_nguoi_xu_ly.Add(CIPConvert.ToDecimal(grv_danh_sach.GetDataRow(grv_danh_sach.GetSelectedRows()[i])["ID"].ToString()));
            }
            this.Close();
        }
    }
}
