//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POScreen.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwPOBrowseList
    {
        public string PurchaseOrder { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public string MStockCode { get; set; }
        public decimal MOrderQty { get; set; }
        public decimal MReceivedQty { get; set; }
        public Nullable<System.DateTime> MLatestDueDate { get; set; }
        public Nullable<System.DateTime> MLastReceiptDat { get; set; }
        public string MCompleteFlag { get; set; }
        public string Currency { get; set; }
        public string MStockDes { get; set; }
        public decimal Line { get; set; }
        public int PO { get; set; }
        public string MWarehouse { get; set; }
    }
}
