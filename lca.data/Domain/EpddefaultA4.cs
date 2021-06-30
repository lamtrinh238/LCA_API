using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddefaultA4
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int Epda4id { get; set; }
        public int? Epda4km { get; set; }
        public int? Epda4filling { get; set; }
        public int? Epda4return { get; set; }
        public int? Epda4reuse { get; set; }
        public string Epda4name { get; set; }
        public string Comments { get; set; }
        public int? GroupId { get; set; }
    }
}
