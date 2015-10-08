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
    public partial class f127_ds_don_hang_hoan_thanh_chua_danh_gia : Form
    {
        public f127_ds_don_hang_hoan_thanh_chua_danh_gia()
        {
            InitializeComponent();
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            string v_query = "SELECT * FROM V_GD_DAT_HANG  WHERE thoi_gian_hoan_thanh is not null and id_danh_gia_tu_user_dat_hang is null  and trang_thai_don_hang = N'L8A- TM đã nghiệm thu' ";
            v_us.FillDatasetWithQuery(v_ds, v_query);
            m_grc_ds_dh_ht_chua_danh_gia.DataSource = v_ds.Tables[0];
        }

        private void m_btn_remind_Click(object sender, EventArgs e)
        {
            string user_email = "dvmc2@topica.edu.vn";
            string password = "topica1234";
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_mau_email where id =10");
            string TIEU_DE = v_ds.Tables[0].Rows[0]["TIEU_DE_MAIL"].ToString();
            string NOI_DUNG = v_ds.Tables[0].Rows[0]["NOI_DUNG_EMAIL"].ToString();
            string GUI_CC = v_ds.Tables[0].Rows[0]["GUI_CC"].ToString();

            DataRow v_dr = m_grv_ds_don_hang_ht_chua_danh_gia.GetDataRow(m_grv_ds_don_hang_ht_chua_danh_gia.FocusedRowHandle);
            decimal v_id_giao_dich = CIPConvert.ToDecimal(v_dr["ID"].ToString());
            US_V_GD_DAT_HANG m_us = new US_V_GD_DAT_HANG(v_id_giao_dich);

            TIEU_DE = TIEU_DE.Replace("MA_DON_HANG", m_us.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("MA_DON_HANG", m_us.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("USER_NHAN_VIEN", m_us.strHO_TEN_USER_DAT_HANG);
            NOI_DUNG = NOI_DUNG.Replace("USER_DON_VI", m_us.strMA_DON_VI);
            NOI_DUNG = NOI_DUNG.Replace("USER_DIEN_THOAI", m_us.strDIEN_THOAI);
            NOI_DUNG = NOI_DUNG.Replace("USER_THOI_GIAN_DAT_HANG", m_us.datTHOI_GIAN_TAO.ToString());
            NOI_DUNG = NOI_DUNG.Replace("LOAI_DICH_VU_HO_TRO", m_us.strTEN_YEU_CAU);
            NOI_DUNG = NOI_DUNG.Replace("YEU_CAU_CU_THE", m_us.strNOI_DUNG_DAT_HANG);
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_HOAN_THANH_THUC_TE", m_us.datTHOI_GIAN_HOAN_THANH.ToString());
            NOI_DUNG = NOI_DUNG.Replace("LICH_SU_TRAO_DOI", "Vừa tiếp nhận.");
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", m_us.datTHOI_DIEM_CAN_HOAN_THANH + "hoặc thời gian hoàn thành là:" + m_us.datTHOI_GIAN_HOAN_THANH);
            NOI_DUNG = NOI_DUNG.Replace("PHAN_HOI_CUA_DVMC", "Quý khách vui lòng đáng giá chất lượng dịch vụ một cửa");

            NOI_DUNG = NOI_DUNG.Replace("NGUOI_XU_LY_DON_HANG", m_us.strNGUOI_XU_LY);
            NOI_DUNG = NOI_DUNG.Replace("NGUOI_NHAN_DAT_HANG", m_us.strNGUOI_TAO);
            US_DUNG_CHUNG v_us_1 = new US_DUNG_CHUNG();
            DataSet v_ds_1 = new DataSet();
            v_ds_1.Tables.Add(new DataTable());
            v_us_1.FillDatasetWithQuery(v_ds_1, "select * from dm_khach_hang where id=" + m_us.dcID_USER_NV_DAT_HANG);
            string to_cc = "";
            to_cc = v_ds_1.Tables[0].Rows[0]["EMAIL"].ToString();
            try
            {
                Mail.sendEmail(user_email, password, to_cc, TIEU_DE, NOI_DUNG);
                MessageBox.Show("Hoàn thành!");
            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
