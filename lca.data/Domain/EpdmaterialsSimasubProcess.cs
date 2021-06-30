using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdmaterialsSimasubProcess
    {
        public int Id { get; set; }
        public int? MainId { get; set; }
        public int? SubId { get; set; }
        public int? ComId { get; set; }
        public string Fase { get; set; }
        public decimal? Value { get; set; }
    }
}
