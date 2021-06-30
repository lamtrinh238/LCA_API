using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class User
    {
        public User()
        {
            Usrlinks = new HashSet<Usrlink>();
        }

        public long UsrId { get; set; }
        public string UsrLoginname { get; set; }
        public string UsrPassword { get; set; }
        public int? UsrType { get; set; }
        public string UsrFullname { get; set; }
        public string UsrEmail { get; set; }
        public string UsrAdd { get; set; }
        public string UsrProid { get; set; }
        public string UsrZip { get; set; }
        public string UsrPhone1 { get; set; }
        public string UsrPhone2 { get; set; }
        public bool? UsrStatus { get; set; }
        public DateTime? UsrCreatedttm { get; set; }
        public long? UsrCreatedby { get; set; }
        public string UsrResetpwd { get; set; }
        public string UsrCity { get; set; }
        public string UsrOrganization { get; set; }
        public int? UsrCompid { get; set; }
        public DateTime? UsrTraining { get; set; }
        public DateTime? UsrTrainingValid { get; set; }
        public DateTime? UsrGdpr { get; set; }
        public DateTime? LastLogin { get; set; }
        public Guid? UsrGuid { get; set; }
        public int? UsrActive { get; set; }
        public int? UsrApproved { get; set; }
        public string UsrComments { get; set; }

        public virtual ICollection<Usrlink> Usrlinks { get; set; }
    }
}
