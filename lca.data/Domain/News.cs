using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("NEWS")]
    public partial class News
    {
        [Column("NWS_ID")]
        public long NwsId { get; set; }
        [Column("NWS_Head")]
        [StringLength(200)]
        public string NwsHead { get; set; }
        [Column("NWS_Detail")]
        [StringLength(4000)]
        public string NwsDetail { get; set; }
        [Column("NWS_Date", TypeName = "datetime")]
        public DateTime? NwsDate { get; set; }
        [Column("NWS_ExpDate", TypeName = "datetime")]
        public DateTime? NwsExpDate { get; set; }
        [Column("NWS_Picture")]
        [StringLength(200)]
        public string NwsPicture { get; set; }
    }
}
