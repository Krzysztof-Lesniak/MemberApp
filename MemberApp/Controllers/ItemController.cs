﻿using Microsoft.AspNetCore.Mvc;

namespace MemberApp.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}