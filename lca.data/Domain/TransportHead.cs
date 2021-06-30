using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class TransportHead
    {
        public int TransportId { get; set; }
        public string TransportName { get; set; }
        public string TransportComments { get; set; }
    }
}
