using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Wcparameter
    {
        public string Sector { get; set; }
        public decimal? WastePrecent { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? WasteTonne { get; set; }
        public decimal? CalcKeyNum { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Co2 { get; set; }
    }
}
