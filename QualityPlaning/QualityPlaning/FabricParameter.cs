using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityPlaning
{
    public class FabricParameter
    {
        public int Id { get; set; }
        public int TensileStrengthWarp { get; set; }
        public int TensileStrengthWeft { get; set; }
        public int TearingStrengthWarp { get; set; }
        public int TearingStrengthWeft { get; set; }
        public int CrockingFastnessDry { get; set; }
        public int CrockingFastnessWeft { get; set; }
        public int ColourFastnessWash { get; set; }
        public int ColourFastnessAcetate { get; set; }
        public int ColourFastnessCotton { get; set; }
        public int ColourFastnessNylon { get; set; }
        public int ColourFastnessPolyster { get; set; }
        public int ColourFastnessAcrylic { get; set; }
        public int ColourFastnessWool { get; set; }
        public int PH { get; set; }
        public int Moisture { get; set; }
        public int Steffness { get; set; }
        public int ReedSpace { get; set; }
        public int RPM { get; set; }
        public int Efficiency { get; set; }
        public int ValueLoss { get; set; }
        public int Remark { get; set; }

        //Navigational Property
        public int StyleId { get; set; }
        public Style Style { get; set; }
    }
}