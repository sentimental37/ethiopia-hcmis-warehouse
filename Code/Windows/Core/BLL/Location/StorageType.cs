
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;
namespace BLL
{
	///<summary>
	/// Storage type logics are handled here.
	///</summary>
	public class StorageType : _StorageType
    {
        private static DataTable _listOfTypesWithAll = null;
        private static DataTable _primaryStorageTypes = null;
        private static DataTable _allStorageTypes = null;

        #region Enumeration variables this simplifies access
        ///<summary>
        /// returns the id of stack stored store
        ///</summary>
        public static String StackedStorage
        {
            get { return "1"; }
        }
        /// <summary>
        /// Returns the id of cold chain storage type
        /// </summary>
        public static String ColdChain
        {
            get { return "2"; }
        }
        /// <summary>
        /// returns ID low flash point 
        /// </summary>
        public static String LowFlashPoint
        {
            get { return "3"; }
        }
        /// <summary>
        /// returns id of controlled drug storage type
        /// </summary>
        public static String ControlledDrug
        {
            get { return "4"; }
        }
        /// <summary>
        /// returns id of low quantity storage type
        /// </summary>
        public static String LowQuantity
        {
            get { return "5"; }
        }
        /// <summary>
        /// gets id of pick face storage type
        /// </summary>
        public static String PickFace
        {
            get { return "6"; }
        }

        /// <summary>
        /// returns id of quaranteen storage type
        /// </summary>
        public static String Quaranteen
        {
            get { return "7"; }
        }
        /// <summary>
        /// returns id of bulk storage type
        /// </summary>
        public static String BulkStore
        {
            get
            {
                return "8";
            }
        }
        public static string Free { 
            get {
                return "9";
            }
        }
        #endregion
        /// <summary>
        /// returns all storage types including a line that has 'All' as a choice
        /// this is optimized for usage in combo boxes
        /// </summary>
	    public static DataTable StorageTypesWithAll
        {
            get
            {
                if (_listOfTypesWithAll == null)
                {
                    StorageType st = new StorageType();
                    st.LoadAll();
                    st.AddNew();
                    st.StorageTypeName = "All";
                    _listOfTypesWithAll = st.DataTable;
                }
                return _listOfTypesWithAll;
            }
        }

        /// <summary>
        /// Returns list of storage types
        /// </summary>
        public static DataTable AllStorageTypes
        {
            get
            {
                if (_allStorageTypes == null)
                {
                    StorageType st = new StorageType();
                    st.LoadAll();
                    _allStorageTypes = st.DataTable;
                }
                return _allStorageTypes;
            }
        }

        /// <summary>
        ///  returns list of primary storage types
        /// </summary>
        public static DataTable PrimaryStorageTypes
        {
            get
            {
                if (_primaryStorageTypes == null)
                {
                    StorageType st = new StorageType();
                    st.LoadPrimaryStorageTypes();
                    _primaryStorageTypes = st.DataTable;
                }
                return _primaryStorageTypes;
            }
        }

        
        /// <summary>
        /// Loads primary storage types
        /// </summary>
        private void LoadPrimaryStorageTypes()
        {
            this.FlushData();
            //TOFIX: this requires a change in the database but we have to remove the quaranteen from the db than in code like is done down here.
            this.LoadFromRawSql(HCMIS.Repository.Queries.StorageType.SelectLoadPrimaryStorageTypes(StorageType.Quaranteen));
        }

	   


	    /// <summary>
        /// Loads the by physical store ID.
        /// </summary>
        /// <param name="physicalStoreID">The physical store ID.</param>
        public void LoadByPhysicalStoreID(int physicalStoreID)
        {
            string query = HCMIS.Repository.Queries.StorageType.SelectLoadByPhysicalStoreID(physicalStoreID);
            this.LoadFromRawSql(query);
        }

        public void LoadDistictStoreTypeForPhysicalStore(int physicalStoreID)
        {
            string query = HCMIS.Repository.Queries.StorageType.SelectDistictStoreTypeForPhysicalStore(physicalStoreID);
            this.LoadFromRawSql(query);
        }
    }
}