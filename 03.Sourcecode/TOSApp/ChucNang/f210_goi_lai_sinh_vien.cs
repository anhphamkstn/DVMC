using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

using System.Data;
using TOSApp.HeThong;
using IPCOREUS;
using IPCOREDS.CDBNames;
using System.IO;
using IP.Core.IPUserService;
using IP.Core.IPData;
using TOSApp.App_Code;
using IPCOREDS;
namespace TOSApp
{
    public partial class f210_goi_lai_sinh_vien : Form
    {
        public f210_goi_lai_sinh_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region public Interface
        public void display_xu_ly_cau_hoi(US_V_GD_CAU_HOI_YEU_CAU i_us)
        {
            m_us_v_cau_hoi_yeu_cau = i_us;
            load_data_2_cbo_truong();
            m_txt_dien_thoai.Text = m_us_v_cau_hoi_yeu_cau.strSO_DIEN_THOAI;
            m_txt_ho_ten.Text = m_us_v_cau_hoi_yeu_cau.strHO_TEN_SINH_VIEN;
            m_txt_ma_hoc_vien.Text = m_us_v_cau_hoi_yeu_cau.strMA_SINH_VIEN;
            m_txt_ma_lop.Text = m_us_v_cau_hoi_yeu_cau.strLOP;
            if(!m_us_v_cau_hoi_yeu_cau.IsNGAY_SINHNull() 
                && m_us_v_cau_hoi_yeu_cau.datNGAY_SINH != Convert.ToDateTime("01/01/1900"))
                m_dtp_ngay_sinh.Value = m_us_v_cau_hoi_yeu_cau.datNGAY_SINH;
            m_cbo_truong.SelectedValue = m_us_v_cau_hoi_yeu_cau.strTRUONG;
            m_txt_ho_ten_qlht.Text = m_us_v_cau_hoi_yeu_cau.strHO_TEN_QLHT;
            
            this.ShowDialog();
        }
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Datastructer
        private enum e_col_Number
        {
            STT = 0
            ,TRANG_THAI = 1
            ,START_TIME = 2
            ,NOI_DUNG_CAU_HOI = 3
            ,NOI_DUNG_TRA_LOI = 4
            ,THOI_DIEM_HEN_GOI_LAI = 5
            ,GHI_CHU_LICH_HEN = 6
            ,GHI_CHU_Y_KIEN_KHAC = 7
            ,ID_CAU_HOI = 8
            ,ID_LOAI_CAU_HOI = 9
            ,ID_DANH_GIA = 10
            ,ID_TRANG_THAI = 11
            ,ID = 12
            , ID_YEU_CAU = 13
        }
        private enum e_kieu_cau_hoi
        {
            CAU_HOI_CU = 0
            , CAU_HOI_MOI = 1
        }
        #endregion

        #region Members
        DS_GD_CUOC_GOI_YEU_CAU m_ds_cuoc_goi = new DS_GD_CUOC_GOI_YEU_CAU();
        US_GD_CUOC_GOI_YEU_CAU m_us_cuoc_goi = new US_GD_CUOC_GOI_YEU_CAU();

        US_GD_CAU_HOI_HOC_VIEN m_us_cau_hoi = new US_GD_CAU_HOI_HOC_VIEN();
        US_DM_CAU_HOI m_us_dm_cau_hoi = new US_DM_CAU_HOI();
        US_V_DM_CAU_HOI m_us_v_cau_hoi = new US_V_DM_CAU_HOI();
        US_V_GD_CAU_HOI_YEU_CAU m_us_v_cau_hoi_yeu_cau = new US_V_GD_CAU_HOI_YEU_CAU();
        DS_V_GD_CAU_HOI_YEU_CAU m_ds_v_cau_hoi_yeu_cau = new DS_V_GD_CAU_HOI_YEU_CAU();
        string m_call_id = "";
        ITransferDataRow m_trans_obj;
        decimal m_dc_id_trang_thai_cuoc_goi = TU_DIEN_TRANG_THAI_DON_HANG.DA_DONG;
        bool m_bl_luu_cau_hoi = false;
        e_kieu_cau_hoi m_e_kieu_cau_hoi = e_kieu_cau_hoi.CAU_HOI_CU;
        #endregion


        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            this.KeyPreview = true;
            m_cbo_loai_cau_hoi_tren.Enabled = false;
            m_txt_key_cau_hoi.Enabled = false;
            m_cbo_don_vi_lien_quan.Enabled = false;

            m_fg.Cols[(int)e_col_Number.ID].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_CAU_HOI].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_DANH_GIA].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_LOAI_CAU_HOI].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI].Visible = false;
            m_fg.Cols[(int)e_col_Number.ID_YEU_CAU].Visible = false;

            set_define_events();
        }
        private void set_inital_form_load()
        {
            m_trans_obj = get_trans_obj(m_fg);
            load_data_2_cbo_trang_thai_cau_tra_loi();
            load_data_2_cbo_danh_gia_cau_tra_loi();
            //load_data_2_cbo_truong();
            load_data_2_cbo_don_vi_lien_quan();
            load_call_history_hoc_vien(m_txt_dien_thoai.Text);
            load_data_2_cbo_loai_cau_hoi_tren();
            load_data_2_cbo_loai_cau_hoi_duoi();
        }
        private ITransferDataRow get_trans_obj(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.START_TIME, e_col_Number.START_TIME);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.NOI_DUNG_CAU_HOI, e_col_Number.NOI_DUNG_CAU_HOI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.NOI_DUNG_TRA_LOI, e_col_Number.NOI_DUNG_TRA_LOI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.TRANG_THAI_CAU_HOI, e_col_Number.TRANG_THAI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.THOI_DIEM_HEN_GOI_LAI, e_col_Number.THOI_DIEM_HEN_GOI_LAI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.GHI_CHU_LICH_HEN, e_col_Number.GHI_CHU_LICH_HEN);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.GHI_CHU_Y_KIEN_KHAC, e_col_Number.GHI_CHU_Y_KIEN_KHAC);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_CAU_HOI, e_col_Number.ID_CAU_HOI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_LOAI_CAU_HOI, e_col_Number.ID_LOAI_CAU_HOI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_DANH_GIA, e_col_Number.ID_DANH_GIA);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID, e_col_Number.ID);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_YEU_CAU, e_col_Number.ID_YEU_CAU);
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU.NewRow());
            return v_obj_trans;		
        }
        private void load_call_history_hoc_vien(string i_str_dien_thoai)
        {
            m_ds_v_cau_hoi_yeu_cau = new DS_V_GD_CAU_HOI_YEU_CAU();
            m_us_v_cau_hoi_yeu_cau.load_call_history_hoc_vien_goi_lai(m_ds_v_cau_hoi_yeu_cau,i_str_dien_thoai);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_cau_hoi_yeu_cau, m_fg, m_trans_obj);
            m_fg.Redraw = true;
            make_stt();

        }
        private void fill_data_2_form(int i_row)
        {
            m_cbo_trang_thai_cau_hoi.SelectedValue = TU_DIEN_TRANG_THAI_GD_CAU_HOI_SV.DA_TRA_LOI;
            if(m_fg[i_row, (int)e_col_Number.ID_DANH_GIA] != null)
                m_cbo_danh_gia_tra_loi.SelectedValue = CIPConvert.ToDecimal(m_fg[i_row, (int)e_col_Number.ID_DANH_GIA]);
            if (m_fg[i_row, (int)e_col_Number.ID_LOAI_CAU_HOI] != null)
                m_cbo_loai_cau_hoi_duoi.SelectedValue = CIPConvert.ToDecimal(m_fg[i_row, (int)e_col_Number.ID_LOAI_CAU_HOI]);
            if (m_fg[i_row, (int)e_col_Number.NOI_DUNG_CAU_HOI] != null)
                m_txt_cau_hoi.Text = CIPConvert.ToStr(m_fg[i_row, (int)e_col_Number.NOI_DUNG_CAU_HOI]);
            if (m_fg[i_row, (int)e_col_Number.GHI_CHU_LICH_HEN] != null)
                m_txt_ghi_chu_hen.Text = CIPConvert.ToStr(m_fg[i_row, (int)e_col_Number.GHI_CHU_LICH_HEN]);
            if (m_fg[i_row, (int)e_col_Number.GHI_CHU_Y_KIEN_KHAC] != null)
                m_txt_y_kien_khac.Text = CIPConvert.ToStr(m_fg[i_row, (int)e_col_Number.GHI_CHU_Y_KIEN_KHAC]);
            if (m_fg[i_row, (int)e_col_Number.THOI_DIEM_HEN_GOI_LAI] != null)
                m_dat_ngay_hen_goi_lai.Value = CIPConvert.ToDatetime(m_fg[i_row, (int)e_col_Number.THOI_DIEM_HEN_GOI_LAI].ToString().Substring(0,10), "dd/MM/yyyy");
            if (m_fg[i_row, (int)e_col_Number.NOI_DUNG_TRA_LOI] != null)
                m_rtb_cau_tra_loi.Text = CIPConvert.ToStr(m_fg[i_row, (int)e_col_Number.NOI_DUNG_TRA_LOI]);
            ////
            //US_V_DM_CAU_HOI v_us_v_cau_hoi = new US_V_DM_CAU_HOI();
            //DS_V_DM_CAU_HOI v_ds_v_cau_hoi = new DS_V_DM_CAU_HOI();
            //v_us_v_cau_hoi.FillDataset(v_ds_v_cau_hoi,"where id = " + CIPConvert.ToStr(m_fg[i_row, (int)e_col_Number.ID_CAU_HOI]));
            //if (v_ds_v_cau_hoi.V_DM_CAU_HOI.Rows.Count > 0)
            //{
            //    m_rtb_cau_tra_loi.Text = v_ds_v_cau_hoi.V_DM_CAU_HOI[0][V_DM_CAU_HOI.CAU_TRA_LOI].ToString();
            //}
        }
        private void make_stt()
        {
            int v_dc_stt = 0;
            for (int i_stt = 1; i_stt <= m_fg.Rows.Count - 1; i_stt++)
            {
                if (m_fg.Rows[i_stt].IsNode)
                {
                    v_dc_stt = 0;
                }
                else
                {
                    v_dc_stt = v_dc_stt + 1;
                    m_fg[i_stt, (int)e_col_Number.STT] = v_dc_stt;
                }
            }
        }
        private void load_data_2_cbo_trang_thai_cau_tra_loi()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_trang_thai = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_trang_thai = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_trang_thai.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_GD_CAU_HOI_SV, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_trang_thai);
            m_cbo_trang_thai_cau_hoi.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_trang_thai_cau_hoi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_cau_hoi.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_cbo_danh_gia_cau_tra_loi()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_danh_gia = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_danh_gia = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_danh_gia.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.HANG_DANH_GIA, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_danh_gia);
            m_cbo_danh_gia_tra_loi.DataSource = v_ds_tu_dien_danh_gia.CM_DM_TU_DIEN;
            m_cbo_danh_gia_tra_loi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_danh_gia_tra_loi.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_cbo_truong()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_truong = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_truong = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_truong.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TO_CHUC_TRUONG, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_truong);
            m_cbo_truong.DataSource = v_ds_tu_dien_truong.CM_DM_TU_DIEN;
            m_cbo_truong.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_truong.ValueMember = CM_DM_TU_DIEN.MA_TU_DIEN;
        }
        private void load_data_2_cbo_loai_cau_hoi_tren()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_truong = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_truong = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_truong.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.NHOM_CAU_HOI, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_truong);

            DataRow v_dr = v_ds_tu_dien_truong.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "- Tất cả -";
            v_dr[CM_DM_TU_DIEN.TEN] = "- Tất cả -";
            v_ds_tu_dien_truong.EnforceConstraints = false;
            v_ds_tu_dien_truong.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_loai_cau_hoi_tren.DataSource = v_ds_tu_dien_truong.CM_DM_TU_DIEN;
            m_cbo_loai_cau_hoi_tren.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_cau_hoi_tren.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_cbo_loai_cau_hoi_duoi()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_truong = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_truong = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_truong.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.NHOM_CAU_HOI, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_truong);

            DataRow v_dr = v_ds_tu_dien_truong.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "- Tất cả -";
            v_dr[CM_DM_TU_DIEN.TEN] = "- Tất cả -";
            v_ds_tu_dien_truong.EnforceConstraints = false;
            v_ds_tu_dien_truong.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_loai_cau_hoi_duoi.DataSource = v_ds_tu_dien_truong.CM_DM_TU_DIEN;
            m_cbo_loai_cau_hoi_duoi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_cau_hoi_duoi.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void load_data_2_cbo_don_vi_lien_quan()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien_dv_lien_quan = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien_dv_lien_quan = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien_dv_lien_quan.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TO_CHUC_TRUONG, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds_tu_dien_dv_lien_quan);
            m_cbo_don_vi_lien_quan.DataSource = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN;
            m_cbo_don_vi_lien_quan.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_lien_quan.ValueMember = CM_DM_TU_DIEN.ID;

            // Linhdh: 2014-06-05: Chọn trường liên quan đến câu hỏi trùng với trường sinh viên đang học
            if (m_cbo_truong.SelectedIndex != 0)
            {
                DataRow[] v_drs = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN.Select(CM_DM_TU_DIEN.MA_TU_DIEN + "='" + m_cbo_truong.SelectedValue + "'");
                decimal v_dc_id = 0;
                if (v_drs.Length > 0)
                    v_dc_id = CIPConvert.ToDecimal(v_drs[0][CM_DM_TU_DIEN.ID]);
                m_cbo_don_vi_lien_quan.SelectedValue = v_dc_id;
            }
        }
        private void insert_cuoc_goi_moi()
        {
            CallInfor v_call_info = new CallInfor();
            v_call_info = HelpUtils.get_call_infor(m_us_cuoc_goi.strCALL_ID
                                                   );


            m_us_cuoc_goi.strERROR_CODE = v_call_info.error_code;
            m_us_cuoc_goi.strERROR_DESC = v_call_info.error_desc;

            m_us_cuoc_goi.strSTATUS = v_call_info.status;
            m_us_cuoc_goi.strVOICE_CALL_LINK = v_call_info.link_down_record;
            if (v_call_info.datetime_response != null)
                m_us_cuoc_goi.datDATETIME_RESPOND = HelpUtils.string_2_datetime(v_call_info.datetime_response);
            else m_us_cuoc_goi.datDATETIME_RESPOND = CIPConvert.ToDatetime("01/01/1900", "dd/MM/yyyy");
            if (v_call_info.end_time != null)
                m_us_cuoc_goi.datEND_TIME = HelpUtils.string_2_datetime(v_call_info.end_time);
            else m_us_cuoc_goi.datEND_TIME = CIPConvert.ToDatetime("01/01/1900", "dd/MM/yyyy");
            if (v_call_info.start_time != null)
                m_us_cuoc_goi.datSTART_TIME = HelpUtils.string_2_datetime(v_call_info.start_time);
            else m_us_cuoc_goi.datSTART_TIME = CIPConvert.ToDatetime("01/01/1900", "dd/MM/yyyy");
            m_us_cuoc_goi.dcDURATION = CIPConvert.ToDecimal(v_call_info.duration);
            m_us_cuoc_goi.dcID_TRANG_THAI = m_dc_id_trang_thai_cuoc_goi;
            m_us_cuoc_goi.dcRINGTIME = CIPConvert.ToDecimal(v_call_info.ringtime);

            m_us_cuoc_goi.Update();
            BaseMessages.MsgBox_Infor("Đã lưu thông tin cuộc gọi thành công");
        }
        private void update_info_cuoc_goi()
        {
            CallInfor v_call_info = new CallInfor();
            v_call_info = HelpUtils.get_call_infor(m_us_cuoc_goi.strCALL_ID
                                                    , m_txt_dien_thoai.Text
                                                    , f002_main_form.m_str_stationId
                                                    , CAppContext_201.getCurrentUserName());
            m_us_cuoc_goi.strERROR_CODE = v_call_info.error_code;
            m_us_cuoc_goi.strERROR_DESC = v_call_info.error_desc;
            //m_us_cuoc_goi.strNOI_DUNG_TRAO_DOI = ???
            m_us_cuoc_goi.strSTATUS = v_call_info.status;
            m_us_cuoc_goi.strVOICE_CALL_LINK = v_call_info.link_down_record;
            m_us_cuoc_goi.datDATETIME_RESPOND = HelpUtils.string_2_datetime(v_call_info.datetime_response);
            m_us_cuoc_goi.datEND_TIME = HelpUtils.string_2_datetime(v_call_info.end_time);
            m_us_cuoc_goi.datSTART_TIME =HelpUtils.string_2_datetime( v_call_info.start_time);
            m_us_cuoc_goi.dcDURATION = CIPConvert.ToDecimal( v_call_info.duration);
            m_us_cuoc_goi.dcRINGTIME = CIPConvert.ToDecimal(v_call_info.ringtime);

            m_us_cuoc_goi.BeginTransaction();
            m_us_cuoc_goi.Update();
            m_us_cuoc_goi.CommitTransaction();

            BaseMessages.MsgBox_Infor("Đã lưu thông tin cuộc gọi thành công");

        }
        private void insert_cau_hoi_moi()
        {
            m_us_cau_hoi = new US_GD_CAU_HOI_HOC_VIEN();
            m_us_cau_hoi.strGHI_CHU_Y_KIEN_KHAC = m_txt_y_kien_khac.Text;
            m_us_cau_hoi.dcID_DANH_GIA = CIPConvert.ToDecimal(m_cbo_danh_gia_tra_loi.SelectedValue);
            m_us_cau_hoi.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_cau_hoi.SelectedValue);
            //
            switch (m_e_kieu_cau_hoi)
            {
                case e_kieu_cau_hoi.CAU_HOI_CU:
                    m_us_cau_hoi.dcID = CIPConvert.ToDecimal(m_fg[m_fg.Row, (int)e_col_Number.ID]);
                    m_us_cau_hoi.update_cau_hoi_cu();
                    break;
                case e_kieu_cau_hoi.CAU_HOI_MOI:
                    m_us_cau_hoi.strGHI_CHU_LICH_HEN = m_txt_ghi_chu_hen.Text;
                    m_us_cau_hoi.strNOI_DUNG_CAU_HOI = m_txt_cau_hoi.Text;
                    m_us_cau_hoi.strNOI_DUNG_TRA_LOI = m_rtb_cau_tra_loi.Text;
                    if (CValidateTextBox.IsValid(m_dat_ngay_hen_goi_lai, DataType.DateType, allowNull.YES)
                        && m_dat_ngay_hen_goi_lai.Text.Trim() != "")
                        m_us_cau_hoi.datTHOI_DIEM_HEN_GOI_LAI = CIPConvert.ToDatetime(m_dat_ngay_hen_goi_lai.Value);
                    m_us_cau_hoi.dcID_CAU_HOI = m_us_v_cau_hoi.dcID;
                    m_us_cau_hoi.dcID_LOAI_CAU_HOI = CIPConvert.ToDecimal(m_cbo_loai_cau_hoi_duoi.SelectedValue);
                    m_us_cau_hoi.dcID_NGUOI_TRA_LOI = CAppContext_201.getCurrentUserID();
                    m_us_cau_hoi.dcID_YEU_CAU = m_us_cuoc_goi.dcID;
                    m_us_cau_hoi.Insert();
                    break;
            }
            //
            if (CIPConvert.ToDecimal(m_cbo_trang_thai_cau_hoi.SelectedValue) == TU_DIEN_TRANG_THAI_GD_CAU_HOI_SV.CHO_TRA_LOI)
                m_dc_id_trang_thai_cuoc_goi = TU_DIEN_TRANG_THAI_DON_HANG.DANG_CHO_GQ;
            m_bl_luu_cau_hoi = true;
            BaseMessages.MsgBox_Infor("Đã lưu câu hỏi trên thành công. Nếu không còn câu hỏi nào nữa, hãy bấm \"End Call\"");
        }
        private void goi_cho_sinh_vien()
        {
            CallInfor v_call_info = new CallInfor();
            v_call_info = HelpUtils.call_2_contact("01682077618", "2000", "admin");
            m_call_id = v_call_info.call_id;
            
            CallInfor v_call_info_answer = new CallInfor();
            v_call_info_answer = HelpUtils.get_call_infor("139463024488", "01682077618", "2000", "admin");
            
            string v_str_ket_qua = v_call_info_answer.agent_code
                + "\n"
                + v_call_info_answer.call_id
                + "\n"
                + v_call_info_answer.datetime_response
                + "\n"
                + v_call_info_answer.duration
                + "\n"
                + v_call_info_answer.end_time
                + "\n"
                + v_call_info_answer.error_code
                + "\n"
                + v_call_info_answer.error_desc
                + "\n"
                + v_call_info_answer.link_down_record
                + "\n"
                + v_call_info_answer.message_code
                + "\n"
                + v_call_info_answer.mobile_phone
                + "\n"
                + v_call_info_answer.ringtime
                + "\n"
                + v_call_info_answer.start_time
                + "\n"
                + v_call_info_answer.station_id
                + "\n"
                + v_call_info_answer.status
                + "\n"
                + v_call_info_answer.ToString();
        }
        private void search_dm_cau_hoi()
        {
            f220_dm_cau_hoi_searching v_frm = new f220_dm_cau_hoi_searching();
            if (v_frm.display_search(m_txt_key_cau_hoi.Text
                , CIPConvert.ToDecimal(m_cbo_don_vi_lien_quan.SelectedValue)
                , CIPConvert.ToDecimal(m_cbo_loai_cau_hoi_tren.SelectedValue)
                , m_us_v_cau_hoi) == DialogResult.OK)
            {
                m_txt_cau_hoi.Text = m_us_v_cau_hoi.strNOI_DUNG_CAU_HOI;
                m_rtb_cau_tra_loi.Text = m_us_v_cau_hoi.strCAU_TRA_LOI;
                m_cbo_loai_cau_hoi_duoi.SelectedValue = m_us_v_cau_hoi.dcID_NHOM_CAU_HOI;
                m_txt_cau_hoi.Enabled = false;
                m_rtb_cau_tra_loi.Enabled = false;
                m_e_kieu_cau_hoi = e_kieu_cau_hoi.CAU_HOI_MOI;
                m_txt_y_kien_khac.Focus();
            }

        }
        private bool check_thong_tin_cau_hoi()
        {

            if (!CValidateTextBox.IsValid(m_txt_ho_ten, DataType.StringType, allowNull.NO, false))
            {
                BaseMessages.MsgBox_Error("Họ tên sinh viên không được trống");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_cau_hoi, DataType.StringType, allowNull.NO, false))
            {
                BaseMessages.MsgBox_Error("Câu hỏi không được trống");
                return false;
            }
            if (CIPConvert.ToDecimal(m_cbo_trang_thai_cau_hoi.SelectedValue) == TU_DIEN_TRANG_THAI_GD_CAU_HOI_SV.DA_TRA_LOI
                && m_rtb_cau_tra_loi.Text.Trim() == "")
            {
                BaseMessages.MsgBox_Error("Trạng thái câu hỏi là 20-Đã trả lời thì không thể để trống câu trả lời.");
                m_rtb_cau_tra_loi.Focus();
                return false;
            }
            return true;
        }
        private void set_define_events()
        {

            this.Load += new EventHandler(f200_sinh_vien_goi_den_Load);
            
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_end_call.Click += new EventHandler(m_cmd_end_call_Click);
            m_pic_call_hoc_vien.Click += new EventHandler(m_pic_call_hoc_vien_Click);
            m_fg.Click += new EventHandler(m_fg_Click);
            m_ckb_cau_hoi_moi.CheckedChanged += new EventHandler(m_ckb_cau_hoi_moi_CheckedChanged);
            m_txt_key_cau_hoi.KeyDown += new KeyEventHandler(m_txt_key_cau_hoi_KeyDown);
        }
        void m_txt_key_cau_hoi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (m_txt_key_cau_hoi.Text.Trim() == "") return;
                        search_dm_cau_hoi();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_ckb_cau_hoi_moi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_ckb_cau_hoi_moi.Checked)
                {
                    m_cbo_loai_cau_hoi_tren.Enabled = true;
                    m_txt_key_cau_hoi.Enabled = true;
                    m_cbo_don_vi_lien_quan.Enabled = true;
                }
                else
                {
                    m_cbo_loai_cau_hoi_tren.Enabled = false;
                    m_txt_key_cau_hoi.Enabled = false;
                    m_cbo_don_vi_lien_quan.Enabled = false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void m_pic_call_hoc_vien_Click(object sender, EventArgs e)
        {
            try
            {
                CallInfor v_call_info_obj = new CallInfor();
                v_call_info_obj = HelpUtils.call_2_contact(m_txt_dien_thoai.Text.Trim()
                                        , f002_main_form.m_str_stationId
                                        , CAppContext_201.getCurrentUserName());

                m_us_cuoc_goi.strCALL_ID = v_call_info_obj.call_id;
                m_us_cuoc_goi.strCUOC_GOI_VAO_YN = "N";
                m_us_cuoc_goi.strHO_TEN_SINH_VIEN = m_txt_ho_ten.Text;
                m_us_cuoc_goi.strLOP = m_txt_ma_lop.Text;
                m_us_cuoc_goi.strMA_SINH_VIEN = m_txt_ma_hoc_vien.Text;
                m_us_cuoc_goi.strNOI_SINH = m_txt_noi_sinh.Text;
                m_us_cuoc_goi.strSO_DIEN_THOAI = m_txt_dien_thoai.Text;
                if (m_cbo_truong.SelectedValue != null)
                    m_us_cuoc_goi.strTRUONG = m_cbo_truong.SelectedValue.ToString();
                else m_us_cuoc_goi.strTRUONG = "------";
                m_us_cuoc_goi.dcID_NGUOI_DUNG = CAppContext_201.getCurrentUserID();
                m_us_cuoc_goi.dcSTATION_ID = CIPConvert.ToDecimal(f002_main_form.m_str_stationId);
                m_us_cuoc_goi.dcID_TRANG_THAI = -1;
                m_us_cuoc_goi.dcID_CAU_HOI_LIEN_QUAN = CIPConvert.ToDecimal(m_fg[m_fg.Row, (int)e_col_Number.ID_CAU_HOI]);
                m_us_cuoc_goi.dcID_CUOC_GOI_LIEN_QUAN = CIPConvert.ToDecimal(m_fg[m_fg.Row, (int)e_col_Number.ID_YEU_CAU]);
                m_us_cuoc_goi.Insert();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_fg_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HelpUtils.is_validated_edit_grid_row(m_fg.Row, m_fg)) return;
                fill_data_2_form(m_fg.Row);
                m_e_kieu_cau_hoi = e_kieu_cau_hoi.CAU_HOI_CU;
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_end_call_Click(object sender, EventArgs e)
        {
            try
            {
                if(BaseMessages.MsgBox_Confirm("Bạn có chắc chắn là đã lưu câu hỏi và muốn kết thúc cuộc gọi không?")==true)
                update_info_cuoc_goi();
                load_call_history_hoc_vien(m_txt_dien_thoai.Text);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_us_cuoc_goi.dcID == -1) return;
                if (!check_thong_tin_cau_hoi()) return;

                insert_cau_hoi_moi();
                load_call_history_hoc_vien(m_txt_dien_thoai.Text);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_goi_Click(object sender, EventArgs e)
        {
            goi_cho_sinh_vien();
        }

        void f200_sinh_vien_goi_den_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region events

        #endregion
    }
}
