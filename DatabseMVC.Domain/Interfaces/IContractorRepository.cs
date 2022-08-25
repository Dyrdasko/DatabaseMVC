using DatabaseMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Domain.Interfaces
{
    public interface IContractorRepository
    {
        IQueryable<Contractor> GetAllActiveContractors();
        ContactPerson GetContactPerson(int contactPersonId);
        Contractor GetContractor(int contractorId);
        int AddContactPerson(ContactPerson contactPerson);
        int AddContractor(Contractor contractor);
    }
}
