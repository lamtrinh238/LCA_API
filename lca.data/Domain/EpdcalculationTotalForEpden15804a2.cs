using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EpdcalculationTotalForEpden15804a2
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("GWPtotal", TypeName = "decimal(38, 12)")]
        public decimal? Gwptotal { get; set; }
        [Column("GWPfossil", TypeName = "decimal(38, 12)")]
        public decimal? Gwpfossil { get; set; }
        [Column("GWPbiogenic", TypeName = "decimal(38, 12)")]
        public decimal? Gwpbiogenic { get; set; }
        [Column("GWPluluc", TypeName = "decimal(38, 12)")]
        public decimal? Gwpluluc { get; set; }
        [Column("ODP", TypeName = "decimal(38, 12)")]
        public decimal? Odp { get; set; }
        [Column("AP", TypeName = "decimal(38, 12)")]
        public decimal? Ap { get; set; }
        [Column("EPfreshwater", TypeName = "decimal(38, 12)")]
        public decimal? Epfreshwater { get; set; }
        [Column("EPmarine", TypeName = "decimal(38, 12)")]
        public decimal? Epmarine { get; set; }
        [Column("EPterrestrial", TypeName = "decimal(38, 12)")]
        public decimal? Epterrestrial { get; set; }
        [Column("POCP", TypeName = "decimal(38, 12)")]
        public decimal? Pocp { get; set; }
        [Column("ADPminerals", TypeName = "decimal(38, 12)")]
        public decimal? Adpminerals { get; set; }
        [Column("ADPfossil", TypeName = "decimal(38, 12)")]
        public decimal? Adpfossil { get; set; }
        [Column("WDP", TypeName = "decimal(38, 12)")]
        public decimal? Wdp { get; set; }
        [Column("PM", TypeName = "decimal(38, 12)")]
        public decimal? Pm { get; set; }
        [Column("IRP", TypeName = "decimal(38, 12)")]
        public decimal? Irp { get; set; }
        [Column("ETPfw", TypeName = "decimal(38, 12)")]
        public decimal? Etpfw { get; set; }
        [Column("HTPc", TypeName = "decimal(38, 12)")]
        public decimal? Htpc { get; set; }
        [Column("HTPnc", TypeName = "decimal(38, 12)")]
        public decimal? Htpnc { get; set; }
        [Column("SQP", TypeName = "decimal(38, 12)")]
        public decimal? Sqp { get; set; }
        [Column("RPEE", TypeName = "decimal(38, 12)")]
        public decimal? Rpee { get; set; }
        [Column("RPEM", TypeName = "decimal(38, 12)")]
        public decimal? Rpem { get; set; }
        [Column("TPE", TypeName = "decimal(38, 12)")]
        public decimal? Tpe { get; set; }
        [Column("NRPE", TypeName = "decimal(38, 12)")]
        public decimal? Nrpe { get; set; }
        [Column("NRPM", TypeName = "decimal(38, 12)")]
        public decimal? Nrpm { get; set; }
        [Column("TRPE", TypeName = "decimal(38, 12)")]
        public decimal? Trpe { get; set; }
        [Column("SM", TypeName = "decimal(38, 12)")]
        public decimal? Sm { get; set; }
        [Column("RSF", TypeName = "decimal(38, 12)")]
        public decimal? Rsf { get; set; }
        [Column("NRSF", TypeName = "decimal(38, 12)")]
        public decimal? Nrsf { get; set; }
        [Column(TypeName = "decimal(38, 12)")]
        public decimal? W { get; set; }
        [Column("HW", TypeName = "decimal(38, 12)")]
        public decimal? Hw { get; set; }
        [Column("NHW", TypeName = "decimal(38, 12)")]
        public decimal? Nhw { get; set; }
        [Column("RW", TypeName = "decimal(38, 12)")]
        public decimal? Rw { get; set; }
        [Column("CR", TypeName = "decimal(38, 12)")]
        public decimal? Cr { get; set; }
        [Column("MR", TypeName = "decimal(38, 12)")]
        public decimal? Mr { get; set; }
        [Column("MER", TypeName = "decimal(38, 12)")]
        public decimal? Mer { get; set; }
        [Column("EEE", TypeName = "decimal(38, 12)")]
        public decimal? Eee { get; set; }
        [Column("ETE", TypeName = "decimal(38, 12)")]
        public decimal? Ete { get; set; }
        [Column("BCCproduct", TypeName = "decimal(38, 12)")]
        public decimal? Bccproduct { get; set; }
        [Column("BCCpackaging", TypeName = "decimal(38, 12)")]
        public decimal? Bccpackaging { get; set; }
        [StringLength(2)]
        public string Fase { get; set; }
    }
}
