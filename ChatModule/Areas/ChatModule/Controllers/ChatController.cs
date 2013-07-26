using System.Web.Mvc;

namespace ChatModule.Areas.ChatModule.Controllers
{
    public class ChatController : Controller
    {
        //
        // GET: /ChatModule/Chat/
        public ActionResult Index()
        {
            return View();
        }

    }
}
