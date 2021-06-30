using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Comlink
    {
        public long Id { get; set; }
        public long ComId { get; set; }
        public long LinkId { get; set; }
        public int? Type { get; set; }

        public virtual Company Com { get; set; }
    }
}
