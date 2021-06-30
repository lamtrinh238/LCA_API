using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class News
    {
        public long NwsId { get; set; }
        public string NwsHead { get; set; }
        public string NwsDetail { get; set; }
        public DateTime? NwsDate { get; set; }
        public DateTime? NwsExpDate { get; set; }
        public string NwsPicture { get; set; }
    }
}
