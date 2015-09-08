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

namespace TOSApp.ChucNang
{
    public partial class f121_tao_user_moi : Form
    {
        public f121_tao_user_moi()
        {
            InitializeComponent();
        }
        US_HT_NGUOI_SU_DUNG m_us = new US_HT_NGUOI_SU_DUNG();
        US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH m_us_nguoi_sd_nhom_cn = new US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH();
        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if(kiemtradulieu())
                {
                    //insert vào HT_NGUOI_SU_DUNG
                    m_us.strTEN_TRUY_CAP = m_txt_ten_truy_cap.Text;
                    m_us.strTEN = m_txt_ho_ten.Text;
                    m_us.strMAT_KHAU = us_user.GetMD5(m_txt_mat_khau.Text);
                    m_us.strEMAIL = m_txt_email.Text;
                    m_us.strMAT_KHAU_EMAIL = us_user.GetMD5(m_txt_mat_khau_email.Text);
                    m_us.datNGAY_TAO = System.DateTime.Now;
                    m_us.Insert();
                    //insert vào HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH
                    m_us_nguoi_sd_nhom_cn.dcID_NGUOI_SU_DUNG = m_us.dcID;
                    m_us_nguoi_sd_nhom_cn.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_cap_xu_ly.SelectedValue.ToString());
                    m_us_nguoi_sd_nhom_cn.dcID_CHI_NHANH = us_user.dcCHI_NHANH;
                    m_us_nguoi_sd_nhom_cn.Insert();
                    MessageBox.Show("Thành công!");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }

        }

        private bool kiemtradulieu()
        {
            if(m_txt_ho_ten.Text == "")
            {
                m_lab_eror.Text = "Nhập họ tên!";
                return false;
            }
            else if(m_txt_ten_truy_cap.Text == "")
            {
                m_lab_eror.Text = "Nhập tên truy cập!";
                return false;
            }
            else if (m_txt_mat_khau.Text == "")
            {
                m_lab_eror.Text = "nhập mật khẩu!";
                return false;
            }
            else if(m_txt_mat_khau_email.Text == "")
            {
                m_lab_eror.Text = "nhập mật khẩu email!";
                return false;
            }
            else if (m_txt_email.Text =="")
            {
                m_lab_eror.Text = "nhập địa chỉ email!";
                return false;
            }
            else
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "SELECT ID FROM HT_NGUOI_SU_DUNG WHERE TEN_TRUY_CAP = '" + m_txt_ten_truy_cap.Text + "'");
                if(v_ds.Tables[0].Rows.Count >0)
                {
                    m_lab_eror.Text = "Tên truy cập đã tồn tại trong hệ thống";
                    m_txt_mat_khau.Text = "";
                    return false;
                }
                return true;
            }
        }

        private void f121_tao_user_moi_Load(object sender, EventArgs e)
        {
            string v_str_query = "";
            if (us_user.dcID == 5)
                v_str_query = "SELECT ID, MA_NHOM FROM HT_NHOM_NGUOI_SU_DUNG NOT IN (6)";
            else
                v_str_query = "SELECT ID, MA_NHOM FROM HT_NHOM_NGUOI_SU_DUNG WHERE ID NOT IN  (3,4,5,6)";
            WinFormControls.load_data_to_combobox_with_query(m_cbo_cap_xu_ly, "ID", "MA_NHOM", WinFormControls.eTAT_CA.NO, v_str_query);
        }
    }
}
