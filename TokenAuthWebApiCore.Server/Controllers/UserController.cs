using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OA.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterWebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
        {
            private readonly IUserService userService;
            private readonly IUserProfileService userProfileService;

            public UserController(IUserService userService, IUserProfileService userProfileService)
            {
                this.userService = userService;
                this.userProfileService = userProfileService;
            }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            var vr = userService.GetUsers().ToList();
           // UserProfile userProfile = userProfileService.GetUserProfile(u.Id);

            // var Courses = _CourseRepo.Get();
             return new string[] { "value1", "value2" };
        }

        //    public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
