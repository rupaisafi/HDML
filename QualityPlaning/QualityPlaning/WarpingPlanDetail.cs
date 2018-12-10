using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class WarpingPlanDetail
    {
        public int ID { get; set; }
        public int WarpingPlanID { get; set; }
        public int ItemName { get; set; }
        public int LotNo { get; set; }
        public int SupplierName { get; set; }
        public int YarnCode { get; set; }
        public int BeamLength { get; set; }
        public int NoOfBeam { get; set; }
        public int NoOfCreel { get; set; }
        public int EndsPerBeamOrBall { get; set; }
        public int TotalEnds { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }
        public int Remarks { get; set; }
    }
}