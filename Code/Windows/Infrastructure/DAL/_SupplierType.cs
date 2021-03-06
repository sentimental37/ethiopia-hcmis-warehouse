
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
	public abstract class _SupplierType : SqlClientEntity
	{
		public _SupplierType()
		{
            this.SchemaTableView = "Commodity].[";
			this.QuerySource = "SupplierType";
			this.MappingName = "SupplierType";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SupplierTypeLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int SupplierTypeID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.SupplierTypeID, SupplierTypeID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SupplierTypeLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter SupplierTypeID
			{
				get
				{
					return new SqlParameter("@SupplierTypeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 100);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.NVarChar, 400);
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
			
			public static SqlParameter SupplierTypeCode
			{
				get
				{
					return new SqlParameter("@SupplierTypeCode", SqlDbType.NVarChar, 5);
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string SupplierTypeID = "SupplierTypeID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "rowguid";
            public const string SupplierTypeCode = "SupplierTypeCode";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[SupplierTypeID] = _SupplierType.PropertyNames.SupplierTypeID;
					ht[Name] = _SupplierType.PropertyNames.Name;
					ht[Description] = _SupplierType.PropertyNames.Description;
					ht[IsActive] = _SupplierType.PropertyNames.IsActive;
					ht[Rowguid] = _SupplierType.PropertyNames.Rowguid;
					ht[SupplierTypeCode] = _SupplierType.PropertyNames.SupplierTypeCode;
					ht[CreatedDate] = _SupplierType.PropertyNames.CreatedDate;
					ht[ModifiedDate] = _SupplierType.PropertyNames.ModifiedDate;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string SupplierTypeID = "SupplierTypeID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "Rowguid";
            public const string SupplierTypeCode = "SupplierTypeCode";
            public const string CreatedDate = "CreatedDate";
            public const string ModifiedDate = "ModifiedDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[SupplierTypeID] = _SupplierType.ColumnNames.SupplierTypeID;
					ht[Name] = _SupplierType.ColumnNames.Name;
					ht[Description] = _SupplierType.ColumnNames.Description;
					ht[IsActive] = _SupplierType.ColumnNames.IsActive;
					ht[Rowguid] = _SupplierType.ColumnNames.Rowguid;
					ht[SupplierTypeCode] = _SupplierType.ColumnNames.SupplierTypeCode;
					ht[CreatedDate] = _SupplierType.ColumnNames.CreatedDate;
					ht[ModifiedDate] = _SupplierType.ColumnNames.ModifiedDate;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string SupplierTypeID = "s_SupplierTypeID";
            public const string Name = "s_Name";
            public const string Description = "s_Description";
            public const string IsActive = "s_IsActive";
            public const string Rowguid = "s_Rowguid";
            public const string SupplierTypeCode = "s_SupplierTypeCode";
            public const string CreatedDate = "s_CreatedDate";
            public const string ModifiedDate = "s_ModifiedDate";

		}
		#endregion		
		
		#region Properties
	
		public virtual int SupplierTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.SupplierTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.SupplierTypeID, value);
			}
		}

		public virtual string Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Name, value);
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

		public virtual string SupplierTypeCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.SupplierTypeCode);
			}
			set
	        {
				base.Setstring(ColumnNames.SupplierTypeCode, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_SupplierTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SupplierTypeID) ? string.Empty : base.GetintAsString(ColumnNames.SupplierTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SupplierTypeID);
				else
					this.SupplierTypeID = base.SetintAsString(ColumnNames.SupplierTypeID, value);
			}
		}

		public virtual string s_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Name);
				else
					this.Name = base.SetstringAsString(ColumnNames.Name, value);
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

		public virtual string s_SupplierTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SupplierTypeCode) ? string.Empty : base.GetstringAsString(ColumnNames.SupplierTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SupplierTypeCode);
				else
					this.SupplierTypeCode = base.SetstringAsString(ColumnNames.SupplierTypeCode, value);
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
				
				
				public WhereParameter SupplierTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SupplierTypeID, Parameters.SupplierTypeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
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

				public WhereParameter SupplierTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SupplierTypeCode, Parameters.SupplierTypeCode);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter SupplierTypeID
		    {
				get
		        {
					if(_SupplierTypeID_W == null)
	        	    {
						_SupplierTypeID_W = TearOff.SupplierTypeID;
					}
					return _SupplierTypeID_W;
				}
			}

			public WhereParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
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

			public WhereParameter SupplierTypeCode
		    {
				get
		        {
					if(_SupplierTypeCode_W == null)
	        	    {
						_SupplierTypeCode_W = TearOff.SupplierTypeCode;
					}
					return _SupplierTypeCode_W;
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

			private WhereParameter _SupplierTypeID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _IsActive_W = null;
			private WhereParameter _Rowguid_W = null;
			private WhereParameter _SupplierTypeCode_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _ModifiedDate_W = null;

			public void WhereClauseReset()
			{
				_SupplierTypeID_W = null;
				_Name_W = null;
				_Description_W = null;
				_IsActive_W = null;
				_Rowguid_W = null;
				_SupplierTypeCode_W = null;
				_CreatedDate_W = null;
				_ModifiedDate_W = null;

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
				
				
				public AggregateParameter SupplierTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SupplierTypeID, Parameters.SupplierTypeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
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

				public AggregateParameter SupplierTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SupplierTypeCode, Parameters.SupplierTypeCode);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter SupplierTypeID
		    {
				get
		        {
					if(_SupplierTypeID_W == null)
	        	    {
						_SupplierTypeID_W = TearOff.SupplierTypeID;
					}
					return _SupplierTypeID_W;
				}
			}

			public AggregateParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
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

			public AggregateParameter SupplierTypeCode
		    {
				get
		        {
					if(_SupplierTypeCode_W == null)
	        	    {
						_SupplierTypeCode_W = TearOff.SupplierTypeCode;
					}
					return _SupplierTypeCode_W;
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

			private AggregateParameter _SupplierTypeID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _IsActive_W = null;
			private AggregateParameter _Rowguid_W = null;
			private AggregateParameter _SupplierTypeCode_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _ModifiedDate_W = null;

			public void AggregateClauseReset()
			{
				_SupplierTypeID_W = null;
				_Name_W = null;
				_Description_W = null;
				_IsActive_W = null;
				_Rowguid_W = null;
				_SupplierTypeCode_W = null;
				_CreatedDate_W = null;
				_ModifiedDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplierTypeInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.SupplierTypeID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplierTypeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplierTypeDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.SupplierTypeID);
			p.SourceColumn = ColumnNames.SupplierTypeID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.SupplierTypeID);
			p.SourceColumn = ColumnNames.SupplierTypeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
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

			p = cmd.Parameters.Add(Parameters.SupplierTypeCode);
			p.SourceColumn = ColumnNames.SupplierTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedDate);
			p.SourceColumn = ColumnNames.ModifiedDate;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
