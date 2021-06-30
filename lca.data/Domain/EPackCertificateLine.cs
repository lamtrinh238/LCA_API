using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackCertificateLine
    {
        public int Id { get; set; }
        public int? PackTypeId { get; set; }
        public int? CertificateId { get; set; }
        public string Comments { get; set; }
        public string HelpTxt { get; set; }
        public int? DeclarationId { get; set; }

        public virtual EPackCertificate Certificate { get; set; }
    }
}
