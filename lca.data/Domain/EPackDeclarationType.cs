using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackDeclarationType")]
    public partial class EPackDeclarationType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PackTypeID")]
        public int? PackTypeId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("HelpTXT")]
        [StringLength(500)]
        public string HelpTxt { get; set; }
        [Column("DeclarationID")]
        public int? DeclarationId { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        public int? DecChoice { get; set; }
        [StringLength(500)]
        public string DecComments { get; set; }
        [Column("filDoc")]
        [StringLength(150)]
        public string FilDoc { get; set; }
    }
}
