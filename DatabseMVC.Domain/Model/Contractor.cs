namespace DatabaseMVC.Domain.Model
{
    public class Contractor
    {
        public int Id { get; set; }
        public int HeadquaterId { get; set; }
        public int DepartmentId { get; set; }
        public int CityId { get; set; }
        public bool HasActiveCase { get; set; }
        public int FirstContactPersonId { get; set; }
        public int? SecondaryContactPersonId { get; set; }

        public virtual Headquater? Headquater { get; set; }
        public virtual Department? Department { get; set; }
        public virtual City? City { get; set; }
        public virtual ContactPerson? FirstContactPerson { get; set; }
        public virtual ContactPerson? SecondaryContactPerson { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }
}