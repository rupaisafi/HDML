namespace QualityPlaning
{
    public class WarpingPlan
    {
        public int ID { get; set; }
        public int PlanID { get; set; }
        public int SetLengthMeter { get; set; }
        public int WarpRatio { get; set; }
        public int TotalEnds { get; set; }
        public int YarnTension { get; set; }
        public int MachineSpeed { get; set; }
        public int PressingForce { get; set; }
        public int Construction { get; set; }
        public int ProYarnLot { get; set; }
        public int ProYarnSupplier { get; set; }
    }
}