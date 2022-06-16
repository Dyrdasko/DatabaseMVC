namespace DatabaseMVC.Domain.Model
{
    public abstract class Device
    {
        public int Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Description { get; set; }
        public string? DepartmentNumber { get; set; }
        public int ManufacturerId { get; set; }
        public bool IsBroken { get; set; } 
        public bool IsTakenOutOfState { get; set; }
        public bool IsInUse { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public virtual Manufacture? Manufacture { get; set; }
        //public virtual SIMCard? SIMCard { get; set; }
        //public virtual Storage? Storage { get; set; }

        public virtual ICollection<Kit>? Kits { get; set; }
    }


    public class RouterDevice : Device
    {
        public int? SIMCardId { get; set; }

        public virtual SIMCard? SIMCard { get; set; }
    }

    public class CameraDevice : Device
    {
        public string? TechSpecification { get; set; }
        public int? StorageCamId { get; set; }

        public virtual Storage? Storage { get; set; }
    }

    public class RecorderDevice : Device
    {
        public int? StorageRecId { get; set; }

        public virtual Storage? Storage { get; set; }
    }
}