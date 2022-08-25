using DatabaseMVC.Application.Interfaces;
using DatabaseMVC.Application.ViewModels.Contractor;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMVC.Web.Controllers
{
    public class ContractorController : Controller
    {
        private readonly IContractorService _contrService;

        public ContractorController(IContractorService contractorService)
        {
            _contrService = contractorService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _contrService.GetAllContractorsForList(2, 1);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }

            var model = _contrService.GetAllContractorsForList(pageSize, (int)pageNo);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddContactPerson()
        {
            //var model = new NewContactPersonVm();
            return View(new NewContactPersonVm());
        }

        [HttpPost]
        public IActionResult AddContactPerson(NewContactPersonVm model)
        {
            var id = _contrService.AddContactPerson(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddContractor()
        {
            return View(new NewContractorVm());
        }

        [HttpPost]
        public IActionResult AddContractor(NewContractorVm model)
        {
            var id = _contrService.AddContractor(model);
            return View();
        }

        public IActionResult ViewContractor(int contractorId)
        {
            var contractorModel = _contrService.GetContractorDetail(contractorId);
            return View(contractorModel);
        }
    }
}
