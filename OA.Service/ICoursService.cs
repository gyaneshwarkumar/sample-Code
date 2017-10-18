using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
  public  interface ICoursService
    {
        IEnumerable<Cours> GetCourss();
        Cours GetCours(long id);
        void InsertCours(Cours user);
        void UpdateCours(Cours user);
        void DeleteCours(long id);
    }
}
