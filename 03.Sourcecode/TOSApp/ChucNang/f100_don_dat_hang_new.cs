using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using TOSApp;
using IPCOREUS;
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
        US_GD_DAT_HANG m_us = new US_GD_DAT_HANG();
        List<decimal> m_lst_id_nguoi_xu_ly = new List<decimal>();

        #region load data to selected

        //load data từ trong csdl lên vào các selected sẵn có 
        private void load_data_2_selected()
        {
            load_data_2_user_nhan_vien_dat_hang();
            load_data_2_selected_don_vi();
            load_data_2_selected_loai_dich_vu();
            load_data_2_dich_vu_ver2();
            load_data_2_selected_trang_thai_don_hang();
            random_data_2_ma_don_hang();
            load_data_2_selected_nguoi_tiep_nhan();
        }

        private void load_data_2_selected_nguoi_tiep_nhan()
        {
            WinFormControls.load_data_to_combobox("V_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH", "ID_NGUOI_SU_DUNG", "TEN", " WHERE ID_NHOM=1", WinFormControls.eTAT_CA.NO, m_cbo_nguoi_nhan_dat_hang);
        }

        private void load_data_2_user_nhan_vien_dat_hang()
        {
 	       WinFormControls.load_data_to_combobox("DM_khach_hang", "ID", "ten_khach_hang", "", WinFormControls.eTAT_CA.NO, m_cbo_user_nhan_vien_dat_hang);
        }
        //don vị đặt hàng
        private void load_data_2_selected_don_vi()
        {
            WinFormControls.load_data_to_combobox("DM_DON_VI", "ID", "MA_DON_VI", "", WinFormControls.eTAT_CA.NO, m_cbo_dv_don_vi);
            // WinFormControls.load_data_to_combobox_with_query(m_cbo_dv_don_vi, "ID", "MA_DON_VI", WinFormControls.eTAT_CA.NO, "select  from DM_KHACH_HANG");
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

            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU", "ID", "TEN_YEU_CAU", " Where ID_CHA=" +m_cbo_loai_dich_vu.SelectedValue.ToString(),WinFormControls.eTAT_CA.NO, m_cbo_dich_vu);
            
        }
        //load len trang thai cua selected don hang
        private void load_data_2_selected_trang_thai_don_hang()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_trang_thai_don_hang, "ID", "TEN", WinFormControls.eTAT_CA.NO, "select TEN from CM_DM_TU_DIEN where ID_LOAI_TU_DIEN =17");
        }
         
       

        private void random_data_2_ma_don_hang()
        {
            m_txt_ma_don_hang.Text = "DVMC2015"+new Random().Next(1000, 9999).ToString();
        }
        #endregion

        //hàm này dùng để fomat controll trước khi tạo một đơn hàng mới
        
        private void fomat_controlls_form()
        {
            if (m_cbo_loai_dich_vu.SelectedValue == "") m_cbo_dich_vu.Visible = false;
        }
        //

     

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
            WinFormControls.load_data_to_combobox("DM_LOAI_YEU_CAU","ID","TEN_YEU_CAU"," where ID_CHA="+m_cbo_loai_dich_vu.SelectedValue.ToString(),WinFormControls.eTAT_CA.NO,m_cbo_dich_vu);
        }

        private void m_cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dc_id_loai_dich_vu = CIPConvert.ToDecimal(m_cbo_loai_dich_vu.SelectedValue.ToString());
            load_data_2_selected_dich_vu();
        }

        private void m_cmd_xac_nhan_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Kiem_tra_du_lieu_truoc_luu() == true)
                {
                    luu_don_hang();
                    dieu_phoi_don_hang();
                    this.Close();
  
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void dieu_phoi_don_hang()
        {
            if (m_lst_id_nguoi_xu_ly.Count==0)
            {
                return;
            }
            cap_nhat_lai_trang_thai_tiep_nhan();
            xac_nhan_dieu_phoi(m_lst_id_nguoi_xu_ly, m_us);
            MessageBox.Show("da dieu phoi");
        }

        private void cap_nhat_lai_trang_thai_tiep_nhan()
        {
           //cap nhat lai trang thai cua log don hang truoc khi thuc hien thao tac dieu huong
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_id_tiep_nhan);
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.Update();  
            
        }

        decimal m_id_tiep_nhan;
        private void luu_don_hang()
        {
            
            ghi_don_hang();
            ghi_log_tiep_nhan();
        }

        private decimal ghi_log_tiep_nhan()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 173;
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_TAO_THAO_TAC = m_us.dcID_NGUOI_TAO;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = m_us.dcID_NGUOI_TAO;
            v_us.datNGAY_LAP_THAO_TAC = m_us.datTHOI_GIAN_TAO;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "tiep nhan";
            v_us.Insert();
            m_id_tiep_nhan = v_us.dcID;
            MessageBox.Show("da tiep nhan");
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
            MessageBox.Show("hoan thanh viec luu don hang!");
        }

        private void xac_nhan_dieu_phoi(List<decimal> v_lst_id_nguoi_xu_ly, US_GD_DAT_HANG m_us)
        {

            for (int i = 0; i < v_lst_id_nguoi_xu_ly.Count; i++)
            {
                ghi_log_dieu_phoi_cho_nguoi_xu_ly(v_lst_id_nguoi_xu_ly[i],m_us);
            }
        }
        //ghi lai dieu phoi cho tung nguoi
        private void ghi_log_dieu_phoi_cho_nguoi_xu_ly(decimal nguoi_nhan_tao_tac_i, US_GD_DAT_HANG m_us)
        {

            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 174;//fix cung cho tao tac dieu huong--> bi ngu
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = nguoi_nhan_tao_tac_i;
            v_us.dcID_NGUOI_TAO_THAO_TAC = m_us.dcID_NGUOI_TAO;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "da nhan";
            v_us.Insert();
        }
        //ghi lai log tai bang gd_log_dat_hang sau khi thuc hien thao tac insert
       
        
     
        private void form_2_us()
        {
            m_us.strMA_DON_HANG = m_txt_ma_don_hang.Text;
            m_us.dcID_USER_NV_DAT_HANG = CIPConvert.ToDecimal(m_cbo_user_nhan_vien_dat_hang.SelectedValue);
            m_us.dcID_DON_VI = CIPConvert.ToDecimal( m_cbo_dv_don_vi.SelectedValue.ToString());//xem lai
            m_us.strDIEN_THOAI = m_txt_dien_thoai.Text;
            m_us.strHO_TEN_USER_DAT_HANG = m_txt_ho_ten_nguoi_dat_hang.Text ;
            m_us.datTHOI_GIAN_DAT_HANG =m_dat_thoi_gian_dat_hang.Value;
            m_us.dcID_DV_YEU_CAU = CIPConvert.ToDecimal( m_cbo_dich_vu.SelectedValue);//xem ai chi lay id
            m_us.strNOI_DUNG_DAT_HANG = m_txt_yeu_cau_cu_the.Text;
            m_us.dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH = CIPConvert.ToDecimal( return_loai_thoi_gian_can_hoan_thanh(m_rdb_loai_time_15phut, m_rdb_loai_time_4h, m_rdb_loai_time_1ngay, m_rdb_loai_time_1tuan, m_rdb_loai_time_1thang).ToString());
            m_us.strPHAN_HOI_TU_DVMC = m_txt_phan_hoi_tu_dvmc.Text;
            m_us.SetTHOI_GIAN_HOAN_THANHNull(); 
            m_us.datTHOI_GIAN_TAO = System.DateTime.Now;
                //System.DateTime.Now.ToString("yyyy/MM/dd/hh/mm/ss");
            m_us.dcID_PHUONG_THUC_DAT_HANG = 182;//---phuong thuc dat hang la goi dien
            m_us.dcID_NGUOI_TAO = CIPConvert.ToDecimal(m_cbo_nguoi_nhan_dat_hang.SelectedValue);///xem lai
            m_us.dcID_CHI_NHANH= 1; //--fix lai sau mac dinh la 1 -HA NOI
        }
        //tra lai thoi gian sau khi hoan thanh don hang dua vao thoi gian dat hang + thoi gian can de hoan thanh don hang
        private DateTime get_thoi_gian_hoan_thanh(DateTime dateTime)
        {
            if (return_loai_thoi_gian_can_hoan_thanh(m_rdb_loai_time_15phut, m_rdb_loai_time_4h, m_rdb_loai_time_1ngay, m_rdb_loai_time_1tuan, m_rdb_loai_time_1thang) == 200)
                dateTime.AddMinutes(15);
            else if (return_loai_thoi_gian_can_hoan_thanh(m_rdb_loai_time_15phut, m_rdb_loai_time_4h, m_rdb_loai_time_1ngay, m_rdb_loai_time_1tuan, m_rdb_loai_time_1thang) == 201)
                dateTime.AddHours(4);
            else if (return_loai_thoi_gian_can_hoan_thanh(m_rdb_loai_time_15phut, m_rdb_loai_time_4h, m_rdb_loai_time_1ngay, m_rdb_loai_time_1tuan, m_rdb_loai_time_1thang) == 202)
                dateTime.AddDays(1);
            else if (return_loai_thoi_gian_can_hoan_thanh(m_rdb_loai_time_15phut, m_rdb_loai_time_4h, m_rdb_loai_time_1ngay, m_rdb_loai_time_1tuan, m_rdb_loai_time_1thang) == 203)
                dateTime.AddDays(7);
            else dateTime.AddMonths(1);
            return dateTime;
        
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
           
            return true;
        }
        internal void displayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            insert_new_data_2_dm_ma_don_hang(m_txt_ma_don_hang.Text);
            this.ShowDialog();
        }

        private void insert_new_data_2_dm_ma_don_hang(string p)
        {
            US_DM_MA_DON_HANG v_us = new US_DM_MA_DON_HANG();
            v_us.strMA_DON_HANG = p;
            v_us.Insert();
        }



       

        internal void displayForUpdate(IPCOREUS.US_GD_DAT_HANG v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(IPCOREUS.US_GD_DAT_HANG v_us)
        {
            string v_time;
            v_time = v_us.datTHOI_GIAN_HOAN_THANH.ToString();


            m_cbo_user_nhan_vien_dat_hang.SelectedValue = "---------";
            m_txt_ho_ten_nguoi_dat_hang.Text = v_us.strHO_TEN_USER_DAT_HANG;
            //m_cbo_dv_don_vi.SelectedValue = 
            load_don_vi(v_us.dcID_DON_VI);
            m_txt_dien_thoai.Text = v_us.strDIEN_THOAI;
            m_dat_thoi_gian_dat_hang.Text = v_us.datTHOI_GIAN_DAT_HANG.ToString();
            m_txt_yeu_cau_cu_the.Text = v_us.strNOI_DUNG_DAT_HANG;
            if (check_value_with_radiobutton_thoi_gian(v_time) == 1)
            {
                m_rdb_loai_time_15phut.Checked = true;

                if (check_value_with_radiobutton_thoi_gian(v_time) == 2)
                {
                    m_rdb_loai_time_4h.Checked = true;
                    if (check_value_with_radiobutton_thoi_gian(v_time) == 3)
                    {
                        m_rdb_loai_time_1ngay.Checked = true;
                        if (check_value_with_radiobutton_thoi_gian(v_time) == 4)
                        {
                            m_rdb_loai_time_1tuan.Checked = true;
                            if (check_value_with_radiobutton_thoi_gian(v_time) == 5)
                                m_rdb_loai_time_1thang.Checked = true;
                            else
                            {
                                m_rdb_loai_time_15phut.Checked = false;
                                m_rdb_loai_time_4h.Checked = false;
                                m_rdb_loai_time_1ngay.Checked = false;
                                m_rdb_loai_time_1tuan.Checked = false;
                                m_rdb_loai_time_1thang.Checked = false;
                            }
                        }
                    }
                }
            }

            m_cbo_loai_dich_vu.SelectedValue = v_us.dcID_DV_YEU_CAU;
            m_cbo_dich_vu.SelectedValue = v_us.dcID_DV_YEU_CAU;
            m_txt_phan_hoi_tu_dvmc.Text = v_us.strPHAN_HOI_TU_DVMC;
            m_txt_lich_su_trao_doi.Text = " ";
            m_cbo_trang_thai_don_hang.SelectedValue = "";
          //  m_cbo_nguoi_nhan_dat_hang.SelectedValue = v_us.dcID_NGUOI_TAO;////////phai lay ra ten
            load_nguoi_nhan_dat_hang(v_us.dcID_NGUOI_TAO);
           // m_txt_nguoi_xu_ly.Text = " ";//log dat hang
          //////////////////////////
            load_nguoi_xu_ly_dat_hang(v_us.dcID);

        }

        private void load_nguoi_xu_ly_dat_hang(decimal p)
        {
            
        }

       

        //private void load_nguoi_xu_ly_dat_hang(decimal p)
        //{
        //    WinFormControls.load_data_to_combobox("HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH", "ID", "TEN", "where HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH.id=gd.dat_hang." + p, WinFormControls.eTAT_CA.NO, m_cbo_nguoi_nhan_dat_hang);
        //}

        private void load_nguoi_nhan_dat_hang(decimal p)
        {
            WinFormControls.load_data_to_combobox("HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH", "ID", "TEN", " where HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH.id=gd_dat_hang." + p, WinFormControls.eTAT_CA.NO, m_cbo_nguoi_nhan_dat_hang);
        }

        private void load_don_vi(decimal p)
        {
        //   US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        //    DataSet v_ds = new DataSet();
        //    v_ds.Tables.Add(new DataTable());
        //    v_us.FillDatasetWithTableName(v_ds,"V_DM_DON_VI");

           // WinFormControls.load_data_to_combobox_with_query(m_cbo_dv_don_vi, "ID", "MA_DON_VI", WinFormControls.eTAT_CA.NO, "");
            WinFormControls.load_data_to_combobox("dm_don_vi", "ID", "ma_don_vi", " where dm_don_vi.id=gd.dat_hang." + p, WinFormControls.eTAT_CA.NO, m_cbo_dv_don_vi);
         //   return " ";
        }

        private int check_value_with_radiobutton_thoi_gian(string v_time)
        {
        
            if (v_time=="200") return 1;
             if (v_time=="201" )return 2;
             if (v_time=="202" )return 3;
             if (v_time == "203") return 4;
             if (v_time == "204") return 5;
               return 0;

        }

        private void m_cmd_danh_sach_nguoi_xu_ly_Click(object sender, EventArgs e)
        {
            f102_chon_danh_sach_nguoi_xu_ly_new v_f102 = new f102_chon_danh_sach_nguoi_xu_ly_new();
           

            v_f102.Display(ref m_lst_id_nguoi_xu_ly);

          //  v_f102.ShowDialog();

        }

        private void m_cmd_tu_choi_Click(object sender, EventArgs e)
        {
            try
            {
                 ghi_don_hang();
                 ghi_log_tu_choi_don_hang();
                 this.Close();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                
            }
        }

        private void ghi_log_tu_choi_don_hang()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 230;
            v_us.dcID_GD_DAT_HANG = m_us.dcID;
            v_us.dcID_NGUOI_TAO_THAO_TAC = m_us.dcID_NGUOI_TAO;
            v_us.SetID_NGUOI_NHAN_THAO_TACNull();
            v_us.datNGAY_LAP_THAO_TAC = m_us.datTHOI_GIAN_TAO;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "tiep nhan";
            v_us.Insert();
            MessageBox.Show("da tu choi");
          
        }

        private void m_grb_phan_hoi_tu_dvm_Enter(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

       

     

     
      
    }
}
