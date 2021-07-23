using System.Collections.Generic;

namespace LCA.Services.Models
{
    public class AuthenticateResponseModel
    {
        public long UsrId { get; set; }
        public string UsrLoginname { get; set; }
        public int? UsrType { get; set; }
        public string UsrFullname { get; set; }
        public string UsrEmail { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }
        public ICollection<CompanyModel> Companies { get; set; }


        public AuthenticateResponseModel(UserCompanyModel user, string token)
        {
            UsrId = user.UsrId;
            UsrLoginname = user.UsrLoginname;
            UsrType = user.UsrType;
            UsrFullname = user.UsrFullname;
            UsrEmail = user.UsrEmail;
            Roles = user.Roles;
            Token = token;
            this.Companies = user.Companies;
        }
    }
}