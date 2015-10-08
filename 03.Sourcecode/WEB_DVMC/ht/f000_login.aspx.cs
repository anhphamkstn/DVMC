using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_DVMC.hethong
{
    public partial class f000_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                m_lab_error.Text = "";
                if ((login_username.Text == "") || (login_password.Text == ""))
                    m_lab_error.Text = "Tên truy cập và password không được để trống.";
                else
                {
                    if (check_login())
                    {
                        this.Hide();
                        f999_main_form v_f = new f999_main_form();
                        v_f.WindowState = FormWindowState.Maximized;
                        us_user.trang_thai_dang_nhap = true;
                        v_f.ShowDialog();
                        if (us_user.trang_thai_dang_nhap == false)
                        {
                            m_txt_pass.Text = "";
                            this.Show();
                        }
                        else this.Close();
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
            throw new NotImplementedException();
        }
    }
}