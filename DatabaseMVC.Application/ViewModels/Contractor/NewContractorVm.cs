using AutoMapper;
using DatabaseMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.ViewModels.Contractor
{
    public class NewContractorVm : IMapFrom<DatabaseMVC.Domain.Model.Contractor>
    {
        public int Id { get; set; }
        public int HeadquaterId { get; set; }
        //public string HeadquaterName { get; set; }
        public int DepartmentId { get; set; }
        //public string DepartmentName { get; set; }
        public int CityId { get; set; }
        //public string CityName { get; set; }
        public int FirstContactPersonId { get; set; }
        //public string FirstContactPersonFirstName { get; set; }
        //public string FirstContactPersonLastName { get; set; }
        public int? SecondContactPersonId { get; set; }
        //public string SecondContactPersonFirstName { get; set; }
        //public string SecondContactPersonLastName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewContractorVm, DatabaseMVC.Domain.Model.Contractor>();//.IncludeMembers(
            //    h => h.Headquater, h => h.Department, h => h.City, h => h.FirstContactPerson, h => h.SecondaryContactPerson);
            //profile.CreateMap<DatabaseMVC.Domain.Model.Headquater, NewContractorVm>(MemberList.None);
            //profile.CreateMap<DatabaseMVC.Domain.Model.Department, NewContractorVm>(MemberList.None);
            //profile.CreateMap<DatabaseMVC.Domain.Model.City, NewContractorVm>(MemberList.None);
            //profile.CreateMap<DatabaseMVC.Domain.Model.ContactPerson, NewContractorVm>(MemberList.None);
        }
    }
}
