using System.Web.Mvc;

namespace MVC_5_Skeleton2.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Http404()
        {
            Response.StatusCode = 404;

            return View();
        }
    }
}