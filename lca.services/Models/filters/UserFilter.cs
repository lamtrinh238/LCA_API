using LCA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Models.filters
{
    public class UserFilter: BaseFilter
    {
        public long? ID { get; set; }
        public string LoginName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int? Type { get; set; }
    }
}
