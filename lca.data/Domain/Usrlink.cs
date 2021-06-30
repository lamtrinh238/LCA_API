using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Usrlink
    {
        public long Id { get; set; }
        public long UsrId { get; set; }
        public long ComId { get; set; }
        public long UsrType { get; set; }

        public virtual User Usr { get; set; }
    }
}
