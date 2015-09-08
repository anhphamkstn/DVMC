///************************************************
/// Generated by: tuandm
/// Date: 08/09/2015 12:13:42
/// Goal: Create User Service Class for HT_NGUOI_SU_DUNG
///************************************************
/// <summary>
/// Create User Service Class for HT_NGUOI_SU_DUNG
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_HT_NGUOI_SU_DUNG : US_Object
	{
		private const string c_TableName = "HT_NGUOI_SU_DUNG";
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

		public string strTEN_TRUY_CAP 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TEN_TRUY_CAP", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TEN_TRUY_CAP"] = value;
			}
		}

		public bool IsTEN_TRUY_CAPNull() 
		{
			return pm_objDR.IsNull("TEN_TRUY_CAP");
		}

		public void SetTEN_TRUY_CAPNull() {
			pm_objDR["TEN_TRUY_CAP"] = System.Convert.DBNull;
		}

		public string strTEN 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TEN"] = value;
			}
		}

		public bool IsTENNull() 
		{
			return pm_objDR.IsNull("TEN");
		}

		public void SetTENNull() {
			pm_objDR["TEN"] = System.Convert.DBNull;
		}

		public string strMAT_KHAU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MAT_KHAU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MAT_KHAU"] = value;
			}
		}

		public bool IsMAT_KHAUNull() 
		{
			return pm_objDR.IsNull("MAT_KHAU");
		}

		public void SetMAT_KHAUNull() {
			pm_objDR["MAT_KHAU"] = System.Convert.DBNull;
		}

		public DateTime datNGAY_TAO
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "NGAY_TAO", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["NGAY_TAO"] = value;
			}
		}

		public bool IsNGAY_TAONull()
		{
			return pm_objDR.IsNull("NGAY_TAO");
		}

		public void SetNGAY_TAONull()
		{
			pm_objDR["NGAY_TAO"] = System.Convert.DBNull;
		}

		public string strNGUOI_TAO 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NGUOI_TAO", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NGUOI_TAO"] = value;
			}
		}

		public bool IsNGUOI_TAONull() 
		{
			return pm_objDR.IsNull("NGUOI_TAO");
		}

		public void SetNGUOI_TAONull() {
			pm_objDR["NGUOI_TAO"] = System.Convert.DBNull;
		}

		public string strTRANG_THAI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TRANG_THAI"] = value;
			}
		}

		public bool IsTRANG_THAINull() 
		{
			return pm_objDR.IsNull("TRANG_THAI");
		}

		public void SetTRANG_THAINull() {
			pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
		}

		public string strEMAIL 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "EMAIL", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["EMAIL"] = value;
			}
		}

		public bool IsEMAILNull() 
		{
			return pm_objDR.IsNull("EMAIL");
		}

		public void SetEMAILNull() {
			pm_objDR["EMAIL"] = System.Convert.DBNull;
		}

		public string strMAT_KHAU_EMAIL 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MAT_KHAU_EMAIL", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MAT_KHAU_EMAIL"] = value;
			}
		}

		public bool IsMAT_KHAU_EMAILNull() 
		{
			return pm_objDR.IsNull("MAT_KHAU_EMAIL");
		}

		public void SetMAT_KHAU_EMAILNull() {
			pm_objDR["MAT_KHAU_EMAIL"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_HT_NGUOI_SU_DUNG() 
		{
			pm_objDS = new DS_HT_NGUOI_SU_DUNG();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_HT_NGUOI_SU_DUNG(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_HT_NGUOI_SU_DUNG(decimal i_dbID) 
		{
			pm_objDS = new DS_HT_NGUOI_SU_DUNG();
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
