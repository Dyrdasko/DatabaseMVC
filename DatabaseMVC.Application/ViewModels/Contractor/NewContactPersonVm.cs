using AutoMapper;
using DatabaseMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.ViewModels.Contractor
{
    public class NewContactPersonVm : IMapFrom<DatabaseMVC.Domain.Model.ContactPerson>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewContactPersonVm, DatabaseMVC.Domain.Model.ContactPerson>();//.ReverseMap();
                                //.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                                //.ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                                //.ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                                //.ForMember(d => d.PhoneNumber, opt => opt.MapFrom(s => s.PhoneNumber));
        }
    }
}
