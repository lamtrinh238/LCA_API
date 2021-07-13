using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("USRLinks")]
    public partial class Usrlink
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("USR_ID")]
        public long UsrId { get; set; }
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("USR_TYPE")]
        public long UsrType { get; set; }

        [ForeignKey(nameof(UsrId))]
        [InverseProperty(nameof(User.Usrlinks))]
        public virtual User Usr { get; set; }
    }
}
