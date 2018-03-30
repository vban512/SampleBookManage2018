using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AbpMpaMvcEfInit.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpMpaMvcEfInitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}