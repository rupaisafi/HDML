using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class Booking
    {
        public int Id { get; set; }
        public int BookingDate { get; set; }
        public int BookingNo { get; set; }
        public int ProjectionDate { get; set; }
        public int DeliveryDate { get; set; }
        public int LCDate { get; set; }
        public int Status { get; set; }          
        public int PONo { get; set; }
        public int EndUser { get; set; }
        public int BuyerReference { get; set; }

        public int BuyerId { get; set; }
        public int CustomerId { get; set; }
        public int TeamLeaderId { get; set; }
        public int ProductTypeId { get; set; }
        public int BuyingHouseId { get; set; }       
        public int MarketingCardNo { get; set; }
        public int CustomerAddressId { get; set; }
        public int ContactPersonId { get; set; }
        public int MarketingPersonId { get; set; }
        public int MarketingEmployeeId { get; set; }
    }
}