using MemberApp.Data;
using MemberApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemberApp.Controllers
{
    public class UserController : Controller
    {
        private readonly MemberAppDbContext _db;
        public UserController(MemberAppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objCategoryList = _db.Items.ToList();
            string dataCellName = string.Empty;
            string dataCellDescription = string.Empty;

            return View(objCategoryList);
        }
    }
}
