using AutoMapper;
using DatabaseMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.ViewModels.Contractor
{
    public class ContractorForListVm : IMapFrom<DatabaseMVC.Domain.Model.Contractor>
    {
        public int Id { get; set; }
        public int HeadquaterId { get; set; }
        public int DepartmentId { get; set; }
         
        public void Mapping(Profile profile)
        {
            profile.CreateMap<DatabaseMVC.Domain.Model.Contractor, ContractorForListVm>();
                // Mapowanie w przypadku innych opisow
                //.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                //.ForMember(d => d.HeadquaterId, opt => opt.MapFrom(s => s.HeadquaterId))
                //.ForMember(d => d.DepartmentId, opt => opt.MapFrom(s => s.DepartmentId));
        }
    }
}
