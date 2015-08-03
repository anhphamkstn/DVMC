///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:36:53
/// Goal: Create User Service Class for HT_BUSINESS_PROCESS_LOCK
///************************************************
/// <summary>
/// Create User Service Class for HT_BUSINESS_PROCESS_LOCK
/// </summary>


using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace IPCOREUS
{

public class US_HT_BUSINESS_PROCESS_LOCK : US_Object
{
	private const string c_TableName = "HT_BUSINESS_PROCESS_LOCK";
#region "Public Properties"
	public string strLOCK_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOCK_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOCK_NAME"] = value;
		}
	}

	public bool IsLOCK_NAMENull() 
	{
		return pm_objDR.IsNull("LOCK_NAME");
	}

	public void SetLOCK_NAMENull() {
		pm_objDR["LOCK_NAME"] = System.Convert.DBNull;
	}

	public DateTime datGRANTED_SYS_DATETIME
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "GRANTED_SYS_DATETIME", IPConstants.c_DefaultDate);
		}
		set   
		{
            DateTime v_dt = value;
			pm_objDR["GRANTED_SYS_DATETIME"] = v_dt.Date;
		}
	}

	public bool IsGRANTED_SYS_DATETIMENull()
	{
		return pm_objDR.IsNull("GRANTED_SYS_DATETIME");
	}

	public void SetGRANTED_SYS_DATETIMENull()
	{
		pm_objDR["GRANTED_SYS_DATETIME"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_HT_BUSINESS_PROCESS_LOCK() 
	{
		pm_objDS = new DS_HT_BUSINESS_PROCESS_LOCK();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_HT_BUSINESS_PROCESS_LOCK(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_HT_BUSINESS_PROCESS_LOCK(decimal i_dbID) 
	{
		pm_objDS = new DS_HT_BUSINESS_PROCESS_LOCK();
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
