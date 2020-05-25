using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SportEvent.Infrastructure;
using SportEvent.Models;
using Microsoft.AspNetCore.Authorization;

namespace SportEvent.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly SportEventContext context;
        private readonly UserManager<AppAdmin> userManager;
        private readonly SignInManager<AppAdmin> signInManager;
        public AdminController(SportEventContext context, UserManager<AppAdmin> userManager, SignInManager<AppAdmin> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;

        }
        public IActionResult Index()
        {
            
            return View();
        }
        
        //EVENTS HANDLING
        public async Task<IActionResult> AdminEvents()
        {
            IQueryable<Event> eventsFromDb = from events in context.EventInformations select events;
            List<Event> EventInformationsList = await eventsFromDb.ToListAsync();
            return View(EventInformationsList);
        }
        //GET on Creating event
        public IActionResult AddEvent() => View();

        //POST on creating event
        [HttpPost]
        public async Task<IActionResult> AddEvent(Event eventToAdd)
        {
            if (ModelState.IsValid)
            {
                context.Add(eventToAdd);
                await context.SaveChangesAsync();
                return RedirectToAction("AdminEvents");
            }
            return View(eventToAdd);
        }


        //GET details for event
        public async Task<IActionResult> AdminViewEventDetails(int ID)
        {
            Event eventToView = await context.EventInformations.FirstOrDefaultAsync(x => x.eventID == ID);
            if (eventToView == null)
            {
                return NotFound();
            }

            return View(eventToView);
        }

        //GET EDIT for event
        
        public async Task<IActionResult> AdminEditEvent(int ID)
        {
            Event eventToView = await context.EventInformations.FindAsync(ID);
            if (eventToView == null)
            {
                return NotFound();
            }

            return View(eventToView);
        }

        //POST on EDIT event
        [HttpPost]
        public async Task<IActionResult> AdminEditEvent(Event eventToAdd)
        {
            if (ModelState.IsValid)
            {
                context.Update(eventToAdd);
                await context.SaveChangesAsync();
                return RedirectToAction("AdminEvents");
            }
            return View(eventToAdd);
        }

        //Delete an event
        public async Task<IActionResult> AdminDeleteEvent(int ID)
        {
            Event eventToDel = await context.EventInformations.FindAsync(ID);

            context.EventInformations.Remove(eventToDel);

            await context.SaveChangesAsync();

            return RedirectToAction("AdminEvents");
        }

        //USER HANDLIG
        public async Task<IActionResult> AdminUserView()
        {
            IQueryable<User> userFromDb = from users in context.UserInformation select users;
            List<User> UserInformationsList = await userFromDb.ToListAsync();
            return View(UserInformationsList);
        }
        //GET admin add user 
        public IActionResult AdminAddUser() => View();

        //POST admin add user
        [HttpPost]
        public async Task<IActionResult> AdminAddUser(User userToAdd)
        {
            if (ModelState.IsValid)
            {
                
                context.Add(userToAdd);
                await context.SaveChangesAsync();
                return RedirectToAction("AdminUserView");
            }
            return View(userToAdd);
        }

        //GET Edit user
        public async Task<IActionResult> AdminEditUser(int ID)
        {
            User UserToView = await context.UserInformation.FindAsync(ID);
            if (UserToView == null)
            {
                return NotFound();
            }

            return View(UserToView);
        }

        //POST edit user
        [HttpPost]
        public async Task<IActionResult> AdminEditUser(User userToAdd)
        {
            if (ModelState.IsValid)
            {
                context.Update(userToAdd);
                await context.SaveChangesAsync();
                return RedirectToAction("AdminUserView");
            }
            return View(userToAdd);
        }

        //DELETE user
        public async Task<IActionResult> AdminDeleteUser(int ID)
        {
            User userToDel = await context.UserInformation.FindAsync(ID);

            context.UserInformation.Remove(userToDel);

            await context.SaveChangesAsync();

            return RedirectToAction("AdminUserView");
        }



        //Admin login and auth handling

        //GET Admin registration
        
        public IActionResult AdminRegister() => View();

        //POST Admin registration
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminRegister(Admin newAdmin) {
            if (ModelState.IsValid)
            {
                AppAdmin appAdmin = new AppAdmin
                {
                    UserName = newAdmin.UserName,
                    Email = newAdmin.Email
                };
                IdentityResult result = await userManager.CreateAsync(appAdmin, newAdmin.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminLogin");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(newAdmin);
        }


        //GET Admin Login
        [AllowAnonymous]
        public IActionResult AdminLogin(String redirectUrl)
        {
            AdminLogin login = new AdminLogin
            {
                RedirectUrl = redirectUrl
            };

            return View(login);
        }


        //POST Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminLogin(AdminLogin adminLogin)
        {
            if (ModelState.IsValid)
            {
                AppAdmin admin = await userManager.FindByNameAsync(adminLogin.UserName);
                if (admin != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(admin, adminLogin.Password, false, false);

                    if (result.Succeeded)
                    {
                        return Redirect(adminLogin.RedirectUrl ?? "/admin/index");
                    }
                    
                }
                ModelState.AddModelError("", "Wrong credentials");

                
            }
            return View(adminLogin);
        }


        //GET Admin logout
        public async Task<IActionResult> AdminLogOut()
        {
            await signInManager.SignOutAsync();

            return Redirect("/");
        }

    }
}