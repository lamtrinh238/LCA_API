using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class Process
    {
        [StringLength(50)]
        public string Column0 { get; set; }
        [StringLength(50)]
        public string Column1 { get; set; }
        [StringLength(50)]
        public string Column2 { get; set; }
    }
}
