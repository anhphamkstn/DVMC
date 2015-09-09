using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TOSApp.ChucNang
{
    public partial class f117_ds_tat_ca_don_dat_hang : Form
    {
        decimal v_deadline =0;
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us;
        public f117_ds_tat_ca_don_dat_hang()
        {          
            InitializeComponent();
            load_data_2_grid();
        }
      
       
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds,"select * from v_GD_DAT_HANG_GD_LOG_DAT_HANG where Thao_tac_het_han_YN= 'N' and thoi_gian_hoan_thanh is null and id_nguoi_tao = " + us_user.dcID.ToString());
            m_grc_ds_don_dat_hang.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_chinh_sua_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
               
                v_f100.displayForUpdate(v_us,v_deadline);
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void m_grv_ds_don_dat_hang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //try
            //{
            //    DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
            //    US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            //    f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
            //    v_f100.displayForUpdate(v_us);
            //    load_data_2_grid();

            //}
            //catch (Exception v_e)
            //{

            //    CSystemLog_301.ExceptionHandle(v_e);
            //}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_2_grid();

        }




        internal void display_for_refurse_dealine(decimal deadline_id)
        {

            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                this.Show();

                v_deadline = deadline_id;
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    
    }
}
