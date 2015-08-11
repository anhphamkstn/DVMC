using System;
using System.Diagnostics;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using IP.Core.IPBusinessService;
using IP.Core.IPUserService;

using System.Threading;
using TOSApp.App_Code;
using IPCOREDS.CDBNames;
using TOSApp.ChucNang;

namespace TOSApp
{
    #region Nhiệm vụ của Class
    //*********************************************************************************
    //*  Là khởi động và điều khiển dăng nhập mới vào  Hệ thống
    //*  - hiện thị form login
    //*  - nếu OK thì tạo context và hiện thị form main, User không muốn vào thì thoát ra
    //*  - nếu trở lại từ main theo kiểu login mới thì lại hiện thị form login
    //*  - nếu trở lại từ main theo kiểu "exit from system" thì thoát
    //*********************************************************************************
    #endregion
    public class ApplicationControl
    {
        [STAThread]
        static void Main()
        {
            try
            {
                //f001_main_FO f_FO = new f001_main_FO();
               // f500_cong_viec_FO_chi_tiet f_FO = new f500_cong_viec_FO_chi_tiet();
               // f104_danh_sach_don_hang_dang_xu_ly_BO f_FO = new f104_danh_sach_don_hang_dang_xu_ly_BO();
             //f002_main_BO f_FO = new f002_main_BO();
              //f000_login_fake f_FO = new f000_login_fake();
              //  f113_danh_sach_can_phe_duyet_PM f_FO = new f113_danh_sach_can_phe_duyet_PM();
                f000_gd_dat_hang_gd_log_dat_hang v_f = new f000_gd_dat_hang_gd_log_dat_hang();
                v_f.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
    

