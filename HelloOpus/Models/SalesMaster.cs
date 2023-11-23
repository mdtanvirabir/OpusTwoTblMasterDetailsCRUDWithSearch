﻿namespace HelloOpus.Models
{
    public class SalesMaster
    {
        public int SalesMasterId { get; set; }
        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public virtual ICollection<SalesDetails> SalesDetails { get; set; } = new List<SalesDetails>();
    }
}
