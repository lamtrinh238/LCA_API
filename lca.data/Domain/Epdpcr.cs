using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDPCR")]
    public partial class Epdpcr
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PCRName")]
        [StringLength(200)]
        public string Pcrname { get; set; }
        [Column("PCRNumber")]
        [StringLength(50)]
        public string Pcrnumber { get; set; }
        [StringLength(50)]
        public string Version { get; set; }
        [Column("UUID")]
        public Guid? Uuid { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValidToDate { get; set; }
        [StringLength(50)]
        public string ProgramOperator { get; set; }
        [Column("PCRURL")]
        [StringLength(100)]
        public string Pcrurl { get; set; }
        [StringLength(500)]
        public string Fase { get; set; }
    }
}
