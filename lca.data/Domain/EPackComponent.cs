using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public int? ComId { get; set; }
        public int? Dec1 { get; set; }
        public int? Dec2 { get; set; }
        public int? Dec3 { get; set; }
        public string DecComments { get; set; }
    }
}
