namespace DatabaseMVC.Domain.Model
{
    public class Kit
    { 
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int DeviceId { get; set; }
    public DateTime DateOfSubmissionKit { get; set; }
    public DateTime? DateOfDisassemblyKit { get; set; }
    //public int? CameraDeviceId { get; set; }
    //public int? RecorderDeviceId { get; set; }
    //public int? RouterDeviceId { get; set; }

    public virtual Order? Order { get; set; }
    public virtual Device? Device { get; set; }
    //public virtual Device? CameraDevice { get; set; }
    //public virtual Device? RecorderDevice { get; set; }
    //public virtual Device? RouterDevice { get; set; }

    //public virtual ICollection<Order> Orders { get; set; }
    //public virtual ICollection<KitItem> KitItems { get; set; }  
}
}