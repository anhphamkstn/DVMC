using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IPCOREDS;
using IPCOREUS;
using IPCOREDS.CDBNames;

using IP.Core.IPSystemAdmin;
using TOSApp.ChucNang;

namespace TOSApp.ChucNang
{
    public partial class f200_ds_dat_hang_new : Form
    {
        public f200_ds_dat_hang_new()
        {
            InitializeComponent();

        }
        #region Public Interface

        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        private void f200_ds_dat_hang_new_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {           
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();//Khai báo US
                DataSet v_ds = new DataSet();
                DataTable v_dt = new DataTable();
                v_ds.Tables.Add(v_dt);
                v_us.FillDatasetWithTableName(v_ds, "V_GD_DAT_HANG");

                m_grc.DataSource = v_ds.Tables[0];
                m_grv.ExpandAllGroups();                
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            insert_to_form();
        }

        private void insert_to_form()
        {
            f100_dat_hang_moi v_f = new f100_dat_hang_moi();
            v_f.Insert_form();
           load_data_2_grid();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                //f100_dat_hang_moi v_f = new f100_dat_hang_moi();
                //// var m_row = m_grv.SelectedRowsCount - 1;
                //var v_data_row = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                //US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                //US_DM_VERSION_MON_HOC us_version = new US_DM_VERSION_MON_HOC();
                //DS_DM_VERSION_MON_HOC v_ds_version = new DS_DM_VERSION_MON_HOC();
                //v_ds_version.EnforceConstraints = false;
                //us_version.FillDataset(v_ds_version, "where ID=" + v_data_row["ID_VERSION_MON_HOC"].ToString());
                //DataRow v_d_r = v_ds_version.Tables[0].Rows[0];
                //decimal v_id_version = CIPConvert.ToDecimal(v_d_r[DM_VERSION_MON_HOC.ID].ToString());
                //us_version = new US_DM_VERSION_MON_HOC(v_id_version);
                //decimal v_index_selected = CIPConvert.ToDecimal(us_version.dcID_MON_HOC.ToString());
                //v_f.Update_form(v_us, v_index_selected);
                //load_data_2_grid();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            //var v_data_row = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            //US_GD_LOP_MON v_us = new US_GD_LOP_MON(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
            //DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    v_us.Delete();
            //}

            //load_data_2_grid();
        }
    }
}
