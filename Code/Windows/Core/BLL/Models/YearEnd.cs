
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
    /// <summary>
    /// Year end Inventory Process Logic
    /// </summary>
	public class YearEnd : _YearEnd
	{


        /// <summary>
        /// Loads the by item ID.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        public void LoadByItemID(int itemID)
        {
            this.FlushData();
            this.Where.ItemID.Value = itemID;
            this.Query.Load();
        }

	   
        /// <summary>
        /// checks if balance exists in the Year End table
        /// </summary>
        /// <param name="year"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DoesBalanceExists(int year, int storeId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Query.Load();
            if (this.DataTable.Rows.Count > 0)
                return true;
           
                return false;
        }

        /// <summary>
        /// Get begining balance from the year end table
        /// </summary>
        /// <param name="year"></param>
        /// <param name="storeId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public DataTable GetBalanceByItemId(int year, int storeId,int itemId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Where.ItemID.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.ItemID.Value = itemId;
            this.Query.Load();
            return this.DataTable;
        }



        /// <summary>
        /// Get begining balance by item, store and month
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="storeId">The store id.</param>
        /// <param name="itemId">The item id.</param>
        /// <param name="month">The month.</param>
        /// <returns></returns>
        public Int64 GetBBalance(int year, int storeId, int itemId, int month)
        {
            this.FlushData();
            Int64 bb = 0;
            int bYear = ((month > 10) ? year : year - 1);
            this.LoadFromRawSql(HCMIS.Repository.Queries.YearEnd.SelectGetBBalance(storeId, itemId, bYear));
            if (this.DataTable.Rows.Count > 0)
            {
                bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
            }
            else
            {
                this.LoadFromRawSql(HCMIS.Repository.Queries.YearEnd.SelectGetBBalanceSelectElse(year, storeId, itemId));
                if (this.DataTable.Rows.Count > 0)
                {
                    bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
                }
                else if (((year + 8) > DateTimeHelper.ServerDateTime.Year) || (month > 10 && (year + 8) == DateTimeHelper.ServerDateTime.Year)) // to check if it is different year from current
                {
                    Int64 cons = 0;
                    IssueDoc iss = new IssueDoc();
                    ReceiveDoc rec = new ReceiveDoc();
                    LossAndAdjustment dis = new LossAndAdjustment();
                    if ((year + 8) > DateTimeHelper.ServerDateTime.Year) // to check if it is hamle and Nehase
                        year = year - 1;
                    month = 10;
                    //}

                    long receivedQuantity = rec.GetReceivedQuantityTillMonth(itemId, storeId, month, year);
                    long adjustedQuantity = dis.GetAdjustedQuantityTillMonth(itemId, storeId, month, year);
                    long issuedQuantity = iss.GetIssuedQuantityTillMonth(itemId, storeId, month, year);
                    long lostQuantity = dis.GetLossesQuantityTillMonth(itemId, storeId, month, year);
                    cons = (receivedQuantity + adjustedQuantity - issuedQuantity - lostQuantity);
                    bb = cons;
                }
            }

            return bb;
        }

      


        /// <summary>
        /// Gets year end values by store id and year
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetDocumentByYear(int storeId, string year)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.YearEnd.SelectGetDocumentByYear(storeId, year));
            return this.DataTable;
        }

       

        /// <summary>
        /// Gets distinct years with entry from the year end table
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public DataTable GetDistinctYear(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.YearEnd.SelectGetDistinctYear(storeId));
            return this.DataTable;
        }

      

        /// <summary>
        /// Get all Year end table
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public DataTable GetDocumentAll(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.YearEnd.SelectGetDocumentAll(storeId));
            return this.DataTable;
        }

       

        /// <summary>
        /// Determines whether [is performed for year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is performed for year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPerformedForYear(int year)
        {
            string query = HCMIS.Repository.Queries.YearEnd.SelectIsPerformedForYear(year);
            YearEnd yearend = new YearEnd();
            yearend.LoadFromRawSql(query);
            return (yearend.RowCount > 0);
        }

      

        /// <summary>
        /// Year End without the physical store information
        /// </summary>
        /// <param name="_itemID">The _item ID.</param>
        /// <param name="_storeID">The _store ID.</param>
        /// <param name="_unitID">The _unit ID.</param>
        /// <param name="_endingBal">The _ending bal.</param>
        /// <param name="_physicalInventory">The _physical inventory.</param>
        /// <param name="year">The year.</param>
        public static void AddNewYearEndEntry(int _itemID, int _storeID, int _unitID, long _endingBal, long _physicalInventory, int year)
        {
            BLL.YearEnd yEnd = new YearEnd();
            yEnd.AddNew();
            yEnd.StoreID = _storeID;
            yEnd.ItemID = _itemID;
            yEnd.UnitID = _unitID;
            yEnd.PhysicalInventory = _physicalInventory;
            yEnd.EBalance = _endingBal;
            yEnd.Year = year;
            yEnd.Save();
        }

        /// <summary>
        /// Year End with the physical store information
        /// </summary>
        /// <param name="_itemID">The _item ID.</param>
        /// <param name="_storeID">The _store ID.</param>
        /// <param name="_unitID">The _unit ID.</param>
        /// <param name="_endingBal">The _ending bal.</param>
        /// <param name="_physicalInventory">The _physical inventory.</param>
        /// <param name="year">The year.</param>
        /// <param name="physicalStoreID">The physical store ID.</param>
        public static void AddNewYearEndEntry(int _itemID, int _storeID, int _unitID, long _endingBal, long _physicalInventory, int year, int physicalStoreID)
        {
            BLL.YearEnd yEnd = new YearEnd();
            yEnd.LoadByItemUnitStoreAndPhysicalStore(_itemID, _unitID, _storeID, physicalStoreID, year);
            
            if (yEnd.RowCount == 0)
                yEnd.AddNew();
            yEnd.StoreID = _storeID;
            yEnd.ItemID = _itemID;
            yEnd.UnitID = _unitID;
            yEnd.PhysicalInventory = _physicalInventory;
            yEnd.EBalance = _endingBal;
            yEnd.Year = year;
            yEnd.PhysicalStoreID = physicalStoreID;
            yEnd.Save();
        }

        /// <summary>
        /// Updates the year end value.
        /// </summary>
        /// <param name="yearEndQuantity2">The year end quantity2.</param>
        /// <param name="itemID">The item ID.</param>
        /// <param name="unitID">The unit ID.</param>
        /// <param name="year">The year.</param>
        public static void UpdateYearEndValue(long yearEndQuantity2, int itemID, int unitID,int year)
        {
            string query = HCMIS.Repository.Queries.YearEnd.UpdateUpdateYearEndValue(yearEndQuantity2, itemID, unitID, year);
            BLL.YearEnd ye = new YearEnd();
            ye.LoadFromRawSql(query);
        }

      

        /// <summary>
        /// Gets the items for year end inventory.
        /// </summary>
        /// <param name="storeID">The store ID.</param>
        /// <param name="physicalStoreID">The physical store ID.</param>
        /// <param name="withQtyOnly">if set to <c>true</c> [with qty only].</param>
        /// <returns></returns>
        public DataTable GetItemsForYearEndInventory(int storeID, int physicalStoreID, bool withQtyOnly)
        {
            string query = HCMIS.Repository.Queries.YearEnd.SelectGetItemsForYearEndInventory(storeID, physicalStoreID, withQtyOnly);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

      

        /// <summary>
        /// Gets the items detail location for year end inventory.
        /// </summary>
        /// <param name="storeID">The store ID.</param>
        /// <param name="physicalStoreID">The physical store ID.</param>
        /// <param name="withQtyOnly">if set to <c>true</c> [with qty only].</param>
        /// <returns></returns>
        public DataTable GetItemsDetailLocationForYearEndInventory(int storeID, int physicalStoreID, bool withQtyOnly)
        {
            string query = HCMIS.Repository.Queries.YearEnd.SelectGetItemsDetailLocationForYearEndInventory(storeID,
                                                                                                            physicalStoreID,
                                                                                                            withQtyOnly);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

       


        /// <summary>
        /// Loads the by item unit store and physical store.
        /// </summary>
        /// <param name="itm">The itm.</param>
        /// <param name="unit">The unit.</param>
        /// <param name="storeID">The store ID.</param>
        /// <param name="physicalStoreID">The physical store ID.</param>
        /// <param name="year">The year.</param>
        public void LoadByItemUnitStoreAndPhysicalStore(int itm, int unit, int storeID, int physicalStoreID, int year)
        {
            string query = HCMIS.Repository.Queries.YearEnd.SelectLoadByItemUnitStoreAndPhysicalStore(itm, unit, storeID, physicalStoreID, year);
            this.LoadFromRawSql(query);
        }
	}
}