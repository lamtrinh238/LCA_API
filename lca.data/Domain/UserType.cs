using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("UserType")]
    public partial class UserType
    {
        [Column("UTPID")]
        public int Utpid { get; set; }
        [Column("UTP_Name")]
        [StringLength(50)]
        public string UtpName { get; set; }
    }
}
