using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatabaseMVC.Application.Interfaces;
using DatabaseMVC.Application.ViewModels.Contractor;
using DatabaseMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.Service
{
    public class ContractorService : IContractorService
    {
        private readonly IContractorRepository _contractorRepo;
        private readonly IMapper _mapper;

        public ContractorService(IContractorRepository contractorRepo, IMapper mapper)
        {
            _contractorRepo = contractorRepo;
            _mapper = mapper;
        }

        public int AddContractor(NewContractorVm contractor)
        {
            throw new NotImplementedException();
        }

        public ContactPersonDetailVm GetContactPersonDetail(int contactPersonId)
        {
            var contactPerson = _contractorRepo.GetContactPerson(contactPersonId);
            var contactPersonVm = new ContactPersonDetailVm
            {
                Id = contactPersonId,
                FullName = contactPerson.FirstName + " " + contactPerson.LastName,
                PhoneNumber = contactPerson.PhoneNumber
            };
            return contactPersonVm;
        }

        public ContractorDetailVm GetContractorDetail(int contractorId)
        {
            var contractor = _contractorRepo.GetContractor(contractorId);
            var contractorVm = _mapper.Map<ContractorDetailVm>(contractor);
            //var contractorVm = new ContractorDetailVm();
            ////var FirstcontactPerson = _contractorRepo.GetContactPerson(contractor.FirstContactPersonId);

            //contractorVm.Id = contractorId;
            //contractorVm.HeadquaterId = contractor.HeadquaterId;
            //contractorVm.DepartmentId = contractor.DepartmentId;
            //contractorVm.FirstContactPersonId = contractor.FirstContactPersonId;
            //contractorVm.SecondContactPersonId = contractor.SecondaryContactPersonId;


            //contractorVm.ContPersons = new List<ContactPersonForListVm>();
            ////przekazac id Contact Person coś w rodzaju ContactDetailInform u Kajetana w szkole
            //foreach (var contactPerson in FirstcontactPerson.ContPersons)
            //{
            //    var add = new ContactPersonForListVm();
            //    {
            //        Id = contactPerson.Id;
            //        FullName = contactPerson.FirstName + " " + contactPerson.LastName;
            //        PhoneNumber = contactPerson.PhoneNumber;
            //    };
            //    contractorVm.ContactPersons.Add(add);
            //}
            return contractorVm;
        }

        public ListContractorForListVm GetAllContractorsForList()
        {
            var contractors = _contractorRepo.GetAllActiveContractors()
                .ProjectTo<ContractorForListVm>(_mapper.ConfigurationProvider).ToList();

            var contractorList = new ListContractorForListVm()
            {
                Contractors = contractors,
                Count = contractors.Count
            };

            return contractorList;

            // .ProjectTo zastępuje poniższy kod
            //ListContractorForListVm result = new ListContractorForListVm();
            //result.Contractors = new List<ContractorForListVm>();
            //foreach (var contractor in contractors)
            //{
            //    var contracVm = new ContractorForListVm()
            //    {
            //        Id = contractor.Id,
            //        HeadquaterId = contractor.HeadquaterId,
            //        DepartmentId = contractor.DepartmentId,
            //        //ContactPersons = contractor.FirstContactPersonId,
            //        //FirstContactPersonId = contractor.FirstContactPersonId
            //    };
            //    result.Contractors.Add(contracVm);
            //}
            //result.Count = result.Contractors.Count;
            //return result;
        }

        public ContactPersonDetailVm ContactPersonDetail(int contactPersonId)
        {
            throw new NotImplementedException();
        }
    }
}
