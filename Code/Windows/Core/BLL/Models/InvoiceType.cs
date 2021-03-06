
// Generated by MyGeneration Version # (1.2.0.7)

using System;
using DAL;

namespace BLL
{
	public class InvoiceType : _InvoiceType
	{
		public InvoiceType()
		{ }
            /*
                1	Invoice Transportation by Air	ITA
                2	Invoice Transportation by Sea	ITS
                3	CIP	CIP
                4	STV	STV
                5	Inventory	INV
                6	Local Purchase	LP
                7	Non Standard	NS
                8	Error Correction 	1
             */
        public static int TransportationByAir { get { return GetInvoiceID("ITA"); } }
        public static int TransportationBySea { get { return GetInvoiceID("ITS"); } }
        public static int CIP { get { return GetInvoiceID("CIP"); } }
        public static int Inventory { get { return GetInvoiceID("INV"); } }
        public static int LocalPurchase { get { return GetInvoiceID("LP"); } }
        public static int NonStandard { get { return GetInvoiceID("NS"); } }
        public static int ErrorCorrection { get { return GetInvoiceID("EC"); } }
        public static int Internal { get { return GetInvoiceID("INT"); } }

        public static int InternalSTV { get { return GetInvoiceID("ISTV"); } }

           private static int GetInvoiceID(string code)
           {
                InvoiceType it = new InvoiceType();
               it.Where.InvoiceTypeCode.Value = code;
               it.Query.Load();
               return it.ID;
           }
        }
}
