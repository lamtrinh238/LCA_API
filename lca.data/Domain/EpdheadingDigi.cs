using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdheadingDigi
    {
        public EpdheadingDigi()
        {
            EpdregistrationFasesDigis = new HashSet<EpdregistrationFasesDigi>();
        }

        public int Id { get; set; }
        public string Epdnumber { get; set; }
        public string Epdname { get; set; }
        public string Epddescription { get; set; }
        public string Epdspesification { get; set; }
        public string Epdtech { get; set; }
        public string Epdmarket { get; set; }
        public long? UserId { get; set; }
        public DateTime? Epddate { get; set; }
        public DateTime? EpdapprovedDate { get; set; }
        public DateTime? EpdexpirationDate { get; set; }
        public string Epdeditor { get; set; }
        public string Epdresponsible { get; set; }
        public int? Epdstatus { get; set; }
        public string Comments { get; set; }
        public string EpdpicturePath { get; set; }
        public string Epdunit { get; set; }
        public string Epdpicture2 { get; set; }
        public string EpdintNum { get; set; }
        public string Epdpcr { get; set; }
        public string EpdproductionSite { get; set; }
        public int? Epdyear { get; set; }
        public string EpdsysBound { get; set; }
        public string Epdallocation { get; set; }
        public string EpddataQuality { get; set; }
        public string EpdcutOff { get; set; }
        public string EpdaddTech { get; set; }
        public string EpdindoorEnv { get; set; }
        public string Epdbibllio { get; set; }
        public long? ComId { get; set; }
        public decimal? EpdunitCalc { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string A4 { get; set; }
        public string A5 { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
        public string B3 { get; set; }
        public string B4 { get; set; }
        public string B5 { get; set; }
        public string B6 { get; set; }
        public string B7 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string D1 { get; set; }
        public int? Epdlayout { get; set; }
        public string EpdproductLife { get; set; }
        public string EpdbuildingLife { get; set; }
        public int? GroupId { get; set; }
        public int? ProductionSiteId { get; set; }
        public int? Epddangerous { get; set; }
        public string Epdscenarios { get; set; }
        public Guid? Guid { get; set; }
        public int? Version { get; set; }
        public int? EpddefaultEpdid { get; set; }
        public string Epdlanguage { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? NoEdit { get; set; }
        public int? EpdsubType { get; set; }
        public int? EpdpcrId { get; set; }
        public Guid? ProductFlowDatasetId { get; set; }
        public Guid? PdfsourceDatasetId { get; set; }
        public string EpdcomOnEnvImp { get; set; }
        public string EpdfuncUnitDesc { get; set; }
        public int? ManufacturerId { get; set; }
        public string EpdUrl { get; set; }
        public int? ThirdPartyVerifier { get; set; }
        public int? Epd2digiPluss { get; set; }

        public virtual Company Com { get; set; }
        public virtual ICollection<EpdregistrationFasesDigi> EpdregistrationFasesDigis { get; set; }
    }
}
