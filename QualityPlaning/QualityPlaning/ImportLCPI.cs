using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class ImportLCPI
    {
        public int ID { get; set; }
        public int LCID { get; set; }
        public int LCNo { get; set; }
        public int LCDate { get; set; }
        public int CostRate { get; set; }
        public int AmendmentDate { get; set; }
        public int AmendmentNo { get; set; }

        public int PIID { get; set; }
        public int PINo { get; set; }
        public int PIDate { get; set; }
        public int PIAmount { get; set; }
        public int PIQuantiy { get; set; }
        public int PIUnit { get; set; }
    }
}