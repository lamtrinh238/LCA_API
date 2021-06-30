using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbsupport
    {
        public long SupportId { get; set; }
        public long UserId { get; set; }
        public string SupportHead { get; set; }
        public string SupportBody { get; set; }
        public string SupportFrom { get; set; }
        public DateTime? SupportDate { get; set; }
        public int? SupportStatus { get; set; }
        public string SupportType { get; set; }
    }
}
