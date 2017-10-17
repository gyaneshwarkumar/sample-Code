using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApiCore.Server.Models
{
    public class MyRole : IdentityRole
    {
        public string Description { get; set; }
    }
}