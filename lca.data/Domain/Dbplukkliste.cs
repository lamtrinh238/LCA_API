using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbplukkliste
    {
        public int Id { get; set; }
        public long PlukkId { get; set; }
        public short? AvId { get; set; }
        public string AvNavn { get; set; }
        public decimal? Prosent { get; set; }

        public virtual DbplukkHead Plukk { get; set; }
    }
}
