using System.Web.Mvc;

namespace AbpMpaMvcEfInit.Web.Controllers
{
    public class AboutController : AbpMpaMvcEfInitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}