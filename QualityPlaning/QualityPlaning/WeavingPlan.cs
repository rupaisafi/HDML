using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class WeavingPlan
    {
        public int ID { get; set; }
        public int PlanID { get; set; }
        public int GreyWidth { get; set; }
        public int GreyLength { get; set; }
        public int GreyPPI { get; set; }
        public int WeftRatio { get; set; }
        public int Selvedge { get; set; }
        public int Weight { get; set; }
        public int WeftCount { get; set; }
        public int ProYarnLot { get; set; }
        public int ProYarnSupplier { get; set; }
        public int ReedSpace { get; set; }
        public int ReedCount { get; set; }
        public int EndsOrDents { get; set; }
        public int Leasing { get; set; }
        public int NoOfBeam { get; set; }
        public int BeamLength { get; set; }
    }
}