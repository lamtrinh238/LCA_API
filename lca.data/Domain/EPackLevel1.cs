using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackLevel1
    {
        public int? HeadId { get; set; }
        public string Name { get; set; }
        public int? MainGroupId { get; set; }
        public string GroupName { get; set; }
        public int? MaterialGroupId { get; set; }
        public string ProductGroup { get; set; }
        public string FEUnit { get; set; }
        public double? KgprT { get; set; }
        public double? Gwp { get; set; }
        public double? WastePrecent { get; set; }
        public double? SalesVolume { get; set; }
        public long? ComId { get; set; }
        public bool? PartOfSelection { get; set; }
        public int? PackTypeId { get; set; }
        public long? Expr1 { get; set; }
    }
}
