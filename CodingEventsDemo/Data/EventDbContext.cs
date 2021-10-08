using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEventsDemo.Data
{
    //we use(extend) DbContext because it provides most of the functionality
    public class EventDbContext : DbContext//By convention, we name it EventDbContext since it is going to be used to work with Event objects and data. 
    {
        public DbSet<Event> Events { get; set; }//DbSet class provides methods for querying sets of objects of the given type (in this case, Event)

        public EventDbContext(DbContextOptions<EventDbContext> options)
              : base(options)
        {
        }
    }
}
