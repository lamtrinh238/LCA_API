using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbavfallstyper
    {
        public short AvId { get; set; }
        public string AvName { get; set; }
        public decimal? Co2 { get; set; }
        public bool? Sjekk { get; set; }
    }
}
