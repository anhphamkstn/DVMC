///************************************************
/// Generated by: NinhVH
/// Date: 26/11/2012 03:27:45
/// Goal: Create User Service Class for HT_PHAN_QUYEN_HE_THONG
///************************************************
/// <summary>
/// Create User Service Class for HT_PHAN_QUYEN_HE_THONG
/// </summary>


using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace IPCOREUS
{

    public class US_HT_PHAN_QUYEN_HE_THONG : US_Object
    {
        private const string c_TableName = "HT_PHAN_QUYEN_HE_THONG";
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

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_PHAN_QUYEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_PHAN_QUYEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_PHAN_QUYEN"] = value;
            }
        }

        public bool IsMA_PHAN_QUYENNull()
        {
            return pm_objDR.IsNull("MA_PHAN_QUYEN");
        }

        public void SetMA_PHAN_QUYENNull()
        {
            pm_objDR["MA_PHAN_QUYEN"] = System.Convert.DBNull;
        }

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        public string strLOAI_PHAN_QUYEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_PHAN_QUYEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_PHAN_QUYEN"] = value;
            }
        }

        public bool IsLOAI_PHAN_QUYENNull()
        {
            return pm_objDR.IsNull("LOAI_PHAN_QUYEN");
        }

        public void SetLOAI_PHAN_QUYENNull()
        {
            pm_objDR["LOAI_PHAN_QUYEN"] = System.Convert.DBNull;
        }

        #endregion


        #region Init Functions
        public US_HT_PHAN_QUYEN_HE_THONG()
        {
            pm_objDS = new DS_HT_PHAN_QUYEN_HE_THONG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_HT_PHAN_QUYEN_HE_THONG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_HT_PHAN_QUYEN_HE_THONG(decimal i_dbID)
        {
            pm_objDS = new DS_HT_PHAN_QUYEN_HE_THONG();
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
