using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterWebApiCore.Server.Repository
{
    public interface IDataAccess<TEntity, U> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity Get(U id);
        int Add(TEntity b);
        int Update(U id, TEntity b);
        int Delete(U id);
    }
}
