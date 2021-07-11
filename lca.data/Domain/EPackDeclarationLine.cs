using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackDeclarationLine")]
    public partial class EPackDeclarationLine
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PackTypeID")]
        public int? PackTypeId { get; set; }
        [Column("DeclarationID")]
        public int? DeclarationId { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("HelpTXT")]
        [StringLength(500)]
        public string HelpTxt { get; set; }
        [Column("ComponentsID")]
        public int? ComponentsId { get; set; }
        [Column("filDoc")]
        [StringLength(150)]
        public string FilDoc { get; set; }
    }
}
