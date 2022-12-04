using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
namespace FootBallLeage.Controllers
{
    public class StoreFootBallDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
