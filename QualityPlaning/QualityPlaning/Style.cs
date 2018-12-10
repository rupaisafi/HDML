using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class Style
    {
        public int ID { get; set; }
        public int StyleNo { get; set; }
        public int ProductionDate { get; set; }
        public int DevelopmentDate { get; set; }
        public int FabricCode { get; set; }
        public int FabricCode1 { get; set; }
        public int FabricStyle { get; set; }
        public int FabricStyle1 { get; set; }
        public int Weight { get; set; }
        public int Weave { get; set; }
        public int PIShrinkage { get; set; }
        public int TotalWidth { get; set; }
        public int CutWidth { get; set; }
        public int GreyConstruction { get; set; }
        public int FinishConstruction { get; set; }
        public int YarnCode { get; set; }
        public int Composition { get; set; }
        public int ShrinkPercent { get; set; }
        public int WarpWeftRatio { get; set; }
        public int TotalEnds { get; set; }
        public int ColorCode { get; set; }
        public int ColorName { get; set; }
        public int ShadeIndigoPercent { get; set; }
        public int ShadeBlackPercent { get; set; }
        public int WarpSupplier { get; set; }
        public int WarpLot { get; set; }
        public int CrimpPercent { get; set; }
        public int CSV { get; set; }
        public int BuyerRef { get; set; }
        public int IsUpdate { get; set; }

        //Navigational property
        //public int DevelopmentUnitID { get; set; }
        public DevelopmentUnit DevelopmentUnit { get; set; }
        //public int FabricTypeID { get; set; }
        public FabricType FabricType { get; set; }
        //public int FinishTypeID { get; set; }
        public FinishType FinishType { get; set; }
        //public int FinishRouteID { get; set; }
        public FinishRoute FinishRoute { get; set; }
        //public int UnitID { get; set; }
        public MeasurementUnit Unit { get; set; }
        //public int GreadCodeID { get; set; }
        public GreadCode GreadCode { get; set; }
        //public int SpecialityID { get; set; }
        public Speciality Speciality { get; set; }
        //public int GreyParameterID { get; set; }
        public GreyParameter GreyParameter { get; set; }
        //public int FabricParameterID { get; set; }
        public FabricParameter FabricParameter { get; set; }
        //public int FinishParameterID { get; set; }
        public FinishParameter FinishParameter { get; set; }        
    }
}