using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Data
{
    public class ApplicationDbContext(DbContextOptions dbContextOptions)
    : base (dbContextOptions)
    {
    }
    public DbSet<User> User { get; set;}
    {
         
    }
}