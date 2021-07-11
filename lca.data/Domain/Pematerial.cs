using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("PEMaterials")]
    public partial class Pematerial
    {
        [Column("PEMatID")]
        public int PematId { get; set; }
        [Column("PEMatName")]
        public string PematName { get; set; }
    }
}
