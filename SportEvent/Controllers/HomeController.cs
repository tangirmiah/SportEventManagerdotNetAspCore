using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SportEvent.Infrastructure;
using SportEvent.Models;

namespace SportEvent.Controllers
{
    public class HomeController : Controller
    {
        private readonly SportEventContext context;
        public HomeController(SportEventContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            IQueryable<Event> eventsFromDb = from events in context.EventInformations select events;
            List<Event> EventInformationsList = await eventsFromDb.ToListAsync();
            return View(EventInformationsList);
        }

        public IActionResult AboutUs()
        {
            
            return View();
        }

        public async Task<IActionResult> ViewEvent(int ID)
        {
            Event eventToView = await context.EventInformations.FirstOrDefaultAsync(x => x.eventID == ID);
            if(eventToView == null)
            {
                return NotFound();
            }

            return View(eventToView);
        }


    }
}
