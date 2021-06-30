using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class NsEn
    {
        public int NsEnid { get; set; }
        public int? ProductId { get; set; }
        public int? ReportId { get; set; }
        public int? PetypeId { get; set; }
        public string Evidence { get; set; }
        public string Commentary { get; set; }
    }
}
