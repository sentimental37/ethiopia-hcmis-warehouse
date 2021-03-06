
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.2.0.7)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _Mode : SqlClientEntity
	{
		public _Mode()
		{
			this.QuerySource = "Mode";
			this.MappingName = "Mode";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ModeLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ModeLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TypeName
			{
				get
				{
					return new SqlParameter("@TypeName", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter IsActive
			{
				get
				{
					return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter Rowguid
			{
				get
				{
					return new SqlParameter("@Rowguid", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter CreatedDate
			{
				get
				{
					return new SqlParameter("@CreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifiedDate
			{
				get
				{
					return new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifiedBy
			{
				get
				{
					return new SqlParameter("@ModifiedBy", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter ModeCode
			{
				get
				{
					return new SqlParameter("@ModeCode", SqlDbType.NVarChar, 5);
				}
			}
			
			public static SqlParameter SN
			{
				get
				{
					return new SqlParameter("@SN", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string TypeName = "TypeName";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "rowguid";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string ModifiedBy = "ModifiedBy";
            public const string ModeCode = "ModeCode";
            public const string SN = "SN";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Mode.PropertyNames.ID;
					ht[TypeName] = _Mode.PropertyNames.TypeName;
					ht[Description] = _Mode.PropertyNames.Description;
					ht[IsActive] = _Mode.PropertyNames.IsActive;
					ht[Rowguid] = _Mode.PropertyNames.Rowguid;
					ht[CreatedDate] = _Mode.PropertyNames.CreatedDate;
					ht[ModifiedDate] = _Mode.PropertyNames.ModifiedDate;
					ht[ModifiedBy] = _Mode.PropertyNames.ModifiedBy;
					ht[ModeCode] = _Mode.PropertyNames.ModeCode;
					ht[SN] = _Mode.PropertyNames.SN;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string TypeName = "TypeName";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "Rowguid";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";
            public const string ModifiedBy = "ModifiedBy";
            public const string ModeCode = "ModeCode";
            public const string SN = "SN";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Mode.ColumnNames.ID;
					ht[TypeName] = _Mode.ColumnNames.TypeName;
					ht[Description] = _Mode.ColumnNames.Description;
					ht[IsActive] = _Mode.ColumnNames.IsActive;
					ht[Rowguid] = _Mode.ColumnNames.Rowguid;
					ht[CreatedDate] = _Mode.ColumnNames.CreatedDate;
					ht[ModifiedDate] = _Mode.ColumnNames.ModifiedDate;
					ht[ModifiedBy] = _Mode.ColumnNames.ModifiedBy;
					ht[ModeCode] = _Mode.ColumnNames.ModeCode;
					ht[SN] = _Mode.ColumnNames.SN;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string TypeName = "s_TypeName";
            public const string Description = "s_Description";
            public const string IsActive = "s_IsActive";
            public const string Rowguid = "s_Rowguid";
            public const string CreatedDate = "s_CreatedDate";
            public const string ModifiedDate = "s_ModifiedDate";
            public const string ModifiedBy = "s_ModifiedBy";
            public const string ModeCode = "s_ModeCode";
            public const string SN = "s_SN";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual string TypeName
	    {
			get
	        {
				return base.Getstring(ColumnNames.TypeName);
			}
			set
	        {
				base.Setstring(ColumnNames.TypeName, value);
			}
		}

		public virtual string Description
	    {
			get
	        {
				return base.Getstring(ColumnNames.Description);
			}
			set
	        {
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual bool IsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsActive, value);
			}
		}

		public virtual Guid Rowguid
	    {
			get
	        {
				return base.GetGuid(ColumnNames.Rowguid);
			}
			set
	        {
				base.SetGuid(ColumnNames.Rowguid, value);
			}
		}

		public virtual DateTime CreatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreatedDate, value);
			}
		}

		public virtual DateTime ModifiedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ModifiedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ModifiedDate, value);
			}
		}

		public virtual string ModifiedBy
	    {
			get
	        {
				return base.Getstring(ColumnNames.ModifiedBy);
			}
			set
	        {
				base.Setstring(ColumnNames.ModifiedBy, value);
			}
		}

		public virtual string ModeCode
	    {
			get
			{
			    return base.Getstring(ColumnNames.ModeCode);
			}
			set
	        {
				base.Setstring(ColumnNames.ModeCode, value);
			}
		}

		public virtual int SN
	    {
			get
	        {
				return base.Getint(ColumnNames.SN);
			}
			set
	        {
				base.Setint(ColumnNames.SN, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_TypeName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TypeName) ? string.Empty : base.GetstringAsString(ColumnNames.TypeName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TypeName);
				else
					this.TypeName = base.SetstringAsString(ColumnNames.TypeName, value);
			}
		}

		public virtual string s_Description
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_IsActive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsActive) ? string.Empty : base.GetboolAsString(ColumnNames.IsActive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsActive);
				else
					this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
			}
		}

		public virtual string s_Rowguid
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Rowguid) ? string.Empty : base.GetGuidAsString(ColumnNames.Rowguid);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Rowguid);
				else
					this.Rowguid = base.SetGuidAsString(ColumnNames.Rowguid, value);
			}
		}

		public virtual string s_CreatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedDate);
				else
					this.CreatedDate = base.SetDateTimeAsString(ColumnNames.CreatedDate, value);
			}
		}

		public virtual string s_ModifiedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ModifiedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedDate);
				else
					this.ModifiedDate = base.SetDateTimeAsString(ColumnNames.ModifiedDate, value);
			}
		}

		public virtual string s_ModifiedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedBy) ? string.Empty : base.GetstringAsString(ColumnNames.ModifiedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedBy);
				else
					this.ModifiedBy = base.SetstringAsString(ColumnNames.ModifiedBy, value);
			}
		}

		public virtual string s_ModeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModeCode) ? string.Empty : base.GetstringAsString(ColumnNames.ModeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModeCode);
				else
					this.ModeCode = base.SetstringAsString(ColumnNames.ModeCode, value);
			}
		}

		public virtual string s_SN
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SN) ? string.Empty : base.GetintAsString(ColumnNames.SN);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SN);
				else
					this.SN = base.SetintAsString(ColumnNames.SN, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TypeName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TypeName, Parameters.TypeName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Rowguid
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Rowguid, Parameters.Rowguid);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedDate, Parameters.ModifiedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModeCode, Parameters.ModeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SN
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SN, Parameters.SN);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter TypeName
		    {
				get
		        {
					if(_TypeName_W == null)
	        	    {
						_TypeName_W = TearOff.TypeName;
					}
					return _TypeName_W;
				}
			}

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			public WhereParameter Rowguid
		    {
				get
		        {
					if(_Rowguid_W == null)
	        	    {
						_Rowguid_W = TearOff.Rowguid;
					}
					return _Rowguid_W;
				}
			}

			public WhereParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			public WhereParameter ModifiedDate
		    {
				get
		        {
					if(_ModifiedDate_W == null)
	        	    {
						_ModifiedDate_W = TearOff.ModifiedDate;
					}
					return _ModifiedDate_W;
				}
			}

			public WhereParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			public WhereParameter ModeCode
		    {
				get
		        {
					if(_ModeCode_W == null)
	        	    {
						_ModeCode_W = TearOff.ModeCode;
					}
					return _ModeCode_W;
				}
			}

			public WhereParameter SN
		    {
				get
		        {
					if(_SN_W == null)
	        	    {
						_SN_W = TearOff.SN;
					}
					return _SN_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _TypeName_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _IsActive_W = null;
			private WhereParameter _Rowguid_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _ModifiedDate_W = null;
			private WhereParameter _ModifiedBy_W = null;
			private WhereParameter _ModeCode_W = null;
			private WhereParameter _SN_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_TypeName_W = null;
				_Description_W = null;
				_IsActive_W = null;
				_Rowguid_W = null;
				_CreatedDate_W = null;
				_ModifiedDate_W = null;
				_ModifiedBy_W = null;
				_ModeCode_W = null;
				_SN_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TypeName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TypeName, Parameters.TypeName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Rowguid
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rowguid, Parameters.Rowguid);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedDate, Parameters.ModifiedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModeCode, Parameters.ModeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SN
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SN, Parameters.SN);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter TypeName
		    {
				get
		        {
					if(_TypeName_W == null)
	        	    {
						_TypeName_W = TearOff.TypeName;
					}
					return _TypeName_W;
				}
			}

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			public AggregateParameter Rowguid
		    {
				get
		        {
					if(_Rowguid_W == null)
	        	    {
						_Rowguid_W = TearOff.Rowguid;
					}
					return _Rowguid_W;
				}
			}

			public AggregateParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			public AggregateParameter ModifiedDate
		    {
				get
		        {
					if(_ModifiedDate_W == null)
	        	    {
						_ModifiedDate_W = TearOff.ModifiedDate;
					}
					return _ModifiedDate_W;
				}
			}

			public AggregateParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			public AggregateParameter ModeCode
		    {
				get
		        {
					if(_ModeCode_W == null)
	        	    {
						_ModeCode_W = TearOff.ModeCode;
					}
					return _ModeCode_W;
				}
			}

			public AggregateParameter SN
		    {
				get
		        {
					if(_SN_W == null)
	        	    {
						_SN_W = TearOff.SN;
					}
					return _SN_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _TypeName_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _IsActive_W = null;
			private AggregateParameter _Rowguid_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _ModifiedDate_W = null;
			private AggregateParameter _ModifiedBy_W = null;
			private AggregateParameter _ModeCode_W = null;
			private AggregateParameter _SN_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_TypeName_W = null;
				_Description_W = null;
				_IsActive_W = null;
				_Rowguid_W = null;
				_CreatedDate_W = null;
				_ModifiedDate_W = null;
				_ModifiedBy_W = null;
				_ModeCode_W = null;
				_SN_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ModeInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ModeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ModeDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TypeName);
			p.SourceColumn = ColumnNames.TypeName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsActive);
			p.SourceColumn = ColumnNames.IsActive;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Rowguid);
			p.SourceColumn = ColumnNames.Rowguid;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedDate);
			p.SourceColumn = ColumnNames.ModifiedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedBy);
			p.SourceColumn = ColumnNames.ModifiedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModeCode);
			p.SourceColumn = ColumnNames.ModeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SN);
			p.SourceColumn = ColumnNames.SN;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
