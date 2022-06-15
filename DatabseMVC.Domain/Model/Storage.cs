namespace DatabaseMVC.Domain.Model
{
    public class Storage
    {
        public int Id { get; set; }
        public string InternalDepartmentNumber { get; set; }
        public int ManufactureId { get; set; }
        public int Capacity { get; set; }
        public int TypeOfStorageId { get; set; }

        public virtual Manufacture? Manufacture { get; set; }
        public virtual TypeOfStorage? TypeOfStorage { get; set; }

        public ICollection<CameraDevice>? CameraDevices { get; set; }
        public ICollection<RecorderDevice>? RecorderDevices { get; set; }
    }
}