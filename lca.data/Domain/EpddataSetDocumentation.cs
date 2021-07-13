using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDDataSetDocumentation")]
    public partial class EpddataSetDocumentation
    {
        public EpddataSetDocumentation()
        {
            EpddataEn15804a1s = new HashSet<EpddataEn15804a1>();
            EpddataEn15804a2s = new HashSet<EpddataEn15804a2>();
        }

        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [StringLength(100)]
        public string Code { get; set; }
        [StringLength(200)]
        public string DatasetMainName { get; set; }
        [StringLength(20)]
        public string Unit { get; set; }
        [Column("Unit_calc", TypeName = "decimal(29, 9)")]
        public decimal? UnitCalc { get; set; }
        public int? DatasetType { get; set; }
        [Column("MaterialMainGroupID")]
        public int? MaterialMainGroupId { get; set; }
        [Column(TypeName = "decimal(29, 9)")]
        public decimal? ScenarioFactor { get; set; }
        [StringLength(20)]
        public string ScenarioUnit { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? ScenarioPercent { get; set; }
        [StringLength(20)]
        public string Version { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        public int? CreatedBy { get; set; }
        public int? CheckedBy { get; set; }
        [StringLength(200)]
        public string InternalDescription { get; set; }
        [StringLength(200)]
        public string InternalComments { get; set; }
        [Column("BackgroundLCADataSet")]
        [StringLength(200)]
        public string BackgroundLcadataSet { get; set; }
        [StringLength(10)]
        public string Location { get; set; }
        [StringLength(50)]
        public string DataSource { get; set; }
        [StringLength(50)]
        public string DataSourceQuality { get; set; }
        [StringLength(10)]
        public string YearOfStudy { get; set; }
        [StringLength(200)]
        public string DataQualityAssessment { get; set; }
        [Column("DescriptionLCAReport")]
        [StringLength(200)]
        public string DescriptionLcareport { get; set; }
        [StringLength(200)]
        public string Geographical { get; set; }
        [StringLength(50)]
        public string Technological { get; set; }
        [StringLength(50)]
        public string Temporal { get; set; }
        public int? Active { get; set; }

        [InverseProperty(nameof(EpddataEn15804a1.ParentDataSet))]
        public virtual ICollection<EpddataEn15804a1> EpddataEn15804a1s { get; set; }
        [InverseProperty(nameof(EpddataEn15804a2.ParentDataSet))]
        public virtual ICollection<EpddataEn15804a2> EpddataEn15804a2s { get; set; }
    }
}
