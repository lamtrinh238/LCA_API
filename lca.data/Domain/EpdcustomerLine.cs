using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdcustomerLine
    {
        public int Id { get; set; }
        public long? ComId { get; set; }
        public int? MaterialId { get; set; }
        public string Comments { get; set; }
        public string HelpTxt { get; set; }
        public int? Type { get; set; }

        public virtual Company Com { get; set; }
    }
}
