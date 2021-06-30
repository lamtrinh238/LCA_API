using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddataSetDocumentationRegistration
    {
        public EpddataSetDocumentationRegistration()
        {
            EpddataEn15804a1registrations = new HashSet<EpddataEn15804a1registration>();
            EpddataEn15804a2registrations = new HashSet<EpddataEn15804a2registration>();
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

        public virtual Epdheading Epdheading { get; set; }
        public virtual ICollection<EpddataEn15804a1registration> EpddataEn15804a1registrations { get; set; }
        public virtual ICollection<EpddataEn15804a2registration> EpddataEn15804a2registrations { get; set; }
    }
}
