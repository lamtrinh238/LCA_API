using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ASPStateTempApplications")]
    [Index(nameof(AppName), Name = "Index_AppName")]
    public partial class AspstateTempApplication
    {
        [Key]
        public int AppId { get; set; }
        [Required]
        [StringLength(280)]
        public string AppName { get; set; }
    }
}
