using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epdpcr
    {
        public int Id { get; set; }
        public string Pcrname { get; set; }
        public string Pcrnumber { get; set; }
        public string Version { get; set; }
        public Guid? Uuid { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ValidToDate { get; set; }
        public string ProgramOperator { get; set; }
        public string Pcrurl { get; set; }
        public string Fase { get; set; }
    }
}
