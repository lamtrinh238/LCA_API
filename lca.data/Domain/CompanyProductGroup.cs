using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class CompanyProductGroup
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ComID")]
        public int? ComId { get; set; }
        [Column("ProductGroupID")]
        [StringLength(50)]
        public string ProductGroupId { get; set; }
        [StringLength(250)]
        public string ProductGroupName { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
    }
}
