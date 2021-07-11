using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDAnalysis")]
    public partial class Epdanalysis
    {
        public Epdanalysis()
        {
            EpdanalysisLists = new HashSet<EpdanalysisList>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ANANumber")]
        [StringLength(50)]
        public string Ananumber { get; set; }
        [Column("ANAName")]
        [StringLength(1000)]
        public string Ananame { get; set; }
        [Column("ANADescription1")]
        [StringLength(5000)]
        public string Anadescription1 { get; set; }
        [Column("ANASpesification")]
        [StringLength(5000)]
        public string Anaspesification { get; set; }
        [Column("ANATech")]
        [StringLength(5000)]
        public string Anatech { get; set; }
        [Column("ANAMarket")]
        [StringLength(5000)]
        public string Anamarket { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }
        [Column("EPDDate", TypeName = "date")]
        public DateTime? Epddate { get; set; }
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("RefID")]
        public int? RefId { get; set; }
        [Column("AnaID")]
        public int? AnaId { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Epdanalyses))]
        public virtual Company Com { get; set; }
        [InverseProperty(nameof(EpdanalysisList.Epdanalysis))]
        public virtual ICollection<EpdanalysisList> EpdanalysisLists { get; set; }
    }
}
