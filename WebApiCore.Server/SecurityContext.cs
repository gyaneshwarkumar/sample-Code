using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Server.Models;

namespace WebApiCore.Server
{
    public class SecurityContext : IdentityDbContext<MyUser>
    {
        public SecurityContext(DbContextOptions<SecurityContext> options)
            : base(options)
        {
        }

        //public DbSet<Batch> Batchs { get; set; }
        //public DbSet<Course> Courses { get; set; }


        

    }
}