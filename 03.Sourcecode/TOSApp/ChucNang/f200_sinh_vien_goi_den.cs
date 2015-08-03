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
using TOSApp.SCMServices;
namespace TOSApp
{
    public partial class f200_sinh_vien_goi_den : Form
    {
        public f200_sinh_vien_goi_den()
        {
            InitializeComponent();
            format_controls();
        }

        #region public Interface
        public void display()
        {
            load_data_2_cbo_truong();
            m_chk_hoc_vien_moi.Enabled = true;

            m_e_form_mode = e_form_mode.NHAP_TAY;
            m_bl_luu_cuoc_goi = true;
            m_txt_dien_thoai.Enabled = true;
            m_txt_dien_thoai.Focus();
            this.ShowDialog();

        }
        public void display(SinhVien i_obj_sinh_vien, string i_str_call_id)
        {
            load_data_2_cbo_truong();
            m_e_form_mode = e_form_mode.TU_DONG_OPEN;
            m_txt_dien_thoai.Text = i_obj_sinh_vien.Dien_thoai;
            m_txt_ho_ten.Text = i_obj_sinh_vien.Ho_ten;
            m_txt_ma_hoc_vien.Text = i_obj_sinh_vien.Ma_sinh_vien;
            m_txt_ma_lop.Text = i_obj_sinh_vien.Ma_lop;
            if(i_obj_sinh_vien.Ngay_sinh != CIPConvert.ToDatetime("01/01/0001","dd/MM/yyyy"))
                m_dtp_ngay_sinh.Value = CIPConvert.ToDatetime( i_obj_sinh_vien.Ngay_sinh.ToShortDateString(),"dd/MM/yyyy");
            if (i_obj_sinh_vien.Truong != null)
                m_cbo_truong.SelectedValue = i_obj_sinh_vien.Truong;
            else m_cbo_truong.SelectedIndex = 0;
            if (i_obj_sinh_vien.Ho_Ten_QLHT != "" && i_obj_sinh_vien.Ho_Ten_QLHT != null)
                m_txt_ho_ten_qlht.Text = i_obj_sinh_vien.Ho_Ten_QLHT;
            if (i_obj_sinh_vien.Dien_thoai_QLHT != "" && i_obj_sinh_vien.Dien_thoai_QLHT != null)
                m_txt_dien_thoai_qlht.Text = i_obj_sinh_vien.Dien_thoai_QLHT;
            m_call_id = i_str_call_id;

            if (m_txt_ho_ten.Text.Trim() == "")
            {
                m_cmd_tim_hv_khac.Enabled = true;
                m_chk_hoc_vien_moi.Enabled = true;
                m_chk_hoc_vien_moi.Checked = true;
            }
           
            //

            this.ShowDialog();
            this.Activate();
        }
        #endregion

        #region Datastructer
        private enum e_col_Number
        {
            STT = 0
            ,START_TIME = 1
            ,NOI_DUNG_CAU_HOI = 2
            ,NOI_DUNG_TRA_LOI = 3
            ,TRANG_THAI = 4
        }
        private enum e_form_mode
        {
            TU_DONG_OPEN = 1,
            NHAP_TAY = 2
        }
        #endregion

        #region Members
        DS_GD_CUOC_GOI_YEU_CAU m_ds_cuoc_goi = new DS_GD_CUOC_GOI_YEU_CAU();
        US_GD_CUOC_GOI_YEU_CAU m_us_cuoc_goi = new US_GD_CUOC_GOI_YEU_CAU();

        US_GD_CAU_HOI_HOC_VIEN m_us_cau_hoi = new US_GD_CAU_HOI_HOC_VIEN();
        US_DM_CAU_HOI m_us_dm_cau_hoi = new US_DM_CAU_HOI();
        DS_DM_CAU_HOI m_ds_dm_cau_hoi = new DS_DM_CAU_HOI();
        US_V_DM_CAU_HOI m_us_v_cau_hoi = new US_V_DM_CAU_HOI();

        US_V_GD_CAU_HOI_YEU_CAU m_us_v_cau_hoi_yeu_cau = new US_V_GD_CAU_HOI_YEU_CAU();
        DS_V_GD_CAU_HOI_YEU_CAU m_ds_v_cau_hoi_yeu_cau = new DS_V_GD_CAU_HOI_YEU_CAU();
        string m_call_id = "";
        ITransferDataRow m_trans_obj;
        decimal m_dc_id_trang_thai_cuoc_goi = TU_DIEN_TRANG_THAI_DON_HANG.DA_DONG;
        bool m_bl_luu_cau_hoi = false;
        bool m_bl_luu_cuoc_goi = false;
        e_form_mode m_e_form_mode;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            CControlFormat.setC1FlexFormat(m_fg);
            this.KeyPreview = true;
            //m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI].DataMap = get_data_map_trang_thai();

            

            set_define_events();
        }
        private void set_inital_form_load()
        {
            m_trans_obj = get_trans_obj(m_fg);
            load_data_2_cbo_trang_thai_cau_tra_loi();
            load_data_2_cbo_danh_gia_cau_tra_loi();
            //load_data_2_cbo_truong();
            load_call_history_hoc_vien(m_txt_dien_thoai.Text);
            load_data_2_cbo_don_vi_lien_quan();
            load_data_2_cbo_loai_cau_hoi_duoi();
            load_data_2_cbo_loai_cau_hoi_tren();
            //insert_cuoc_goi_moi();

            if (m_e_form_mode == e_form_mode.NHAP_TAY)
                m_txt_dien_thoai.Focus();
            else m_txt_key_cau_hoi.Focus();
        }
        private ITransferDataRow get_trans_obj(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.START_TIME, e_col_Number.START_TIME);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.NOI_DUNG_CAU_HOI, e_col_Number.NOI_DUNG_CAU_HOI);
            v_htb.Add(V_GD_CAU_HOI_YEU_CAU.TRANG_THAI_CAU_HOI, e_col_Number.TRANG_THAI);
            //v_htb.Add(V_GD_CAU_HOI_YEU_CAU.HO_TEN_SINH_VIEN, e_col_Number.ID_TRANG_THAI);
            //v_htb.Add(V_GD_CAU_HOI_YEU_CAU.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU.NewRow());
            return v_obj_trans;		
        }
        private Hashtable get_data_map_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_GD_CAU_HOI_SV, CM_DM_TU_DIEN.MA_TU_DIEN, v_ds);
            Hashtable v_htb = new Hashtable();
            foreach (DS_CM_DM_TU_DIEN.CM_DM_TU_DIENRow v_tu_dien in v_ds.CM_DM_TU_DIEN.Rows)
            {
                v_htb.Add(v_tu_dien[CM_DM_TU_DIEN.ID], v_tu_dien[CM_DM_TU_DIEN.TEN]);
            }
            return v_htb;
        }
        private void load_call_history_hoc_vien(string i_str_dien_thoai)
        {
            m_ds_v_cau_hoi_yeu_cau = new DS_V_GD_CAU_HOI_YEU_CAU();
           
            m_us_v_cau_hoi_yeu_cau.load_call_history_hoc_vien(m_ds_v_cau_hoi_yeu_cau,i_str_dien_thoai);

            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_cau_hoi_yeu_cau, m_fg, m_trans_obj);
            m_fg.Redraw = true;
            make_stt();

            //
            // Trường hợp nếu học viên không tìm được trên SCM mà lại tìm được sdt trong lịch sử cuộc gọi
            // thì sẽ tự động điền họ tên học viên lên form.
            //
            if(m_txt_ho_ten.Text.Trim() == ""
                && m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU.Rows.Count > 0)
            {
                m_txt_ho_ten.Text = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU.Rows[0][V_GD_CAU_HOI_YEU_CAU.HO_TEN_SINH_VIEN].ToString();
                m_txt_ma_hoc_vien.Text = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][ V_GD_CAU_HOI_YEU_CAU.MA_SINH_VIEN].ToString();
                m_txt_ma_lop.Text = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.LOP].ToString();
                m_txt_noi_sinh.Text = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.NOI_SINH].ToString();
                if(m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.NGAY_SINH].ToString() != "")
                    m_dtp_ngay_sinh.Value = CIPConvert.ToDatetime(m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.NGAY_SINH].ToString(),"dd/MM/yyyy hh:mi:ss");
                m_cbo_truong.SelectedValue = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.TRUONG].ToString();
                if(m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.HO_TEN_QLHT].ToString() != "")
                    m_txt_ho_ten_qlht.Text = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.HO_TEN_QLHT].ToString();
                if (m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.DIEN_THOAI_QLHT].ToString() != "")
                    m_txt_dien_thoai_qlht.Text = m_ds_v_cau_hoi_yeu_cau.V_GD_CAU_HOI_YEU_CAU[0][V_GD_CAU_HOI_YEU_CAU.DIEN_THOAI_QLHT].ToString();
            }
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
            v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN.Rows.RemoveAt(1);

            m_cbo_trang_thai_cau_hoi.DataSource = v_ds_tu_dien_trang_thai.CM_DM_TU_DIEN;
            m_cbo_trang_thai_cau_hoi.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai_cau_hoi.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai_cau_hoi.SelectedIndex = 1;
            

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

            DataRow v_dr = v_ds_tu_dien_truong.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.TEN] = "------";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "------";
            v_ds_tu_dien_truong.EnforceConstraints = false;
            v_ds_tu_dien_truong.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

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

            DataRow v_dr = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = "0";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "- Tất cả -";
            v_dr[CM_DM_TU_DIEN.TEN] = "- Tất cả -";
            v_ds_tu_dien_dv_lien_quan.EnforceConstraints = false;
            v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_don_vi_lien_quan.DataSource = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN;
            m_cbo_don_vi_lien_quan.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_lien_quan.ValueMember = CM_DM_TU_DIEN.ID;
            
            // Linhdh: 2014-05-22: Chọn trường liên quan đến câu hỏi trùng với trường sinh viên đang học
            if (m_cbo_truong.SelectedIndex != 0)
            {
                DataRow[] v_drs = v_ds_tu_dien_dv_lien_quan.CM_DM_TU_DIEN.Select(CM_DM_TU_DIEN.MA_TU_DIEN + "='" + m_cbo_truong.SelectedValue + "'");
                decimal v_dc_id = 0;
                if(v_drs.Length > 0)
                    v_dc_id = CIPConvert.ToDecimal(v_drs[0][CM_DM_TU_DIEN.ID]);
                m_cbo_don_vi_lien_quan.SelectedValue = v_dc_id;
            }
        }
        private bool check_thong_tin_cuoc_goi()
        {
            if (!m_bl_luu_cau_hoi)
            {
                BaseMessages.MsgBox_Error("Bạn cần phải lưu câu hỏi trước khi kết thúc cuộc gọi.");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_ten,DataType.StringType,allowNull.NO,false))
            {
                BaseMessages.MsgBox_Error("Họ tên sinh viên không được trống");
                return false;
            }
            return true;
        }
        private bool check_thong_tin_cau_hoi()
        {

            if (!CValidateTextBox.IsValid(m_txt_ho_ten, DataType.StringType, allowNull.NO, false))
            {
                BaseMessages.MsgBox_Error("Họ tên sinh viên không được trống");
                return false;
            }
            if (m_cbo_loai_cau_hoi_duoi.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Error("Hãy chọn loại câu hỏi");
                m_cbo_loai_cau_hoi_duoi.Focus();
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
        private bool check_lich_su_cuoc_goi(string i_str_dien_thoai)
        {
            US_GD_CUOC_GOI_YEU_CAU v_us_cuoc_goi = new US_GD_CUOC_GOI_YEU_CAU();
            DS_GD_CUOC_GOI_YEU_CAU v_ds_cuoc_goi = new DS_GD_CUOC_GOI_YEU_CAU();

            v_us_cuoc_goi.FillDataset(v_ds_cuoc_goi, "where SO_DIEN_THOAI = '" + i_str_dien_thoai 
                + "' and HO_TEN_SINH_VIEN = 'Chua xac dinh' and THOI_DIEM_GOI = 1 order by ID desc");

            //v_us_cuoc_goi.FillDataset(v_ds_cuoc_goi, "where SO_DIEN_THOAI = '" + i_str_dien_thoai.Replace(" ","").Trim()
            //    + "' order by START_TIME desc");

            // Nếu ko có cuộc gọi nào chưa nhập thì thông báo sai số điện thoại, bắt nhập lại
            if (v_ds_cuoc_goi.GD_CUOC_GOI_YEU_CAU.Rows.Count == 0)
            {
                BaseMessages.MsgBox_Error("Không có cuộc gọi nào từ số " + i_str_dien_thoai + " mà chưa được xử lý");
                m_txt_dien_thoai.Focus();
                return false;
            }
            // Nếu có cuộc gọi chưa nhập thì load lịch sử gọi lên và load thông tin học viên lên form
            else
            {
                // Set ID cuộc gọi
                m_call_id = CIPConvert.ToStr(v_ds_cuoc_goi.GD_CUOC_GOI_YEU_CAU.Rows[0][GD_CUOC_GOI_YEU_CAU.CALL_ID]);
                m_us_cuoc_goi.dcID = CIPConvert.ToDecimal(v_ds_cuoc_goi.GD_CUOC_GOI_YEU_CAU.Rows[0][GD_CUOC_GOI_YEU_CAU.ID]);
                // Search thông tin sinh viên từ SCM
                SinhVien v_obj_sinhvien = new SinhVien();
                SyncData v_ws_scm = new SyncData();
                string v_str_search = HelpUtils.gen_string_call_scm_get_sinh_vien_ws(i_str_dien_thoai, "", "", "", "10", "TOPICA");
                DataSet v_ds = v_ws_scm.TOS_search_info_hoc_vien(v_str_search);
                v_obj_sinhvien.get_sinh_vien_by_ds(v_ds);

                // Điền dữ liệu sinh viên vào form
                m_txt_ho_ten.Text = v_obj_sinhvien.Ho_ten;
                m_txt_ma_hoc_vien.Text = v_obj_sinhvien.Ma_sinh_vien;
                m_txt_ma_lop.Text = v_obj_sinhvien.Ma_lop;
                if (v_obj_sinhvien.Ngay_sinh != CIPConvert.ToDatetime("01/01/0001", "dd/MM/yyyy"))
                    m_dtp_ngay_sinh.Value = CIPConvert.ToDatetime(v_obj_sinhvien.Ngay_sinh.ToShortDateString(), "dd/MM/yyyy");
                if (v_obj_sinhvien.Truong != null)
                    m_cbo_truong.SelectedValue = v_obj_sinhvien.Truong;
                else m_cbo_truong.SelectedIndex = 0;
                if (v_obj_sinhvien.Ho_Ten_QLHT != "" && v_obj_sinhvien.Ho_Ten_QLHT != null)
                    m_txt_ho_ten_qlht.Text = v_obj_sinhvien.Ho_Ten_QLHT;
                if (v_obj_sinhvien.Dien_thoai_QLHT != "" && v_obj_sinhvien.Dien_thoai_QLHT != null)
                    m_txt_dien_thoai_qlht.Text = v_obj_sinhvien.Dien_thoai_QLHT;
                
                // Load lịch sử cuộc gọi lên
                load_call_history_hoc_vien(i_str_dien_thoai);
                return true;
            }
        }
        //private void insert_cuoc_goi_moi()
        //{
        //    m_us_cuoc_goi = new US_GD_CUOC_GOI_YEU_CAU();
        //    m_us_cuoc_goi.dcCALL_ID = CIPConvert.ToDecimal(m_call_id);
        //    m_us_cuoc_goi.strCUOC_GOI_VAO_YN = "Y";
        //    m_us_cuoc_goi.strHO_TEN_SINH_VIEN = m_txt_ho_ten.Text;
        //    m_us_cuoc_goi.strLOP = m_txt_ma_lop.Text;
        //    m_us_cuoc_goi.strMA_SINH_VIEN = m_txt_ma_hoc_vien.Text;
        //    m_us_cuoc_goi.strNOI_SINH = m_txt_noi_sinh.Text;
        //    m_us_cuoc_goi.strSO_DIEN_THOAI = m_txt_dien_thoai.Text;
        //    m_us_cuoc_goi.strTRUONG = CIPConvert.ToStr(m_cbo_truong.SelectedValue);
        //    m_us_cuoc_goi.dcID_NGUOI_DUNG = CAppContext_201.getCurrentUserID();
        //    m_us_cuoc_goi.dcSTATION_ID = CIPConvert.ToDecimal(f001_main_form.m_str_stationId);

            
        //    m_us_cuoc_goi.Insert();
            
        //}
        private void insert_cuoc_goi_moi()
        {
            // Trường hợp này xảy ra khi bấm nút Lưu câu hỏi lần đầu tiên
            // Nếu cuộc gọi chưa được insert thì phải insert trước
            if (m_us_cuoc_goi.dcID == -1)
            {
                m_us_cuoc_goi.strCALL_ID = m_call_id;
                m_us_cuoc_goi.strCUOC_GOI_VAO_YN = "Y";
                m_us_cuoc_goi.strHO_TEN_SINH_VIEN = m_txt_ho_ten.Text;
                m_us_cuoc_goi.strLOP = m_txt_ma_lop.Text;
                m_us_cuoc_goi.strMA_SINH_VIEN = m_txt_ma_hoc_vien.Text;
                m_us_cuoc_goi.strNOI_SINH = m_txt_noi_sinh.Text;
                m_us_cuoc_goi.strSO_DIEN_THOAI = m_txt_dien_thoai.Text;
                m_us_cuoc_goi.strTRUONG = CIPConvert.ToStr(m_cbo_truong.SelectedValue);
                m_us_cuoc_goi.dcID_NGUOI_DUNG = CAppContext_201.getCurrentUserID();
                m_us_cuoc_goi.dcSTATION_ID = CIPConvert.ToDecimal(f002_main_form.m_str_stationId);
                m_us_cuoc_goi.dcID_TRANG_THAI = -1;
                m_us_cuoc_goi.strHO_TEN_QLHT = m_txt_ho_ten_qlht.Text.Trim();
                m_us_cuoc_goi.strDIEN_THOAI_QLHT = m_txt_dien_thoai_qlht.Text.Trim();

                if (m_e_form_mode == e_form_mode.NHAP_TAY)
                    m_us_cuoc_goi.dcTHOI_DIEM_GOI = THOI_DIEM_GOI.GOI_BUOI_TOI;
                else if (m_e_form_mode == e_form_mode.TU_DONG_OPEN)
                    m_us_cuoc_goi.dcTHOI_DIEM_GOI = THOI_DIEM_GOI.GOI_BAN_NGAY;
                m_us_cuoc_goi.Insert();
            }
                // Trường hợp này xảy ra khi bấm nút End Call
            // Nếu cuộc gọi đã được insert rồi thì chỉ việc update thông tin còn lại. 
            else  
                {
                    CallInfor v_call_info = new CallInfor();
                if (m_e_form_mode == e_form_mode.TU_DONG_OPEN)
                v_call_info = HelpUtils.get_call_infor(m_call_id
                                                       );
                else v_call_info = HelpUtils.get_call_infor_overtime(m_call_id
                                                       );
           

                m_us_cuoc_goi.strERROR_CODE = v_call_info.error_code;
                m_us_cuoc_goi.strERROR_DESC = v_call_info.error_desc;
                
                m_us_cuoc_goi.strSTATUS = v_call_info.status;
                m_us_cuoc_goi.strVOICE_CALL_LINK = v_call_info.link_down_record;
                if (v_call_info.datetime_response != null)
                    m_us_cuoc_goi.datDATETIME_RESPOND = HelpUtils.string_2_datetime(v_call_info.datetime_response);
                else m_us_cuoc_goi.datDATETIME_RESPOND = CIPConvert.ToDatetime("01/01/1900","dd/MM/yyyy");
                if (v_call_info.end_time != null)
                    m_us_cuoc_goi.datEND_TIME = HelpUtils.string_2_datetime(v_call_info.end_time);
                else m_us_cuoc_goi.datEND_TIME = CIPConvert.ToDatetime("01/01/1900", "dd/MM/yyyy");
                if (v_call_info.start_time!= null)
                    m_us_cuoc_goi.datSTART_TIME =HelpUtils.string_2_datetime(v_call_info.start_time);
                else m_us_cuoc_goi.datSTART_TIME = CIPConvert.ToDatetime("01/01/1900", "dd/MM/yyyy");
                m_us_cuoc_goi.dcDURATION = CIPConvert.ToDecimal( v_call_info.duration);
                m_us_cuoc_goi.dcID_TRANG_THAI = m_dc_id_trang_thai_cuoc_goi;
                m_us_cuoc_goi.dcRINGTIME = CIPConvert.ToDecimal(v_call_info.ringtime);
                m_us_cuoc_goi.strHO_TEN_SINH_VIEN = m_txt_ho_ten.Text.Trim();
                m_us_cuoc_goi.dcID_NGUOI_DUNG = CAppContext_201.getCurrentUserID();
                m_us_cuoc_goi.strSO_DIEN_THOAI = m_txt_dien_thoai.Text;
                m_us_cuoc_goi.strCUOC_GOI_VAO_YN = "Y";
                m_us_cuoc_goi.strCALL_ID = m_call_id;

                if (m_e_form_mode == e_form_mode.NHAP_TAY)
                    m_us_cuoc_goi.dcTHOI_DIEM_GOI = THOI_DIEM_GOI.GOI_BUOI_TOI;
                else if (m_e_form_mode == e_form_mode.TU_DONG_OPEN)
                    m_us_cuoc_goi.dcTHOI_DIEM_GOI = THOI_DIEM_GOI.GOI_BAN_NGAY;

                m_us_cuoc_goi.Update();
                BaseMessages.MsgBox_Infor("Đã lưu thông tin cuộc gọi thành công");
            }
            
        }
        private void insert_cau_hoi_moi()
        {
            m_us_cau_hoi = new US_GD_CAU_HOI_HOC_VIEN();
            m_us_cau_hoi.strGHI_CHU_LICH_HEN = m_txt_ghi_chu_hen.Text;
            m_us_cau_hoi.strGHI_CHU_Y_KIEN_KHAC = m_txt_y_kien_khac.Text;
            m_us_cau_hoi.strNOI_DUNG_CAU_HOI = m_txt_cau_hoi.Text;
            m_us_cau_hoi.strNOI_DUNG_TRA_LOI = m_rtb_cau_tra_loi.Text;
            if(CValidateTextBox.IsValid(m_dat_ngay_hen_goi_lai,DataType.DateType,allowNull.YES)
                && m_dat_ngay_hen_goi_lai.Text.Trim() != "")
                m_us_cau_hoi.datTHOI_DIEM_HEN_GOI_LAI = CIPConvert.ToDatetime(m_dat_ngay_hen_goi_lai.Value);
            m_us_cau_hoi.dcID_CAU_HOI = m_us_v_cau_hoi.dcID;
            m_us_cau_hoi.dcID_DANH_GIA = CIPConvert.ToDecimal(m_cbo_danh_gia_tra_loi.SelectedValue);
            m_us_cau_hoi.dcID_LOAI_CAU_HOI = CIPConvert.ToDecimal(m_cbo_loai_cau_hoi_duoi.SelectedValue);
            m_us_cau_hoi.dcID_NGUOI_TRA_LOI = CAppContext_201.getCurrentUserID();
            m_us_cau_hoi.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai_cau_hoi.SelectedValue);
            m_us_cau_hoi.dcID_YEU_CAU = m_us_cuoc_goi.dcID;
            //
            
            m_us_cau_hoi.Insert();

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
            if(v_frm.display_search(m_txt_key_cau_hoi.Text
                , CIPConvert.ToDecimal(m_cbo_don_vi_lien_quan.SelectedValue)
                ,CIPConvert.ToDecimal(m_cbo_loai_cau_hoi_tren.SelectedValue)
                , m_us_v_cau_hoi) == DialogResult.OK)
            {
                m_txt_cau_hoi.Text = m_us_v_cau_hoi.strNOI_DUNG_CAU_HOI;
                m_rtb_cau_tra_loi.Text = m_us_v_cau_hoi.strCAU_TRA_LOI;
                m_cbo_loai_cau_hoi_duoi.SelectedValue = m_us_v_cau_hoi.dcID_NHOM_CAU_HOI;
                m_txt_cau_hoi.Enabled = false;
                m_rtb_cau_tra_loi.Enabled = false;
                m_txt_link_tham_khao.Text = m_us_v_cau_hoi.strLINK_TL_THAM_KHAO.Trim();
                if (m_us_v_cau_hoi.strLINK_TL_THAM_KHAO != "")
                    m_cmd_open_link_tham_khao.Visible = true;
                else m_cmd_open_link_tham_khao.Visible = false;
                m_txt_y_kien_khac.Focus();
            }
            
        }
        private void search_dm_sinh_vien()
        {
            f230_dm_sinh_vien_searching v_frm = new f230_dm_sinh_vien_searching();
            //string v_str_key_search = HelpUtils.gen_string_call_scm_get_sinh_vien_ws("", m_txt_ho_ten.Text.Trim(), "", "", "20",m_cbo_truong.Text);
            
            if (v_frm.display_search(m_txt_ho_ten.Text
                ,m_cbo_truong.Text.ToUpper()
                , m_us_v_cau_hoi_yeu_cau) == DialogResult.OK)
            {
                m_txt_ho_ten.Text = m_us_v_cau_hoi_yeu_cau.strHO_TEN_SINH_VIEN;
                m_txt_ma_hoc_vien.Text = m_us_v_cau_hoi_yeu_cau.strMA_SINH_VIEN;
                m_txt_ma_lop.Text = m_us_v_cau_hoi_yeu_cau.strLOP;
                m_txt_noi_sinh.Text = m_us_v_cau_hoi_yeu_cau.strNOI_SINH;
                m_dtp_ngay_sinh.Value = m_us_v_cau_hoi_yeu_cau.datNGAY_SINH;
                m_cbo_truong.SelectedValue = m_us_v_cau_hoi_yeu_cau.strTRUONG;

                m_txt_ho_ten.Enabled = m_cbo_truong.Enabled = false;
            }

        }
        #endregion

        #region events
        private void set_define_events()
        {

            this.Load += new EventHandler(f200_sinh_vien_goi_den_Load);
            
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_end_call.Click += new EventHandler(m_cmd_end_call_Click);
            
            m_txt_key_cau_hoi.KeyDown += new KeyEventHandler(m_txt_key_cau_hoi_KeyDown);
            m_cmd_nhap_cau_hoi_chua_co.Click += new EventHandler(m_cmd_nhap_cau_hoi_chua_co_Click);
            m_txt_ho_ten.KeyDown += new KeyEventHandler(m_txt_ho_ten_KeyDown);
            m_cmd_tim_hv_khac.Click += new EventHandler(m_cmd_tim_hv_khac_Click);
            m_chk_hoc_vien_moi.CheckedChanged += new EventHandler(m_chk_hoc_vien_moi_CheckedChanged);
            this.FormClosing += new FormClosingEventHandler(f200_sinh_vien_goi_den_FormClosing);
            m_cmd_tim_kiem_cau_hoi.Click += new EventHandler(m_cmd_tim_kiem_cau_hoi_Click);
            m_cmd_open_link_tham_khao.Click += new EventHandler(m_cmd_open_link_tham_khao_Click);
            m_txt_dien_thoai.KeyDown += new KeyEventHandler(m_txt_dien_thoai_KeyDown);
            m_cmd_refresh.Click += new EventHandler(m_cmd_refresh_Click);
        }

        void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                m_txt_dien_thoai.Text = "";
                m_txt_dien_thoai_qlht.Text = "";
                m_txt_ho_ten.Text = "";
                m_txt_ma_hoc_vien.Text = "";
                m_txt_ma_lop.Text = "";
                m_cbo_truong.SelectedIndex = 0;
                m_txt_noi_sinh.Text = "";
                m_dtp_ngay_sinh.Value = CAppContext_201.getCurentDate();
                CGridUtils.ClearDataInGrid(m_fg);

                m_bl_luu_cau_hoi = false;
                m_bl_luu_cuoc_goi = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_txt_dien_thoai_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        m_bl_luu_cau_hoi = false;
                        check_lich_su_cuoc_goi(m_txt_dien_thoai.Text.Trim());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

       

       

        void m_cmd_open_link_tham_khao_Click(object sender, EventArgs e)
        {
            try
            {
                HelpUtils.open_link_in_default_browser(m_txt_link_tham_khao.Text);
            }
            catch (Exception v_e)
            {
                BaseMessages.MsgBox_Error("Link không đúng định dạng");
            }
        }

        void m_cmd_tim_kiem_cau_hoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_key_cau_hoi.Text.Trim() == "") return;
                search_dm_cau_hoi();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f200_sinh_vien_goi_den_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(m_e_form_mode == e_form_mode.NHAP_TAY && !m_bl_luu_cau_hoi)
                {
                    if (!BaseMessages.MsgBox_Confirm("Chú ý: Bạn chưa lưu câu hỏi. Bấm Đồng ý nếu bạn vẫn muốn thoát, Bấm Không đồng ý để ở lại form."))
                        e.Cancel = true;
                }
                else if(!m_bl_luu_cuoc_goi)
                {
                    if(!BaseMessages.MsgBox_Confirm("Chú ý: Bạn chưa lưu cuộc gọi. Bấm Đồng ý nếu bạn vẫn muốn thoát, Bấm Không đồng ý để ở lại form."))
                    e.Cancel = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_chk_hoc_vien_moi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_chk_hoc_vien_moi.Checked)
                {
                    m_txt_ho_ten.Enabled = true;
                    m_txt_ma_hoc_vien.Enabled = true;
                    m_txt_ma_lop.Enabled = true;
                    m_txt_noi_sinh.Enabled = true;
                    m_dtp_ngay_sinh.Enabled = true;
                    m_cbo_truong.Enabled = true;
                    m_txt_ho_ten_qlht.Enabled = true;
                    m_txt_dien_thoai_qlht.Enabled = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tim_hv_khac_Click(object sender, EventArgs e)
        {
            try
            {
                f230_dm_sinh_vien_searching v_frm = new f230_dm_sinh_vien_searching();
                if (v_frm.display(m_us_v_cau_hoi_yeu_cau) == DialogResult.OK)
                {
                    m_txt_ho_ten.Text = m_us_v_cau_hoi_yeu_cau.strHO_TEN_SINH_VIEN;
                    m_txt_ma_hoc_vien.Text = m_us_v_cau_hoi_yeu_cau.strMA_SINH_VIEN;
                    m_txt_ma_lop.Text = m_us_v_cau_hoi_yeu_cau.strLOP;
                    m_txt_noi_sinh.Text = m_us_v_cau_hoi_yeu_cau.strNOI_SINH;
                    m_dtp_ngay_sinh.Value = m_us_v_cau_hoi_yeu_cau.datNGAY_SINH;
                    m_cbo_truong.SelectedValue = m_us_v_cau_hoi_yeu_cau.strTRUONG;

                    m_txt_ho_ten.Enabled = false;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_txt_ho_ten_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        search_dm_sinh_vien();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_cau_hoi_chua_co_Click(object sender, EventArgs e)
        {
            m_txt_cau_hoi.Enabled = true;
            m_rtb_cau_tra_loi.Enabled = true;
            m_txt_cau_hoi.Text = "";
            m_rtb_cau_tra_loi.Text = "";
            m_txt_cau_hoi.Focus();
        }

        void m_txt_key_cau_hoi_KeyDown(object sender, KeyEventArgs e)
        {
             try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        //if (m_txt_key_cau_hoi.Text.Trim() == "") return;
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

        void m_cmd_end_call_Click(object sender, EventArgs e)
        {
            try
            {

                if (!check_thong_tin_cuoc_goi()) return;
                if (BaseMessages.MsgBox_Confirm("Bạn có chắc chắn là đã lưu câu hỏi và muốn kết thúc cuộc gọi không?") == true)
                {
                    insert_cuoc_goi_moi();
                    m_bl_luu_cuoc_goi = true;

                    if(m_e_form_mode == e_form_mode.TU_DONG_OPEN)
                    this.Close();
                }
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
                if (!check_thong_tin_cau_hoi()) return;
                if (m_us_cuoc_goi.dcID == -1)
                    insert_cuoc_goi_moi();
                insert_cau_hoi_moi();
                load_call_history_hoc_vien(m_txt_dien_thoai.Text);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
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
        private void m_fg_Click(object sender, EventArgs e)
        {

        }
        #endregion



    }
}
