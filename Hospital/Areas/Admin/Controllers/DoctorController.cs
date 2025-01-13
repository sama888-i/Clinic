using Microsoft.AspNetCore.Mvc;

namespace Hospital.Areas.Admin.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
