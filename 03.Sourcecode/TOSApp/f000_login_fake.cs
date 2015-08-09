using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TOSApp
{
    public partial class f000_login_fake : Form
    {
        public f000_login_fake()
        {
            InitializeComponent();
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txtTenTruyNhap.Text == "fo")
                {
                    f001_main_FO v_f001 = new f001_main_FO();
                    v_f001.ShowDialog();
                   
                }
                else if (m_txtTenTruyNhap.Text == "bo")
                {
                    f002_main_BO v_f002 = new f002_main_BO();
                    v_f002.ShowDialog();
                }
                else if (m_txtTenTruyNhap.Text == "pm")
                {
                    f003_main_PM v_f003 = new f003_main_PM();
                    this.Visible = false;
                    v_f003.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
