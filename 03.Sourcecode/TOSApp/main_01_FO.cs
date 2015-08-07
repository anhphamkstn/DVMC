using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOSApp.ChucNang;
using IP.Core.IPCommon;

namespace TOSApp
{
    public partial class main_01_FO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public main_01_FO()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f500_cong_viec_FO_chi_tiet v_f500 = new f500_cong_viec_FO_chi_tiet();
                v_f500.MdiParent = this;

                v_f500.Show();
            }
            catch (Exception v_e)
            {

               CSystemLog_301.ExceptionHandle(v_e);
            }
          
        }
    }
}
