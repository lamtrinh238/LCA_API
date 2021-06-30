using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Comsw
    {
        public int Id { get; set; }
        public long ComId { get; set; }
        public int? SwType { get; set; }
        public int? SwId { get; set; }

        public virtual Company Com { get; set; }
    }
}
