using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class PlanningOrder
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int OrderNo { get; set; }
        public int OrderId { get; set; }
        public int PINo { get; set; }
        public int MarketingPerson { get; set; }
        public int MarketingEmployeeId { get; set; }
        public int OrderQuantityYds { get; set; }
        public int RequireQuantityMeter { get; set; }
        public int PreviousDyeProductionMeter { get; set; }
        public int PIId { get; set; }
        public int LCId { get; set; }
        public int LCNo { get; set; }
        public int Buyer { get; set; }
        public int BuyerId { get; set; }
        public int CustomerId { get; set; }
    }
}