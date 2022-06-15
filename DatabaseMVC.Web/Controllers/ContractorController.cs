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

        public IActionResult Index()
        {
            var model = _contrService.GetAllContractorsForList();
            return View(model);
        }

        //[HttpGet]
        //public IActionResult AddContractor()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddContractor(ContractorModel model)
        //{
        //    var id = _contrService.AddContractor(model);
        //    return View();
        //}

        public IActionResult ViewContractor(int contractorId)
        {
            var contractorModel = _contrService.GetContractorDetail(contractorId);
            return View(contractorModel);
        }

        //[HttpGet]
        //public IActionResult AddContactPerson(int contactPersonId)
        //{
        //    return View(new NewContractorVm);
        //}

        //[HttpPost]
        //public IActionResult AddContactPerson(NewContractorVm model)
        //{
        //    var id = _contrService.AddContactPerson(model);
        //    return View();
        //}
    }
}
