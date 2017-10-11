using System.Collections.Generic;
using System.Linq;
using TokenAuthWebApiCore.Server.Models;


namespace TokenAuthWebApiCore.Server.Repository
{


    public class CourseRepository : IDataAccess<Course, int>
    {
        SecurityContext ctx;
        public CourseRepository(SecurityContext c)
        {
            ctx = c;
        }
        public int Add(Course b)
        {
            ctx.Courses.Add(b);
            int res = ctx.SaveChanges();
            return res;
        }

        public int Delete(int id)
        {
            int res = 0;
            var Course = ctx.Courses.FirstOrDefault(b => b.Id == id);
            if (Course != null)
            {
                ctx.Courses.Remove(Course);
                res = ctx.SaveChanges();
            }
            return res;
        }

        public Course Get(int id)
        {
            var Course = ctx.Courses.FirstOrDefault(b=>b.Id==id);
            return Course;
        }

        public IEnumerable<Course> Get()
        {
            var Courses = ctx.Courses.ToList();
            return Courses;
        }

        public int Update(int id,Course b)
        {
            int res = 0;
            var Course = ctx.Courses.Find(id);
            if (Course != null)
            {
                Course.Course_Name = b.Course_Name;
                Course.Description = b.Description;
               res = ctx.SaveChanges();
            }
            return res;
        }
    }
}
