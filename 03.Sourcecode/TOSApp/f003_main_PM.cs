using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOSApp
{
    public partial class f003_main_PM : Form
    {
        public f003_main_PM()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TOSApp.BaoCao.f510_BAO_CAO_TIEP_NHAN v_f = new TOSApp.BaoCao.f510_BAO_CAO_TIEP_NHAN();
            v_f.ShowDialog();

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TOSApp.BaoCao.f520_BAO_CAO_XU_LI v_f = new TOSApp.BaoCao.f520_BAO_CAO_XU_LI();
            v_f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TOSApp.BaoCao.f500_BAO_CAO_DANH_GIA v_f = new TOSApp.BaoCao.f500_BAO_CAO_DANH_GIA();
            v_f.ShowDialog();
        }
    }
}
