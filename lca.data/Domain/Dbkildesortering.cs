using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbkildesortering
    {
        public int Id { get; set; }
        public short? AvfallsId { get; set; }
        public string Avfallsnavn { get; set; }
        public short? BehandlingsstedId { get; set; }
        public string Behandlingssted { get; set; }
        public short? BehandlingsmateId { get; set; }
        public string Behandlingsmate { get; set; }
        public decimal? TransUtenLast { get; set; }
        public decimal? TransRute { get; set; }
        public decimal? TransSted { get; set; }
        public decimal? Transport2 { get; set; }
        public decimal? Transport3 { get; set; }
        public decimal? Avfallbehandling { get; set; }
        public decimal? ErstattetEnergi { get; set; }
        public DateTime? DatoSistEndret { get; set; }
        public string UserId { get; set; }
    }
}
