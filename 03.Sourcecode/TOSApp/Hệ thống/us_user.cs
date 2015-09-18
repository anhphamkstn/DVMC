///************************************************
/// Generated by: Anhpt
/// Date: 17/08/2015 03:24:31
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
using System.Collections.Generic;


namespace TOSApp
{

	public class us_user
	{
		private const string c_TableName = "HT_NGUOI_SU_DUNG";
		#region Public Properties
		public static decimal dcID ;
        public static decimal dcCHI_NHANH;	
		public static string strTEN_TRUY_CAP ;
		public string strTEN ;
		public static string strMAT_KHAU ;	
		public static string strEMAIL ;
        public static decimal dcIDNhom;
        public static string TD_tu_choi;
        public static List <decimal> m_lst_id_nguoi_xu_ly = new List<decimal>(); 
        public static string GetMD5(string txt)
        {
            string str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (byte tmp in buffer)
            {
                str += tmp.ToString("x2");
            }
            return str;
        }

        public static bool trang_thai_dang_nhap;
		#endregion



	}
}
