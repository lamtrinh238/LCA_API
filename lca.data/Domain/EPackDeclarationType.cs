using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackDeclarationType
    {
        public int Id { get; set; }
        public int? PackTypeId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public string HelpTxt { get; set; }
        public int? DeclarationId { get; set; }
        public long? ComId { get; set; }
        public int? DecChoice { get; set; }
        public string DecComments { get; set; }
        public string FilDoc { get; set; }
    }
}
