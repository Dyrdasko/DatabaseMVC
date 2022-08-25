using DatabaseMVC.Application.ViewModels.Contractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.Interfaces
{
    public interface IContractorService
    {
        ListContractorForListVm GetAllContractorsForList(int pageSize, int pageNo);
        int AddContactPerson(NewContactPersonVm contactPerson);
        int AddContractor(NewContractorVm contractor);
        ContractorDetailVm GetContractorDetail(int contractorId);
        ContactPersonDetailVm ContactPersonDetail(int contactPersonId);

    }
}
