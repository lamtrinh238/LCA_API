using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackAnalyser
    {
        public EPackAnalyser()
        {
            EPackAnalysePacklists = new HashSet<EPackAnalysePacklist>();
        }

        public int Id { get; set; }
        public int? ComId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductGroup { get; set; }
        public int? FpakDpak { get; set; }
        public int? DpakPall { get; set; }
        public double? NetWeight { get; set; }
        public string Comments { get; set; }
        public int? TransportGroup { get; set; }
        public int? NsEn { get; set; }
        public decimal? NoFpakT { get; set; }
        public decimal? NoDpakT { get; set; }
        public decimal? NoPallT { get; set; }
        public int? Anaid { get; set; }
        public double? SalesVolume { get; set; }
        public double? WasteVolume { get; set; }
        public double? WastePrecent { get; set; }

        public virtual ICollection<EPackAnalysePacklist> EPackAnalysePacklists { get; set; }
    }
}
