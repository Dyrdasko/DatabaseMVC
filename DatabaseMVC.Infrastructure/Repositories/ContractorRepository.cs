using DatabaseMVC.Domain.Interfaces;
using DatabaseMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Infrastructure.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly Context _context;

        public ContractorRepository(Context context)
        {
            _context = context;
        }

        public int AddContactPerson(ContactPerson contactPerson)
        {
            _context.ContactPersons.Add(contactPerson);
            _context.SaveChanges();
            return contactPerson.Id;
        }

        public int AddContractor(Contractor contractor)
        {
            _context.Contractors.Add(contractor);
            _context.SaveChanges();
            return contractor.Id;
        }

        public IQueryable<Contractor> GetAllActiveContractors()
        {
            return _context.Contractors.Where(p => p.HasActiveCase);
        }

        public ContactPerson GetContactPerson(int contactPersonId)
        {
            throw new NotImplementedException();
        }

        public Contractor GetContractor(int contractorId)
        {
            return _context.Contractors.FirstOrDefault(p => p.Id == contractorId);
        }
    }
}
