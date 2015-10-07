using IP.Core.IPUserService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEB_DVMC
{

    public class US_DUNG_CHUNG : US_Object
    {
        public void FillDatasetWithProc(DataSet op_ds, string ip_str_table_name, string ip_str_column_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_to_dataset_with_table_name_and_column_name");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_NAME", ip_str_column_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetTinhHinhDaoTao(DataSet op_ds, DateTime ip_dat)
        {
            CStoredProc v_cstore = new CStoredProc("rpt_tinh_hinh_dao_tao");
            v_cstore.addDatetimeInputParam("@ip_dat_ngay_bao_cao", ip_dat);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetVNghiepVuMonHoc(DataSet op_ds)
        {
            CStoredProc v_cstore = new CStoredProc("get_danh_sach_nhan_vien_nghiep_vu");
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetCBO(DataSet op_ds, string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_for_cbo");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_VALUE", ip_str_value_field);
            v_cstore.addNVarcharInputParam("@COLUMN_DISPLAY", ip_str_display_field);
            v_cstore.addNVarcharInputParam("@CONDITION", ip_str_condition);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithTableName(DataSet op_ds, string ip_str_table_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_from_table");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }


        internal void FillDatasetWithQuery(DataSet op_ds, string ip_query)
        {
            CStoredProc v_cstore = new CStoredProc("pr_fill_ds_with_query");
            v_cstore.addNVarcharInputParam("@SQL_QUERY", ip_query);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetChungChiHetHan(DataSet v_ds, DateTime dateTime)
        {
            CStoredProc v_cstore = new CStoredProc("get_chung_chi_het_han_theo_ngach");
            v_cstore.addDatetimeInputParam("@ngay", dateTime);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetSQLInjection(DataSet v_ds, string p)
        {
            CStoredProc v_cstore = new CStoredProc("sqlInjection");
            v_cstore.addNVarcharInputParam("@str_query", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }



        public void FillDatasetChuongTrinhKhung(DataSet v_ds, decimal p)
        {
            CStoredProc v_cstore = new CStoredProc("pr_get_chuong_trinh_hoc_cua_1_nhan_vien");
            v_cstore.addDecimalInputParam("@id_nhan_vien", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void FillLopMonChoNhanVien(DataSet v_ds, decimal p)
        {
            CStoredProc v_cstore = new CStoredProc("get_lop_mon_cua_nhan_vien");
            v_cstore.addDecimalInputParam("@ip_id_nhan_vien", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void FillDatasetLopMonDaCo(DataSet v_ds, decimal id_nhan_vien, decimal id_mon_hoc)
        {
            CStoredProc v_cstore = new CStoredProc("get_lop_mon_da_co");
            v_cstore.addDecimalInputParam("@id_nhan_vien", id_nhan_vien);
            v_cstore.addDecimalInputParam("@id_mon_hoc", id_mon_hoc);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void FillLopMonDangKiThanhCong(DataSet v_ds, decimal p)
        {
            CStoredProc v_cstore = new CStoredProc("get_lop_mon_dang_ki_thanh_cong");
            v_cstore.addDecimalInputParam("@id_nhan_vien", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void FillDatasetForLogin(DataSet v_ds, string ip_str_username)
        {
            CStoredProc v_cstore = new CStoredProc("check_login");
            v_cstore.addNVarcharInputParam("@username", ip_str_username);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetForIDMonHoc(DataSet v_ds, decimal id_mon_hoc, decimal id_nhan_vien)
        {
            CStoredProc v_cstore = new CStoredProc("get_lop_mon_theo_mon_hoc");
            v_cstore.addDecimalInputParam("@id_mon_hoc", id_mon_hoc);
            v_cstore.addDecimalInputParam("@ip_id_nhan_vien", id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillLopMonĐangKy(DataSet v_ds, decimal p)
        {
            CStoredProc v_cstore = new CStoredProc("get_lop_mon_da_dang_ki");
            v_cstore.addDecimalInputParam("@id_nhan_vien", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetGetDai(DataSet v_ds_dai, decimal p, decimal v_id_nghiep_vu)
        {

            CStoredProc v_cstore = new CStoredProc("get_dai_cua_nhan_vien");
            v_cstore.addDecimalInputParam("@id_nhan_vien", p);
            v_cstore.addDecimalInputParam("@id_nghiep_vu", v_id_nghiep_vu);
           
            v_cstore.fillDataSetByCommand(this, v_ds_dai);
        }

        internal void FillDatasetDiemCanCapNhat(DataSet v_ds, decimal id_gd_diem, decimal id_nhan_vien, decimal id_mon_hoc)
        {
            CStoredProc v_cstore = new CStoredProc("pr_cap_nhat_diem_truoc");
            v_cstore.addDecimalInputParam("@id_nhan_vien", id_nhan_vien);
            v_cstore.addDecimalInputParam("@id_gd_diem", id_gd_diem);
            v_cstore.addDecimalInputParam("@id_mon_hoc", id_mon_hoc);

            v_cstore.fillDataSetByCommand(this, v_ds);
        }
    }
}
