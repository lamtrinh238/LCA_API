using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epdshare
    {
        public int Id { get; set; }
        public int? EpdheadingId { get; set; }
        public int? Comid { get; set; }
        public int? Type { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public string Contact { get; set; }
        public int? FullSingleShare { get; set; }

        public virtual Epdheading Epdheading { get; set; }
    }
}
