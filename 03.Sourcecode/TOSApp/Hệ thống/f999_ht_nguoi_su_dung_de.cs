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

namespace TOSApp.Hệ_thống
{
    public partial class f999_ht_nguoi_su_dung_de : Form
    {
        public f999_ht_nguoi_su_dung_de()
        {
            InitializeComponent();
        }
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_HT_NGUOI_SU_DUNG m_us = new US_HT_NGUOI_SU_DUNG();
        
        private void form_to_us()
        {
            m_us.strTEN_TRUY_CAP = txt_ten_truy_cap.Text;
            m_us.strTEN = txt_ten.Text;
            m_us.strMAT_KHAU = txt_mat_khau.Text;
            m_us.strNGUOI_TAO = txt_nguoi_tao.Text;
            m_us.strEMAIL = txt_email.Text;
            m_us.strMAT_KHAU_EMAIL = txt_mat_khau_email.Text;
            m_us.strTRANG_THAI = txt_trang_thai.Text;
            m_us.datNGAY_TAO = Convert.ToDateTime(dat_ngay_tao.Text);
            if (rad_n.Checked == true)
                m_us.strBUILT_IN_YN = "N";
            else
                m_us.strBUILT_IN_YN = "Y";
        }

        private bool kiemtrdulieu()
        {
            if(txt_ten_truy_cap.Text==""||txt_mat_khau.Text == ""|| txt_ten.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập dữ liệu!");
                return false;
            }
            return true;
        }

        internal void displayinsert()
        {
            m_e_form_mode =  DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        internal void displayupdate(US_HT_NGUOI_SU_DUNG v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();

        }

        private void us_to_form(US_HT_NGUOI_SU_DUNG v_us)
        {
            txt_ten_truy_cap.Text = v_us.strTEN_TRUY_CAP;
            txt_mat_khau.Text = v_us.strMAT_KHAU;
            txt_ten.Text = v_us.strTEN;
            txt_nguoi_tao.Text = v_us.strNGUOI_TAO;
            txt_trang_thai.Text = v_us.strTRANG_THAI;
            dat_ngay_tao.Text = v_us.datNGAY_TAO.ToString();
            txt_email.Text = v_us.strEMAIL;
            txt_mat_khau_email.Text = v_us.strMAT_KHAU_EMAIL;
            if (v_us.strBUILT_IN_YN == "Y")
            {
                rad_y.Checked = true;
            }
            else
            {
                rad_n.Checked = true;
            }
               
        }

        private void simpbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtrdulieu())
                {
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us();
                        m_us.Insert();
                    }
                    else
                    {
                        form_to_us();
                        m_us.Update();
                    }
                }
                MessageBox.Show("Thành công!");
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void simpbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
