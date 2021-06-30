using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epdpcrlink
    {
        public int Id { get; set; }
        public int? Pcrid { get; set; }
        public int? ProcessId { get; set; }
        public int? ComId { get; set; }
        public string Fase { get; set; }
        public decimal? Epdquantity { get; set; }
    }
}
