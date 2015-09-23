using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp;

using IPCOREUS;
using IP.Core.IPCommon;
using TOSApp.App_Code;
using TOSApp.DanhMuc;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IPCOREDS.CDBNames;




namespace TOSApp.ChucNang
{
    public partial class f100_don_dat_hang_new : Form
    {

        decimal m_dc_id_loai_dich_vu = -1;
        decimal m_id_dich_vu;
        CallInfor m_ip_call_infor;

        public f100_don_dat_hang_new()
        {
            InitializeComponent();
            load_data_2_selected();
            
        }

        public void display_for_ipphone(CallInfor ip_call_infor)
        {
            m_ip_call_infor = ip_call_infor;
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_khach_hang where DIEN_THOAI = '" + ip_call_infor.mobile_phone + "'");
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                m_searchLookUpEdit_user_nv_dat_hang.EditValue = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][0].ToString());
            }
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
            m_cbo_phuong_thuc_dat_hang.SelectedIndex = 183;
            // nếu đang có đơn hàng thì xử lí như thế nào
        }

        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_GD_DAT_HANG m_us = new US_GD_DAT_HANG();
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG M_us;
        US_DUNG_CHUNG m_us_dm_mau_mail = new US_DUNG_CHUNG();
        decimal m_deadline_id;
        string v_time;
        decimal id_log;
        List<decimal> m_lst_id_nguoi_xu_ly = new List<decimal>();

        #region load data to selected

        //load data từ trong csdl lên vào các selected sẵn có 
        private void load_data_2_selected()
        {
            load_data_2_dv_2();
            load_data_2_dc_dich_vu();
            load_data_2_selected_trang_thai_don_hang();
            random_data_2_ma_don_hang();
            load_data_2_selected_nguoi_tiep_nhan();
            load_data_2_selected_loai_dich_vu();
            load_data_2_m_cbo_phuong_thuc_dat_hang();
            load_data_2_selected_thoi_gian_hoan_thanh();
            load_data_2_search_look_edit_dich_vu();
            load_data_to_cbo_don_vi();
            load_data_2_search_look_edit_user();
        }

        private void load_data_2_m_cbo_phuong_thuc_dat_hang()
        {
            WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN_NGAN", " where ID_LOAI_TU_DIEN = 18 ", WinFormControls.eTAT_CA.NO, m_cbo_phuong_thuc_dat_hang);
        }

        private void load_data_2_dc_dich_vu()
        {
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " where ID_CHA is not Null AND TRANG_THAI_HSD = 'N'", WinFormControls.eTAT_CA.NO, m_cbo_dich_vu);
        }

        private void load_data_2_dv_2()
        {
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " where ID_CHA is not Null AND TRANG_THAI_HSD = 'N'", WinFormControls.eTAT_CA.NO, m_cbo_loai_dich_vu_2);
        }
        private void load_data_to_cbo_don_vi()
        {
            WinFormControls.load_data_to_combobox("DM_DON_VI", "ID", "MA_DON_VI","", WinFormControls.eTAT_CA.NO, m_cbo_dv_don_vi
);
        }
        private void load_data_2_search_look_edit_dich_vu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_LOAI_YEU_CAU");
            m_searchLookUpEdit_dv.Properties.DataSource = v_ds.Tables[0];
            m_searchLookUpEdit_user_nv_dat_hang.EditValue = v_ds.Tables[0].Rows[0][0].ToString();
        }
        private void load_data_2_search_look_edit_user()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_KHACH_HANG");
            m_searchLookUpEdit_user_nv_dat_hang.Properties.DataSource = v_ds.Tables[0];
        }
        
        private void load_data_to_selected_so_dien_thoai(US_DM_KHACH_HANG v_us)
        {
            m_txt_dien_thoai.Text = v_us.strDIEN_THOAI;
        }

        private void load_data_to_selected_ho_ten_nguoi_dat_hang(US_DM_KHACH_HANG v_us)
        {
            m_txt_ho_ten_nguoi_dat_hang.Text = v_us.strTEN_KHACH_HANG;
        }

        private void load_data_2_grid_khach_hang_don_hang()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_DON_HANG_TRANG_THAI where ID_USER_NV_DAT_HANG =" + m_searchLookUpEdit_user_nv_dat_hang.EditValue.ToString() + "order by THOI_GIAN_TAO");
            m_grc_user_don_hang.DataSource = v_ds.Tables[0];
        }

        private void load_data_2_selected_thoi_gian_hoan_thanh()
        {
            WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN", " where ID_LOAI_TU_DIEN = 20", WinFormControls.eTAT_CA.NO, m_cbo_thoi_gian_hoan_thanh);
        }

        private void load_data_2_selected_nguoi_tiep_nhan()
        {
            WinFormControls.load_data_to_combobox("V_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH", "ID_NGUOI_SU_DUNG", "TEN", " Where ID_NHOM=1", WinFormControls.eTAT_CA.NO, m_cbo_nguoi_nhan_dat_hang);
        }

        //don vị đặt hàng
        private void load_data_2_selected_don_vi()
        {
            WinFormControls.load_data_to_combobox("DM_DON_VI", "ID", "MA_DON_VI", "", WinFormControls.eTAT_CA.NO, m_cbo_dv_don_vi);
        }
        //load dữ liệu lên selected loại dịch vụ
        private void load_data_2_selected_loai_dich_vu()
        {
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " where ID_CHA is Null AND TRANG_THAI_HSD = 'N'", WinFormControls.eTAT_CA.NO, m_cbo_loai_dich_vu_1);
        }
        //hàm này load data len loai dịch vụ 3 là loại cấp 3- dịch vụ 
        private void load_data_2_dich_vu()
        {

            WinFormControls.load_data_to_combobox_with_query(m_cbo_dich_vu, "ID", "TEN", WinFormControls.eTAT_CA.NO, "select DISTINCT ID, TEN_YEU_CAU as TEN  from DM_LOAI_YEU_CAU where ID_CHA=" + m_cbo_loai_dich_vu_2.SelectedValue.ToString());


        }
        //hàm này load data len loai dịch vụ 2 là loại cấp 2
        private void load_data_2_loai_dich_vu_2()
        {

            WinFormControls.load_data_to_combobox_with_query(m_cbo_loai_dich_vu_2, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "select ID, TEN_YEU_CAU from DM_LOAI_YEU_CAU where ID_CHA=" + m_cbo_loai_dich_vu_1.SelectedValue.ToString() + "AND TRANG_THAI_HSD = 'N'");
        }
        //load du liệu lên selected  dịch vụ
        private void load_data_2_selected_dich_vu()
        {

            WinFormControls.load_data_to_combobox_with_query(m_cbo_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "select ID, TEN_YEU_CAU  from DM_LOAI_YEU_CAU where ID_CHA=" + m_cbo_loai_dich_vu_2.SelectedValue.ToString() + "AND TRANG_THAI_HSD = 'N'");
        }
        //load len trang thai cua selected don hang
        private void load_data_2_selected_trang_thai_don_hang()
        {
            WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN", " where ID in(293,297)", WinFormControls.eTAT_CA.NO, m_cbo_trang_thai_don_hang);
        }


        private void random_data_2_ma_don_hang()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_txt_ma_don_hang.Text = v_us.get_ma_dat_hang_tiep_theo();       
        }
        #endregion

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_xac_nhan_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kiem_tra_du_lieu_truoc_luu() == true)
                {
                    if (m_e_form_mode == DataEntryFormMode.UpdateDataState || m_deadline_id == 1)
                    {

                        udpate_don_hang();
                        if (m_deadline_id == 0)
                        {
                            ghi_log_thay_doi_don_hang();
                        }
                        else
                        {
                            ghi_log_thay_doi_deadline();
                        }
                        gui_emai_xac_nhan_cap_nhat_don_hang(M_us);
                        MessageBox.Show("đơn hàng đã được cập nhật thông tin");
                        this.Close();
                    }
                    else
                    {
                        if (m_lst_id_nguoi_xu_ly.Count != 0 & CIPConvert.ToDecimal(m_cbo_trang_thai_don_hang.SelectedValue) == 293)
                        {
                           
                            luu_don_hang();
                            dieu_phoi_don_hang();
                            if (m_ip_call_infor != null)
                                insert_gd_cuoc_goi(m_ip_call_infor);
                            if (m_chk_gui_mail_yn.Checked == true)
                            {
                                gui_emai_xac_nhan(m_us);
                            }

                            this.Close();
                        }
                        else if (m_lst_id_nguoi_xu_ly.Count != 0 & CIPConvert.ToDecimal(m_cbo_trang_thai_don_hang.SelectedValue) == 297)
                        {
                            luu_don_hang();
                            dieu_phoi_don_hang();
                            if (m_chk_gui_mail_yn.Checked == true)
                            {
                                gui_emai_xac_nhan(m_us);
                            }

                            this.Close();
                        }
                        else MessageBox.Show("Hãy chọn người xử lý!");
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void insert_gd_cuoc_goi(CallInfor v_ip_call_infor)
        {

            US_GD_CUOC_GOI_YEU_CAU v_us = new US_GD_CUOC_GOI_YEU_CAU();
            v_us.strCALL_ID = v_ip_call_infor.call_id;
            if (v_ip_call_infor.link_down_record != null)
                v_us.strVOICE_CALL_LINK = v_ip_call_infor.link_down_record;
            if (v_ip_call_infor.start_time != null)
                v_us.datSTART_TIME = Convert.ToDateTime(v_ip_call_infor.start_time);
            if (v_ip_call_infor.end_time != null)
                v_us.datEND_TIME = Convert.ToDateTime(v_ip_call_infor.end_time);
            if (v_ip_call_infor.station_id != null)
                v_us.dcSTATION_ID = CIPConvert.ToDecimal(v_ip_call_infor.station_id.ToString());
            if (v_ip_call_infor.duration != null)
                v_us.dcDURATION = CIPConvert.ToDecimal(v_ip_call_infor.duration.ToString());
            if (v_ip_call_infor.status != null)
                v_us.strSTATUS = v_ip_call_infor.status;
            if (v_ip_call_infor.error_code != null)
                v_us.strERROR_CODE = v_ip_call_infor.error_code;
            if (v_ip_call_infor.error_desc != null)
                v_us.strERROR_DESC = v_ip_call_infor.error_desc;
            if (v_ip_call_infor.datetime_response != null)
                v_us.datDATETIME_RESPOND = Convert.ToDateTime(v_ip_call_infor.datetime_response);
            if (v_ip_call_infor.ringtime != null)
                v_us.dcRINGTIME = CIPConvert.ToDecimal(v_ip_call_infor.ringtime.ToString());
            v_us.datTHOI_DIEM_GOI = System.DateTime.Now;
            v_us.dcID_DAT_HANG = m_us.dcID;
            v_us.strCUOC_GOI_VAO_YN = "Y";
            v_us.Insert();
        }

        private void ghi_log_thay_doi_don_hang()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 321;//trang thai vua được cập nhật
            v_us.dcID_GD_DAT_HANG = M_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "thông tin đơn hàng được thay đổi";
            v_us.Insert();
        }

        private void gui_emai_xac_nhan_cap_nhat_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_mau_email where id =7");
            string TIEU_DE = v_ds.Tables[0].Rows[0]["TIEU_DE_MAIL"].ToString();
            string NOI_DUNG = v_ds.Tables[0].Rows[0]["NOI_DUNG_EMAIL"].ToString();
            string GUI_CC = v_ds.Tables[0].Rows[0]["GUI_CC"].ToString();

            TIEU_DE = TIEU_DE.Replace("MA_DON_HANG", m_us.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("MA_DON_HANG", m_us.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("USER_NHAN_VIEN", m_txt_ho_ten_nguoi_dat_hang.Text);
            NOI_DUNG = NOI_DUNG.Replace("USER_DON_VI", m_cbo_dv_don_vi.Text);
            NOI_DUNG = NOI_DUNG.Replace("USER_DIEN_THOAI", m_txt_dien_thoai.Text);
            NOI_DUNG = NOI_DUNG.Replace("USER_THOI_GIAN_DAT_HANG", m_us.datTHOI_GIAN_TAO.ToString());
            NOI_DUNG = NOI_DUNG.Replace("LOAI_DICH_VU_HO_TRO", m_cbo_dich_vu.Text);
            NOI_DUNG = NOI_DUNG.Replace("YEU_CAU_CU_THE", m_txt_yeu_cau_cu_the.Text);
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_HOAN_THANH_THUC_TE", "chưa có");
            NOI_DUNG = NOI_DUNG.Replace("LICH_SU_TRAO_DOI", "Vừa tiếp nhận.");
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", m_dat_thoi_diem_can_hoan_thanh.Text + "hoặc thời gian hoàn thành là:" + m_cbo_thoi_gian_hoan_thanh.Text);
            NOI_DUNG = NOI_DUNG.Replace("PHAN_HOI_CUA_DVMC", m_txt_phan_hoi_tu_dvmc.Text);
            string nguoi_xu_ly = "";
            US_DUNG_CHUNG v_us_3 = new US_DUNG_CHUNG();
            DataSet v_ds_3 = new DataSet();
            v_ds_3.Tables.Add(new DataTable());
            v_us_3.FillDatasetWithQuery(v_ds_3, "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where ten_nguoi_tao_thao_tac_log is not null and THAO_TAC_HET_HAN_YN ='N' and ID_DON_HANG=" + m_us.dcID_DON_HANG);
            for (int i = 0; i < v_ds_3.Tables[0].Rows.Count; i++)
            {
                nguoi_xu_ly += "," + v_ds_3.Tables[0].Rows[i]["TEN_NGUOI_TAO_THAO_TAC_LOG"].ToString();
            }

            NOI_DUNG = NOI_DUNG.Replace("NGUOI_XU_LY_DON_HANG", nguoi_xu_ly);
            NOI_DUNG = NOI_DUNG.Replace("NGUOI_NHAN_DAT_HANG", m_cbo_nguoi_nhan_dat_hang.Text);
            US_DUNG_CHUNG v_us_1 = new US_DUNG_CHUNG();
            DataSet v_ds_1 = new DataSet();
            v_ds_1.Tables.Add(new DataTable());
            v_us_1.FillDatasetWithQuery(v_ds_1, "select * from dm_khach_hang where id=" + m_us.dcID_USER_NV_DAT_HANG);
            string to_cc = "";
            to_cc = v_ds_1.Tables[0].Rows[0]["EMAIL"].ToString();

            string user_email = "daothihienhien@gmail.com";
            string password = "daothihien";
            try
            {
                Mail.sendEmail(user_email, password, to_cc, TIEU_DE, NOI_DUNG);

            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void gui_emai_xac_nhan(US_GD_DAT_HANG m_us)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_mau_email where id =11");
            string TIEU_DE = v_ds.Tables[0].Rows[0]["TIEU_DE_MAIL"].ToString();
            string NOI_DUNG = v_ds.Tables[0].Rows[0]["NOI_DUNG_EMAIL"].ToString();
            string GUI_CC = v_ds.Tables[0].Rows[0]["GUI_CC"].ToString();

            TIEU_DE = TIEU_DE.Replace("MA_DON_HANG", m_us.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("MA_DON_HANG", m_us.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("USER_NHAN_VIEN", m_txt_ho_ten_nguoi_dat_hang.Text);
            NOI_DUNG = NOI_DUNG.Replace("USER_DON_VI", m_cbo_dv_don_vi.Text);
            NOI_DUNG = NOI_DUNG.Replace("USER_DIEN_THOAI", m_txt_dien_thoai.Text);
            NOI_DUNG = NOI_DUNG.Replace("USER_THOI_GIAN_DAT_HANG", m_us.datTHOI_GIAN_TAO.ToString());
            NOI_DUNG = NOI_DUNG.Replace("LOAI_DICH_VU_HO_TRO", m_cbo_dich_vu.Text);
            NOI_DUNG = NOI_DUNG.Replace("YEU_CAU_CU_THE", m_txt_yeu_cau_cu_the.Text);
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_HOAN_THANH_THUC_TE", "chưa có");
            NOI_DUNG = NOI_DUNG.Replace("LICH_SU_TRAO_DOI", "Vừa tiếp nhận.");
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", m_dat_thoi_diem_can_hoan_thanh.Text + "hoặc thời gian hoàn thành là:" + m_cbo_thoi_gian_hoan_thanh.Text);
            NOI_DUNG = NOI_DUNG.Replace("PHAN_HOI_CUA_DVMC", m_txt_phan_hoi_tu_dvmc.Text);
            string nguoi_xu_ly = "";

            for (int i = 0; i < m_lst_id_nguoi_xu_ly.Count; i++)
            {
                US_DUNG_CHUNG v_us_2 = new US_DUNG_CHUNG();
                DataSet v_ds_2 = new DataSet();
                v_ds_2.Tables.Add(new DataTable());
                v_us_2.FillDatasetWithQuery(v_ds_2, "select * from ht_nguoi_su_dung where id=" + m_lst_id_nguoi_xu_ly[i]);
                nguoi_xu_ly += v_ds_2.Tables[0].Rows[0]["TEN_TRUY_CAP"].ToString() + " , ";
            }
            NOI_DUNG = NOI_DUNG.Replace("NGUOI_XU_LY_DON_HANG", nguoi_xu_ly);
            NOI_DUNG = NOI_DUNG.Replace("NGUOI_NHAN_DAT_HANG", m_cbo_nguoi_nhan_dat_hang.Text);
            US_DUNG_CHUNG v_us_1 = new US_DUNG_CHUNG();
            DataSet v_ds_1 = new DataSet();
            v_ds_1.Tables.Add(new DataTable());
            v_us_1.FillDatasetWithQuery(v_ds_1, "select * from dm_khach_hang where id=" + m_us.dcID_USER_NV_DAT_HANG);
            string to_cc = "";
            to_cc = v_ds_1.Tables[0].Rows[0]["EMAIL"].ToString();

            string user_email = "daothihienhien@gmail.com";
            string password = "daothihien";
            try
            {
                Mail.sendEmail(user_email, password, to_cc, TIEU_DE, NOI_DUNG);

            }

            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void ghi_log_thay_doi_deadline()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 329;//trang thai vua được cập nhật deadline
            v_us.dcID_GD_DAT_HANG = M_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            //v_us.dcID_NGUOI_NHAN_THAO_TAC = M_us.dcID_NGUOI_NHAN_THAO_TAC;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "đơn hàng vừa đươc cập nhật DEADLINE !";
            v_us.Insert();
        }

        private void load_data_2_lich_su_thuc_hien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from v_GD_DAT_HANG_GD_LOG_DAT_HANG where ID_DON_HANG=" + M_us.dcID_DON_HANG + "order by THOI_GIAN_TAO");
            m_grc_lich_su_thuc_hien.DataSource = v_ds.Tables[0];
        }

        private void udpate_don_hang()
        {

            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(M_us.dcID_DON_HANG);
            v_us.strNOI_DUNG_DAT_HANG = m_txt_yeu_cau_cu_the.Text;
            v_us.strPHAN_HOI_TU_DVMC = m_txt_phan_hoi_tu_dvmc.Text;
            v_us.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH = CIPConvert.ToDecimal(m_cbo_thoi_gian_hoan_thanh.SelectedValue);
            v_us.datTHOI_DIEM_CAN_HOAN_THANH = m_dat_thoi_diem_can_hoan_thanh.Value;
            v_us.Update();
        }

        private void dieu_phoi_don_hang()
        {
            cap_nhat_lai_trang_thai_tiep_nhan();
            xac_nhan_dieu_phoi(m_lst_id_nguoi_xu_ly, m_us);
            MessageBox.Show("FO đã điều phối");
        }

        private void cap_nhat_lai_trang_thai_tiep_nhan()
        {
            //cap nhat lai trang thai cua log don hang truoc khi thuc hien thao tac dieu huong
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(id_log);
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.Update();
        }

        private void luu_don_hang()
        {
            //insert_new_data_2_dm_ma_don_hang(m_txt_ma_don_hang.Text);
            ghi_don_hang();
            ghi_log_tiep_nhan();
        }

        private decimal ghi_log_tiep_nhan()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();

            v_us.dcID_LOAI_THAO_TAC = CIPConvert.ToDecimal(m_cbo_trang_thai_don_hang.SelectedValue.ToString());
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = m_us.datTHOI_GIAN_TAO;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = m_txt_phan_hoi_tu_dvmc.Text;
            v_us.Insert();
            id_log = v_us.dcID;
            return v_us.dcID;
        }

        private void ghi_don_hang()
        {
            form_2_us();

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_us.Insert();
            }
            else m_us.Update();
        }

        private void xac_nhan_dieu_phoi(List<decimal> v_lst_id_nguoi_xu_ly, US_GD_DAT_HANG m_us)
        {

            for (int i = 0; i < v_lst_id_nguoi_xu_ly.Count; i++)
            {
                ghi_log_dieu_phoi_cho_nguoi_xu_ly(v_lst_id_nguoi_xu_ly[i], m_us);
            }
        }
        //ghi lai dieu phoi cho tung nguoi
        private void ghi_log_dieu_phoi_cho_nguoi_xu_ly(decimal nguoi_nhan_tao_tac_i, US_GD_DAT_HANG m_us)
        {

            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 295;//fix cung cho tao tac dieu huong--> bi ngu
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = nguoi_nhan_tao_tac_i;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;//?? văn
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "đã điều phối cho BO ";
            v_us.Insert();
        }
        //ghi lai log tai bang gd_log_dat_hang sau khi thuc hien thao tac insert

        private void form_2_us()
        {
            m_us.strMA_DON_HANG = m_txt_ma_don_hang.Text;
            m_us.dcID_USER_NV_DAT_HANG = CIPConvert.ToDecimal(m_searchLookUpEdit_user_nv_dat_hang.EditValue);
            m_us.dcID_DON_VI = CIPConvert.ToDecimal(m_cbo_dv_don_vi.SelectedValue.ToString());//xem lai
            m_us.strDIEN_THOAI = m_txt_dien_thoai.Text;
            m_us.strHO_TEN_USER_DAT_HANG = m_txt_ho_ten_nguoi_dat_hang.Text;

            if (m_checkbox_m2_m3.Checked == false)
            {
                m_us.datTHOI_DIEM_CAN_HOAN_THANH = m_dat_thoi_diem_can_hoan_thanh.Value;
            }
            else m_us.SetTHOI_DIEM_CAN_HOAN_THANHNull();

            m_us.dcID_DV_YEU_CAU = CIPConvert.ToDecimal(m_cbo_dich_vu.SelectedValue);//xem ai chi lay id
            m_us.strNOI_DUNG_DAT_HANG = m_txt_yeu_cau_cu_the.Text;
            m_us.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH = CIPConvert.ToDecimal(m_cbo_thoi_gian_hoan_thanh.SelectedValue);
            m_us.strPHAN_HOI_TU_DVMC = m_txt_phan_hoi_tu_dvmc.Text;
            m_us.SetTHOI_GIAN_HOAN_THANHNull();
            m_us.datTHOI_GIAN_TAO = System.DateTime.Now;

            m_us.dcID_PHUONG_THUC_DAT_HANG = CIPConvert.ToDecimal(m_cbo_phuong_thuc_dat_hang.SelectedValue);//---phuong thuc dat hang la goi dien
            m_us.dcID_NGUOI_TAO = us_user.dcID ;///xem lai
            m_us.dcID_CHI_NHANH = TOSApp.us_user.dcCHI_NHANH; //--fix lai sau mac dinh la 1 -HA NOI
        }

        //kiem tra cac trang thai cua button radio cua thoi gian can de hoan thanh don hang va tra ve ma
        private int return_loai_thoi_gian_can_hoan_thanh(RadioButton m_rdb_loai_time_15phut, RadioButton m_rdb_loai_time_4h, RadioButton m_rdb_loai_time_1ngay, RadioButton m_rdb_loai_time_1tuan, RadioButton m_rdb_loai_time_1thang)
        {
            if (m_rdb_loai_time_15phut.Checked == true) return 200;
            else if (m_rdb_loai_time_4h.Checked == true) return 201;
            else if (m_rdb_loai_time_1ngay.Checked == true) return 202;
            else if (m_rdb_loai_time_1tuan.Checked == true) return 203;
            else return 204;
        }

        private bool Kiem_tra_du_lieu_truoc_luu()
        {

            decimal v_id_time = CIPConvert.ToDecimal(m_cbo_thoi_gian_hoan_thanh.SelectedValue);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.GetTimeByProcedure(v_ds, v_id_time, m_dat_thoi_diem_can_hoan_thanh.Value);
            DateTime v_time = (DateTime)v_ds.Tables[0].Rows[0][0];

            if (m_txt_ho_ten_nguoi_dat_hang.Text == "")
            {
                MessageBox.Show("người đặt hàng vẫn còn trống!");
                return false;
            }
            else
                if (m_txt_dien_thoai.Text == "") return false;
                else if (m_txt_phan_hoi_tu_dvmc.Text == "")
                {

                    MessageBox.Show("phản hồi từ dvmc vẫn còn trống!");
                    return false;
                }
                else if (m_checkbox_m2_m3.Checked == true)
                {
                    if (v_time > System.DateTime.Now)
                    {
                        MessageBox.Show("Thời điểm cần hoàn thành chưa chính xác!Hãy chọn lại!");
                        return false;

                    }

                }
            if (m_txt_yeu_cau_cu_the.Text == "")
            {
                MessageBox.Show("Hãy nhập yêu cầu cụ thể!");
                m_txt_yeu_cau_cu_the.Focus();
                return false;
            }


            return true;
        }

        internal void displayForInsert()
        {
            m_dat_thoi_diem_can_hoan_thanh.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }

        internal void displayForUpdate(IPCOREUS.US_GD_DAT_HANG v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(IPCOREUS.US_GD_DAT_HANG v_us)
        {
            m_searchLookUpEdit_user_nv_dat_hang.EditValue = "---------";
            m_txt_ho_ten_nguoi_dat_hang.Text = v_us.strHO_TEN_USER_DAT_HANG;
            load_don_vi(v_us.dcID_DON_VI);
            m_txt_dien_thoai.Text = v_us.strDIEN_THOAI;
            m_dat_thoi_diem_can_hoan_thanh.Text = v_us.datTHOI_DIEM_CAN_HOAN_THANH.ToString();
            m_txt_yeu_cau_cu_the.Text = v_us.strNOI_DUNG_DAT_HANG;
            m_cbo_thoi_gian_hoan_thanh.SelectedValue = v_us.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH;
            m_cbo_dich_vu.SelectedValue = v_us.dcID_DV_YEU_CAU;
            m_txt_phan_hoi_tu_dvmc.Text = v_us.strPHAN_HOI_TU_DVMC;
            m_cbo_trang_thai_don_hang.SelectedValue = "";
            load_nguoi_nhan_dat_hang(v_us.dcID_NGUOI_TAO);
            load_nguoi_xu_ly_dat_hang(v_us.dcID);

        }

        private void load_nguoi_xu_ly_dat_hang(decimal p)
        {

        }

        private void load_nguoi_nhan_dat_hang(decimal p)
        {
            WinFormControls.load_data_to_combobox("V_GD_DAT_HANG_GD_LOG_DAT_HANG", "ID", "HO_TEN_USER_DAT_HANG", " where V_GD_DAT_HANG_GD_LOG_DAT_HANG.ID" + p, WinFormControls.eTAT_CA.NO, m_cbo_nguoi_nhan_dat_hang);
        }

        private void load_don_vi(decimal p)
        {
            WinFormControls.load_data_to_combobox("dm_don_vi", "ID", "ma_don_vi", " where dm_don_vi.id=gd_dat_hang." + p, WinFormControls.eTAT_CA.NO, m_cbo_dv_don_vi);

        }

        private int check_value_with_radiobutton_thoi_gian(string v_time)
        {

            if (v_time == "200") return 1;
            if (v_time == "201") return 2;
            if (v_time == "202") return 3;
            if (v_time == "203") return 4;
            if (v_time == "204") return 5;
            return 0;

        }

        private void m_cmd_danh_sach_nguoi_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                f102_chon_danh_sach_nguoi_xu_ly_new v_f102 = new f102_chon_danh_sach_nguoi_xu_ly_new();
                m_id_dich_vu = CIPConvert.ToDecimal(m_cbo_dich_vu.SelectedValue.ToString());
                if (m_id_dich_vu == 0)
                {
                    MessageBox.Show("hãy chọn dịch vụ");
                }
                else
                    v_f102.Display(ref m_lst_id_nguoi_xu_ly, m_id_dich_vu);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_choi_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_phan_hoi_tu_dvmc.Text == "")
                {
                    MessageBox.Show("hãy nhập lý do từ chối!");
                    m_txt_phan_hoi_tu_dvmc.Focus();
                }
                else
                {
                    ghi_don_hang();
                    ghi_log_tu_choi_don_hang();
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        private void ghi_log_tu_choi_don_hang()
        {


            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 294;
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;//?? văn
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = m_txt_phan_hoi_tu_dvmc.Text;
            v_us.Insert();
            MessageBox.Show("Đã từ chối đơn hàng");

        }

        private void us_2_form(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            m_txt_dien_thoai.Text = v_us.strDIEN_THOAI;
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
            m_txt_ho_ten_nguoi_dat_hang.Text = v_us.strHO_TEN_USER_DAT_HANG;
            m_searchLookUpEdit_user_nv_dat_hang.EditValue = v_us.dcID_USER_NV_DAT_HANG;
            m_cbo_dv_don_vi.SelectedValue = v_us.dcID_DON_VI;
            m_cmd_danh_sach_nguoi_xu_ly.Enabled = false;
            m_cmd_tu_choi.Enabled = false;
            m_cbo_nguoi_nhan_dat_hang.SelectedValue = v_us.dcID_NGUOI_TAO;
            m_dat_thoi_diem_can_hoan_thanh.Text = v_us.datTHOI_DIEM_CAN_HOAN_THANH.ToString();
            m_cbo_thoi_gian_hoan_thanh.SelectedValue = v_us.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH;
            m_txt_yeu_cau_cu_the.Text = v_us.strNOI_DUNG_DAT_HANG;
            m_txt_phan_hoi_tu_dvmc.Text = v_us.strPHAN_HOI_TU_DVMC;
            m_cbo_trang_thai_don_hang.SelectedText = v_us.strTEN_LOAI_THAO_TAC_LOG;
            US_V_DM_LOAI_YEU_CAU k_us = new US_V_DM_LOAI_YEU_CAU(v_us.dcID_NHOM_DV_YEU_CAU);
            m_cbo_loai_dich_vu_1.SelectedValue = k_us.dcID_DM_YEU_CAU_1;
            m_cbo_loai_dich_vu_2.SelectedValue = k_us.dcID_DM_YEU_CAU_2;
            m_cbo_dich_vu.SelectedValue = k_us.dcID;
            M_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);

        }

        private void format_controlls()
        {
            m_checkbox_m2_m3.Enabled = false;
            m_txt_dien_thoai.Enabled = false;
            m_txt_dien_thoai.BackColor = SystemColors.Control;
            m_txt_ho_ten_nguoi_dat_hang.Enabled = false;
            m_txt_ma_don_hang.BackColor = SystemColors.Control;
            m_txt_ho_ten_nguoi_dat_hang.Enabled = false;
            m_txt_ho_ten_nguoi_dat_hang.BackColor = SystemColors.Control;
            m_searchLookUpEdit_user_nv_dat_hang.Enabled = false;
            m_cbo_dv_don_vi.Enabled = false;
            m_cmd_danh_sach_nguoi_xu_ly.Enabled = false;
            m_cmd_tu_choi.Enabled = false;
            m_cbo_nguoi_nhan_dat_hang.Enabled = false;
            m_cbo_trang_thai_don_hang.Enabled = false;
            m_cbo_loai_dich_vu_1.Enabled = false;
            m_cbo_loai_dich_vu_2.Enabled = false;
            m_cbo_dich_vu.Enabled = false;
            m_searchLookUpEdit_dv.Enabled = false;

        }

        private void m_cbo_loai_dich_vu_1_SelectedValueChanged(object sender, EventArgs e)
        {

            load_data_2_loai_dich_vu_2();
        }

        private void m_cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {

            load_data_2_selected_dich_vu();
        }


        internal void displayForUpdate(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us, decimal deadline_id)
        {
            try
            {
                if (deadline_id == 1)
                {
                    format_controlls_for_refurse_deadline();
                    us_2_form(v_us);
                    m_e_form_mode = DataEntryFormMode.UpdateDataState;
                    M_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
                    m_deadline_id = deadline_id;
                    load_data_2_lich_su_thuc_hien();
                    this.ShowDialog();

                }
                else
                {
                    format_controlls();
                    us_2_form(v_us);
                    m_e_form_mode = DataEntryFormMode.UpdateDataState;
                    M_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
                    load_data_2_lich_su_thuc_hien();
                    this.ShowDialog();
                }

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void format_controlls_for_refurse_deadline()
        {
            format_controlls();
            m_cbo_thoi_gian_hoan_thanh.Enabled = false;
            m_txt_yeu_cau_cu_the.Enabled = false;
            m_txt_phan_hoi_tu_dvmc.Enabled = false;
            m_searchLookUpEdit_dv.Enabled = false;
        }

        private void m_checkbox_change(object sender, EventArgs e)
        {
            if (m_checkbox_m2_m3.Checked == true)
            {
                m_dat_thoi_diem_can_hoan_thanh.Enabled = false;

            }
            else m_dat_thoi_diem_can_hoan_thanh.Enabled = true;
        }

        private void fomat_key_so_dien_thoai(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void m_cmd_giai_dap_thac_mac_Click(object sender, EventArgs e)
        {
            f100_dm_cau_hoi v_f = new f100_dm_cau_hoi();

            v_f.Show();
        }

        private void chinh_sua_don_hang(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);

        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                decimal v_deadline = 0;
                DataRow v_dr = m_grv_user_don_hang.GetDataRow(m_grv_user_don_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.m_docmanager_don_hang.Visible = false;
                m_dp_don_hang.Hide();
                this.Hide();
                v_f100.displayForUpdate(v_us, v_deadline);
                this.Show();
            }
        }

        private void m_btn_timeline_Click(object sender, EventArgs e)
        {
            try
            {
                f150_Bo_time_line v_f = new f150_Bo_time_line(CIPConvert.ToDecimal(m_cbo_dich_vu.SelectedValue.ToString()));
                v_f.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cbo_dv_don_vi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fill_data_to_dich_vu(object sender, EventArgs e)
        {

            DataRow v_dr = m_searchLookUpEdit_dich_vu.GetDataRow(m_searchLookUpEdit_dich_vu.FocusedRowHandle);
            US_V_DM_LOAI_YEU_CAU v_us = new US_V_DM_LOAI_YEU_CAU(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            load_data_to_dv1(v_us);
            load_data_to_dv2(v_us);
            load_data_to_dv(v_us);

        }

        private void load_data_to_dv(US_V_DM_LOAI_YEU_CAU v_us)
        {
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " where id =" + v_us.dcID, WinFormControls.eTAT_CA.NO, m_cbo_dich_vu);
        }

        private void load_data_to_dv2(US_V_DM_LOAI_YEU_CAU v_us)
        {
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " where ID=" + v_us.dcID_DM_YEU_CAU_2, WinFormControls.eTAT_CA.NO, m_cbo_loai_dich_vu_2);
        }

        private void load_data_to_dv1(US_V_DM_LOAI_YEU_CAU v_us)
        {
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " where ID=" + v_us.dcID_DM_YEU_CAU_1, WinFormControls.eTAT_CA.NO, m_cbo_loai_dich_vu_1);
        }

        private void m_searchLookUpEdit_user_nv_dat_hang_EditValueChanged(object sender, EventArgs e)
        {
            decimal ID_khach_hang = CIPConvert.ToDecimal(m_searchLookUpEdit_user_nv_dat_hang.EditValue.ToString());
            US_DM_KHACH_HANG v_us = new US_DM_KHACH_HANG(ID_khach_hang);
            m_cbo_dv_don_vi.SelectedValue = CIPConvert.ToDecimal(v_us.dcDON_VI.ToString());
            load_data_to_selected_ho_ten_nguoi_dat_hang(v_us);
            load_data_to_selected_so_dien_thoai(v_us);
            load_data_2_grid_khach_hang_don_hang();
        }
        private void f100_don_dat_hang_new_Load(object sender, EventArgs e)
        {

        }

        private void m_grb_loai_dich_vu_Enter(object sender, EventArgs e)
        {

        }

        private void m_txt_yeu_cau_cu_the_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }






        private void format_control_view_thong_tin_don_hang()
        {
            m_docmanager_don_hang.Visible =false;
            m_checkbox_m2_m3.Enabled = false;
            m_txt_dien_thoai.Enabled = false;
            m_txt_dien_thoai.BackColor = SystemColors.Control;
            m_txt_ho_ten_nguoi_dat_hang.Enabled = false;
            m_txt_ma_don_hang.BackColor = SystemColors.Control;
            m_txt_ho_ten_nguoi_dat_hang.Enabled = false;
            m_txt_ho_ten_nguoi_dat_hang.BackColor = SystemColors.Control;
            m_searchLookUpEdit_user_nv_dat_hang.Enabled = false;
            m_cbo_dv_don_vi.Enabled = false;
            m_cmd_danh_sach_nguoi_xu_ly.Enabled = false;
            m_cmd_tu_choi.Enabled = false;
            m_cbo_nguoi_nhan_dat_hang.Enabled = false;
            m_cbo_trang_thai_don_hang.Enabled = false;
            m_cbo_loai_dich_vu_1.Enabled = false;
            m_cbo_loai_dich_vu_2.Enabled = false;
            m_cbo_dich_vu.Enabled = false;
            m_searchLookUpEdit_dv.Enabled = false;

            m_dat_thoi_diem_can_hoan_thanh.Enabled = false;
            m_checkbox_m2_m3.Enabled = false;
            m_txt_yeu_cau_cu_the.Enabled = false;
            m_txt_phan_hoi_tu_dvmc.Enabled = false;
            m_cbo_nguoi_nhan_dat_hang.Enabled = false;
            m_cbo_thoi_gian_hoan_thanh.Enabled = false;
            m_cbo_trang_thai_don_hang.Enabled = false;
            m_cmd_danh_sach_nguoi_xu_ly.Enabled = false;
            m_cmd_giai_dap_thac_mac.Enabled = false;
            m_btn_timeline.Enabled = false;
            m_cmd_tu_choi.Visible = false;
            m_cmd_xac_nhan_don_hang.Visible = false;
            m_docmanager_don_hang.Visible = false;
        }


        internal void displayForUpdate2(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            format_control_view_thong_tin_don_hang();
            us_2_form(v_us);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            M_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
            load_data_2_lich_su_thuc_hien();
            this.ShowDialog();
        }
    }
}
