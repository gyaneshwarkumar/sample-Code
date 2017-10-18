using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repo;

namespace OA.Service
{
    public class CoursService : ICoursService
    {
        private IRepository<Cours> coursRepository;
        // private IRepository<Cours> userProfileRepository;

        public CoursService(IRepository<Cours> coursRepository)
        {
            this.coursRepository = coursRepository;
           
        }

        public void DeleteCours(long id)
        {
          var objCor=  coursRepository.Get(id);
            coursRepository.Delete(objCor);
        }

        public Cours GetCours(long id)
        {
            return coursRepository.Get(id);
        }

        public IEnumerable<Cours> GetCourss()
        {

                return coursRepository.GetAll();   
        }



        public void InsertCours(Cours course)
        {
            coursRepository.Insert(course);

        }


        public void UpdateCours(Cours course)
        {
             coursRepository.Update(course);
        }
    }
}
