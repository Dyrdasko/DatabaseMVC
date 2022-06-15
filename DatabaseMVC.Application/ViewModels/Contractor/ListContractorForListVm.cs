using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Application.ViewModels.Contractor
{
    public class ListContractorForListVm
    {
        public List<ContractorForListVm> Contractors { get; set; }
        public int Count { get; set; }
    }
}
