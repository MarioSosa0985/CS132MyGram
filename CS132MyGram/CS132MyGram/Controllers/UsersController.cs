using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS132MyGram.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS132MyGram.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogUser([FromForm]User user)
        {
            string result = $"The user name is: {user.UserName} and the password is: {user.Password}";

            return Content(result);
        }
    }
}
