using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Server.Models;

namespace WebApiCore.Server.Repository
{
    public class BatchRepository:IDataAccess<Batch,int>
    {
        SecurityContext ctx;
        public BatchRepository(SecurityContext c)
        {
            ctx = c;
        }
        public int Add(Batch b)
        {
            ctx.Batchs.Add(b);
            int res = ctx.SaveChanges();
            return res;
        }

        public int Delete(int id)
        {
            int res = 0;
            var Batch = ctx.Batchs.FirstOrDefault(b => b.Id == id);
            if (Batch != null)
            {
                ctx.Batchs.Remove(Batch);
                res = ctx.SaveChanges();
            }
            return res;
        }

        public Batch Get(int id)
        {
            var Batch = ctx.Batchs.FirstOrDefault(b => b.Id == id);
            return Batch;
        }

        public IEnumerable<Batch> Get()
        {
            var Batchs = ctx.Batchs.ToList();
            return Batchs;
        }

        public int Update(int id, Batch b)
        {
            int res = 0;
            var Batch = ctx.Batchs.Find(id);
            if (Batch != null)
            {
                Batch.Batch_Name = b.Batch_Name;
                Batch.Description = b.Description;
                res = ctx.SaveChanges();
            }
            return res;
        }
    }
}
