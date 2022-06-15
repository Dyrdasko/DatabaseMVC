using Microsoft.AspNetCore.Mvc;

namespace DatabaseMVC.Web.Controllers
{
    public class DeviceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
