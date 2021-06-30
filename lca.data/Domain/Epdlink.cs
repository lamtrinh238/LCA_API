using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epdlink
    {
        public int Id { get; set; }
        public int? EpdheadingId { get; set; }
        public int? EpdId { get; set; }
        public int? Type { get; set; }

        public virtual Epdheading Epdheading { get; set; }
    }
}
