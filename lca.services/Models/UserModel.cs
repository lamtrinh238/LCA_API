using LCA.Data.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace LCA.Services.Models
{
    public class UserModel
    {
        public UserModel()
        {
        }

        public UserModel(User user) 
        {
            UsrId = user.UsrId;
            UsrLoginname = user.UsrLoginname;
            UsrPassword = user.UsrPassword;
            UsrType = user.UsrType;
            UsrFullname = user.UsrFullname;
            UsrEmail = user.UsrEmail;
            UsrAdd = user.UsrAdd;
            UsrProid = user.UsrProid;
            UsrZip = user.UsrZip;
            UsrPhone1 = user.UsrPhone1;
            UsrPhone2 = user.UsrPhone2;
            UsrStatus = user.UsrStatus;
            UsrCreatedttm = user.UsrCreatedttm;
            UsrCreatedby = user.UsrCreatedby;
            UsrResetpwd = user.UsrResetpwd;
            UsrCity = user.UsrCity;
            UsrOrganization = user.UsrOrganization;
            UsrCompid = user.UsrCompid;
            UsrTraining = user.UsrTraining;
            UsrTrainingValid = user.UsrTrainingValid;
            UsrGdpr = user.UsrGdpr;
            LastLogin = user.LastLogin;
            UsrGuid = user.UsrGuid;
            UsrActive = user.UsrActive;
            UsrApproved = user.UsrApproved;
            UsrComments = user.UsrComments;
            Roles = "";
        }
        public string Roles { get; set; }

        public long UsrId { get; set; }
        public string UsrLoginname { get; set; }

        [JsonIgnore]
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
    }

    public class UserCompanyModel: UserModel
    {
        public UserCompanyModel(User user, ICollection<Company> companies): base(user)
        {
            this.Companies = companies.Select(company => new CompanyModel(company)).ToList();
        }

        public ICollection<CompanyModel> Companies { get; set; }

    }

    public class PasswordChangeModel
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}