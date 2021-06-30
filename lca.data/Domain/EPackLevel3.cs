using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackLevel3
    {
        public int? HeadId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public int? MainGroupId { get; set; }
        public string MainGroupName { get; set; }
        public int? ProductGroup { get; set; }
        public int? MaterialGroupId { get; set; }
        public string FEUnit { get; set; }
        public string GroupName { get; set; }
        public int? TransportGroup { get; set; }
        public double? SalesVolume { get; set; }
        public double? WasteVolume { get; set; }
        public double? WastePrecent { get; set; }
        public decimal? KgprT { get; set; }
        public double? Weight { get; set; }
        public decimal? Gwp { get; set; }
        public bool? PartOfSelection { get; set; }
        public int? PackTypeId { get; set; }
        public long? ComId { get; set; }
        public string ProductId { get; set; }
    }
}
