using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class TransportExpHeader
    {
        public int Id { get; set; }
        public long? ComId { get; set; }
        public int? UserId { get; set; }
        public string Transportname { get; set; }
        public string Comments { get; set; }

        public virtual Company Com { get; set; }
    }
}
