using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class FinishParameter
    {
        public int Id { get; set; }
        public int WarpShrinkPercent { get; set; }
        public int WeftShrinkPercent { get; set; }
        public int ShrinkEnzyme { get; set; }
        public int ShrinkBleach { get; set; }
        public int FinishWeight { get; set; }
        public int WashWeight { get; set; }
        public int SkewPercent { get; set; }
        public int MovementPercent { get; set; }
        public int StretchAbilityPercent { get; set; }
        public int GrowthPercent { get; set; }
        public int RecoveryPercent { get; set; }
        public int Remark { get; set; }

        //Navigational Property
        public int StyleId { get; set; }
        public Style Style { get; set; }
    }
}