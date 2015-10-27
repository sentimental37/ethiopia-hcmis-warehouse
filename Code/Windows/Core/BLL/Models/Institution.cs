// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
	public class Institution : _Institution
	{
		public Institution()
		{
		
		}
        /// <summary>
        /// For Facility Edition only
        /// Loads Receiving Units (Dispensing units that have ever received a given Item)
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="storeId"></param>
        /// <returns>Data Table containing list of Receiving Units</returns>
        public DataTable GetApplicableDUs(int itemId,int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.Institution.SelectGetApplicableDUs(itemId, storeId));
            return this.DataTable;
        }

	    /// <summary>
        /// Gets the receiving units by zone.
        /// </summary>
        /// <param name="zoneID">The zone ID.</param>
        /// <returns></returns>
        public static Institution GetReceivingUnitsByZone(int zoneID)
        {
            Institution rec = new Institution();
            var query = HCMIS.Repository.Queries.Institution.SelectGetReceivingUnitsByZone(zoneID);
            rec.LoadFromRawSql(query);

            return rec;
        }


	    /// <summary>
        /// Gets receiving units for IssuDetail by Account report.
        /// </summary>
        /// 


        public static DataTable GetDistinctInstitutionForIssueDetail()
        {
            var query = HCMIS.Repository.Queries.Institution.SelectGetDistinctInstitutionForIssueDetail();
            Institution institution = new Institution();
            institution.LoadFromRawSql(query);
            return institution.DataTable;
        }

	    /// <returns></returns>
        /// 
        /// <summary>
        /// Gets the receiving units by type ID.
        /// </summary>
        /// <param name="TypeID">The type ID.</param>
        /// <returns></returns>
        public static Institution GetReceivingUnitsByTypeID(int TypeID)
        {
            Institution rec = new Institution();
            var query = HCMIS.Repository.Queries.Institution.SelectGetReceivingUnitsByTypeID(TypeID);
            rec.LoadFromRawSql(query);
            return rec;
        }

	    /// <summary>
        /// Gets all receiving units.
        /// </summary>
        /// <returns></returns>
        public static Institution GetAllReceivingUnits()
        {
            
            Institution rec = new Institution();
            var query = HCMIS.Repository.Queries.Institution.SelectLoadAll();
            rec.LoadFromRawSql(query);
            return rec;
        }

	    /// <summary>
        /// Loads l
        /// </summary>
        /// <returns></returns>
        public DataTable GetFacilitiesThatEverReceivedItems()
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.Institution.SelectGetFacilitiesThatEverReceivedItems());
            return this.DataTable;
        }


	    /// <summary>
        /// Gets the applicable D us all.
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <returns></returns>
        public DataTable GetApplicableDUsAll(int itemId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.Institution.SelectGetApplicableDUsAll(itemId));
            return this.DataTable;
        }

	    /// <summary>
        /// This is an overridden method
        /// Load All receiving units,
        /// This is sorted by Name of facilities.
        /// </summary>
        public new void LoadAll()
	    {
	        // Sort and load all the receiving units
	        var query = HCMIS.Repository.Queries.Institution.SelectLoadAll();
	        this.LoadFromRawSql(query);
	    }

        public new void LoadByPrimaryKey(int id)
        {
            var query = HCMIS.Repository.Queries.Institution.SelectInstitutionByID(id);
            this.LoadFromRawSql(query);
        }

	    public string WoredaName
	    {
            get { return Getstring("WoredaName"); }
	    }

        public string ZoneName
        {
            get { return Getstring("ZoneName"); }
        }

        public string RegionName
        {
            get { return Getstring("RegionName"); }
        }
        
        public string InstitutionTypeName   
        {
            get { return Getstring("InstitutionTypeName"); }
        }

	    public new void LoadAllActive()
	    {
	        // Sort and load all the receiving units
	        var query = HCMIS.Repository.Queries.Institution.SelectLoadAllActive();
	        this.LoadFromRawSql(query);
	    }


	    /// <summary>
        /// Loads all hubs depending if and only if the hub table exists on the connected schema
        /// </summary>
        /// <returns>
        /// Data Table containing list of hubs( if the hub table exists in the current schema only )
        /// </returns>
        [Obsolete]
        public DataTable GetAllHubs()
        {
            this.FlushData();
            var query = HCMIS.Repository.Queries.Institution.SelectGetAllHubs();
            //TOFIX: no Try catch wrong wrong
            try
            {
                this.LoadFromRawSql(query);
            }
            catch { }
            return this.DataTable;
        }

	    /// <summary>
        /// Returns list of facilities under a selected route. the route ID is an integer
        /// </summary>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public DataTable GetAllUnderRoute(int route)
        {
            // sorted by facility name
            var query = HCMIS.Repository.Queries.Institution.SelectGetAllUnderRoute(route);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

	    /// <summary>
        /// Gets the top receiving units.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTopReceivingUnits()
        {
            var query = HCMIS.Repository.Queries.Institution.SelectGetTopReceivingUnits();
            Institution institution = new Institution();
            institution.LoadFromRawSql(query);
            return institution.DataTable;
        }

	    /// <summary>
        /// Gets the resupply per unit.
        /// </summary>
        /// <param name="recievingUnitID">The recieving unit ID.</param>
        /// <returns></returns>
        public static DataTable GetResupplyPerUnit(int recievingUnitID)
        {
            var query = HCMIS.Repository.Queries.Institution.SelectGetResupplyPerUnit(recievingUnitID);
            Institution institution = new Institution();
            institution.LoadFromRawSql(query);
            return institution.DataTable;
        }

	    /// <summary>
        /// Gets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public string Region { 
        
            get
            {
                if (this.IsColumnNull("Woreda"))
                {
                    return "";
                }
                BLL.Woreda woreda = new Woreda();
                woreda.LoadByPrimaryKey(this.Woreda);
                BLL.Zone zone = new Zone();
                zone.LoadByPrimaryKey(woreda.ZoneID);
                BLL.Region region = new Region();
                region.LoadByPrimaryKey(zone.RegionId);
                return region.RegionName;
            }
       }

        /// <summary>
        /// Gets the zone text.
        /// </summary>
        /// <value>
        /// The zone text.
        /// </value>
        public string ZoneText
        {
            get
            {
                if (this.IsColumnNull("Zone"))
                {
                    return "";
                }
                BLL.Zone zone = new BLL.Zone();
                zone.LoadByPrimaryKey(this.Zone);
                return  zone.ZoneName;
            }
        }

        /// <summary>
        /// Gets the woreda text.
        /// </summary>
        /// <value>
        /// The woreda text.
        /// </value>
        public string WoredaText
        {
            get
            {
                if (this.IsColumnNull("Woreda"))
                {
                    return "";
                }
                BLL.Woreda woreda = new Woreda();
                woreda.LoadByPrimaryKey(this.Woreda);
                return woreda.WoredaName;

            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is privately owned.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is privately owned; otherwise, <c>false</c>.
        /// </value>
        public bool IsPrivatelyOwned
        {
            get { return OwnershipType.IsPrivate(this.Ownership); }
        }

        /// <summary>
        /// Swaps the receiving units.
        /// </summary>
        /// <param name="receivingUnitID">The receiving unit ID.</param>
        /// <param name="receivingUnitIDTarget">The receiving unit ID target.</param>
        public static void SwapReceivingUnits(int receivingUnitID, int receivingUnitIDTarget)
        {
            BLL.Institution ru = new Institution();
            var query = HCMIS.Repository.Queries.Institution.UpdateSwapReceivingUnitsOrder(receivingUnitID, receivingUnitIDTarget);
            ru.LoadFromRawSql(query);

            ru.FlushData();
            query = HCMIS.Repository.Queries.Institution.UpdateSwapReceivingUnitsIssueDoc(receivingUnitID, receivingUnitIDTarget);
            ru.LoadFromRawSql(query);
        }

	    /// <summary>
        /// Loads the receiving unit by filter.
        /// </summary>
        /// <param name="woredaID">The woreda ID.</param>
        /// <param name="zoneID">The zone ID.</param>
        /// <param name="ruType">Type of the ru.</param>
        /// <param name="ownershipType">Type of the ownership.</param>
        /// <param name="activeStatus">The active status.</param>
        /// <param name="inProcess">The in process.</param>
        /// <param name="hasBeenIssuedTo">if set to <c>true</c> [has been issued to].</param>
        /// <returns></returns>
        public static Institution LoadReceivingUnitByFilter(int woredaID, int zoneID, int ruType, int ownershipType, int activeStatus, Boolean inProcess, bool hasBeenIssuedTo)
        {
            var filterQuery = HCMIS.Repository.Queries.Institution.SelectLoadReceivingUnitByFilter(woredaID, zoneID, ruType, ownershipType, activeStatus, hasBeenIssuedTo, inProcess);
            var ru = new Institution();
            ru.LoadFromRawSql(filterQuery);
            return ru;
        }

	    /// <summary>
        /// Loads the receiving unit by filter.
        /// </summary>
        /// <param name="woredaID">The woreda ID.</param>
        /// <param name="zoneID">The zone ID.</param>
        /// <param name="ruType">Type of the ru.</param>
        /// <param name="ownershipType">Type of the ownership.</param>
        /// <param name="activeStatus">The active status.</param>
        /// <param name="inProcess">The in process.</param>
        /// <param name="storeID">The store ID.</param>
        /// <param name="hasBeenIssuedTo">if set to <c>true</c> [has been issued to].</param>
        /// <returns></returns>
        public static Institution LoadReceivingUnitByFilter(int woredaID, int zoneID, int ruType, int ownershipType, int activeStatus, Boolean inProcess,int storeID,bool hasBeenIssuedTo)
	    {
	        var query = HCMIS.Repository.Queries.Institution.SelectLoadReceivingUnitByFilterByName(woredaID, zoneID, ruType,
	                                                                                               ownershipType,
	                                                                                               activeStatus,
	                                                                                               hasBeenIssuedTo,
	                                                                                               inProcess, storeID);
            BLL.Institution ru = new Institution();
            ru.LoadFromRawSql(query);
            return ru;
        }

	    /// <summary>
        /// Loads the receiving unit by filter.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static Institution LoadReceivingUnitByFilter(string name)
        {
            var query = HCMIS.Repository.Queries.Institution.SelectLoadReceivingUnitByFilter(name);

            BLL.Institution ru = new Institution();
            ru.LoadFromRawSql(query);
            return ru;
        }

	    /// <summary>
        /// Loads the hubs.
        /// </summary>
        /// <returns></returns>
        public static DataView LoadHubs()
        {
            // remember Hub is RUType 8
            var filterQuery = HCMIS.Repository.Queries.Institution.SelectLoadHubs(InstitutionType.Constants.HUB);

            BLL.Institution ru = new Institution();
            ru.LoadFromRawSql(filterQuery);
            return ru.DefaultView;
        }

	    /// <summary>
        /// Gets the other ID.
        /// </summary>
        /// <returns></returns>
        public static int getOtherID()
        {
            var filterQuery = HCMIS.Repository.Queries.Institution.SelectgetOtherID();
              BLL.Institution ru = new Institution();
            ru.LoadFromRawSql(filterQuery);
            return ru.ID;
             
        }

	    public static bool ValidateNewAddition(string facilityName, int woredaID)
        {
            BLL.Institution institution = new Institution();

            var query = HCMIS.Repository.Queries.Institution.SelectValidateNewAddition(facilityName, woredaID);
            institution.LoadFromRawSql(query);
            if(institution.RowCount>0) //If it already exists, then it's not valid.
            {
                return false;
            }
            else
            {
                return true;
            }
        }


	    public static Institution LoadReceivingUnitByFilter(int woredaID)
        {
            var query = HCMIS.Repository.Queries.Institution.SelectLoadReceivingUnitByFilter(woredaID);
            var inst = new Institution();
            inst.LoadFromRawSql(query);
            return inst;
        }

	    public void LoadAllActiveForDeliverySettingsPage()
	    {
	        // Sort and load all the receiving units
	        var query = HCMIS.Repository.Queries.Institution.SelectLoadAllActiveForDeliverySettingsPage();
	        this.LoadFromRawSql(query);
	    }

        public void LoadBySN(int facilityID)
        {
            string query = HCMIS.Repository.Queries.Institution.SelectLoadBySN(facilityID);
            LoadFromRawSql(query);
        }

        public static DataTable GetItemFacilityDistribution(int ModeID, DateTime StartDate, DateTime EndDate, int RegionID = -1, int ZoneID = -1, int WoredaID = -1)
        {
            string query = HCMIS.Repository.Queries.Institution.SelectGetItemFacilityDistribution(ModeID, StartDate.ToShortDateString(), EndDate.ToShortDateString(), RegionID, ZoneID, WoredaID);
            Institution inst = new Institution();
            inst.LoadFromRawSql(query);
            return inst.DefaultView.Table;
        }

	    public void LoadByRowGuid(Guid rowguid)
	    {
	        this.Where.Rowguid.Value = rowguid;
	        this.Query.Load();

	    }
	}
}