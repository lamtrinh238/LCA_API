using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddefaultA2
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int Epda2id { get; set; }
        public int? Epda2km { get; set; }
        public int? Epda2filling { get; set; }
        public int? Epda2return { get; set; }
        public int? Epda2reuse { get; set; }
        public string Epda2name { get; set; }
        public string Comments { get; set; }
        public int? GroupId { get; set; }
    }
}
