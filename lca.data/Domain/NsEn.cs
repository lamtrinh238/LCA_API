using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("NS-EN")]
    public partial class NsEn
    {
        [Column("NS-ENID")]
        public int NsEnid { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        [Column("ReportID")]
        public int? ReportId { get; set; }
        [Column("PETypeID")]
        public int? PetypeId { get; set; }
        [StringLength(255)]
        public string Evidence { get; set; }
        public string Commentary { get; set; }
    }
}
