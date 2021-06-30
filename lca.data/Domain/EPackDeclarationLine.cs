using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackDeclarationLine
    {
        public int Id { get; set; }
        public int? PackTypeId { get; set; }
        public int? DeclarationId { get; set; }
        public string Comments { get; set; }
        public string HelpTxt { get; set; }
        public int? ComponentsId { get; set; }
        public string FilDoc { get; set; }
    }
}
