//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmsWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public Nullable<int> EventId { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> OriginalPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    
        public virtual Event Event { get; set; }
    }
}
