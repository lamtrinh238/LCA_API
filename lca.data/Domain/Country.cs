using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("COUNTRY")]
    public partial class Country
    {
        [Key]
        [Column("int")]
        public int Int { get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }
        [StringLength(2)]
        public string Alpha2Code { get; set; }
        [StringLength(3)]
        public string Alpha3Code { get; set; }
        public int? NumericCode { get; set; }
        [StringLength(100)]
        public string Language { get; set; }
    }
}
