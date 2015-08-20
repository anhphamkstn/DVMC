using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f100_dm_cau_hoi_de : Form
    {
        public f100_dm_cau_hoi_de()
        {
            InitializeComponent();
        }

        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_CAU_HOI m_us_cau_hoi = new US_DM_CAU_HOI();
        US_CM_DM_TU_DIEN m_us_cmtd = new US_CM_DM_TU_DIEN();
        US_DM_CAU_TRA_LOI m_us_cau_tra_loi = new US_DM_CAU_TRA_LOI();

        private void f100_dm_cau_hoi_de_Load(object sender, EventArgs e)
        {

        }

        private void load_data_cbo()
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_nhom_cau_hoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT   ID, TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 5");
            WinFormControls.load_data_to_combobox_with_query(cbo_to_chuc, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT  ID, TEN FROM CM_DM_TU_DIEN  WHERE ID_LOAI_TU_DIEN= 11 ");
            WinFormControls.load_data_to_combobox_with_query(cbo_nguoi_tao_cau_hoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT ID, TEN FROM HT_NGUOI_SU_DUNG ");
            WinFormControls.load_data_to_combobox_with_query(cbo_nguoi_cap_nhat_cuoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT ID, TEN FROM HT_NGUOI_SU_DUNG ");
            WinFormControls.load_data_to_combobox_with_query(cbo_nguoi_tao_cau_tra_loi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT ID, TEN FROM HT_NGUOI_SU_DUNG ");
        }

        public void DisPlayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_cbo();
            this.ShowDialog();
        }

        internal void DisPlayForUpdate(IPCOREUS.US_DM_CAU_HOI v_us1, IPCOREUS.US_CM_DM_TU_DIEN v_us2, IPCOREUS.US_CM_DM_TU_DIEN v_us3, IPCOREUS.US_DM_CAU_TRA_LOI v_us4)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_cau_hoi = v_us1;
            m_us_cau_tra_loi = v_us4;
            us_to_form(v_us1, v_us2, v_us3, v_us4);
            this.ShowDialog();
        }

        private void us_to_form(IPCOREUS.US_DM_CAU_HOI v_us1, IPCOREUS.US_CM_DM_TU_DIEN v_us2, IPCOREUS.US_CM_DM_TU_DIEN v_us3, IPCOREUS.US_DM_CAU_TRA_LOI v_us4)
        {
            load_data_cbo();
            txt_cau_hoi.Text = v_us1.strNOI_DUNG_CAU_HOI;
            m_dat_ngay_tao_cau_hoi.Text = v_us1.datNGAY_TAO.ToString();
            m_dat_ngay_cap_nhat_cuoi.Text = v_us1.datNGAY_CAP_NHAP_CUOI.ToString();
            cbo_nguoi_tao_cau_hoi.SelectedValue = v_us1.dcNGUOI_TAO;
            cbo_nguoi_cap_nhat_cuoi.SelectedValue = v_us1.dcNGUOI_CAP_NHAT_CUOI;
            cbo_to_chuc.SelectedValue = v_us3.dcID;
            cbo_nhom_cau_hoi.SelectedValue = v_us2.dcID;
            txt_cau_tra_loi.Text = v_us4.strCAU_TRA_LOI;
            m_dat_ngay_tao_cau_tra_loi.Text = v_us4.datNGAY_TAO.ToString();
            cbo_nguoi_tao_cau_tra_loi.SelectedValue = v_us4.dcNGUOI_TAO;
            if (v_us4.dcID_TRANG_THAI == 22)
                cb_da_duyet.Checked = true;
            else cb_da_duyet.Checked = false;

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu() == true)
                {

                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us_cau_hoi();
                        m_us_cau_hoi.Insert();
                        form_to_us_cau_tra_loi();
                        m_us_cau_tra_loi.Insert();
                    }
                    else
                    {
                        form_to_us_cau_hoi();
                        m_us_cau_hoi.Update();
                        form_to_us_cau_tra_loi();
                        m_us_cau_tra_loi.Update();
                    }
                    MessageBox.Show("Thành công!");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool kiemtradulieu()
        {
            if (txt_cau_hoi.Text == "")
            {
                MessageBox.Show("Nhập câu hỏi!");
                return false;
            }
            else if (txt_cau_tra_loi.Text == "")
            {
                MessageBox.Show("Nhập câu trả lời!");
                return false;
            }
            return true;
        }

        private void form_to_us_cau_hoi()
        {
            //bảng câu hỏi
            m_us_cau_hoi.dcID_TO_CHUC = CIPConvert.ToDecimal(cbo_to_chuc.SelectedValue.ToString());
            m_us_cau_hoi.dcID_NHOM_CAU_HOI = CIPConvert.ToDecimal(cbo_nhom_cau_hoi.SelectedValue.ToString());
            m_us_cau_hoi.strNOI_DUNG_CAU_HOI = txt_cau_hoi.Text;
            m_us_cau_hoi.datNGAY_TAO = Convert.ToDateTime(m_dat_ngay_tao_cau_hoi.Text);
            m_us_cau_hoi.dcNGUOI_TAO = CIPConvert.ToDecimal(cbo_nguoi_tao_cau_hoi.SelectedValue.ToString());
            m_us_cau_hoi.dcNGUOI_CAP_NHAT_CUOI = CIPConvert.ToDecimal(cbo_nguoi_cap_nhat_cuoi.SelectedValue.ToString());
            m_us_cau_hoi.datNGAY_CAP_NHAP_CUOI = Convert.ToDateTime(m_dat_ngay_cap_nhat_cuoi.Text);
        }

        private void form_to_us_cau_tra_loi()
        {
            //bảng câu trả lời
            m_us_cau_tra_loi.dcID_CAU_HOI = m_us_cau_hoi.dcID;
            m_us_cau_tra_loi.strCAU_TRA_LOI = txt_cau_tra_loi.Text;
            m_us_cau_tra_loi.datNGAY_TAO = Convert.ToDateTime(m_dat_ngay_tao_cau_tra_loi.Text);
            m_us_cau_tra_loi.dcNGUOI_TAO = CIPConvert.ToDecimal(cbo_nguoi_tao_cau_tra_loi.SelectedValue.ToString());
            if (cb_da_duyet.Checked == true)
                m_us_cau_tra_loi.dcID_TRANG_THAI = 22;
            else
                m_us_cau_tra_loi.dcID_TRANG_THAI = 21;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
