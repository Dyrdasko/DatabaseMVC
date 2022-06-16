using System.ComponentModel.DataAnnotations;

namespace DatabaseMVC.Domain.Model
{
    public class Headquater
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Contractor>? Contractors { get; set; }
    }
}