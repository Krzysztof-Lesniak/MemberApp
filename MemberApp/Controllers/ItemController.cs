using MemberApp.Data;
using MemberApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemberApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly MemberAppDbContext _db;
        public ItemController(MemberAppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objCategoryList = _db.Items.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]  //this is not required but good to have it and get to know what it does
        public IActionResult Create(Item obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Add(obj);
                _db.SaveChanges();
                TempData["succes"] = "Category succesfully created";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
