namespace DatabaseMVC.Domain.Model
{
    public class City
    {
        public int Id { get; set; }

        public string CityName { get; set; }

        public virtual ICollection<Contractor>? Contractors { get; set; }
    }
}
