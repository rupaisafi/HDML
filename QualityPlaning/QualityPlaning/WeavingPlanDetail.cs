using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class WeavingPlanDetail
    {
        public int ID { get; set; }
        public int WeavingPlanID { get; set; }
        public int ItemName { get; set; }
        public int LotNo { get; set; }
        public int SupplierName { get; set; }
        public int YarnCode { get; set; }
        public int YarnCount { get; set; }
        public int PickLength { get; set; }
        public int PPI { get; set; }
        public int WeftRatio { get; set; }
        public int TotalRatio { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }
        public int Remarks { get; set; }
    }
}