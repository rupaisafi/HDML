namespace QualityPlaning
{
    public class Plan
    {
        public int ID { get; set; }
        public int DevelopmentUnitID { get; set; }
        public int PlanDate { get; set; }
        public int SetID { get; set; }
        public int SetLength { get; set; }
        public int ProductionOrderID { get; set; }
        public int ProductionTypeID { get; set; }
        public int StyleID { get; set; }
        public int LikelyDeliveryDate { get; set; }
        public int SetPlanned { get; set; }
        public int PIWidth { get; set; }
        public int PIShrink { get; set; }
        public int RequestOrderProduction { get; set; }
        public int PreviousDyeProduction { get; set; }
        public int TakenProduction { get; set; }
        public int RemainingProduction { get; set; }
        public int CSV { get; set; }
        public int DyeLength { get; set; }
        public int WeaveLength { get; set; }
        public int FinishingLength { get; set; }
        public int InspectionLength { get; set; }
        public int RejectionLength { get; set; }
        public int Remark { get; set; }


        public virtual Style Style { get; set; }
        public virtual ProductionSet ProductionSet { get; set; }
        public virtual DevelopmentUnit DevelopmentUnit { get; set; }
        public virtual ProductionOrder ProductionOrder { get; set; }
        public virtual ProductionType ProductionType { get; set; }
        
    }
}