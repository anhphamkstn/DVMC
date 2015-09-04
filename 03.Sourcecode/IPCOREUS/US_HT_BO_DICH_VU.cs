///************************************************
/// Generated by: tuandm
/// Date: 03/09/2015 06:11:46
/// Goal: Create User Service Class for HT_BO_DICH_VU
///************************************************
/// <summary>
/// Create User Service Class for HT_BO_DICH_VU
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_HT_BO_DICH_VU : US_Object
	{
		private const string c_TableName = "HT_BO_DICH_VU";
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

		public decimal dcID_DICH_VU 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DICH_VU", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DICH_VU"] = value;
			}
		}

		public bool IsID_DICH_VUNull()	{
			return pm_objDR.IsNull("ID_DICH_VU");
		}

		public void SetID_DICH_VUNull() {
			pm_objDR["ID_DICH_VU"] = System.Convert.DBNull;
		}

		public decimal dcID_NGUOI_SU_DUNG 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_SU_DUNG", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_NGUOI_SU_DUNG"] = value;
			}
		}

		public bool IsID_NGUOI_SU_DUNGNull()	{
			return pm_objDR.IsNull("ID_NGUOI_SU_DUNG");
		}

		public void SetID_NGUOI_SU_DUNGNull() {
			pm_objDR["ID_NGUOI_SU_DUNG"] = System.Convert.DBNull;
		}

		public decimal dcCAP_SU_DUNG 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "CAP_SU_DUNG", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["CAP_SU_DUNG"] = value;
			}
		}

		public bool IsCAP_SU_DUNGNull()	{
			return pm_objDR.IsNull("CAP_SU_DUNG");
		}

		public void SetCAP_SU_DUNGNull() {
			pm_objDR["CAP_SU_DUNG"] = System.Convert.DBNull;
		}

		public string strTRANG_THAI_HSD 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HSD", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TRANG_THAI_HSD"] = value;
			}
		}

		public bool IsTRANG_THAI_HSDNull() 
		{
			return pm_objDR.IsNull("TRANG_THAI_HSD");
		}

		public void SetTRANG_THAI_HSDNull() {
			pm_objDR["TRANG_THAI_HSD"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_HT_BO_DICH_VU() 
		{
			pm_objDS = new DS_HT_BO_DICH_VU();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_HT_BO_DICH_VU(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_HT_BO_DICH_VU(decimal i_dbID) 
		{
			pm_objDS = new DS_HT_BO_DICH_VU();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion


	}
}