using System.ComponentModel.DataAnnotations;

namespace DatabaseMVC.Domain.Model
{
    public class Manufacture
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Device>? Devices { get; set; }
        public virtual ICollection<Storage>? Storages { get; set; }
    }
}