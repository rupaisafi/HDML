namespace QualityPlaning
{
    public class QualityPlan
    {
        public int ID { get; set; }
        public int PlanID { get; set; }
        public int GreyConstruction { get; set; }
        public int FabricConstruction { get; set; }
        public int WarpRatio { get; set; }
        public int WeftRatio { get; set; }
        public int TotalEnds { get; set; }
        public int Weave { get; set; }
        public int Color { get; set; }
        public int SetStandard { get; set; }
        public int GreyWidth { get; set; }
        public int GreyWeight { get; set; }
        public int GreyEPI { get; set; }
        public int GreyPPI { get; set; }
        public int ReedSpace { get; set; }
        public int ReedCount { get; set; }
        public int EndsOrDents { get; set; }
        public int FinishWidth { get; set; }
        public int FinishLength { get; set; }
        public int FinishRoute { get; set; }
        public int WarpShrinkPercent { get; set; }
        public int WeftShrinkPercent { get; set; }
        public int YarnCode { get; set; }
        public int Weight { get; set; }
        public int FabricTypeID { get; set; }
        public int FabricDescription { get; set; }
        public int ShadeIndigo { get; set; }
        public int ShadeBlack { get; set; }
        public int FinishWeight { get; set; }
        public int WashWeight { get; set; }
        public int SkewPercent { get; set; }
        public int MovementPercent { get; set; }
        public int StretchAbilityPercent { get; set; }
    }
}