using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("CompanyProductList")]
    public partial class CompanyProductList
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ComID")]
        public int? ComId { get; set; }
        [Column("ProductID")]
        [StringLength(50)]
        public string ProductId { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        public int? ProductGroup { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        public long? DataSet { get; set; }
        public int? DataSetType { get; set; }
    }
}
