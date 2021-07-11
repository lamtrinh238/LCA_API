using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBSupport")]
    public partial class Dbsupport
    {
        [Key]
        [Column("Support_ID")]
        public long SupportId { get; set; }
        public long UserId { get; set; }
        [Column("Support_Head")]
        [StringLength(100)]
        public string SupportHead { get; set; }
        [Column("Support_Body")]
        [StringLength(500)]
        public string SupportBody { get; set; }
        [Column("Support_From")]
        [StringLength(100)]
        public string SupportFrom { get; set; }
        [Column("Support_Date", TypeName = "datetime")]
        public DateTime? SupportDate { get; set; }
        [Column("Support_Status")]
        public int? SupportStatus { get; set; }
        [Column("Support_Type")]
        [StringLength(50)]
        public string SupportType { get; set; }
    }
}
