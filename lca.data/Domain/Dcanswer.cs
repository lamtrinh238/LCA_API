using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dcanswer
    {
        public int Id { get; set; }
        public int? DcrecipId { get; set; }
        public int? DcanswerLine { get; set; }
        public string Dcanswer1 { get; set; }
        public string Dcanswer2 { get; set; }
        public string Dcanswer3 { get; set; }
        public string Dcanswer4 { get; set; }
        public string Dcanswer5 { get; set; }

        public virtual Dcrecipient Dcrecip { get; set; }
    }
}
