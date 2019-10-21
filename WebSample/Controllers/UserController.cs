using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicSample;
using Microsoft.AspNetCore.Mvc;

namespace WebSample.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var manager = new UserManager();
            manager.Seed();
            var users = manager.GetAll();

            return View(users);
        }
    }
}