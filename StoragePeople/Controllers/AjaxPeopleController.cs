using Microsoft.AspNetCore.Mvc;

namespace StoragePeople.Controllers
{
    public class AjaxPeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
