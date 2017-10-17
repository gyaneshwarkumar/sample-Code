using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MasterWebApiCore.Server.Models;

namespace MasterWebApiCore
{
    public class SecurityContext : DbContext
    {
        public SecurityContext(DbContextOptions<SecurityContext> options)
            : base(options)
        {
        }

        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Course> Courses { get; set; }


        

    }
}