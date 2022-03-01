using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }
    }
}
