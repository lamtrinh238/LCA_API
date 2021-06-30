using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class PackElementer
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? PetypeId { get; set; }
        public int? PematId { get; set; }
        public double? Penettovekt { get; set; }
    }
}
