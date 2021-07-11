using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDAnalysisList")]
    public partial class EpdanalysisList
    {
        public EpdanalysisList()
        {
            EpdanalysisFases = new HashSet<EpdanalysisFase>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDAnalysisID")]
        public int? EpdanalysisId { get; set; }
        [Column("AnaID")]
        public int? AnaId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        [Column("Unit_calc", TypeName = "decimal(18, 4)")]
        public decimal? UnitCalc { get; set; }

        [ForeignKey(nameof(EpdanalysisId))]
        [InverseProperty("EpdanalysisLists")]
        public virtual Epdanalysis Epdanalysis { get; set; }
        [InverseProperty(nameof(EpdanalysisFase.Epdheading))]
        public virtual ICollection<EpdanalysisFase> EpdanalysisFases { get; set; }
    }
}
