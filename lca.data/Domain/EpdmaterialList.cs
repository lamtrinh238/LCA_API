using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdmaterialList
    {
        public int Id { get; set; }
        public int EpdheadingId { get; set; }
        public string Name { get; set; }
        public string Range { get; set; }
        public int? Fase { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
    }
}
