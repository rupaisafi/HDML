using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class DyeingPlanDetail
    {
        public int Id { get; set; }
        public int DyeingPlanId { get; set; }
        public int ItemName { get; set; }
        public int SupplierName { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }
        public int Remarks { get; set; }
    }
}