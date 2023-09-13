using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IRepository<T> : IQueryRepository<T>
    {

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }

    public interface IQueryRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();

    }
}
