using Microsoft.AspNetCore.Mvc;

namespace mvc_web_azure_app_anand.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
