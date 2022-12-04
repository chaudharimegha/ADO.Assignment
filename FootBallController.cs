using FootBallLeage.Data;
using FootBallLeage.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootBallLeage.Controllers
{
    public class FootBallController : Controller
    {
        private readonly DBContext _context;
        public FootBallController(DBContext context)
        { 
            _context=context;
        }
        public IActionResult Index()
        {
            IEnumerable<FootBallModel> FootBallObj = _context.FootBallLeages ;
            return View(FootBallObj);
        }
        public IActionResult Create()
        { 
            return View();
        }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(FootBallModel footBallModel)
    {
            if (ModelState.IsValid)
            {
                _context.FootBallLeages.Add(footBallModel);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully";
                return RedirectToAction("Index");
            }
            return View(footBallModel);
    }
    }
}
