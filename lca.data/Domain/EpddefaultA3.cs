using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddefaultA3
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int Epda3id { get; set; }
        public string Epda3name { get; set; }
        public decimal? Epda3quantity { get; set; }
        public string Comments { get; set; }
        public string Epda3unit { get; set; }
        public int? GroupId { get; set; }
        public int? Type { get; set; }
        public decimal? UnitCalc { get; set; }
    }
}
