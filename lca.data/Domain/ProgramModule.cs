using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class ProgramModule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProgramFile { get; set; }
        public int? Status { get; set; }
    }
}
