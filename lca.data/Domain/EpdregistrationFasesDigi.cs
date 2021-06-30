using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdregistrationFasesDigi
    {
        public int Id { get; set; }
        public int EpdheadingId { get; set; }
        public int EpdrecId { get; set; }
        public string Epdname { get; set; }
        public decimal? Epdquantity { get; set; }
        public string Comments { get; set; }
        public string Epdunit { get; set; }
        public int? Type { get; set; }
        public decimal? UnitCalc { get; set; }
        public decimal? A1 { get; set; }
        public decimal? A2 { get; set; }
        public decimal? A3 { get; set; }
        public decimal? A4 { get; set; }
        public decimal? A5 { get; set; }
        public decimal? B1 { get; set; }
        public decimal? B2 { get; set; }
        public decimal? B3 { get; set; }
        public decimal? B4 { get; set; }
        public decimal? B5 { get; set; }
        public decimal? B6 { get; set; }
        public decimal? B7 { get; set; }
        public decimal? C1 { get; set; }
        public decimal? C2 { get; set; }
        public decimal? C3 { get; set; }
        public decimal? C4 { get; set; }
        public decimal? D1 { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual EpdheadingDigi Epdheading { get; set; }
    }
}
