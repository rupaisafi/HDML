using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class ExportPI
    {
        public int Id { get; set; }
        public int FactoryId { get; set; }
        public int PIDate { get; set; }
        public int ProductType { get; set; }
        public int BookingId { get; set; }
        public int BookingNo { get; set; }
        public int RevisedNo { get; set; }
        public int RevisedFromPIId { get; set; }
        public int RevisedFromPINo { get; set; }
        public int ParentPIId { get; set; }
        public int CustomerId { get; set; }
        public int CustomerAddressId { get; set; }
        public int CustomerContactPersonId { get; set; }
        public int BuyerId { get; set; }
        public int BuyingHouseId { get; set; }
        public int MarketEmployeeId { get; set; }
        public int CardNo { get; set; }
        public int BankId { get; set; }
        public int BankBranchId { get; set; }
        public int LCPaymentMode { get; set; }
        public int Tenor { get; set; }
        public int OfferValidateDate { get; set; }
        public int PIStatus { get; set; }
        public int LCPIStatus { get; set; }
        public int BuyerRef { get; set; }
        public int BinNo { get; set; }
        public int EndUser { get; set; }
        public int PONo { get; set; }
        public int BankName { get; set; }
        public int MarketingPerson { get; set; }
        public int PINo { get; set; }
        public int TeamLeaderId { get; set; }
    }
}