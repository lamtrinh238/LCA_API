using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbbehandlingsmate
    {
        public short BehandId { get; set; }
        public string Behandling { get; set; }
        public decimal? Co2 { get; set; }
    }
}
