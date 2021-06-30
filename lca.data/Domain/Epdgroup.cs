using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epdgroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public long? Comid { get; set; }
        public int? Type { get; set; }
    }
}
