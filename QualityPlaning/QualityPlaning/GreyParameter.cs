namespace QualityPlaning
{
    public class GreyParameter
    {
        public int Id { get; set; }
        public int WarpShrinkPercent { get; set; }
        public int WeftShrinkPercent { get; set; }
        public int CrimpPercent { get; set; }
        public int FinishWeight { get; set; }
        public int WashWeight { get; set; }
        public int SkewPercent { get; set; }
        public int StretchAbilityPercent { get; set; }
        public int Width { get; set; }
        public int GreyEPI { get; set; }
        public int GreyPPI { get; set; }
        public int ReedCount { get; set; }
        public int EndsOrDent { get; set; }
        public int CostRPM { get; set; }
        public int CostEfficiency { get; set; }
        public int Remark { get; set; }

        //Navigational Property
        public int StyleId { get; set; }
        public Style Style { get; set; }
    }
}