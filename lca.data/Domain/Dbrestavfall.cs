using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbrestavfall
    {
        public int Id { get; set; }
        public short? RestavfallsId { get; set; }
        public string Restavfallsnavn { get; set; }
        public short? BehandlingsstedId { get; set; }
        public string Behandlingssted { get; set; }
        public short? BehandlingsmateId { get; set; }
        public string Behandlingsmate { get; set; }
        public decimal? Avfallsbehandling { get; set; }
        public decimal? ErstattetEnergi { get; set; }
        public DateTime? DatoSistEndret { get; set; }
        public string UserId { get; set; }
    }
}
