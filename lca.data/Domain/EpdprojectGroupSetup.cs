using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdprojectGroupSetup
    {
        public int Id { get; set; }
        public int? GroupNr { get; set; }
        public string GroupName { get; set; }
        public int? Comid { get; set; }
    }
}
