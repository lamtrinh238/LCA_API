using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Impact
    {
        public string ImpactId { get; set; }
        public string ProcessId { get; set; }
        public string ImpactCategory { get; set; }
        public string ImpactScalar { get; set; }
    }
}
