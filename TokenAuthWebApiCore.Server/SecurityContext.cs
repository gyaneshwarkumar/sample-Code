using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TokenAuthWebApiCore.Server.Models;

namespace TokenAuthWebApiCore.Server
{
    public class SecurityContext : IdentityDbContext<MyUser>
    {
        public SecurityContext(DbContextOptions<SecurityContext> options)
            : base(options)
        {
        }

        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Course> Courses { get; set; }


        

    }
}