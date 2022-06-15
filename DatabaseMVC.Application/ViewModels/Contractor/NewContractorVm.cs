using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.ViewModels.Contractor
{
    public class NewContractorVm
    {
        public int Id { get; set; }
        public int HeadquaterId { get; set; }
        public int DepartmentId { get; set; }
        public int FirstContactPersonId { get; set; }
        public int? SecondContactPersonId { get; set; }
    }
}
