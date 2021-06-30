using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class CompanyProductGroup
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public string ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public string Comments { get; set; }
    }
}
