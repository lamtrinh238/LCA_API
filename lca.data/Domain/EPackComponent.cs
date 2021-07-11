using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackComponents")]
    public partial class EPackComponent
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("COM_ID")]
        public int? ComId { get; set; }
        public int? Dec1 { get; set; }
        public int? Dec2 { get; set; }
        public int? Dec3 { get; set; }
        [StringLength(500)]
        public string DecComments { get; set; }
    }
}
