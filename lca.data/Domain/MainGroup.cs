using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class MainGroup
    {
        [Column("HgruppeID")]
        public int HgruppeId { get; set; }
        public string HgruppeName { get; set; }
    }
}
