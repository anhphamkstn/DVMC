using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class UserControl_dm_cau_hoi : UserControl
    {
        public UserControl_dm_cau_hoi()
        {
            InitializeComponent();
        }

        private void UserControl_dm_cau_hoi_Load(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_nhom_cau_hoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT   ID, TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 5");
            WinFormControls.load_data_to_combobox_with_query(cbo_to_chuc, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT  ID, TEN FROM CM_DM_TU_DIEN  WHERE ID_LOAI_TU_DIEN= 11 ");
            WinFormControls.load_data_to_combobox_with_query(cbo_nguoi_tao_cau_hoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT ID, TEN FROM HT_NGUOI_SU_DUNG ");
            WinFormControls.load_data_to_combobox_with_query(cbo_nguoi_cap_nhat_cuoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT ID, TEN FROM HT_NGUOI_SU_DUNG ");
            WinFormControls.load_data_to_combobox_with_query(cbo_nguoi_tao_cau_tra_loi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT ID, TEN FROM HT_NGUOI_SU_DUNG ");
  
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
