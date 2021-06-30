using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class TransportDistance
    {
        public int TransportDistId { get; set; }
        public int? TransportId { get; set; }
        public int? EpdmaterialsSimaid { get; set; }
        public string TransportDistName { get; set; }
        public decimal? TransportDistKm { get; set; }
        public string TransportDistComment { get; set; }
    }
}
