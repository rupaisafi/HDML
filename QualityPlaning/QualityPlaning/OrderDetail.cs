using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int StyleCode { get; set; }
        public int StyleNo { get; set; }
        public int EndUser { get; set; }
        public int PONo { get; set; }
        public int Color { get; set; }
        public int Grade { get; set; }
        public int Width { get; set; }
        public int Weave { get; set; }
        public int ShrinkDesize { get; set; }
        public int ShrinkEnzyme { get; set; }
        public int ShrinkBleach { get; set; }
        public int OrderQuantityKg { get; set; }
        public int OrderQuantityMeter { get; set; }
        public int OrderCategory { get; set; }
        public int EPI { get; set; }
        public int PPI { get; set; }
        public int GreyConstruction { get; set; }
        public int TotalEnds { get; set; }
        public int Twile { get; set; }
        public int FinishRoute { get; set; }
        public int OrderStatus { get; set; }
        public int EntryBy { get; set; }
        public int EntryDate { get; set; }
        public int UpdateBy { get; set; }
        public int UpdateDate { get; set; }

    }
}