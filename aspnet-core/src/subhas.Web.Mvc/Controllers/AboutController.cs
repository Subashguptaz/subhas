using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using subhas.Controllers;

namespace subhas.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : subhasControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
