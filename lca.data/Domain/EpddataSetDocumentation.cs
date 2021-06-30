using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddataSetDocumentation
    {
        public EpddataSetDocumentation()
        {
            EpddataEn15804a1s = new HashSet<EpddataEn15804a1>();
            EpddataEn15804a2s = new HashSet<EpddataEn15804a2>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string DatasetMainName { get; set; }
        public string Unit { get; set; }
        public decimal? UnitCalc { get; set; }
        public int? DatasetType { get; set; }
        public int? MaterialMainGroupId { get; set; }
        public decimal? ScenarioFactor { get; set; }
        public string ScenarioUnit { get; set; }
        public decimal? ScenarioPercent { get; set; }
        public string Version { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? CreatedBy { get; set; }
        public int? CheckedBy { get; set; }
        public string InternalDescription { get; set; }
        public string InternalComments { get; set; }
        public string BackgroundLcadataSet { get; set; }
        public string Location { get; set; }
        public string DataSource { get; set; }
        public string DataSourceQuality { get; set; }
        public string YearOfStudy { get; set; }
        public string DataQualityAssessment { get; set; }
        public string DescriptionLcareport { get; set; }
        public string Geographical { get; set; }
        public string Technological { get; set; }
        public string Temporal { get; set; }
        public int? Active { get; set; }

        public virtual ICollection<EpddataEn15804a1> EpddataEn15804a1s { get; set; }
        public virtual ICollection<EpddataEn15804a2> EpddataEn15804a2s { get; set; }
    }
}
