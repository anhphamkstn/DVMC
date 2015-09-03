using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class f999_ht_bo_pm_td_dich_vu_de : Form
    {
        public f999_ht_bo_pm_td_dich_vu_de()
        {
            InitializeComponent();
        }
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_LOAI_YEU_CAU m_us_dich_vu = new US_DM_LOAI_YEU_CAU();
        US_HT_BO_DICH_VU m_us_bo_dich_vu = new US_HT_BO_DICH_VU();

        private void form_to_us_update(GridView gridview, decimal v_id_nhom)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT hbdv.ID, hbdv.ID_NGUOI_SU_DUNG  FROM HT_BO_DICH_VU hbdv WHERE hbdv.ID_DICH_VU =" + m_us_dich_vu.dcID.ToString() + "AND hbdv.CAP_SU_DUNG=" + v_id_nhom.ToString() );
            for (int i = 0; i < gridview.RowCount; i++)
            {
                DataRow v_dr = gridview.GetDataRow(i);
                for (int j = 0; j < v_ds.Tables[0].Rows.Count; j++)
                {
                    if (v_ds.Tables[0].Rows[j]["ID_NGUOI_SU_DUNG"].ToString() == "")
                    {
                        m_us_bo_dich_vu.dcID_NGUOI_SU_DUNG = CIPConvert.ToDecimal(v_dr[0].ToString());
                        m_us_bo_dich_vu.dcID_DICH_VU = m_us_dich_vu.dcID;
                        m_us_bo_dich_vu.dcCAP_SU_DUNG = v_id_nhom;
                        m_us_bo_dich_vu.strTRANG_THAI_HSD = "N";
                        m_us_bo_dich_vu.Insert();
                        break;
                    }
                    else if (CIPConvert.ToDecimal(v_dr[0].ToString()) == CIPConvert.ToDecimal(v_ds.Tables[0].Rows[j]["ID_NGUOI_SU_DUNG"].ToString()))
                    {
                        break;
                    }
                    if (j == v_ds.Tables[0].Rows.Count - 1)
                    {
                        //insert v_dr
                        m_us_bo_dich_vu.dcID_NGUOI_SU_DUNG = CIPConvert.ToDecimal(v_dr[0].ToString());
                        m_us_bo_dich_vu.dcID_DICH_VU = m_us_dich_vu.dcID;
                        m_us_bo_dich_vu.dcCAP_SU_DUNG = v_id_nhom;
                        m_us_bo_dich_vu.strTRANG_THAI_HSD = "N";
                        m_us_bo_dich_vu.Insert();
                    }
                }

            }
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                if (v_ds.Tables[0].Rows[i]["ID_NGUOI_SU_DUNG"].ToString() == "" && gridview.RowCount !=0)
                {
                    m_us_bo_dich_vu = new US_HT_BO_DICH_VU(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                    m_us_bo_dich_vu.Delete();
                }
                else if (gridview.RowCount == 0)
                {
                    m_us_bo_dich_vu = new US_HT_BO_DICH_VU(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                    m_us_bo_dich_vu.Delete();
                    if(i == v_ds.Tables[0].Rows.Count - 1)
                    {
                        m_us_bo_dich_vu.dcID_DICH_VU = m_us_dich_vu.dcID;
                        m_us_bo_dich_vu.dcCAP_SU_DUNG = v_id_nhom;
                        m_us_bo_dich_vu.SetID_NGUOI_SU_DUNGNull();
                        m_us_bo_dich_vu.strTRANG_THAI_HSD = "N";
                        m_us_bo_dich_vu.Insert();
                    }
                }
                else
                {
                    for (int j = 0; j < gridview.RowCount; j++)
                    {
                        DataRow v_dr = gridview.GetDataRow(j);
                        if (CIPConvert.ToDecimal(v_dr[0].ToString()) == CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_NGUOI_SU_DUNG"].ToString()))
                        {
                            break;
                        }
                        if (j == gridview.RowCount - 1)
                        {
                            m_us_bo_dich_vu = new US_HT_BO_DICH_VU(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                            m_us_bo_dich_vu.Delete();
                        }
                    }
                }

            }

        }

        private void form_to_us_insert(GridView gridview, decimal v_id_nhom, US_DM_LOAI_YEU_CAU v_us_dm_dich_vu)
        {
            if (gridview.RowCount == 0)
            {
                m_us_bo_dich_vu.dcID_DICH_VU = v_us_dm_dich_vu.dcID;
                m_us_bo_dich_vu.strTRANG_THAI_HSD = "N";
                m_us_bo_dich_vu.SetID_NGUOI_SU_DUNGNull() ;
                m_us_bo_dich_vu.dcCAP_SU_DUNG = v_id_nhom;
                m_us_bo_dich_vu.Insert();
            }
            else
            {
                for (int i = 0; i < gridview.RowCount; i++)
                {
                    DataRow v_dr = gridview.GetDataRow(i);
                    m_us_bo_dich_vu.dcID_NGUOI_SU_DUNG = CIPConvert.ToDecimal(v_dr[0].ToString());
                    m_us_bo_dich_vu.dcID_DICH_VU = v_us_dm_dich_vu.dcID;
                    m_us_bo_dich_vu.dcCAP_SU_DUNG = v_id_nhom;
                    m_us_bo_dich_vu.strTRANG_THAI_HSD = "N";
                    m_us_bo_dich_vu.Insert();
                }
            }

        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu())
                {
                    if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                    {
                        
                        form_to_us_update(grv_danh_sach_bo, 2);
                        form_to_us_update(grv_danh_sach_pm, 3);
                        form_to_us_update(grv_danh_sach_td, 5);
                    }
                    else
                    {
                        US_DM_LOAI_YEU_CAU v_us_dm_dich_vu = new US_DM_LOAI_YEU_CAU();
                        v_us_dm_dich_vu.dcID_CHA = CIPConvert.ToDecimal(cbo_nhom_dich_vu.SelectedValue.ToString());
                        v_us_dm_dich_vu.strTEN_YEU_CAU = txt_dich_vu.Text;
                        v_us_dm_dich_vu.strTRANG_THAI_HSD = "N";
                        v_us_dm_dich_vu.Insert();
                        form_to_us_insert(grv_danh_sach_bo, 2, v_us_dm_dich_vu);
                        form_to_us_insert(grv_danh_sach_pm, 3, v_us_dm_dich_vu);
                        form_to_us_insert(grv_danh_sach_td, 5, v_us_dm_dich_vu);

                    }
                    MessageBox.Show("thành công");
                    this.Close();
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool kiemtradulieu()
        {
            if (txt_dich_vu.Text == "")
            {
                MessageBox.Show("Nhập dịch vụ");
                return false;
            }
            return true;
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                m_us_dich_vu.strTRANG_THAI_HSD = "Y";
                m_us_dich_vu.Update();
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "select id from ht_bo_dich_vu where id_dich_vu = " + m_us_bo_dich_vu.dcID_DICH_VU.ToString());
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    decimal v_dr = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString());
                    US_HT_BO_DICH_VU v_us_bo_dich_vu = new US_HT_BO_DICH_VU(v_dr);
                    v_us_bo_dich_vu.Delete();
                }
                MessageBox.Show("thành công");
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_to_grv_ds_nv(decimal v_id_nhom, decimal v_id_dich_vu)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if (us_user.m_lst_id_nguoi_xu_ly.Count == 0)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT hbdv.ID_NGUOI_SU_DUNG, hnsd.TEN  FROM HT_BO_DICH_VU hbdv,HT_NGUOI_SU_DUNG hnsd WHERE hbdv.ID_DICH_VU =" + v_id_dich_vu.ToString() + "AND hbdv.CAP_SU_DUNG=" + v_id_nhom.ToString() + "AND hnsd.ID = hbdv.ID_NGUOI_SU_DUNG");
            }
            else
            {
                string m_str_query = "SELECT Distinct hnsd.ID,hnsd.TEN FROM V_HT_NGUOI_SU_DUNG hnsd  WHERE hnsd.ID IN (";
                for (int i = 0; i<us_user.m_lst_id_nguoi_xu_ly.Count;i++)
                {
                    if (i == us_user.m_lst_id_nguoi_xu_ly.Count-1)
                        m_str_query += us_user.m_lst_id_nguoi_xu_ly[i].ToString() + ")";
                    else
                        m_str_query += us_user.m_lst_id_nguoi_xu_ly[i].ToString() + ",";
                }
                v_us.FillDatasetWithQuery(v_ds, m_str_query);
            }
            if (v_ds != null)
            {
                if (v_id_nhom == 2)
                {
                    grc_danh_sach_bo.DataSource = v_ds.Tables[0];
                }
                if (v_id_nhom == 3)
                {
                    grc_danh_sach_pm.DataSource = v_ds.Tables[0];
                }
                if (v_id_nhom == 5)
                {
                    grc_danh_sach_td.DataSource = v_ds.Tables[0];
                }
                us_user.m_lst_id_nguoi_xu_ly.Clear();
            }
        }

        private void load_data_to_form()
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_loai_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_YEU_CAU FROM DM_LOAI_YEU_CAU WHERE ID_CHA IS NULL");           
        }

        private void f999_ht_bo_pm_td_dich_vu_de_Load(object sender, EventArgs e)
        {
            if(us_user.dcIDNhom != 5)
            {
                grv_danh_sach_bo.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                grv_danh_sach_pm.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                grv_danh_sach_td.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                m_pan_button.Visible = false;
                txt_dich_vu.ReadOnly = true;
                cbo_nhom_dich_vu.Enabled = false;
                cbo_loai_dich_vu.Enabled = false;
            }
        }

        private void cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_nhom_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_YEU_CAU FROM DM_LOAI_YEU_CAU WHERE ID_CHA =" + cbo_loai_dich_vu.SelectedValue.ToString());
        }

        internal void displayInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_to_form();
            this.ShowDialog();
        }

        internal void displayUpdate(US_HT_BO_DICH_VU v_us_bo_dich_vu,US_DM_LOAI_YEU_CAU v_us_dich_vu )
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            txt_dich_vu.ReadOnly = true;
            cbo_loai_dich_vu.Enabled = false;
            cbo_nhom_dich_vu.Enabled = false;
            load_data_to_form();
            m_us_dich_vu = v_us_dich_vu;
            m_us_bo_dich_vu = v_us_bo_dich_vu;
            us_to_form(v_us_bo_dich_vu, v_us_dich_vu);
            this.ShowDialog();
        }

        private void us_to_form(US_HT_BO_DICH_VU v_us_bo_dich_vu, US_DM_LOAI_YEU_CAU v_us_dich_vu)
        {
            US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU(v_us_dich_vu.dcID_CHA);
            cbo_loai_dich_vu.SelectedValue = v_us.dcID_CHA;
            cbo_nhom_dich_vu.SelectedValue = v_us_dich_vu.dcID_CHA;
            txt_dich_vu.Text = v_us_dich_vu.strTEN_YEU_CAU;
            load_data_to_grv_ds_nv(2, v_us_dich_vu.dcID);
            load_data_to_grv_ds_nv(3, v_us_dich_vu.dcID);
            load_data_to_grv_ds_nv(5, v_us_dich_vu.dcID);


        }

        private void grv_danh_sach_bo_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DataRow v_dr = grv_danh_sach_bo.GetDataRow(grv_danh_sach_bo.FocusedRowHandle);
            DoRowDoubleClick(view, pt,v_dr,2);

        }

        private void grv_danh_sach_pm_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DataRow v_dr = grv_danh_sach_pm.GetDataRow(grv_danh_sach_pm.FocusedRowHandle);
            DoRowDoubleClick(view, pt,v_dr,3);
        }

        private void grv_danh_sach_td_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DataRow v_dr = grv_danh_sach_td.GetDataRow(grv_danh_sach_td.FocusedRowHandle);
            DoRowDoubleClick(view, pt,v_dr,5);
        }

        private void DoRowDoubleClick(GridView view, Point pt, DataRow v_dr, decimal v_id_nhom)
        {
             GridHitInfo info = view.CalcHitInfo(pt);
             if ((info.InRow || info.InRowCell) && v_dr == null)
             {

                 f999_ht_bo_pm_td_dich_vu_them_nhan_vien v_f = new f999_ht_bo_pm_td_dich_vu_them_nhan_vien();
                 v_f.load_to_form(v_id_nhom);
                 v_f.ShowDialog();
                 load_data_to_grv_ds_nv(v_id_nhom, m_us_dich_vu.dcID);
             }

        }
    }
}
