using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;


namespace TOSApp.ChucNang
{
    public partial class f100_don_dat_hang_new : Form
    {
        decimal m_dc_id_loai_dich_vu=-1;
        decimal m_dc_loai_dich_vu = -1;
        decimal m_dc_ten_dich_vu = -1;
        public f100_don_dat_hang_new()
        {
            InitializeComponent();
            fomat_controlls_form();
            load_data_2_selected();
            
        }
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();

       
      
        //load data từ trong csdl lên vào các selected sẵn có 
        private void load_data_2_selected()
        {
            load_data_2_selected_don_vi();
            load_data_2_selected_loai_dich_vu();
            load_data_2_dich_vu_ver2();
            load_data_2_selected_trang_thai_don_hang();
            load_data_2_selected_nguoi_nhan_dat_hang();
            random_data_2_ma_don_hang();
        }
        //don vị đặt hàng
        private void load_data_2_selected_don_vi()
        {
             WinFormControls.load_data_to_combobox_with_query(m_cbo_dv_don_vi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "select TEN_KHACH_HANG from DM_KHACH_HANG");
        }
        //load dữ liệu lên selected loại dịch vụ
        private void load_data_2_selected_loai_dich_vu()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_loai_dich_vu, "ID", "TEN", WinFormControls.eTAT_CA.NO, "select ID, TEN_YEU_CAU as TEN from DM_LOAI_YEU_CAU where ID_CHA is null");
            m_cbo_loai_dich_vu.SelectedValue = m_dc_id_loai_dich_vu;
        }
        //load du liệu lên selected  dịch vụ
        private void load_data_2_selected_dich_vu()
        {

            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", "Where ID_CHA=" +m_dc_loai_dich_vu.ToString(),WinFormControls.eTAT_CA.NO, m_cbo_dich_vu);
            
        }
        //load len trang thai cua selected don hang
        private void load_data_2_selected_trang_thai_don_hang()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_trang_thai_don_hang, "ID", "TEN", WinFormControls.eTAT_CA.NO, "select TEN from CM_DM_TU_DIEN where ID_LOAI_TU_DIEN =17");
        }

        private void load_data_2_selected_nguoi_nhan_dat_hang()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_nguoi_nhan_dat_hang,"ID","TEN",WinFormControls.eTAT_CA.NO,"select Ten from HT_NGUOI_SU_DUNG");
        }

        private void random_data_2_ma_don_hang()
        {
            m_txt_ma_don_hang.Text = new Random().ToString();
        }
        //hàm này dùng để fomat controll trước khi tạo một đơn hàng mới
        //
        //

        private void fomat_controlls_form()
        {
            if (m_cbo_loai_dich_vu.SelectedValue == "") m_cbo_dich_vu.Visible = false;
        }

        private void m_chon_nguoi_xu_ly(object sender, EventArgs e)
        {
            f102_chon_danh_sach_nguoi_xu_ly_new v_f102 = new f102_chon_danh_sach_nguoi_xu_ly_new();
            v_f102.ShowDialog();
        }

       

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void load_data_2_dich_vu_ver2()
        {
            WinFormControls.load_data_to_combobox("DM_YEU_CAU","ID","TEN","where MA_LOAI_YEU_CAU="+m_cbo_loai_dich_vu.SelectedValue.ToString(),WinFormControls.eTAT_CA.NO,m_cbo_dich_vu);
        }

        private void m_cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dc_id_loai_dich_vu = CIPConvert.ToDecimal(m_cbo_loai_dich_vu.SelectedValue.ToString());
            load_data_2_selected_dich_vu();
        }

       
    }
}
