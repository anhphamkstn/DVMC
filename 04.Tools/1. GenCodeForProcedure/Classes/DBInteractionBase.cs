////////////////////////////////////////////////////////////////////////////////
// Description: Base class for Database Interaction.                       
// Generated by LLBLGen v1.21.2003.712 Final on: Friday, May 22, 2015, 20:40:30
// Because this class implements IDisposable, derived classes shouldn't do so.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DVMCLLBL
{
	/// <summary>
	/// Purpose: Error Enums used by this LLBL library.
	/// </summary>
	public enum LLBLError
	{
		AllOk
		// Add more here (check the comma's!)
	}


	/// <summary>
	/// Purpose: General interface of the API generated. Contains only common methods of all classes.
	/// </summary>
	public interface ICommonDBAccess
	{
		bool		Insert();
		bool		Update();
		bool		Delete();
		DataTable	SelectOne();
		DataTable	SelectAll();
	}


	/// <summary>
	/// Purpose: Abstract base class for Database Interaction classes.
	/// </summary>
	public abstract class DBInteractionBase : IDisposable, ICommonDBAccess
	{
		#region Class Member Declarations
			protected	SqlConnection			_mainConnection;
			protected	int						_rowsAffected;
			private		bool					_isDisposed;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DBInteractionBase()
		{
			// Initialize the class' members.
			InitClass();
		}


		/// <summary>
		/// Purpose: Initializes class members.
		/// </summary>
		private void InitClass()
		{
			// create all the objects and initialize other members.
			_mainConnection = new SqlConnection();
			AppSettingsReader _configReader = new AppSettingsReader();

			// Set connection string of the sqlconnection object
			_mainConnection.ConnectionString = 
						_configReader.GetValue("Main.ConnectionString", typeof(string)).ToString();
			_isDisposed = false;
		}


		/// <summary>
		/// Purpose: Implements the IDispose' method Dispose.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}


		/// <summary>
		/// Purpose: Implements the Dispose functionality.
		/// </summary>
		protected virtual void Dispose(bool isDisposing)
		{
			// Check to see if Dispose has already been called.
			if(!_isDisposed)
			{
				if(isDisposing)
				{
					// Dispose managed resources.
					_mainConnection.Dispose();
					_mainConnection = null;
				}
			}
			_isDisposed = true;
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.Insert() method.
		/// </summary>
		public virtual bool Insert()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.Delete() method.
		/// </summary>
		public virtual bool Delete()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.Update() method.
		/// </summary>
		public virtual bool Update()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.SelectOne() method.
		/// </summary>
		public virtual DataTable SelectOne()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.SelectAll() method.
		/// </summary>
		public virtual DataTable SelectAll()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		#region Class Property Declarations
		public int RowsAffected
		{
			get
			{
				return _rowsAffected;
			}
		}
		#endregion
	}
}
