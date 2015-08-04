///************************************************
/// Generated by: LinhDH
/// Date: 21/03/2014 12:30:46
/// Goal: Create User Service Class for V_GD_LICH_GOI_NOI_BO
///************************************************
/// <summary>
/// Create User Service Class for V_GD_LICH_GOI_NOI_BO
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_V_GD_LICH_GOI_NOI_BO : US_Object
	{
		private const string c_TableName = "V_GD_LICH_GOI_NOI_BO";
		#region Public Properties
		public decimal dcID 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID"] = value;
			}
		}

		public bool IsIDNull()	{
			return pm_objDR.IsNull("ID");
		}

		public void SetIDNull() {
			pm_objDR["ID"] = System.Convert.DBNull;
		}

		public decimal dcID_CAU_HOI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_CAU_HOI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_CAU_HOI"] = value;
			}
		}

		public bool IsID_CAU_HOINull()	{
			return pm_objDR.IsNull("ID_CAU_HOI");
		}

		public void SetID_CAU_HOINull() {
			pm_objDR["ID_CAU_HOI"] = System.Convert.DBNull;
		}

		public decimal dcID_CUOC_GOI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_CUOC_GOI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_CUOC_GOI"] = value;
			}
		}

		public bool IsID_CUOC_GOINull()	{
			return pm_objDR.IsNull("ID_CUOC_GOI");
		}

		public void SetID_CUOC_GOINull() {
			pm_objDR["ID_CUOC_GOI"] = System.Convert.DBNull;
		}

		public decimal dcID_NGUOI_LIEN_QUAN 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LIEN_QUAN", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_NGUOI_LIEN_QUAN"] = value;
			}
		}

		public bool IsID_NGUOI_LIEN_QUANNull()	{
			return pm_objDR.IsNull("ID_NGUOI_LIEN_QUAN");
		}

		public void SetID_NGUOI_LIEN_QUANNull() {
			pm_objDR["ID_NGUOI_LIEN_QUAN"] = System.Convert.DBNull;
		}

		public string strNDD_HO_TEN 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NDD_HO_TEN", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NDD_HO_TEN"] = value;
			}
		}

		public bool IsNDD_HO_TENNull() 
		{
			return pm_objDR.IsNull("NDD_HO_TEN");
		}

		public void SetNDD_HO_TENNull() {
			pm_objDR["NDD_HO_TEN"] = System.Convert.DBNull;
		}

		public string strSO_DIEN_THOAI_GOI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "SO_DIEN_THOAI_GOI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["SO_DIEN_THOAI_GOI"] = value;
			}
		}

		public bool IsSO_DIEN_THOAI_GOINull() 
		{
			return pm_objDR.IsNull("SO_DIEN_THOAI_GOI");
		}

		public void SetSO_DIEN_THOAI_GOINull() {
			pm_objDR["SO_DIEN_THOAI_GOI"] = System.Convert.DBNull;
		}

		public string strDUNG_SO_KHAC_YN 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "DUNG_SO_KHAC_YN", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["DUNG_SO_KHAC_YN"] = value;
			}
		}

		public bool IsDUNG_SO_KHAC_YNNull() 
		{
			return pm_objDR.IsNull("DUNG_SO_KHAC_YN");
		}

		public void SetDUNG_SO_KHAC_YNNull() {
			pm_objDR["DUNG_SO_KHAC_YN"] = System.Convert.DBNull;
		}

		public string strNOI_DUNG_TRAO_DOI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NOI_DUNG_TRAO_DOI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NOI_DUNG_TRAO_DOI"] = value;
			}
		}

		public bool IsNOI_DUNG_TRAO_DOINull() 
		{
			return pm_objDR.IsNull("NOI_DUNG_TRAO_DOI");
		}

		public void SetNOI_DUNG_TRAO_DOINull() {
			pm_objDR["NOI_DUNG_TRAO_DOI"] = System.Convert.DBNull;
		}

		public DateTime datDATETIME_RESPOND
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "DATETIME_RESPOND", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["DATETIME_RESPOND"] = value;
			}
		}

		public bool IsDATETIME_RESPONDNull()
		{
			return pm_objDR.IsNull("DATETIME_RESPOND");
		}

		public void SetDATETIME_RESPONDNull()
		{
			pm_objDR["DATETIME_RESPOND"] = System.Convert.DBNull;
		}

		public string strDON_VI_LIEN_QUAN 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "DON_VI_LIEN_QUAN", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["DON_VI_LIEN_QUAN"] = value;
			}
		}

		public bool IsDON_VI_LIEN_QUANNull() 
		{
			return pm_objDR.IsNull("DON_VI_LIEN_QUAN");
		}

		public void SetDON_VI_LIEN_QUANNull() {
			pm_objDR["DON_VI_LIEN_QUAN"] = System.Convert.DBNull;
		}

        public string strVOICE_CALL_LINK
		{
			get 
			{
                return CNull.RowNVLString(pm_objDR, "VOICE_CALL_LINK", IPConstants.c_DefaultString);
			}
			set 
			{
                pm_objDR["VOICE_CALL_LINK"] = value;
			}
		}

        public bool IsVOICE_CALL_LINKNull() 
		{
            return pm_objDR.IsNull("VOICE_CALL_LINK");
		}

        public void SetVOICE_CALL_LINKNull()
        {
            pm_objDR["VOICE_CALL_LINK"] = System.Convert.DBNull;
		}
		#endregion


		#region Init Functions
		public US_V_GD_LICH_GOI_NOI_BO() 
		{
			pm_objDS = new DS_V_GD_LICH_GOI_NOI_BO();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_V_GD_LICH_GOI_NOI_BO(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_V_GD_LICH_GOI_NOI_BO(decimal i_dbID) 
		{
			pm_objDS = new DS_V_GD_LICH_GOI_NOI_BO();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion

        #region Additional Function
        public void load_ds_xu_ly_noi_bo_cau_hoi(DS_V_GD_LICH_GOI_NOI_BO op_ds, decimal ip_dc_id_cau_hoi)
        {
            CStoredProc v_cstore = new CStoredProc("pr_V_GD_LICH_GOI_NOI_BO_Load_ds_xu_ly_by_cau_hoi");

            v_cstore.addDecimalInputParam("@ID_CAU_HOI", ip_dc_id_cau_hoi);

            v_cstore.fillDataSetByCommand(this, op_ds);
        }
        #endregion
    }
}
