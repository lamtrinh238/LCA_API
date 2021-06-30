using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Calheading
    {
        public int Id { get; set; }
        public int? Calstatus { get; set; }
        public string Calname { get; set; }
        public DateTime? Caldate { get; set; }
        public decimal? Calquantity { get; set; }
        public decimal? Caldistance { get; set; }
        public int? Calbiogass { get; set; }
        public int? Calbiorest { get; set; }
        public int? Calstorage { get; set; }
        public decimal? Calbiopig { get; set; }
        public decimal? Calbiomeet { get; set; }
        public int? Calreference { get; set; }
        public int? Calburnrate { get; set; }
        public decimal? Caldistance2 { get; set; }
        public long? UserId { get; set; }
        public string Comments { get; set; }
        public long? ComId { get; set; }
        public string CalBiogassTxt { get; set; }
        public string CalBiorestTxt { get; set; }
        public string CalstorageTxt { get; set; }
        public string CalreferenceTxt { get; set; }
        public string CalburnrateTxt { get; set; }
        public decimal? Caldistance3 { get; set; }
        public decimal? Caldistance4 { get; set; }

        public virtual Company Com { get; set; }
    }
}
