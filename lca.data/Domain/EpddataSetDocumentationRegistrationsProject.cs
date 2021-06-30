using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddataSetDocumentationRegistrationsProject
    {
        public EpddataSetDocumentationRegistrationsProject()
        {
            EpddataEn15804a1registrationsProjects = new HashSet<EpddataEn15804a1registrationsProject>();
            EpddataEn15804a2registrationsProjects = new HashSet<EpddataEn15804a2registrationsProject>();
        }

        public long Id { get; set; }
        public int EpdheadingId { get; set; }
        public int EpdrecId { get; set; }
        public string Epdname { get; set; }
        public decimal? Epdquantity { get; set; }
        public string Comments { get; set; }
        public string Epdunit { get; set; }
        public decimal? Epdfilling { get; set; }
        public decimal? Epdreuse { get; set; }
        public decimal? Epdreturn { get; set; }
        public int? Epdbit { get; set; }
        public int? OldId { get; set; }
        public int? Type { get; set; }
        public decimal? UnitCalc { get; set; }
        public int? GroupId { get; set; }
        public decimal? UnitCalcT { get; set; }
        public int? Fase { get; set; }
        public int? EpdrefId { get; set; }
        public string EpdrefName { get; set; }
        public int? DatasetType { get; set; }
        public decimal? ReCyclePer { get; set; }
        public DateTime? LastUpdate { get; set; }
        public decimal? WastagePer { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual EpdprojectHeading Epdheading { get; set; }
        public virtual ICollection<EpddataEn15804a1registrationsProject> EpddataEn15804a1registrationsProjects { get; set; }
        public virtual ICollection<EpddataEn15804a2registrationsProject> EpddataEn15804a2registrationsProjects { get; set; }
    }
}
