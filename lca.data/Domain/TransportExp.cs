using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class TransportExp
    {
        public int Id { get; set; }
        public int? Epda1id { get; set; }
        public string Epda1name { get; set; }
        public int? Epda2id { get; set; }
        public string Epda2name { get; set; }
        public decimal? Epda2km { get; set; }
        public string Comments { get; set; }
        public int? HeadId { get; set; }
        public decimal? Epda1kg { get; set; }
        public string Type { get; set; }
        public decimal? Co2 { get; set; }
        public int? LineId { get; set; }
    }
}
