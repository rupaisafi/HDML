using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class BookingDetail
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int StyleNo { get; set; }
        public int StyleCode { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int Composition { get; set; }
        public int Construction { get; set; }
        public int Colour { get; set; }
        public int Width { get; set; }
        public int Weave { get; set; }
        public int Weight { get; set; }
        public int ShrinkDesize { get; set; }
        public int ShrinkEnzyme { get; set; }
        public int ShrinkBleach { get; set; }
        public int HSCode { get; set; }
        public int Grade { get; set; }
        public int Unit { get; set; }
        public int EndUser { get; set; }
        public int PONo { get; set; }
    }
}