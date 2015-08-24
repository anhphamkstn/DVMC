﻿using System;
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
using TOSApp.DanhMuc;
using TOSApp.Hệ_thống;

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
                TOSApp.HT.f000_login v_f = new HT.f000_login();
                //f100_don_dat_hang_new v_f= new f100_don_dat_hang_new();
               // f999_main_form v_f = new f999_main_form();
               // f118_ds_log_dat_hang v_f = new f118_ds_log_dat_hang();
                v_f.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
    

