using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdregisterMain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? ComId { get; set; }
        public string Comments { get; set; }
        public int? Register { get; set; }
        public int? MenuFunction { get; set; }
        public string Fase { get; set; }
        public string Fase2 { get; set; }
    }
}
