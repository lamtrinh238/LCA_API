using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epddangerou
    {
        public int Id { get; set; }
        public int EpdheadingId { get; set; }
        public string Name { get; set; }
        public string Casno { get; set; }
        public string Among { get; set; }

        public virtual Epdheading Epdheading { get; set; }
    }
}
