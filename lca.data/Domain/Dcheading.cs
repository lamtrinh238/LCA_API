using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DCHeading")]
    public partial class Dcheading
    {
        public Dcheading()
        {
            Dcrecipients = new HashSet<Dcrecipient>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DCRefNo")]
        [StringLength(50)]
        public string DcrefNo { get; set; }
        [Column("DCName")]
        [StringLength(1000)]
        public string Dcname { get; set; }
        [Column("DCDescription")]
        [StringLength(5000)]
        public string Dcdescription { get; set; }
        [Column("DCSpesification")]
        [StringLength(5000)]
        public string Dcspesification { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }
        [Column("DCDate", TypeName = "date")]
        public DateTime? Dcdate { get; set; }
        [Column("DCStartDate", TypeName = "date")]
        public DateTime? DcstartDate { get; set; }
        [Column("DCStopDate", TypeName = "date")]
        public DateTime? DcstopDate { get; set; }
        [Column("DCStatus")]
        public int? Dcstatus { get; set; }
        [Column("DCQuestions")]
        public int? Dcquestions { get; set; }
        [StringLength(5000)]
        public string Comments { get; set; }
        [Column("DCPicture1")]
        [StringLength(150)]
        public string Dcpicture1 { get; set; }
        [Column("DCPicture2")]
        [StringLength(150)]
        public string Dcpicture2 { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Dcheadings))]
        public virtual Company Com { get; set; }
        [InverseProperty(nameof(Dcrecipient.Dcheading))]
        public virtual ICollection<Dcrecipient> Dcrecipients { get; set; }
    }
}
