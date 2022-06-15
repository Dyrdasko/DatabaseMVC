namespace DatabaseMVC.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public string? CaseNumber { get; set; }
        public string? CodeName { get; set; }
        public DateTime ReceivedApplicationDate { get; set; }
        public DateTime? RecognizeDate { get; set; }
        public bool IsPosibility { get; set; }
        public DateTime? InstallationDate { get; set; }
        //public int? KitId { get; set; }
        public DateTime? EndApplicationDate { get; set; }
        public DateTime? DisassemblyDate { get; set; }
        public bool IsBattery { get; set; }
        public DateTime? NextExchangeBattery { get; set; }

        public virtual Contractor? Contractor { get; set; }
        public virtual ICollection<Kit>? Kits { get; set; }
    }
}