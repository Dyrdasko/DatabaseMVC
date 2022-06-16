using System.ComponentModel.DataAnnotations;

namespace DatabaseMVC.Domain.Model
{
    public class TypeOfStorage
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }

        public ICollection<Storage>? Storages { get; set; }
    }
}