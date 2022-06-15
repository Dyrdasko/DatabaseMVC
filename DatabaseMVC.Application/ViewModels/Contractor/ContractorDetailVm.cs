using AutoMapper;
using DatabaseMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.ViewModels.Contractor
{
    public class ContractorDetailVm : IMapFrom<DatabaseMVC.Domain.Model.Contractor>
    {
        public int Id { get; set; }
        public int HeadquaterId { get; set; }
        public int DepartmentId { get; set; }
        public int FirstContactPersonId { get; set; }
        public int? SecondContactPersonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<DatabaseMVC.Domain.Model.Contractor, ContractorDetailVm>()
                ;
        }
        //public List<ContactPersonForListVm> ContPersons { get; set; }
    }
}
