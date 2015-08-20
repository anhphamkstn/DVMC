using IP.Core.IPCommon;
using IPCOREDS.CDBNames;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f101_dm_mau_email : Form
    {
        public f101_dm_mau_email()
        {
            InitializeComponent();
        }


        private void f101_dm_mau_email_Load(object sender, EventArgs e)
        {
            load_data_grid();
        }

        private void load_data_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_MAU_EMAIL");
            m_grc_dm_mau_email.DataSource = v_ds.Tables[0];
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_mau_email.GetDataRow(m_grv_dm_mau_email.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_MAU_EMAIL.ID].ToString());
                US_DM_MAU_EMAIL v_us = new US_DM_MAU_EMAIL(v_id);
                v_us.Delete();
                MessageBox.Show("Da xoa thanh cong " + v_dr[DM_MAU_EMAIL.ID].ToString());
                load_data_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_btn_them_Click(object sender, EventArgs e)
        {
            f101_dm_mau_email_de v_f = new f101_dm_mau_email_de();
            v_f.DisPlayForInsert();
            load_data_grid();
        }

        private void m_btn_sua_Click(object sender, EventArgs e)
        {
            DataRow v_dr = m_grv_dm_mau_email.GetDataRow(m_grv_dm_mau_email.FocusedRowHandle);
            US_DM_MAU_EMAIL v_us = new US_DM_MAU_EMAIL(CIPConvert.ToDecimal(v_dr[DM_MAU_EMAIL.ID].ToString()));
            f101_dm_mau_email_de v_f = new f101_dm_mau_email_de();
            v_f.DisPlayForUpdate(v_us);
            load_data_grid();
        }
       
    }
}
