using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("SystemReportLayoutList")]
    public partial class SystemReportLayoutList
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(20)]
        public string LayoutName { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public int? System { get; set; }
        [StringLength(50)]
        public string LayoutFile { get; set; }
    }
}
