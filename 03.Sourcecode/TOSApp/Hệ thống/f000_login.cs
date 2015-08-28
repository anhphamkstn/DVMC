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

namespace TOSApp.HT
{
    public partial class f000_login : Form
    {
      

        public f000_login()
        {
            InitializeComponent();
        }
        private void f000_login_Load(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox("HT_CHI_NHANH", "ID", "TEN_CHI_NHANH", "", WinFormControls.eTAT_CA.NO, m_cb_chi_nhanh);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((m_txt_id.Text == "") || (m_txt_pass.Text == ""))
                    m_lab_error.Text = "Tên truy cập và password không được để trống.";
                else
                {
                    if (check_login())
                    {
                       
                        f999_main_form v_f = new f999_main_form();
                        v_f.ShowDialog();

                    }
                    else m_lab_error.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
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
            string str = "SELECT *FROM [BKI_DVMC].[dbo].[V_HT_NGUOI_SU_DUNG] WHERE TEN_TRUY_CAP = " + " '" + m_txt_id.Text + "' " + "AND MAT_KHAU = " + " '" + us_user.GetMD5(m_txt_pass.Text) + "' " + "AND ID_CHI_NHANH =" + m_cb_chi_nhanh.SelectedValue.ToString();
            v_us.FillDatasetWithQuery(v_ds,str );
            
                //v_us.FillDatasetLogin(v_ds, m_txt_id.Text, m_txt_pass.Text, CIPConvert.ToDecimal(m_cb_chi_nhanh.SelectedValue.ToString()));
                if (v_ds.Tables[0].Rows.Count > 0)
                {
                    DataRow v_dr = v_ds.Tables[0].Rows[0];
                    US_V_HT_NGUOI_SU_DUNG ht_us = new US_V_HT_NGUOI_SU_DUNG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    us_user.dcID = ht_us.dcID;
                    us_user.dcIDNhom = ht_us.dcID_NHOM;
                    us_user.dcCHI_NHANH = CIPConvert.ToDecimal(m_cb_chi_nhanh.SelectedValue.ToString());
                    return true;
                }
                else return false;
        }

       
    }
}
