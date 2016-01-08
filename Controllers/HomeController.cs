using System.Web.Mvc;
using AcklenAveApplication.Interfaces;

namespace AcklenAveApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISecretPayloadRepository _secretPayloadRepository;

        public HomeController(ISecretPayloadRepository secretPayloadRepository)
        {
            _secretPayloadRepository = secretPayloadRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "AR Communications Beacon";
            return View();
        }

        public ActionResult Messages()
        {
            var payloads = _secretPayloadRepository.GetAllPayloads();
            return View(payloads);
        }

        [HttpPost]
        public ActionResult RequestSecret()
        {
            return RedirectToAction("Messages");
        }
    }
}
