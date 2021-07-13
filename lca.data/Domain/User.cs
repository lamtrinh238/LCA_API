using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("USERS")]
    public partial class User
    {
        public User()
        {
            Usrlinks = new HashSet<Usrlink>();
        }

        [Key]
        [Column("USR_ID")]
        public long UsrId { get; set; }
        [Column("USR_LOGINNAME")]
        [StringLength(50)]
        public string UsrLoginname { get; set; }
        [Column("USR_PASSWORD")]
        [StringLength(50)]
        public string UsrPassword { get; set; }
        [Column("USR_TYPE")]
        public int? UsrType { get; set; }
        [Column("USR_FULLNAME")]
        [StringLength(100)]
        public string UsrFullname { get; set; }
        [Column("USR_EMAIL")]
        [StringLength(100)]
        public string UsrEmail { get; set; }
        [Column("USR_ADD")]
        [StringLength(100)]
        public string UsrAdd { get; set; }
        [Column("USR_PROID")]
        [StringLength(5)]
        public string UsrProid { get; set; }
        [Column("USR_ZIP")]
        [StringLength(10)]
        public string UsrZip { get; set; }
        [Column("USR_PHONE1")]
        [StringLength(20)]
        public string UsrPhone1 { get; set; }
        [Column("USR_PHONE2")]
        [StringLength(10)]
        public string UsrPhone2 { get; set; }
        [Column("USR_STATUS")]
        public bool? UsrStatus { get; set; }
        [Column("USR_CREATEDTTM", TypeName = "datetime")]
        public DateTime? UsrCreatedttm { get; set; }
        [Column("USR_CREATEDBY")]
        public long? UsrCreatedby { get; set; }
        [Column("USR_RESETPWD")]
        [StringLength(15)]
        public string UsrResetpwd { get; set; }
        [Column("USR_CITY")]
        [StringLength(50)]
        public string UsrCity { get; set; }
        [Column("USR_ORGANIZATION")]
        [StringLength(50)]
        public string UsrOrganization { get; set; }
        [Column("USR_COMPID")]
        public int? UsrCompid { get; set; }
        [Column("USR_Training", TypeName = "date")]
        public DateTime? UsrTraining { get; set; }
        [Column("USR_Training_Valid", TypeName = "date")]
        public DateTime? UsrTrainingValid { get; set; }
        [Column("USR_GDPR", TypeName = "datetime")]
        public DateTime? UsrGdpr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLogin { get; set; }
        [Column("USR_GUID")]
        public Guid? UsrGuid { get; set; }
        [Column("USR_Active")]
        public int? UsrActive { get; set; }
        [Column("USR_Approved")]
        public int? UsrApproved { get; set; }
        [Column("USR_Comments")]
        [StringLength(500)]
        public string UsrComments { get; set; }

        [InverseProperty(nameof(Usrlink.Usr))]
        public virtual ICollection<Usrlink> Usrlinks { get; set; }
    }
}
