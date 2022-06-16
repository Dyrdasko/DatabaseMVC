namespace DatabaseMVC.Domain.Model
{
    public class SIMCard
    {
        public int Id { get; set; }
        public string? NumberOnSIMCard { get; set; }
        public string MSISDN { get; set; }
        public string? IP { get; set; }
        public string PIN { get; set; }
        public string PUK { get; set; }
        public bool IsLimitOnInternet { get; set; }
        public short? LimitGB { get; set; }

        public virtual ICollection<RouterDevice>? RouterDevices { get; set; }
    }
}