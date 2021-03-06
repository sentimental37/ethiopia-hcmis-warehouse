
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Collections.Generic;

namespace Proxy
{
    public class ItemManufacturer
    {

        #region Properties

        private int? _ID;
        public int? ID
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

        private int? _ItemID;
        public int? ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                _ItemID = value;
            }
        }

        private int? _ManufacturerID;
        public int? ManufacturerID
        {
            get
            {
                return _ManufacturerID;
            }
            set
            {
                _ManufacturerID = value;
            }
        }

        private int? _PackageLevel;
        public int? PackageLevel
        {
            get
            {
                return _PackageLevel;
            }
            set
            {
                _PackageLevel = value;
            }
        }

        private int? _QuantityPerLevel;
        public int? QuantityPerLevel
        {
            get
            {
                return _QuantityPerLevel;
            }
            set
            {
                _QuantityPerLevel = value;
            }
        }

        private bool? _IsssuingDefault;
        public bool? IsssuingDefault
        {
            get
            {
                return _IsssuingDefault;
            }
            set
            {
                _IsssuingDefault = value;
            }
        }

        private bool? _RecevingDefault;
        public bool? RecevingDefault
        {
            get
            {
                return _RecevingDefault;
            }
            set
            {
                _RecevingDefault = value;
            }
        }

        private double? _BoxWidth;
        public double? BoxWidth
        {
            get
            {
                return _BoxWidth;
            }
            set
            {
                _BoxWidth = value;
            }
        }

        private double? _BoxHeight;
        public double? BoxHeight
        {
            get
            {
                return _BoxHeight;
            }
            set
            {
                _BoxHeight = value;
            }
        }

        private double? _BoxLength;
        public double? BoxLength
        {
            get
            {
                return _BoxLength;
            }
            set
            {
                _BoxLength = value;
            }
        }

        private string _BrandName;
        public string BrandName
        {
            get
            {
                return _BrandName;
            }
            set
            {
                _BrandName = value;
            }
        }

        private double? _StackHeight;
        public double? StackHeight
        {
            get
            {
                return _StackHeight;
            }
            set
            {
                _StackHeight = value;
            }
        }

        private bool? _IsDeleted;
        public bool? IsDeleted
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

        private DateTime? _UpdateTime;
        public DateTime? UpdateTime
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

        #region Web Service Getters

        public static List<ItemManufacturer> GetAll()
        {
            BLL.ItemManufacturer v = new BLL.ItemManufacturer();
            v.LoadAll();
            return ToList(v);
        }



        #endregion



        #region Utilities

        public static List<ItemManufacturer> ToList(BLL.ItemManufacturer v)
        {
            List<ItemManufacturer> list = new List<ItemManufacturer>();
            while (!v.EOF)
            {
                ItemManufacturer t = new ItemManufacturer();
                if (!v.IsColumnNull("ID"))
                    t.ID = v.ID;
                if (!v.IsColumnNull("ItemID"))
                    t.ItemID = v.ItemID;
                if (!v.IsColumnNull("ManufacturerID"))
                    t.ManufacturerID = v.ManufacturerID;
                if (!v.IsColumnNull("PackageLevel"))
                    t.PackageLevel = v.PackageLevel;
                if (!v.IsColumnNull("QuantityPerLevel"))
                    t.QuantityPerLevel = v.QuantityPerLevel;
                if (!v.IsColumnNull("IsssuingDefault"))
                    t.IsssuingDefault = v.IsssuingDefault;
                if (!v.IsColumnNull("RecevingDefault"))
                    t.RecevingDefault = v.RecevingDefault;
                if (!v.IsColumnNull("BoxWidth"))
                    t.BoxWidth = v.BoxWidth;
                if (!v.IsColumnNull("BoxHeight"))
                    t.BoxHeight = v.BoxHeight;
                if (!v.IsColumnNull("BoxLength"))
                    t.BoxLength = v.BoxLength;
                if (!v.IsColumnNull("BrandName"))
                    t.BrandName = v.BrandName;
                if (!v.IsColumnNull("StackHeight"))
                    t.StackHeight = v.StackHeight;

                list.Add(t);
                v.MoveNext();
            }
            return list;
        }

        #endregion


        #region Web service Saving

        public static void SaveList(List<HCMIS.Desktop.DirectoryServices.ItemManufacturer> list)
        {
            BLL.ItemManufacturer bv = new BLL.ItemManufacturer();
            foreach (HCMIS.Desktop.DirectoryServices.ItemManufacturer v in list)
            {
                // try to load by primary key
                bv.LoadByItemIDandManufacturerID(v.ItemID.Value, v.ManufacturerID.Value);

                // if the entry doesn't exist, create it
                if (bv.RowCount == 0)
                {
                    bv.AddNew();
                }
                // populate the contents of v on the to the database list
                if (v.ItemID.HasValue)
                    bv.ItemID = v.ItemID.Value;
                if (v.ManufacturerID.HasValue)
                    bv.ManufacturerID = v.ManufacturerID.Value;
                if (v.PackageLevel.HasValue)
                    bv.PackageLevel = v.PackageLevel.Value;
                if (v.QuantityPerLevel.HasValue)
                    bv.QuantityPerLevel = v.QuantityPerLevel.Value;
                if (v.IsssuingDefault.HasValue)
                    bv.IsssuingDefault = v.IsssuingDefault.Value;
                if (v.RecevingDefault.HasValue)
                    bv.RecevingDefault = v.RecevingDefault.Value;
                if (v.BrandName != "" && v.BrandName != null)
                    bv.BrandName = v.BrandName;
                if (v.StackHeight.HasValue)
                    bv.StackHeight = v.StackHeight.Value;

                bv.BoxHeight = 1;
                bv.BoxLength = 1;
                bv.BoxWidth = 1;
                bv.Save();
            }


        }

        public static void DeleteList(List<int> list)
        {
            BLL.ItemManufacturer bv = new BLL.ItemManufacturer();
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
