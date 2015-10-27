
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;
using MyGeneration.dOOdads;

namespace BLL
{
	public class ReceivePallet : _ReceivePallet
	{

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <value>
        /// The current data row.
        /// </value>
		public DataRow CurrentDataRow
		{
			get
			{
				return this.DataRow;
			}
		}


	 

	    /// <summary>
        /// Loads the misplaced items.
        /// </summary>
        /// <param name="storeID">The store ID.</param>
		public void LoadMisplacedItems(int storeID)
		{
			//First run the location correcting query. Make sure the Balance contains the correct amount in the entry.
			string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadMisplacedItems(storeID);
			this.LoadFromRawSql(query);
		}

	   

	    /// <summary>
        /// Loads the by item ID.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
		public void LoadByItemID(int itemID)
		{
			string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadByItemID(itemID);
			this.LoadFromRawSql(query);
		}

	   

	    /// <summary>
        /// Loads the by receive doc ID.
        /// </summary>
        /// <param name="receiveDocID">The receive doc ID.</param>
		public void LoadByReceiveDocID(int receiveDocID)
		{
			this.FlushData();
			this.Where.ReceiveID.Value = receiveDocID;
			this.Query.Load();
		}

	  

	    /// <summary>
        /// Loads the non pick face all items ready to dispatch.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="unitID">The unit ID.</param>
        /// <param name="fromStore">From store.</param>
        /// <param name="preferredManufacturerID">Make it -1 to disregard manufacturer preferrence</param>
        /// <param name="preferredPhysicalStoreID">The preferred physical store ID.</param>
        /// <param name="deliveryNote">if set to <c>true</c> [delivery note].</param>
        /// <param name="preferredExpiryDate">The preferred expiry date.</param>
		public void LoadNonPickFaceAllItemsReadyToDispatch(int userID, int itemID, int? unitID, int fromStore, int preferredManufacturerID,int preferredPhysicalStoreID, bool deliveryNote, DateTime? preferredExpiryDate)
	    {
	        string query =
	            HCMIS.Repository.Queries.ReceivePallet.LoadNonPickFaceAllItemsReadyToDispatch(userID, itemID, unitID,
	                                                                                          fromStore,
	                                                                                          preferredManufacturerID,
	                                                                                          preferredPhysicalStoreID,
	                                                                                          preferredExpiryDate,
	                                                                                          StorageType.PickFace,
	                                                                                          deliveryNote,
	                                                                                          Settings.
	                                                                                              IssueUnPricedCommodities,
	                                                                                          Settings.
	                                                                                              DoNotIssueNearExpiryItems,
                                                                                                  Settings.IsCenter);
	        this.LoadFromRawSql(query);
	    }

	  

	    /// <summary>
        /// Loads the pick face all items ready to dispatch.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="unitID">The unit ID.</param>
        /// <param name="fromStore">From store.</param>
        [Obsolete]
		public void LoadPickFaceAllItemsReadyToDispatch(int itemID, int? unitID, int fromStore)
		{
			//TODO: Remove this hard coded condition. 
			//TODO: Manufacturer Preference needs to be inserted here too.
			// What the condition addes is the restriction that RDF stuff cannot be issued if the price is not set
			if (fromStore == 1)
			{
                string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadPickFaceAllItemsReadyToDispatch(itemID, fromStore, StorageType.PickFace);
				this.LoadFromRawSql(query);
			}
			else
			{
                string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadPickFaceAllItemsReadyToDispatchElse(itemID, unitID, fromStore, StorageType.PickFace);
				this.LoadFromRawSql(query);
			}
		}

      


	    /// <summary>
        /// Gets the balance by pallet ID.
        /// </summary>
        /// <param name="palletID">The pallet ID.</param>
        /// <returns></returns>
		public int GetBalanceByPalletID(int palletID)
		{
			string query = HCMIS.Repository.Queries.ReceivePallet.SelectGetBalanceByPalletID(palletID);
			this.LoadFromRawSql(query);
			if (this.RowCount > 0 && !this.IsColumnNull("Balance"))
			{
				return Convert.ToInt32(this.Balance);
			}

			return 0;
		}

	   

	    /// <summary>
        /// Consolidates the specified source pallet ID.
        /// </summary>
        /// <param name="sourcePalletID">The source pallet ID.</param>
        /// <param name="destinationPalletID">The destination pallet ID.</param>
		public void Consolidate(int sourcePalletID, int destinationPalletID)
		{
			string query = HCMIS.Repository.Queries.ReceivePallet.UpdateConsolidate(sourcePalletID, destinationPalletID);
			this.LoadFromRawSql(query);
		}

	  

	    /// <summary>
        /// Loads the non zero RP by receive ID.
        /// </summary>
        /// <param name="recID">The rec ID.</param>
		public void LoadNonZeroRPByReceiveID(int recID)
		{

			string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadNonZeroRPByReceiveID(recID);
			this.LoadFromRawSql(query);
		}

	  

	    /// <summary>
        /// Loads the non zero RP by item expiry.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="expDate">The exp date.</param>
		public void LoadNonZeroRPByItemExpiry(int itemID, DateTime expDate)
		{
			string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadNonZeroRPByItemExpiry(itemID, expDate);
			this.LoadFromRawSql(query);
		}

	 

	    /// <summary>
        /// Gets the pallet location ready for movement.
        /// </summary>
        /// <param name="palletID">The pallet ID.</param>
        /// <returns></returns>
		public DataTable GetPalletLocationReadyForMovement(int palletID)
		{
			string query = HCMIS.Repository.Queries.ReceivePallet.SelectGetPalletLocationReadyForMovement(palletID);
			this.LoadFromRawSql(query);
			return this.DataTable;
		}

	 

	    /// <summary>
        /// Fixes the reserved stock problems.
        /// </summary>
		public static void FixReservedStockProblems()
		{
			ReceivePallet rp=new ReceivePallet();
            string query =
                HCMIS.Repository.Queries.ReceivePallet.UpdateFixReservedStockProblems();
			rp.LoadFromRawSql(query);

            query =
                HCMIS.Repository.Queries.ReceivePallet.UpdateFixReservedStockProblemsMakeReservationSameAsBalance();
            rp.LoadFromRawSql(query);


            query =
                HCMIS.Repository.Queries.ReceivePallet.UpdateFixReservedStockProblemsCancelReservations();
            rp.LoadFromRawSql(query);
		}

	  

	    /// <summary>
        /// Gets the facilities items reserved for.
        /// </summary>
        /// <returns></returns>
		public DataTable GetFacilitiesItemsReservedFor()
		{
            string query = HCMIS.Repository.Queries.ReceivePallet.SelectGetFacilitiesItemsReservedFor(this.ID, OrderStatus.Constant.PICK_LIST_GENERATED, OrderStatus.Constant.PICK_LIST_CONFIRMED);
			ReceivePallet rp = new ReceivePallet();
			rp.LoadFromRawSql(query);

			return rp.DefaultView.ToTable();
		}

      

	    /// <summary>
        /// Gets the name of the physical store.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
		internal string GetPhysicalStoreName()
		{

            try
                {
                    var physicalStore = new PhysicalStore();
                    if (!this.IsColumnNull("PalletLocationID"))
                        physicalStore.LoadByPalletLocationID(PalletLocationID);
                    else
                        physicalStore.LoadByPalletID(PalletID);
                    return physicalStore.Name;
                }
                catch
                {
                    throw new Exception("Invalid warehouse setting.  Please configure the warehouse settings correctly.");
                }

		}

      


	    /// <summary>
        /// Gets the physical store type ID.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
		internal int GetPhysicalStoreTypeID()
		{
			try
			{
			    var physicalStore = new PhysicalStore();
				if (!this.IsColumnNull("PalletLocationID"))
                    physicalStore.LoadByPalletLocationID(PalletLocationID);
				else
                    physicalStore.LoadByPalletID(PalletID);
			    return physicalStore.PhysicalStoreTypeID;
			}
			catch
			{
				throw new Exception("Invalid warehouse setting.  Please configure the warehouse settings correctly.");
			}
		}

	  


	    /// <summary>
        /// Moves the balance.
        /// </summary>
        /// <param name="rpSource">The rp source.</param>
        /// <param name="rpDestination">The rp destination.</param>
        /// <param name="quantityToBeMoved">The quantity to be moved.</param>
        /// <exception cref="System.Exception"></exception>
		public static void MoveBalance(ReceivePallet rpSource, ReceivePallet rpDestination, long quantityToBeMoved)
		{
           
            TransactionMgr transaction = TransactionMgr.ThreadTransactionMgr();
			transaction.BeginTransaction();
			try
			{
				//DropProcedureReceiveDocReceivePallet();
				if (rpSource.Balance < quantityToBeMoved)
				{
					throw new Exception("Quantity to be moved must be less than or equal to the balance!");
				}

				if (rpDestination.IsColumnNull("Balance"))
				{
					rpDestination.Balance = 0;
				}
				
				rpDestination.Balance += quantityToBeMoved;
			    rpDestination.BoxSize = 0;
			    rpDestination.IsOriginalReceive = rpSource.IsOriginalReceive;
                rpDestination.Save();

			    rpSource.BoxSize = 0;
                rpSource.Balance -= quantityToBeMoved;

				rpSource.Save();
				//CreateProcedureReceiveDocReceivePallet();
				transaction.CommitTransaction();
			}
			catch
			{
				transaction.RollbackTransaction();
				CreateProcedureReceiveDocReceivePallet();       
			}
		}

        /// <summary>
        /// Creates the procedure receive doc receive pallet.
        /// </summary>
		private static void CreateProcedureReceiveDocReceivePallet()
		{
			ReceivePallet rp = new ReceivePallet();
            string storedProc = HCMIS.Repository.Queries.ReceivePallet.SpCreateProcedureReceiveDocReceivePallet();
			rp.LoadFromRawSql(storedProc);
		}

	  

	    /// <summary>
        /// Drops the procedure receive doc receive pallet.
        /// </summary>
		private static void DropProcedureReceiveDocReceivePallet()
		{
			ReceivePallet rp = new ReceivePallet();
			var query = HCMIS.Repository.Queries.ReceivePallet.DropTriggerProcedureReceiveDocReceivePallet();
			rp.LoadFromRawSql(query);
		}

	  

	    /// <summary>
        /// Physical StoreID remaining
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="unitID">The unit ID.</param>
        /// <param name="batch">The batch.</param>
        /// <param name="physicalStoreID">The physical store ID.</param>
		public void LoadByUnitIDItemIDAndBatch(int itemID, int unitID, string batch, int physicalStoreID)
		{            
			string query = HCMIS.Repository.Queries.ReceivePallet.SelectLoadByUnitIDItemIDAndBatch(itemID, unitID, batch);
			this.LoadFromRawSql(query);
		}

	    public static void ReserveQty(decimal pack, int receivePalletId, bool isOriginalReceive = true)
	    {
	        var receivepallet = new ReceivePallet();
	        receivepallet.LoadByPrimaryKey(receivePalletId);
            receivepallet.IsOriginalReceive = isOriginalReceive;
            receivepallet.ReservedStock = receivepallet.ReservedStock + pack;
            if (receivepallet.Balance >= receivepallet.ReservedStock) 
                receivepallet.Save();
	    }

        internal void LoadForInventory(Inventory inventory)
        {
            DateTime? expiryDate = null;
            if(!inventory.IsColumnNull("ExpiryDate"))
            {
                expiryDate = inventory.ExpiryDate;
            }
            string batchNo = "";
            if(!inventory.IsColumnNull("BatchNo"))
            {
                batchNo = inventory.BatchNo;
            }
            string query =
                HCMIS.Repository.Queries.ReceivePallet.SelectLoadForInventory(batchNo, expiryDate, inventory.ItemID, inventory.UnitID, inventory.ManufacturerID,
                                       inventory.ActivityID, inventory.PhysicalStoreID);
            this.LoadFromRawSql(query);
        }
	}
}