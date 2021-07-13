using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDCustomerLine")]
    public partial class EpdcustomerLine
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("MaterialID")]
        public int? MaterialId { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("HelpTXT")]
        [StringLength(500)]
        public string HelpTxt { get; set; }
        [Column("type")]
        public int? Type { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.EpdcustomerLines))]
        public virtual Company Com { get; set; }
    }
}
