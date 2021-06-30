using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackGwplevel2
    {
        public long? ComId { get; set; }
        public int? HeadId { get; set; }
        public string Name { get; set; }
        public int? ProductGroup { get; set; }
        public string EpdmaterialName { get; set; }
        public string MainGroupName { get; set; }
        public double? SalesVolume { get; set; }
        public string Gwpname { get; set; }
        public string FEUnit { get; set; }
        public double? Gwp { get; set; }
    }
}
