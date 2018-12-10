using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public int OrderDate { get; set; }
        public int RequireDate { get; set; }
        public int BookingId { get; set; }
        public int BookingNo { get; set; }
        public int BookingDate { get; set; }
        public int MarketingEmployeeId { get; set; }
        public int TeamLeaderId { get; set; }
        public int CustomerId { get; set; }
        public int BuyerId { get; set; }
        public int CustomerAddressId { get; set; }
        public int ContactPerson { get; set; }
        public int ContactNo { get; set; }
        public int OrderStatus { get; set; }
        public int EntryBy { get; set; }
        public int EntryDate { get; set; }
        public int UpdateBy { get; set; }
        public int UpdateDate { get; set; }

    }
}