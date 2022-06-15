namespace DatabaseMVC.Domain.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Contractor>? Contractors { get; set; }
    }
}