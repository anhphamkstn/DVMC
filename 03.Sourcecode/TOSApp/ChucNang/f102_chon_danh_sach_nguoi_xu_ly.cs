using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

using IPCOREDS;
using IPCOREDS.CDBNames;
using IPCOREUS;
using IP.Core.IPUserService;
using IP.Core.IPData;
using TOSApp.App_Code;

namespace TOSApp.ChucNang
{
    public partial class f102_chon_danh_sach_nguoi_xu_ly : Form
    {
        public f102_chon_danh_sach_nguoi_xu_ly()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interfaces
        public string display_to_select(string ip_str_username_nguoi_xu_ly)
        {
            m_str_id_nguoi_xu_ly = ip_str_username_nguoi_xu_ly;
            this.ShowDialog();
            return m_str_id_nguoi_xu_ly;
        }
        #endregion

        #region Members
        string m_str_id_nguoi_xu_ly = "";
        US_HT_NGUOI_SU_DUNG m_us_gd_nguoi_xu_ly = new US_HT_NGUOI_SU_DUNG();
        DS_HT_NGUOI_SU_DUNG m_ds_gd_nguoi_xu_ly = new DS_HT_NGUOI_SU_DUNG();
        Dictionary<int, string> m_dic_index_user_nguoi_xu_ly = new Dictionary<int, string>();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            load_data_2_clb_nguoi_xu_ly();
            load_data_2_form();
        }
        private void chon_danh_sach_nguoi_xu_ly()
        {
            string v_str_user_nguoi_xu_ly = "";
            m_str_id_nguoi_xu_ly = "";
            for (int v_i = 0; v_i < m_clb_nguoi_xu_ly.Items.Count; v_i++)
            {
                if (m_clb_nguoi_xu_ly.GetItemChecked(v_i))
                {
                    v_str_user_nguoi_xu_ly = m_dic_index_user_nguoi_xu_ly[v_i];
                    m_str_id_nguoi_xu_ly += v_str_user_nguoi_xu_ly.ToString() + ",";
                }
            }
            if (!is_validate_data()) return;
            this.Close();
        }
        private void load_data_2_form()
        {
            if (m_str_id_nguoi_xu_ly == "") return;
            string[] v_str_user = m_str_id_nguoi_xu_ly.Split(',');
            if (v_str_user.Length > 0)
            {
                for (int v_i = 0; v_i < v_str_user.Length; v_i++)
                {
                    for (int v_j = 0; v_j < m_dic_index_user_nguoi_xu_ly.Keys.Count; v_j++)
                    {
                        if (m_dic_index_user_nguoi_xu_ly[v_j] == v_str_user[v_i])
                        {
                            m_clb_nguoi_xu_ly.SetItemChecked(v_j, true);
                            v_j = m_dic_index_user_nguoi_xu_ly.Keys.Count;
                        }
                    }
                }
            }
        }
        private void load_data_2_clb_nguoi_xu_ly()
        {
            string v_str_nguoi_xu_ly = "";
            m_ds_gd_nguoi_xu_ly.EnforceConstraints = false;
            m_us_gd_nguoi_xu_ly.LoadNguoiDungXuLy("", m_ds_gd_nguoi_xu_ly);

            for (int v_i = 0; v_i < m_ds_gd_nguoi_xu_ly.HT_NGUOI_SU_DUNG.Rows.Count; v_i++)
            {
                m_dic_index_user_nguoi_xu_ly.Add(v_i, Convert.ToString(m_ds_gd_nguoi_xu_ly.HT_NGUOI_SU_DUNG.Rows[v_i][HT_NGUOI_SU_DUNG.TEN_TRUY_CAP]));                
                v_str_nguoi_xu_ly = CIPConvert.ToStr(m_ds_gd_nguoi_xu_ly.HT_NGUOI_SU_DUNG.Rows[v_i][HT_NGUOI_SU_DUNG.TEN_TRUY_CAP]);
                m_clb_nguoi_xu_ly.Items.Add(v_str_nguoi_xu_ly, false);
            }
        }
        private bool is_validate_data()
        {
            if (m_str_id_nguoi_xu_ly == "")
            {
                BaseMessages.MsgBox_Infor("Hãy chọn ít nhất một người xử lý đặt hàng!");
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.m_cmd_exit.Click += new EventHandler(m_cmd_thoat_Click);
            this.Load += new EventHandler(f102_chon_danh_sach_nguoi_xu_ly_Load);
            this.KeyDown += new KeyEventHandler(f102_chon_danh_sach_nguoi_xu_ly_KeyDown);
            m_cmd_oke.Click += new EventHandler(m_cmd_oke_Click);
        }

        void m_cmd_oke_Click(object sender, EventArgs e)
        {
            try
            {
                chon_danh_sach_nguoi_xu_ly();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f102_chon_danh_sach_nguoi_xu_ly_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        void f102_chon_danh_sach_nguoi_xu_ly_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
