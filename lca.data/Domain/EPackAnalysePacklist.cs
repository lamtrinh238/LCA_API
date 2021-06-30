using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackAnalysePacklist
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? PackTypeId { get; set; }
        public int? PackMaterialId { get; set; }
        public double? PackNetWeight { get; set; }
        public string Comments { get; set; }
        public decimal? KgprT { get; set; }
        public decimal? Gwp { get; set; }
        public decimal? PrecentResirk { get; set; }

        public virtual EPackAnalyser Product { get; set; }
    }
}
