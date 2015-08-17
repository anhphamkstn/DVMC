using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOSApp;
using IPCOREUS;
using IP.Core.IPCommon;

namespace HT_DVMC
{
    public partial class f000_login : Form
    {
      

        public f000_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((m_txt_id.Text == "") || (m_txt_pass.Text == ""))
                    m_lab_error.Text = "Tên truy cập và password không được để trống.";
                else
                
                    if(check_login())
                    {
                        
                    }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_login()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetLogin(v_ds,m_txt_id.Text, m_txt_pass.Text);
            v_ds.Tables[0].Rows[0][0];
            return true;

        }
    }
}
