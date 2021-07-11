using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDDataSetDocumentationRegistrationsProjects")]
    public partial class EpddataSetDocumentationRegistrationsProject
    {
        public EpddataSetDocumentationRegistrationsProject()
        {
            EpddataEn15804a1registrationsProjects = new HashSet<EpddataEn15804a1registrationsProject>();
            EpddataEn15804a2registrationsProjects = new HashSet<EpddataEn15804a2registrationsProject>();
        }

        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("EPDHeadingID")]
        public int EpdheadingId { get; set; }
        [Column("EPDRecID")]
        public int EpdrecId { get; set; }
        [Column("EPDName")]
        [StringLength(500)]
        public string Epdname { get; set; }
        [Column("EPDQuantity", TypeName = "decimal(29, 9)")]
        public decimal? Epdquantity { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("EPDUnit")]
        [StringLength(50)]
        public string Epdunit { get; set; }
        [Column("EPDFilling", TypeName = "decimal(18, 9)")]
        public decimal? Epdfilling { get; set; }
        [Column("EPDReuse", TypeName = "decimal(18, 9)")]
        public decimal? Epdreuse { get; set; }
        [Column("EPDReturn", TypeName = "decimal(18, 9)")]
        public decimal? Epdreturn { get; set; }
        [Column("EPDBit")]
        public int? Epdbit { get; set; }
        [Column("OldID")]
        public int? OldId { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("Unit_calc", TypeName = "decimal(29, 9)")]
        public decimal? UnitCalc { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
        [Column("Unit_calcT", TypeName = "decimal(26, 12)")]
        public decimal? UnitCalcT { get; set; }
        public int? Fase { get; set; }
        [Column("EPDRefID")]
        public int? EpdrefId { get; set; }
        [Column("EPDRefName")]
        [StringLength(500)]
        public string EpdrefName { get; set; }
        public int? DatasetType { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? ReCyclePer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? WastagePer { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        [StringLength(500)]
        public string ProductName { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty(nameof(EpdprojectHeading.EpddataSetDocumentationRegistrationsProjects))]
        public virtual EpdprojectHeading Epdheading { get; set; }
        [InverseProperty(nameof(EpddataEn15804a1registrationsProject.ParentDataSet))]
        public virtual ICollection<EpddataEn15804a1registrationsProject> EpddataEn15804a1registrationsProjects { get; set; }
        [InverseProperty(nameof(EpddataEn15804a2registrationsProject.ParentDataSet))]
        public virtual ICollection<EpddataEn15804a2registrationsProject> EpddataEn15804a2registrationsProjects { get; set; }
    }
}
