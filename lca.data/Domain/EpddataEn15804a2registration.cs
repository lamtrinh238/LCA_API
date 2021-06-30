using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpddataEn15804a2registration
    {
        public long Id { get; set; }
        public long? ParentDataSetId { get; set; }
        public int? OldSimaId { get; set; }
        public string EpdprocessName { get; set; }
        public string InternalComments { get; set; }
        public string Version { get; set; }
        public decimal? Gwptotal { get; set; }
        public decimal? Gwpfossil { get; set; }
        public decimal? Gwpbiogenic { get; set; }
        public decimal? Gwpluluc { get; set; }
        public decimal? Odp { get; set; }
        public decimal? Ap { get; set; }
        public decimal? Epfreshwater { get; set; }
        public decimal? Epmarine { get; set; }
        public decimal? Epterrestrial { get; set; }
        public decimal? Pocp { get; set; }
        public decimal? Adpminerals { get; set; }
        public decimal? Adpfossil { get; set; }
        public decimal? Wdp { get; set; }
        public decimal? Pm { get; set; }
        public decimal? Irp { get; set; }
        public decimal? Etpfw { get; set; }
        public decimal? Htpc { get; set; }
        public decimal? Htpnc { get; set; }
        public decimal? Sqp { get; set; }
        public decimal? Rpee { get; set; }
        public decimal? Rpem { get; set; }
        public decimal? Tpe { get; set; }
        public decimal? Nrpe { get; set; }
        public decimal? Nrpm { get; set; }
        public decimal? Trpe { get; set; }
        public decimal? Sm { get; set; }
        public decimal? Rsf { get; set; }
        public decimal? Nrsf { get; set; }
        public decimal? W { get; set; }
        public decimal? Hw { get; set; }
        public decimal? Nhw { get; set; }
        public decimal? Rw { get; set; }
        public decimal? Cr { get; set; }
        public decimal? Mr { get; set; }
        public decimal? Mer { get; set; }
        public decimal? Eee { get; set; }
        public decimal? Ete { get; set; }
        public decimal? Bccproduct { get; set; }
        public decimal? Bccpackaging { get; set; }

        public virtual EpddataSetDocumentationRegistration ParentDataSet { get; set; }
    }
}
