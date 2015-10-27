
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
	public abstract class _DirectoryUpdates : SqlClientEntity
	{
		public _DirectoryUpdates()
		{
			this.QuerySource = "DirectoryUpdates";
			this.MappingName = "DirectoryUpdates";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DirectoryUpdatesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(string ServiceName)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ServiceName, ServiceName);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DirectoryUpdatesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ServiceName
			{
				get
				{
					return new SqlParameter("@ServiceName", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter LastCalled
			{
				get
				{
					return new SqlParameter("@LastCalled", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ServiceName = "ServiceName";
            public const string LastCalled = "LastCalled";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ServiceName] = _DirectoryUpdates.PropertyNames.ServiceName;
					ht[LastCalled] = _DirectoryUpdates.PropertyNames.LastCalled;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ServiceName = "ServiceName";
            public const string LastCalled = "LastCalled";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ServiceName] = _DirectoryUpdates.ColumnNames.ServiceName;
					ht[LastCalled] = _DirectoryUpdates.ColumnNames.LastCalled;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ServiceName = "s_ServiceName";
            public const string LastCalled = "s_LastCalled";

		}
		#endregion		
		
		#region Properties
	
		public virtual string ServiceName
	    {
			get
	        {
				return base.Getstring(ColumnNames.ServiceName);
			}
			set
	        {
				base.Setstring(ColumnNames.ServiceName, value);
			}
		}

		public virtual DateTime LastCalled
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.LastCalled);
			}
			set
	        {
				base.SetDateTime(ColumnNames.LastCalled, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ServiceName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ServiceName) ? string.Empty : base.GetstringAsString(ColumnNames.ServiceName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ServiceName);
				else
					this.ServiceName = base.SetstringAsString(ColumnNames.ServiceName, value);
			}
		}

		public virtual string s_LastCalled
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastCalled) ? string.Empty : base.GetDateTimeAsString(ColumnNames.LastCalled);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastCalled);
				else
					this.LastCalled = base.SetDateTimeAsString(ColumnNames.LastCalled, value);
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
				
				
				public WhereParameter ServiceName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ServiceName, Parameters.ServiceName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LastCalled
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastCalled, Parameters.LastCalled);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ServiceName
		    {
				get
		        {
					if(_ServiceName_W == null)
	        	    {
						_ServiceName_W = TearOff.ServiceName;
					}
					return _ServiceName_W;
				}
			}

			public WhereParameter LastCalled
		    {
				get
		        {
					if(_LastCalled_W == null)
	        	    {
						_LastCalled_W = TearOff.LastCalled;
					}
					return _LastCalled_W;
				}
			}

			private WhereParameter _ServiceName_W = null;
			private WhereParameter _LastCalled_W = null;

			public void WhereClauseReset()
			{
				_ServiceName_W = null;
				_LastCalled_W = null;

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
				
				
				public AggregateParameter ServiceName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ServiceName, Parameters.ServiceName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LastCalled
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastCalled, Parameters.LastCalled);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ServiceName
		    {
				get
		        {
					if(_ServiceName_W == null)
	        	    {
						_ServiceName_W = TearOff.ServiceName;
					}
					return _ServiceName_W;
				}
			}

			public AggregateParameter LastCalled
		    {
				get
		        {
					if(_LastCalled_W == null)
	        	    {
						_LastCalled_W = TearOff.LastCalled;
					}
					return _LastCalled_W;
				}
			}

			private AggregateParameter _ServiceName_W = null;
			private AggregateParameter _LastCalled_W = null;

			public void AggregateClauseReset()
			{
				_ServiceName_W = null;
				_LastCalled_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DirectoryUpdatesInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DirectoryUpdatesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DirectoryUpdatesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ServiceName);
			p.SourceColumn = ColumnNames.ServiceName;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ServiceName);
			p.SourceColumn = ColumnNames.ServiceName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastCalled);
			p.SourceColumn = ColumnNames.LastCalled;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}