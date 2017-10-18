using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBusinessServices
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
