using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackAnalyseGwp
    {
        public int Anaid { get; set; }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public string Gwpname { get; set; }
        public string FEUnit { get; set; }
        public double? Gwp { get; set; }
    }
}
