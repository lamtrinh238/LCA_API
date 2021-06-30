using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackCertificate
    {
        public EPackCertificate()
        {
            EPackCertificateLines = new HashSet<EPackCertificateLine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public long? ComId { get; set; }
        public int? Status { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeLastChange { get; set; }

        public virtual Company Com { get; set; }
        public virtual ICollection<EPackCertificateLine> EPackCertificateLines { get; set; }
    }
}
