using System;
using Microsoft.AspNetCore.Mvc;
using WebPerson.Models;

namespace WebPerson.Controllers
{
    [Route("Person")]
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Person() =>
            View();

        [HttpPost]
        public IActionResult Person(Person person)
        {
            Console.WriteLine("ss");
            return View(person);
        }
    }
}