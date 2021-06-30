using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackComponentsFile
    {
        public int Id { get; set; }
        public int? CompId { get; set; }
        public string FileName { get; set; }
        public string Comments { get; set; }
        public DateTime? ValidTo { get; set; }
        public string ShareName { get; set; }
    }
}
