using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("PETypes")]
    public partial class Petype
    {
        [Column("PETypeID")]
        public int PetypeId { get; set; }
        [Column("PETypeName")]
        public string PetypeName { get; set; }
    }
}
