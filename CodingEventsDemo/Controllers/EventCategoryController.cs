using CodingEventsDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext category;

        public EventCategoryController(EventDbContext dbContext)
        {
            category = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
