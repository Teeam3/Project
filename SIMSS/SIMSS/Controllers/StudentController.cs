using Microsoft.AspNetCore.Mvc;

namespace SIMSS.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
