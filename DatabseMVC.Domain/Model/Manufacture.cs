namespace DatabaseMVC.Domain.Model
{
    public class Manufacture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Device>? Devices { get; set; }
        public virtual ICollection<Storage>? Storages { get; set; }
    }
}