using System.ComponentModel.DataAnnotations;

namespace DatabaseMVC.Domain.Model
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Contractor>? Contractors { get; set; }
    }
}