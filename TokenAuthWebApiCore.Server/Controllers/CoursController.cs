using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OA.Service;
using OA.Data;
using Microsoft.AspNetCore.Authorization;

namespace MasterWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class CoursController : Controller
    {
        private readonly ICoursService coursService;


        public CoursController(ICoursService coursService)
        {
            this.coursService = coursService;

        }


        [HttpGet]
        public IEnumerable<Cours> Get()
        {
            return coursService.GetCourss().ToList();
            //  return vr.ToString();
            // UserProfile userProfile = userProfileService.GetUserProfile(u.Id);

        }

        [HttpPost]
        public IActionResult Post([FromBody]Cours b)
        {
            coursService.InsertCours(b);
            return Ok(b);
            // return Forbid();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Course = coursService.GetCours(id);
            if (Course == null)
            {
                return NotFound();
            }
            return Ok(Course);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Cours b)
        {
            if (id == b.Id)
            {
                 coursService.UpdateCours(b);
          
                return Ok(b);
            }
            return NotFound();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             coursService.DeleteCours(id);
            if (id != 0)
            {
                return Ok(id);
            }
            return NotFound();
        }


    }
}