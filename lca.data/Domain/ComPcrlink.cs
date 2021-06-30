using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class ComPcrlink
    {
        public int Id { get; set; }
        public long ComId { get; set; }
        public int? PcrId { get; set; }

        public virtual Company Com { get; set; }
    }
}
