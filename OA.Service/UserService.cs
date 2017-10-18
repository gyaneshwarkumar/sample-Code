using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserService:IUserService
    {
        private IRepository<Course> userRepository;
        private IRepository<UserProfile> userProfileRepository;

        public UserService(IRepository<Course> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public IEnumerable<Course> GetUsers()
        {
            return userRepository.GetAll();
        }

        public Course GetUser(long id)
        {
            return userRepository.Get(id);
        }

        public void InsertUser(Course user)
        {
            userRepository.Insert(user);
        }
        public void UpdateUser(Course user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(long id)
        {            
            UserProfile userProfile = userProfileRepository.Get(id);
            userProfileRepository.Remove(userProfile);
            Course user = GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }
    }
}
