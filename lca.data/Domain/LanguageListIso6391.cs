using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("LanguageListISO6391")]
    public partial class LanguageListIso6391
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(100)]
        public string LanguageName { get; set; }
        [Column("ISO6391Code")]
        [StringLength(10)]
        public string Iso6391code { get; set; }
    }
}
