
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Collections.Generic;
using System.Data;
using DAL;
namespace BLL
{
    /// <summary>
    /// Item Manufacturer Class
    /// This encapsulates the logic behind Items coming from different manufacturers
    /// and in what kind of casing/boxing the item comes.
    /// </summary>
	public class ItemManufacturer : _ItemManufacturer
	{
        /// <summary>
        /// Caches the different keys
        /// </summary>
        private static DataTable _keys = null;

	    private static Dictionary<int, String> _pLevels = null;

        ///<summary>
        /// caches the level types
        ///</summary>
        public static Dictionary<int, String> PLevels {

            get
            {
                if (_pLevels == null)
                {
                    _pLevels = new Dictionary<int, string>();
                    _pLevels.Add(-1, "Basic Unit");
                    _pLevels.Add(0, "SKU");
                    _pLevels.Add(1, "1st Outer Box");
                    _pLevels.Add(2, "2nd Outer Box");
                    _pLevels.Add(3, "3rd Outer Box");
                    _pLevels.Add(4, "4th Outer Box");
                    _pLevels.Add(5, "5th Outer Box");
                }
                
                return _pLevels;
                
            }
        }

        /// <summary>
        /// Gets a data table that contains the package level names
        /// </summary>
        public static DataTable PackageLevelKeys
        {
            get
            {
                if (_keys == null)
                {
                    _keys = new DataTable();
                   
                    _keys.Columns.Add("ID", typeof(int));
                    _keys.Columns.Add("Name");
                    DataView keysView = _keys.DefaultView;
                    DataRowView dr = keysView.AddNew();
                    dr["ID"] = -1; dr["Name"] = "Basic Unit";
                    dr = keysView.AddNew();
                    dr["ID"] = 0; dr["Name"] = "SKU";
                    dr = keysView.AddNew();
                    dr["ID"] = 1; dr["Name"] = "1st Outer Box";
                    dr = keysView.AddNew();
                    dr["ID"] = 2; dr["Name"] = "2nd Outer Box";
                    dr = keysView.AddNew();
                    dr["ID"] = 3; dr["Name"] = "3rd Outer Box";
                    dr = keysView.AddNew();
                    dr["ID"] = 4; dr["Name"] = "4th Outer Box";
                    dr = keysView.AddNew();
                    dr["ID"] = 5; dr["Name"] = "5th Outer Box";
                }
                return _keys;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int PackageLevel
        {
            get { return 0; }
        }


        public override int QuantityPerLevel
        {
            get { return 1; }
        }


        public override bool RecevingDefault
        {
            get { return true; }
        }
        /// <summary>
        /// Calculates the volume from the box width, height and lenght properties.
        /// </summary>
        public double Volume
        {
            get
            {
                return (this.BoxHeight * this.BoxLength * this.BoxWidth);
            }
        }

        /// <summary>
        /// Loads all the levels and returns a data table.
        /// </summary>
        public DataTable GetAllLevels
        {
            get {
                var query = HCMIS.Repository.Queries.ItemManufacturer.SelectGetAllLevels();
                this.LoadFromRawSql(query);
                return this.DataTable;
            }
        }

        /// <summary>
        ///     loads the package level with the appended notation
        ///     Example: 1 x 50 x 100
        /// </summary>
        public string LevelView2
        {
            get
            {
                string str = "1";
                ItemManufacturer im = new ItemManufacturer();
                im.LoadFromRawSql(HCMIS.Repository.Queries.ItemManufacturer.SelectLevelView2(this.ItemID, this.ManufacturerID, this.PackageLevel));
                while (!im.EOF)
                {
                    str = str + " x " + im.QuantityPerLevel.ToString();
                    im.MoveNext();
                }
                return str;
            }
        }

        /// <summary>
        /// Loads all Distinct manufacturers for an item
        /// </summary>
        /// <param name="item"></param>
        public void LoadManufacturersFor(int item)
        {
            this.FlushData();
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadManufacturersFor(item);
            this.LoadFromRawSql(query);
        }


        /// <summary>
        /// Loads all the package levels for the an item from the parameter manufacturer
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="manufactuerer">The manufactuerer.</param>
        public void LoadManufacturerItemRelationsFor(int item, int manufactuerer)
        {
            this.FlushData();
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadManufacturerItemRelationsFor(item, manufactuerer);
            this.LoadFromRawSql(query);
        }

        /// <summary>
        /// Loads a specific level of item by a manufacturer
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="manufactuerer">The manufactuerer.</param>
        /// <param name="level">The level.</param>
        public void LoadManufacturerItemRelationsFor(int item, int manufactuerer, int level)
        {
            this.FlushData();
            //String query = String.Format("select * , 'Level ' + CAST(PackageLevel AS VarChar ) as PLevel from ItemManufacturer where ItemID = {0} and ManufacturerID = {1} and PackageLevel = {2}", item, manufactuerer,level);
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadManufacturerItemLevelRelationsFor(item, manufactuerer);
            this.LoadFromRawSql(query);
        }

        /// <summary>
        ///  Saves a level as Default Receiving Package level
        ///  This is depreciated
        /// </summary>
        public void SaveReceivingDefault()
        {
            if (!this.RecevingDefault)
            {
                int id = this.ID;
                ItemManufacturer im = new ItemManufacturer();
                im.LoadFromRawSql(HCMIS.Repository.Queries.ItemManufacturer.UpdateSaveReceivingDefault(this.ItemID, this.ManufacturerID));
                
                this.RecevingDefault = true;
                this.Save();
                this.LoadManufacturerItemRelationsFor(this.ItemID, this.ManufacturerID);
            }
            else
            {
                this.RecevingDefault = true;
                this.Save();
            }
        }

        /// <summary>
        /// Loads the default receiving package level
        /// </summary>
        /// <param name="itemid">The itemid.</param>
        /// <param name="manufid">The manufid.</param>
        public void LoadDefaultReceiving(int itemid, int manufid)
        {
            this.FlushData();
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadDefaultReceiving(itemid, manufid);
            this.LoadFromRawSql(query);
            if (this.RowCount == 0)
            {
                // return the most outer box if none of the levels is marked as default.
                this.LoadOuterBoxForItemManufacturer(itemid, manufid);
            }
            //if (this.RowCount == 0)
            //{
            //    // create a default level for this maufacturer, this assumes that it is not used anyways.
            //    this.FlushData();
            //    this.AddNew();
            //    this.ItemID = itemid;
            //    this.ManufacturerID = manufid;
            //    this.QuantityPerLevel = 1;
            //    this.PackageLevel = 0;
            //    this.BoxHeight = this.BoxLength = this.BoxWidth = 1;
            //    this.Save();
            //}
        }

        /// <summary>
        /// Loads the top most package level for an item from a given manufacturer
        /// </summary>
        /// <param name="itemid">The itemid.</param>
        /// <param name="manufid">The manufid.</param>
        public void LoadOuterBoxForItemManufacturer(int itemid, int manufid)
        {
            //HACK: To get the Level1 problems stop.  An artificial fix used.
            //string query = string.Format("select * from ItemManufacturer where ItemID = {0} and ManufacturerID = {1} order by PackageLevel DESC",itemid,manufid); // This is the correct code used to work for ItemManufacturers

            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadOuterBoxForItemManufacturer(itemid, manufid); //An artificial fix until the level ones (Item Manufacturer table) is implemented
            this.LoadFromRawSql(query);
        }

        /// <summary>
        /// Returns Quantity in basic unit for any loaded Package level
        /// </summary>
        public int QuantityInBasicUnit
        {
            get {
                int id = this.ID;
                int q = 1;
                ItemManufacturer im = new ItemManufacturer();
                im.LoadManufacturerItemRelationsFor(this.ItemID, this.ManufacturerID);
                while (!im.EOF && im.PackageLevel <= this.PackageLevel)
                {
                    q *= im.QuantityPerLevel;
                    im.MoveNext();
                }
                return q;
            }
        }

        /// <summary>
        /// Returns how much SKU a Package Level holds
        /// </summary>
        public int QuantityInSku
        {
            get
            {
                int id = this.ID;
                int q = 1;
                ItemManufacturer im = new ItemManufacturer();
                im.LoadManufacturerItemRelationsFor(this.ItemID, this.ManufacturerID);
                while (!im.EOF && im.PackageLevel <= this.PackageLevel)
                {
                    if (im.PackageLevel > 0)
                    {
                        q *= im.QuantityPerLevel;
                    }
                    im.MoveNext();
                }
                return q;
            }
        }

        /// <summary>
        /// Load a level by specified itemID, Manufacturer ID and package level
        /// this method doesn't put the formatted level name
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <param name="manufId">The manuf id.</param>
        /// <param name="plevel">The plevel.</param>
        public void LoadIMbyLevel(int itemId, int manufId, int plevel)
        {
            this.FlushData();
            //String query = String.Format("select * from ItemManufacturer where ItemID = {0} and ManufacturerID = {1} and PackageLevel = {2}", itemId, manufId,plevel);
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadIMbyLevel(itemId, manufId);
            this.LoadFromRawSql(query);
        }


        /// <summary>
        /// Loads levels
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <param name="manufId">The manuf id.</param>
        /// <returns></returns>
        public DataTable LoadLevelsFor2(int itemId, int manufId)
        {
            this.LoadDefaultReceiving(itemId, manufId);
            int ru = this.PackageLevel;
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadLevelsFor2(itemId, manufId);
            this.LoadFromRawSql(query);
            DataTable dtbl = ItemManufacturer.PackageLevelKeys.Clone();
            foreach (DataRow dr in ItemManufacturer.PackageLevelKeys.Select(" ID < " + this.RowCount))
            {
                DataRowView drv = dtbl.DefaultView.AddNew();

                drv["ID"] = dr["ID"];
                if (Convert.ToInt32(dr["ID"]) == ru)
                {
                    drv["Name"] = "Shipping Box";
                }
                else
                {
                    drv["Name"] = dr["Name"];
                }
            }
            return dtbl;
        }

        /// <summary>
        /// Saves item as stack stored and this also sets the stack height
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <param name="manufacturerId">The manufacturer id.</param>
        /// <param name="stackHeight">Height of the stack.</param>
        public void SaveStackStored(int itemId, int manufacturerId, double stackHeight)
        {
            var query = HCMIS.Repository.Queries.ItemManufacturer.UpdateSaveStackStored(itemId, manufacturerId, stackHeight);
            this.LoadFromRawSql(query);
        }

        /// <summary>
        /// Returns the suggested package style for a given quantity,
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <param name="manufId">The manuf id.</param>
        /// <param name="qty">The qty.</param>
        /// <returns></returns>
        public DataTable SuggestComposition(int itemId, int manufId, decimal qty)
        {
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SKU", typeof(int));
            dtbl.Columns.Add("BoxSize");
            dtbl.Columns.Add("BSize", typeof(int));
            dtbl.Columns.Add("Qty",typeof(decimal));
            dtbl.Columns.Add("SKUM",typeof(decimal));

            this.LoadOuterBoxForItemManufacturer(itemId, manufId);
            int multiplier = this.QuantityInSku;
            decimal first = qty / multiplier;
            DataRowView d = dtbl.DefaultView.AddNew();
            d["SKU"] = first * multiplier;

            d["BoxSize"] = this.LevelView2;////"Shipping Cartoon";
            d["BSize"] = this.PackageLevel;
            d["Qty"] = first;
            d["SKUM"] = multiplier;


            decimal sum = (first * multiplier);
            bool iterate = true;
            if (this.PackageLevel == 0)
            {
                d["BoxSize"] = "SKU";
                iterate = false;

            }
            d.EndEdit();
            while (iterate)
            {
                this.LoadIMbyLevel(itemId, manufId, this.PackageLevel - 1);
                decimal reminder = qty - sum;
                multiplier = this.QuantityInSku;
                first = reminder / multiplier;
                d = dtbl.DefaultView.AddNew();
                d["SKU"] = first * multiplier;
                if (this.PackageLevel != 0)
                {
                    d["BoxSize"] = this.LevelView2;////PLevels[this.PackageLevel];
                }
                else
                {
                    d["BoxSize"] = PLevels[this.PackageLevel];
                }
                d["BSize"] = this.PackageLevel;
                d["Qty"] = first;
                d["SKUM"] = multiplier;
                d.EndEdit();
                sum += (first * multiplier);
                if (this.PackageLevel == 0)
                {
                    break;
                }
            }
            return dtbl;
        }

        /// <summary>
        /// Converts the Data Table suggested composition to displayable formatted string
        /// </summary>
        /// <param name="dtbl">The DTBL.</param>
        /// <returns></returns>
        public string ConvertCompositionToString(DataTable dtbl)
        {
            string composition = "";
            foreach (DataRow dr in dtbl.Rows)
            {
                if (composition == "")
                {
                    composition = string.Format("({1}) x {0}", dr["Qty"], dr["BoxSize"]);
                }
                else
                {
                    composition = string.Format("{2}\n ({1}) x {0}", dr["Qty"], dr["BoxSize"],composition);
                }
            }
            return composition;
        }

        /// <summary>
        /// Loads Stock Keeping uint for an item
        /// </summary>
        /// <param name="itemid">The itemid.</param>
        public void LoadDefaultSKUItemManufacturer(int itemid)
        {
            // give the priority to the item that has a manufacturer and that have been received to by.
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadDefaultSkuItemManufacturer(itemid);
            this.LoadFromRawSql(query);
            if (RowCount == 0)
            {
                // try if there is a manufacturer that is setup but has not supplied
                query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadDefaultSkuItemManufacturerNotSuppled(itemid);
                this.LoadFromRawSql(query);
            }
        }

        /// <summary>
        /// Get the basic units found in the most probable next supplied item
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <returns></returns>
        public static int GetDefaultBuInSKU(int itemId)
        {
            ItemManufacturer im = new ItemManufacturer();
            im.LoadDefaultSKUItemManufacturer(itemId);
            
            // check if there is atleast one manufacturer which has supplied the given item.
            if (im.RowCount > 0)
            {
                return im.QuantityInBasicUnit;
            }
            else
            {
                return 1;
            }
        }



        /// <summary>
        /// Loads Stock Keeping unit level for a manufacutrer
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <returns></returns>
        public int LoadSKUUnit(int itemId, int manufacturer)
        {
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadSkuUnit(itemId, manufacturer);
            this.LoadFromRawSql(query);
            return this.QuantityInBasicUnit;
        }

        /// <summary>
        /// Checks if the loaded item manufacturer has had receives done
        /// </summary>
        /// <returns></returns>
        public bool HasReceives()
        {
            ItemManufacturer imf = new ItemManufacturer();
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectHasReceives(this.ItemID, this.ManufacturerID);
            imf.LoadFromRawSql(query);
            return (imf.RowCount > 0);
            
        }

        /// <summary>
        /// Checks if a level has dependent levels
        /// </summary>
        /// <returns></returns>
        public bool HasDependants()
        {
            ItemManufacturer imf = new ItemManufacturer();
            imf.LoadIMbyLevel(this.ItemID, this.ManufacturerID, this.PackageLevel + 1);
            return (imf.RowCount > 0);
        }
        /// <summary>
        /// Enables changing the SKU of a product mid flight
        /// This should only be available to the administrator who could do it more carefully.
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="manufacturerID"></param>
        /// <param name="level"></param>
        /// <param name="newQuantity"></param>
        public static void ChangeSKU(int itemID, int manufacturerID,int level, int newQuantity)
        {
            // preserve the old SKU
           ItemManufacturer imf = new ItemManufacturer();
            imf.LoadIMbyLevel(itemID,manufacturerID,level);
            int previousQuantityPerLevel = imf.QuantityPerLevel;

            if(level == 0)
            {
                // change the SKU Unit
                imf.QuantityPerLevel = newQuantity;
                imf.Save();

                // change the received Qty Per pack

                var query = HCMIS.Repository.Queries.ItemManufacturer.UpdateChangeSKU(itemID, manufacturerID, newQuantity, previousQuantityPerLevel);


                imf.LoadFromRawSql(query);
                
                
                // Update Issue Doc
                query = HCMIS.Repository.Queries.ItemManufacturer.UpdateChangeSKUIssueDoc(itemID, manufacturerID, newQuantity, previousQuantityPerLevel);
                imf.LoadFromRawSql(query);

                // Update disposal table
                query =
                    HCMIS.Repository.Queries.ItemManufacturer.UpdateChangeSKULossAndAdjustment(itemID, manufacturerID, newQuantity, previousQuantityPerLevel);
                imf.LoadFromRawSql(query);
                // update the Receive Pallet
                query =
                    HCMIS.Repository.Queries.ItemManufacturer.UpdateChangeSKUReceivePallet(itemID, manufacturerID, newQuantity, previousQuantityPerLevel);

                imf.LoadFromRawSql(query);

                // Update Pick Face
                //TODO:

                // Update Order.
                // this is a bit tricky, it is better to not update it and ask the user to make sure
                // that they don't have an outstanding order with the item that is about to be changed.
                // Update Pick List.
                query =
                    HCMIS.Repository.Queries.ItemManufacturer.UpdateChangeSKUPickListDetail(itemID, manufacturerID, newQuantity, previousQuantityPerLevel);

                imf.LoadFromRawSql(query);
                
            }
        }

        /// <summary>
        /// Loads the by item ID and manufacturer ID.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="manufacturerID">The manufacturer ID.</param>
        public void LoadByItemIDandManufacturerID(int itemID, int manufacturerID)
        {
            this.FlushData();
            this.Where.ItemID.Value = itemID;
            this.Where.ManufacturerID.Value = manufacturerID;
            this.Query.Load();
        }
        /// <summary>
        /// Load Only Received Manufacturer
        /// </summary>
        /// <param name="_itemID"></param>
        public void LoadManufactuererByItemWithReceive(int _itemID)
        {
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadManufactuererByItemWithReceive(_itemID);
            this.LoadFromRawSql(query);
        }

        public void LoadAllManufacturersByItem(int _itemID)
        {
            var query = HCMIS.Repository.Queries.ItemManufacturer.SelectLoadAllManufacturersByItem(_itemID);
            this.LoadFromRawSql(query);
        }
	}
}