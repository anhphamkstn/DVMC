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

namespace TOSApp
{
    public partial class f002_main_BO : Form
    {
        public f002_main_BO()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f104_danh_sach_don_hang_dang_xu_ly_BO v_f104 = new f104_danh_sach_don_hang_dang_xu_ly_BO();
            v_f104.ShowDialog();
        }
    }
}
