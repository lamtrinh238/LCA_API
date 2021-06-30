using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class ComProcessLink
    {
        public int Id { get; set; }
        public long ComId { get; set; }
        public int? ProcessId { get; set; }
        public string ProcessName { get; set; }

        public virtual Company Com { get; set; }
    }
}
