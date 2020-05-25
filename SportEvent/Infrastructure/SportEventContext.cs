using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportEvent.Infrastructure
{
    public class SportEventContext : IdentityDbContext<AppAdmin> 
    { 

        public SportEventContext(DbContextOptions<SportEventContext> options) :base(options)
        {

        }

        public DbSet<Event> EventInformations { get; set; }
        public DbSet<User> UserInformation { get; set; }
    }
}
