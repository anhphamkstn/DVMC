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
    public partial class f001_main_FO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f001_main_FO()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
            //    f500_cong_viec_FO_chi_tiet v_f500 = new f500_cong_viec_FO_chi_tiet();
            //  v_f500.MdiParent = this;
            //    v_f500.Show();
            }
            catch (Exception v_e)
            {

               CSystemLog_301.ExceptionHandle(v_e);
            }
          
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                TOSApp.BaoCao.f500_BAO_CAO_DANH_GIA v_f = new BaoCao.f500_BAO_CAO_DANH_GIA();
             //   v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                TOSApp.BaoCao.f510_BAO_CAO_TIEP_NHAN v_f = new BaoCao.f510_BAO_CAO_TIEP_NHAN();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f110_danh_sach_dieu_phoi_lai v_f110 = new f110_danh_sach_dieu_phoi_lai();
            v_f110.MdiParent = this;
            this.Show();
        }

      
    }
}
