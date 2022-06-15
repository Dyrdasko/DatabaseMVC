namespace DatabaseMVC.Domain.Model
{
    public class TypeOfStorage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Storage>? Storages { get; set; }
    }
}