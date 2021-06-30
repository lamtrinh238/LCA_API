using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbbehandlingssted
    {
        public short BehandlingId { get; set; }
        public string Behandlingssted { get; set; }
        public decimal? Co2 { get; set; }
    }
}
