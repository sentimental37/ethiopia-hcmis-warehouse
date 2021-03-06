
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Collections.Generic;

namespace Proxy
{
	public class DrugSubCategory 
	{
	
	#region Properties
	
		private  int? _ID;
		public  int? ID
	    {
			get
	        {
				return _ID;
			}
			set
	        {
				_ID = value;
			}
		}

		private  int? _CategoryId;
		public  int? CategoryId
	    {
			get
	        {
				return _CategoryId;
			}
			set
	        {
				_CategoryId = value;
			}
		}

		private  string _SubCategoryName;
		public  string SubCategoryName
	    {
			get
	        {
				return _SubCategoryName;
			}
			set
	        {
				_SubCategoryName = value;
			}
		}

		private  string _SubCategoryCode;
		public  string SubCategoryCode
	    {
			get
	        {
				return _SubCategoryCode;
			}
			set
	        {
				_SubCategoryCode = value;
			}
		}

		private  string _Description;
		public  string Description
	    {
			get
	        {
				return _Description;
			}
			set
	        {
				_Description = value;
			}
		}

		private  int? _ParentID;
		public  int? ParentID
	    {
			get
	        {
				return _ParentID;
			}
			set
	        {
				_ParentID = value;
			}
		}

		private  bool? _IsDeleted;
		public  bool? IsDeleted
	    {
			get
	        {
				return _IsDeleted;
			}
			set
	        {
				_IsDeleted = value;
			}
		}

		private  DateTime? _UpdateTime;
		public  DateTime? UpdateTime
	    {
			get
	        {
				return _UpdateTime;
			}
			set
	        {
				_UpdateTime = value;
			}
		}


	#endregion
	
    //#region Web Service Getters
		
    //    public static List<DrugSubCategory> GetAll()
    //    {
    //        BLL.DrugSubCategory v = new BLL.DrugSubCategory();
    //        v.LoadAll();
    //        return ToList(v);
    //    }
		
    //    public static List<DrugSubCategory> GetUpdatesAfter(long? lastVersion,DateTime? lastUpdateTime)
    //    {
    //        BLL.DrugSubCategory v = new BLL.DrugSubCategory();
    //        if(lastVersion.HasValue && lastVersion.Value != 0)
    //        {
    //            v.LoadUpdatesAfter( lastVersion.Value );    
    //        }else if(lastUpdateTime.HasValue)
    //        {
    //            v.LoadUpdatesAfterByTime(lastUpdateTime.Value);
    //        }else
    //        {
    //            v.LoadAll();
    //        }
    //        return ToList(v);
    //    }
		
    //    public static List<int> GetDeletedIDsAfter(long LastVersion)
    //    {
    //         BLL.DrugSubCategory v = new BLL.DrugSubCategory();
    //        v.LoadDeletedIDs(LastVersion);
    //        List<int> list = new List<int>();
    //        while (!v.EOF)
    //        {
    //            list.Add((int)v.GetColumn("ID"));
    //            v.MoveNext();
    //        }
    //        return list;
    //    }
		
    //#endregion
	
	
	
	#region Utilities
	
		
		#endregion
		
		
		#region Web service Saving

        public static void SaveList(List<HCMIS.Desktop.DirectoryServices.DrugSubCategory> list)
        {
            BLL.SubCategory bv = new BLL.SubCategory();
            foreach (HCMIS.Desktop.DirectoryServices.DrugSubCategory v in list)
            {
                // try to load by primary key
                bv.LoadByPrimaryKey(v.ID.Value);

                // if the entry doesn't exist, create it
                if (bv.RowCount == 0)
                {
                    bv.AddNew();
                }
                // populate the contents of v on the to the database list
              if( v.ID.HasValue )
				   bv.ID = v.ID.Value;
              if( v.CategoryId.HasValue )
				   bv.CategoryId = v.CategoryId.Value;
              if( v.SubCategoryName != "" && v.SubCategoryName != null )
				   bv.SubCategoryName = v.SubCategoryName;
              if( v.SubCategoryCode != "" && v.SubCategoryCode != null )
				   bv.SubCategoryCode = v.SubCategoryCode;
              if( v.Description != "" && v.Description != null )
				   bv.Description = v.Description;
              if( v.ParentID.HasValue )
				   bv.ParentID = v.ParentID.Value;
              //if( v.IsDeleted.HasValue )
              //     bv.IsDeleted = v.IsDeleted.Value;
              //if( v.UpdateTime.HasValue )
              //     bv.UpdateTime = v.UpdateTime.Value;

                bv.Save();
            }


        }
	
	public static void DeleteList(List<int> list)
        {
            BLL.SubCategory bv = new BLL.SubCategory();
            foreach (int v in list)
            {
                // try to load by primary key
                bv.LoadByPrimaryKey(v);
                // if the entry doesn't exist, create it
                if (bv.RowCount > 0)
                {
                    bv.MarkAsDeleted();
					bv.Save();
                }
                // populate the contents of v on the to the database list

            }


        }
	
	
	#endregion
	}
}
