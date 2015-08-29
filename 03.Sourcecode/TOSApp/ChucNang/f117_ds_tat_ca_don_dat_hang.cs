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

          // v_us.FillDatasetWithTableName(v_ds, "v_GD_DAT_HANG_GD_LOG_DAT_HANG");
           v_us.FillDatasetWithQuery(v_ds,"select * from v_GD_DAT_HANG_GD_LOG_DAT_HANG where THAo_tac_het_han_YN= 'N'");
           // v_us.FillDatasetWithQuery(v_ds,"select	distinct ID_DON_HANG,MA_DON_HANG,ID_USER_NV_DAT_HANG,HO_TEN_USER_DAT_HANG,ID_DON_VI,DIEN_THOAI,THOI_GIAN_DAT_HANG,ID_NHOM_DV_YEU_CAU,TEN_NHOM_DICH_VU_YEU_CAU,NOI_DUNG_DAT_HANG,LOAI_THOI_GIAN_CAN_HOAN_THANH,THOI_GIAN_TAO,TEN_PHUONG_THUC_DAT_HANG,NGUOI_TAO_THAO_TAC,TEN_CHI_NHANH,THAO_TAC_HET_HAN_YN from V_GD_DAT_HANG_GD_LOG_DAT_HANG where THAO_TAC_HET_HAN_YN='N'");
            m_grc_ds_don_dat_hang.DataSource = v_ds.Tables[0];

          
 
        }

        private void m_cmd_chinh_sua_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us);
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
