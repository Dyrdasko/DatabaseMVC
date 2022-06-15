namespace DatabaseMVC.Domain.Model
{
    public class SIMCard
    {
        public int Id { get; set; }
        public string? NumberOnSIMCard { get; set; }
        public int MSISDN { get; set; }
        public string? IP { get; set; }
        public short PIN { get; set; }
        public int PUK { get; set; }
        public bool IsLimitOnInternet { get; set; }
        public short? LimitGB { get; set; }

        public virtual ICollection<RouterDevice>? RouterDevices { get; set; }
    }
}