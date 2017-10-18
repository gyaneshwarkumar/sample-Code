using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Service
{
  public  interface IUserService
    {
        IEnumerable<Course> GetUsers();
        Course GetUser(long id);
        void InsertUser(Course user);
        void UpdateUser(Course user);
        void DeleteUser(long id);
    }
}
