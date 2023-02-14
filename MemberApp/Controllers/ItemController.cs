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
    }
}
