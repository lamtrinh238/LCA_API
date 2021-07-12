namespace LCA.Service.Models.filters
{
    public class ClientFilter: BaseFilter
    {
        public long? ID { get; set; }
        public string VAT { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string MainContact { get; set; }
        public string WEB { get; set; }
        public int? Coutry { get; set; }
        public int? ComSW { get; set; }
        public string Sort { get; set; }
        public string Search { get; set; }
    }
}
